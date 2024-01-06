using MineSweeper.Controls;
using Resources = MineSweeper.Properties.Resources;

namespace MineSweeper.DataStructure
{
    static internal class GridImage
    {
        #region 字段
        private static Dictionary<GridType, dynamic> explored;
        private static Dictionary<GridState, dynamic> concealed, marked, undetermined;
        #endregion

        static GridImage()
        {
            explored = new Dictionary<GridType, dynamic>
            {
                {GridType.Zero,Resources.empty },
                {GridType.One,Resources._1 },
                {GridType.Two,Resources._2 },
                {GridType.Three,Resources._3 },
                {GridType.Four,Resources._4 },
                {GridType.Five,Resources._5 },
                {GridType.Six,Resources._6 },
                {GridType.Seven,Resources._7 },
                {GridType.Eight,Resources._8 },
                {GridType.Mine,Resources.redMine },
                {GridType.Undetermined,null }
            };

            concealed = new Dictionary<GridState, dynamic>
            {
                {GridState.None,Resources.concealed },
                {GridState.MouseOver,Resources.concealedMouseOver },
                {GridState.MouseDown,Resources.empty }
            };

            marked = new Dictionary<GridState, dynamic>
            {
                {GridState.None, Resources.marked },
                {GridState.MouseOver,Resources.markedMouseOver },
                {GridState.MouseDown,Resources.marked }
            };

            undetermined = new Dictionary<GridState, dynamic>
            {
                {GridState.None,Resources.questionMark },
                {GridState.MouseOver,Resources.questionMarkMouseOver },
                {GridState.MouseDown,Resources.questionMarkMouseDown }
            };
        }

        public static void Paint(BasicGrid grid)
        {
            switch (grid.Mode)
            {
                case GridMode.Concealed:
                    grid.Image = concealed[grid.State];
                    break;
                case GridMode.Marked:
                    grid.Image = marked[grid.State];
                    break;
                case GridMode.Undetermined:
                    grid.Image = undetermined[grid.State];
                    break;
                case GridMode.Explored:
                    grid.Image = explored[grid.Type];
                    break;
                case GridMode.Revealed:
                    grid.Image = grid.Type == GridType.Mine ? Resources.mine : Resources.falseMine;
                    break;
            }
        }
    }
}