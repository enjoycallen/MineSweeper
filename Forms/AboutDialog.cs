using MineSweeper.Properties;
using System.Diagnostics;

namespace MineSweeper.Forms
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            captionLabel.Text = "NJUPT B20030919陈天 程序设计 扫雷\r\n\r\n" + "版本：" + Resources.version + "\r\n\r\n" +
                "发布时间：" + Resources.publishDate + " 2024/1/4\r\n\r\n" + "项目地址：";
            repositoryLinkLabel.Text = Resources.repository;
        }

        private void repositoryLinkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("explorer.exe", repositoryLinkLabel.Text);

        private void exitButtonClick(object sender, EventArgs e) => Close();
    }
}
