using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace GlueComa
{
    public partial class EditorControl : UserControl
    {
        private ChromiumWebBrowser _browser;

        public EditorControl()
        {
            InitializeComponent();
        }

        private void EditorControl_Load(object sender, EventArgs e)
        {
            Cef.Initialize(new CefSettings());
            _browser = new ChromiumWebBrowser("www.google.com");
            Controls.Add(_browser);
            _browser.Dock = DockStyle.Fill;
        }
    }
}
