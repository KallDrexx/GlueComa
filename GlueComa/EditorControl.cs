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

            _browser.Navigated += _browser_Navigated;
            _browser.DocumentCompleted += _browser_DocumentCompleted;
        }

        private void _browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void _browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
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

        private const string Test = @"using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS
{
	class Program
	{
		static void Main(string[] args)
		{
			ProcessStartInfo si = new ProcessStartInfo();
			float load= 3.2e02f;
		}
    }
}
";

        private void button1_Click(object sender, EventArgs e)
        {
            var param = new object[] { Test, "csharp" };
            var result = _browser.Document.InvokeScript("loadCode", param);
        }
    }
}
