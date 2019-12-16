using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAndTripleDES
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DESFormButton_Click(object sender, EventArgs e)
        {
            DESForm desForm = new DESForm();
            desForm.Show();
        }

        private void TDESFromButton_Click(object sender, EventArgs e)
        {
            TDESForm tdesForm = new TDESForm();
            tdesForm.Show();
        }
    }
}
