using ShelterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterPackager
{
    public partial class Form1 : Form
    {
        private readonly MechineCode mechineCode;

        public Form1()
        {
            InitializeComponent();

            this.mechineCode = new MechineCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length != 32)
            {
                MessageBox.Show("无效的机器码");
                return;
            }

            string authorizeCode = mechineCode.GenerateAuthorizeCode(textBox1.Text);

            textBox2.Text = authorizeCode;
        }
    }
}
