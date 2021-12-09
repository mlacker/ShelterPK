using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterInstaller
{
    public partial class Setup4 : Form
    {
        private FormController controller;
        private readonly FileController fileController;

        public Setup4(FormController controller)
        {
            this.controller = controller;
            this.fileController = new FileController();

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileController.Install(controller.GamePath, progressBar1);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            controller.Prev();
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
