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

namespace AnimalFileImporter
{
    public partial class AnimalFileImporter : Form
    {
        public AnimalFileImporter()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            if(ofdGetAnimals.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofdGetAnimals.FileName;
                using (StreamReader stream = new StreamReader(fileName))
                {
                    string line;
                    while((line = stream.ReadLine()) != null)
                    {
                        lbImportedAnimals.Items.Add(line);
                    }
                    
                }
            }
        }
    }
}
