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
using System.Text.Json;



namespace PracticalWork
{
    public partial class Form2 : Form
    {
        TrainServcie tr = new TrainServcie();
        
         public Form2()
        {
            InitializeComponent();
            tr.Add();
            TypeCar[] typeCar = Enum.GetValues(typeof(TypeCar)) as TypeCar[];
            foreach (var item in typeCar)
            {
                comboBoxType.Items.Add(item);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            foreach(var i in tr.TrainList)
            {
                if (textBoxCityFrom.Text == i.CityFrom && textBoxCityTo.Text == i.CityTo)
                {
                    listBoxReis.Items.Add(i);
                }   
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listBoxTicket.Enabled = true;
            Ticket ticket = new Ticket();
            using (FileStream sr = new FileStream("tickec.json",FileMode.OpenOrCreate)) {

                
                ticket.pasanger.NamePass = textBoxName.Text;
                ticket.pasanger.SurnamePass = textBoxSurname.Text;
                ticket.train = listBoxReis.SelectedItem as Train;
                ticket.NumberCarr = (uint)numericUpDown1.Value;
                ticket.seat = Convert.ToUInt16(textBoxSeat.Text);
                ticket.typecar = (TypeCar)comboBoxType.SelectedItem;
                JsonSerializer.SerializeAsync<Ticket>(sr,ticket);


            }
            listBoxTicket.Items.Add(ticket);
        }
    }
}
