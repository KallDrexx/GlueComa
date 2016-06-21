using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace GlueComa
{
    public partial class EditorControl : UserControl
    {
        private readonly WebBrowser _browser;

        public EditorControl()
        {
            InitializeComponent();
            _browser = new WebBrowser();
            Controls.Add(_browser);
            _browser.Dock = DockStyle.Fill;
        }

        private void EditorControl_Load(object sender, EventArgs e)
        {
            _browser.Url = new Uri(GetPagePath("editor.html"));
        }

        private string GetPagePath(string htmlFileName)
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var htmlFolder = Path.Combine(basePath, "html");
            return Path.Combine(htmlFolder, htmlFileName);
        }
    }
}
