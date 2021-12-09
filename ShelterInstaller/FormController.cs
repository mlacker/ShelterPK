using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShelterInstaller
{
    public class FormController
    {
        private int currentIndex = 0;

        public IEnumerable<Form> Forms { get;  set; }
        public string GamePath { get; internal set; }

        public Form Head()
        {
            return Forms.ElementAt(currentIndex = 0);
        }

        public void Prev()
        {
            if (currentIndex == 0) return;

            Forms.ElementAt(currentIndex).Hide();
            Forms.ElementAt(--currentIndex).Show();
        }

        public void Next()
        {
            if (currentIndex == Forms.Count() - 1) return;

            var prev = Forms.ElementAt(currentIndex);
            var next = Forms.ElementAt(++currentIndex);

            prev.Hide();
            next.Show();
        }

        public void Close()
        {
            Application.Exit();
        }
    }
}
