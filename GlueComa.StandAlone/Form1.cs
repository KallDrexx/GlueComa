using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlueComa.StandAlone
{
    public partial class Form1 : Form
    {
        private readonly EditorControl _editor;

        public Form1()
        {
            InitializeComponent();

            _editor = new EditorControl();
            Controls.Add(_editor);
            _editor.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _editor.LoadCodeFile(dialog.FileName);
            }
        }
    }
}
