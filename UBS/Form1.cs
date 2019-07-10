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

        private void button1_Click(object sender, EventArgs e)
        {
            //string pathFile = @"c:\movie.json";
            string pathFile = @"C:\UBS\MOCK_DATA_1.json";
            List<PersonDTO> person = JsonConvert.DeserializeObject<List<PersonDTO>>(File.ReadAllText(pathFile));
        }
    }
}
