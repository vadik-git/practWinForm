using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalWork
{
    public partial class Form1 : Form
    {
        TrainServcie TrainServcie = new TrainServcie();
        public Form1()
        {
            InitializeComponent();
            //TrainServcie.Add();
            //listBox1.DataSource = TrainServcie.TrainList;
            //listBox1.DisplayMember = "NumberTrain";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("ticket.json", FileMode.OpenOrCreate))
            {
               // Ticket historyTicket = JsonSerializer.Deserialize<Ticket>("ticket.json");
                //listBox1.Items.Add(historyTicket);
                
            }
        }

        private void buttonOrderTicket_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
