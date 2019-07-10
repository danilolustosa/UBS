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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string pathFile = @"C:\UBS\DATA.json";
            if (File.Exists(pathFile))
            {
                List<PersonDTO> person = JsonConvert.DeserializeObject<List<PersonDTO>>(File.ReadAllText(pathFile));
                this.dataGridView1.DataSource = person;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }
    }
}
