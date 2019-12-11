using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTF8Base64
{
    public partial class Form1 : Form
    {
        Conv conv = new Conv();

        public Form1()
        {
            InitializeComponent();
        }

        private void UTFEnBtn_Click(object sender, EventArgs e)
        {
            this.DecodeTextBox.Text = conv.UTF8Encode(this.EncodeTextBox.Text);
        }

        private void UTFDeBtn_Click(object sender, EventArgs e)
        {
            this.DecodeTextBox.Text = conv.UTF8Decode(this.DecodeTextBox.Text);
        }

        private void BaseEnBtn_Click(object sender, EventArgs e)
        {
            this.DecodeTextBox.Text = conv.Base64Encode(this.EncodeTextBox.Text);
        }

        private void BaseDeBtn_Click(object sender, EventArgs e)
        {
            this.DecodeTextBox.Text = conv.Base64Encode(this.DecodeTextBox.Text);
        }
    }
}
