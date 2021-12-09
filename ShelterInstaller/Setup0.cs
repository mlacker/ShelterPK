using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterInstaller
{
    public partial class Setup0 : Form
    {
        private FormController controller;

        public Setup0(FormController controller)
        {
            this.controller = controller;

            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
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
