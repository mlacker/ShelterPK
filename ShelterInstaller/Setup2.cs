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
    public partial class Setup2 : Form
    {
        private readonly List<string> existsFiles = new List<string>()
        {
            "dnf.exe",
            "GameLoader.exe",
            "ImagePacks2\\sprite_interface.NPK",
        };
        private FormController controller;
        private readonly FileController fileController;

        public Setup2(FormController controller)
        {
            this.controller = controller;
            this.fileController = new FileController();

            InitializeComponent();
        }

        private void browserFolderBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (DialogResult.OK != folderBrowserDialog.ShowDialog())
                {
                    return;
                }

                gameDirTxt.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Install(object sender, EventArgs e)
        {
            if (!validateGamePath())
            {
                return;
            }
            controller.Next();
        }

        private void Uninstall(object sender, EventArgs e)
        {
            if (!validateGamePath())
            {
                return;
            }
            
            fileController.Uninstall(controller.GamePath);
        }

        private bool validateGamePath()
        {
            var gamePath = gameDirTxt.Text;
            if (existsFiles.All(it => File.Exists($"{gamePath}\\{it}")))
            {
                controller.GamePath = gamePath;
                return true;
            }

            MessageBox.Show("非游戏目录");
            return false;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            controller.Prev();
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
