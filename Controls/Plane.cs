using MineSweeper.DataStructure;

namespace MineSweeper.Controls
{
    internal class Plane : Control, IData
    {
        #region 字段
        private MatrixSize size;
        private int mineCount;
        private Matrix<Grid> gridMatrix;
        private Grid activeGrid = null;
        private bool active = false;
        private MouseButtons mouseState = MouseButtons.None;
        #endregion

        #region 属性

        private Grid ActiveGrid
        {
            get => activeGrid;
            set
            {
                if (activeGrid == value) return;
                Active = false;
                activeGrid = value;
                Active = true;
            }
        }

        private MouseButtons MouseState
        {
            get => mouseState;
            set
            {
                if (mouseState == value) return;
                Active = false;
                mouseState = value;
                Active = true;
            }
        }

        private bool Active
        {
            get => active;
            set
            {
                if (active == value) return;
                active = value;
                if (activeGrid == null) return;
                if (active)
                {
                    switch (mouseState)
                    {
                        case MouseButtons.Left | MouseButtons.Right:
                            foreach (var grid in gridMatrix.NeighbourWithin(activeGrid.Index))
                            {
                                grid.State = GridState.MouseDown;
                            }
                            break;
                        case MouseButtons.Left:
                            activeGrid.State = GridState.MouseDown;
                            break;
                        default:
                            activeGrid.State = GridState.MouseOver;
                            break;
                    }
                }
                else
                {
                    switch (mouseState)
                    {
                        case MouseButtons.Left | MouseButtons.Right:
                            foreach (var grid in gridMatrix.NeighbourWithin(activeGrid.Index))
                            {
                                grid.State = GridState.None;
                            }
                            break;
                        default:
                            activeGrid.State = GridState.None;
                            break;
                    }
                }
            }
        }

        public new MatrixSize Size { get => size; }

        public int Row => size.Row;

        public int Column => size.Column;

        public int MineCount { get => mineCount; }

        public Game Game => Parent as Game;
        #endregion

        #region 构造函数
        public Plane(MatrixSize size, int mineCount)
        {
            this.size = size;
            this.mineCount = mineCount;
            gridMatrix = new(size);
            initializeComponent();
        }
        #endregion

        #region 方法
        private void initializeComponent()
        {
            SuspendLayout();
            base.Size = new(Column * 26 + 1, Row * 26 + 1);
            foreach (var index in Size)
            {
                var grid = gridMatrix[index] = new(index);
                grid.Location = new(26 * index.Column, 26 * index.Row);
                grid.MouseEnter += gridMouseEnter;
                grid.MouseLeave += gridMouseLevae;
                grid.MouseMove += gridMouseMove;
                grid.MouseUp += gridMouseUp;
                grid.MouseDown += gridMouseDown;
                Controls.Add(grid);
            }
            ResumeLayout();
        }

        private void gridMouseEnter(object? sender, EventArgs e) => ActiveGrid = sender as Grid;

        private void gridMouseLevae(object? sender, EventArgs e) => ActiveGrid = null;

        private void gridMouseMove(object? sender, MouseEventArgs e)
        {
            var index = (sender as Grid).Index;
            static int calcOffset(int x) => x >= 0 ? x / 26 : (x + 1) / 26 - 1;
            var offset = (calcOffset(e.Y), calcOffset(e.X));
            ActiveGrid = gridMatrix[index + offset];
        }

        private void gridMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;
            MouseState ^= e.Button;
        }

        private void gridMouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right) return;
            if (activeGrid == null) return;
            switch (mouseState)
            {
                case MouseButtons.Left | MouseButtons.Right:
                    if (activeGrid.Mode == GridMode.Explored)
                    {
                        List<Grid> neighbour = new(gridMatrix.Neighbour(activeGrid.Index));
                        if (neighbour.Where(x => x.Mode == GridMode.Marked).Count() == (int)activeGrid.Type)
                            foreach (var grid in neighbour)
                            {
                                if (floodFill(grid)) Game.Lose();
                            }
                    }
                    break;
                case MouseButtons.Left:
                    if (Game.State == GameState.Pendnig) generateMine();
                    if (floodFill(activeGrid)) Game.Lose();
                    break;
                case MouseButtons.Right:
                    activeGrid.SwitchMode();
                    break;
            }
            if (cleared()) Game.Win();
            MouseState ^= e.Button;
        }

        private void generateMine()
        {
            List<Grid> blank = new(gridMatrix.NeighbourWithin(activeGrid.Index));
            int[] array = new int[Row * Column - blank.Count];
            Random random = new();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i < MineCount ? 1 : 0;
                int j = random.Next(i);
                (array[i], array[j]) = (array[j], array[i]);
            }

            Matrix<int> map = new(Size);
            int cur = 0;
            foreach (var index in Size)
            {
                map[index] = blank.Find(x => x == gridMatrix[index]) == null ? array[cur++] : 0;
            }
            foreach (var index in Size)
            {
                gridMatrix[index].Type = map[index] == 0 ? (GridType)map.Neighbour(index).Sum() : GridType.Mine;
            }
            Game.State = GameState.Started;
        }

        private bool floodFill(Grid grid)
        {
            if (!grid.Explorable) return false;
            if (grid.Explore()) return true;
            if (grid.Type != GridType.Zero) return false;
            foreach (var neighbour in gridMatrix.Neighbour(grid.Index))
            {
                if (neighbour.Explorable && floodFill(neighbour)) return true;
            }
            return false;
        }

        private bool cleared()
        {
            foreach (var grid in gridMatrix)
            {
                if (grid.Type != GridType.Mine && grid.Mode != GridMode.Explored) return false;
            }
            return true;
        }

        public void Reveal()
        {
            foreach (var grid in gridMatrix)
            {
                grid.Reveal();
            }
        }
        #endregion

        #region 接口实现
        void IReadable.ReadFrom(Reader reader)
        {
            foreach (var grid in gridMatrix) reader.Read(grid);
        }

        void IWritable.WriteTo(Writer writer)
        {
            foreach (var grid in gridMatrix) writer.Write(grid);
        }
        #endregion
    }
}