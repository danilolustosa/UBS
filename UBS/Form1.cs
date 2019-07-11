using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBS.DTO;
using Newtonsoft.Json;
using System.IO;

namespace UBS
{
    public partial class Form1 : Form
    {
        public string pathFile = @"C:\UBS\DATA.json";
        public DateTime lastChangeDataFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadJson();
        }

        private void LoadJson()
        {
            if (File.Exists(this.pathFile))
            {
                this.lastChangeDataFile = File.GetLastWriteTime(this.pathFile);
                List<PersonDTO> person = JsonConvert.DeserializeObject<List<PersonDTO>>(File.ReadAllText(this.pathFile));
                this.dataGridView1.DataSource = person;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(this.pathFile))
            {
                if (File.GetLastWriteTime(this.pathFile) != this.lastChangeDataFile)
                {
                    this.lastChangeDataFile = File.GetLastWriteTime(this.pathFile);
                    this.LoadJson();
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }
    }
}
