using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShelterLibrary
{
    public class MechineCode
    {
        private readonly MD5 md5 = MD5.Create();

        public string GenerateMechineCode()
        {
            var processId = GetProcessId();
            var boisVersion = GetBiosVersion();

            var content = processId + boisVersion;

            return Hash(content);
        }

        public string GenerateAuthorizeCode(string mechineCode)
        {
            return Hash(mechineCode.Insert(10, "SHELTER"));
        }

        public bool ValidateCode(string mechineCode, string authorizeCode)
        {
            var hash = GenerateAuthorizeCode(mechineCode);

            return hash.Equals(authorizeCode);
        }

        private string Hash(String content)
        {
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(content));

            return BitConverter.ToString(hash, 0, hash.Length).Replace("-", String.Empty);
        }

        private string GetProcessId()
        {
            using (var management = new ManagementClass("Win32_Processor"))
            {
                ManagementObjectCollection moc = management.GetInstances();

                string processId = string.Empty;
                foreach (var mo in moc)
                {
                    processId = mo.Properties["ProcessorId"].Value.ToString();
                    mo.Dispose();
                }

                return processId;
            }
        }

        private string GetBiosVersion()
        {
            var biosVersions = (object[])Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System", "SystemBiosVersion", string.Empty);
            var biosVersion = string.Empty;
            if (biosVersions != null)
            {
                foreach (var item in biosVersions)
                {
                    biosVersion += item.ToString();
                }
            }

            return biosVersion;
        }
    }
}
