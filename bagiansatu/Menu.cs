using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bagiansatu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Owner = this;
            menu.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();

            profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();

            transaksi.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
