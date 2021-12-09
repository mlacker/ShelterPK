using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterInstaller
{
    public class FileController
    {
        public void Install(string gamePath, System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar.Value = 0;

            var fakeFile = new FileInfo("1假.NPK");
            var trueFile = new FileInfo("2真.NPK");

            if (!fakeFile.Exists || !trueFile.Exists)
            {
                MessageBox.Show("安装文件不存在");
                return;
            }

            var targetTureFile = new FileInfo($"{gamePath}\\ImagePacks2\\sprite_character_common_aura_chn_2020_nationalday_aura.NPK");
            if (targetTureFile.Exists)
            {
                targetTureFile.Attributes &= ~(FileAttributes.System | FileAttributes.Hidden);
            }

            progressBar.Increment(20);

            var copiedFakeFile = fakeFile.CopyTo($"{gamePath}\\ImagePacks2\\{fakeFile.Name}", true);

            progressBar.Increment(20);

            var copiedTrueFile = trueFile.CopyTo(targetTureFile.FullName, true);

            progressBar.Increment(20);

            copiedTrueFile.Attributes |= FileAttributes.Hidden | FileAttributes.System;
            copiedTrueFile.CreationTime = trueFile.CreationTime;
            copiedFakeFile.CreationTime = DateTime.Now;

            progressBar.Increment(20);

            var paddingSize = trueFile.Length;
            var fileStream = copiedFakeFile.Open(FileMode.Append, FileAccess.Write);
            var buffer = new byte[paddingSize];
            fileStream.Seek(0, SeekOrigin.Current);
            fileStream.Write(buffer, 0, buffer.Length);
            fileStream.Flush();
            fileStream.Close();

            progressBar.Increment(20);
        }

        public void Uninstall(string gamePath)
        {
            var fakeName = "1假.NPK";
            var trueName = "sprite_character_common_aura_chn_2020_nationalday_aura.NPK";

            var fakeFile = new FileInfo($"{gamePath}\\ImagePacks2\\{fakeName}");
            var trueFile = new FileInfo($"{gamePath}\\ImagePacks2\\{trueName}");

            if (fakeFile.Exists)
            {
                fakeFile.Delete();
            }

            if (trueFile.Exists)
            {
                trueFile.Delete();
            }
        }
    }
}
