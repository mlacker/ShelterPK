using Microsoft.Win32;
using ShelterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterInstaller
{
    public partial class Setup3 : Form
    {
        private readonly FormController controller;
        private readonly MechineCode mechineCode;
        private readonly string code;

        public Setup3(FormController controller)
        {
            this.controller = controller;
            this.mechineCode = new MechineCode();

            InitializeComponent();

            textBox2.Text = this.code = this.mechineCode.GenerateMechineCode();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            controller.Prev();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (!this.mechineCode.ValidateCode(code, textBox1.Text))
            {
                MessageBox.Show("请输入正确的授权码");
                return;
            }

            controller.Next();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Setup0_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.Close();
        }
    }
}
