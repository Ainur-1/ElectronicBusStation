using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicBusStation
{
    public partial class MainForm : Form
    {
        ApplicationContext appdb;
        public MainForm()
        {
            InitializeComponent();
            appdb = new ApplicationContext();
            Timetable[] tt = appdb.timetable.ToArray<Timetable>();
            RouteData.DataSource = tt;
            foreach(Timetable i in tt)
            {
                RoutNums.Items.Add(i.BusId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SignOutItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AuthorisationForm = new AuthorisationForm();
            AuthorisationForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numTic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RoutNums_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            int RN = RoutNums.SelectedIndex+1;
            int TicketNum = (int)numTic.Value;
            this.Hide();
            //Timetable NewInf = appdb.timetable.Find(RN);
            //Timetable N1 = new Timetable { BusId = NewInf.BusId, DepartureTime = NewInf.DepartureTime, TicketPrice = NewInf.TicketPrice, NuberOfTicket = NewInf.NuberOfTicket-TicketNum };
            //appdb.timetable.Remove(NewInf);
            //appdb.SaveChanges();
            //appdb.timetable.Add(NewInf);
            //appdb.SaveChanges();


            var uprout = appdb.timetable
                // Загрузить покупателя с фамилией "Иванов"
                .Where(c => c.BusId == RN)
                .FirstOrDefault();
            int q = uprout.NuberOfTicket;
            // Внести изменения
            uprout.NuberOfTicket = q - TicketNum;

            // Сохранить изменения
            appdb.SaveChanges();
            MessageBox.Show("Спасибо за покупку!");
        }
    }
}
