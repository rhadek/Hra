using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class HerniPostava
    {
        private string name;

        public HerniPostava(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    MessageBox.Show("Příliš dlouhé jméno!");
                }
            }
        }
    }
}

