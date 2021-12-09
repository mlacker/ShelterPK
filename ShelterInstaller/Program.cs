using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterInstaller
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new FormController();
            controller.Forms =  new List<Form> {
                new Setup0(controller),
                new Setup1(controller),
                new Setup2(controller),
                new Setup3(controller),
                new Setup4(controller),
                new Setup5(controller)
            };


            Application.Run(controller.Head());
        }
    }
}
