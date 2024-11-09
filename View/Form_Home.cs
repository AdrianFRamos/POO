using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cadProd = new Form_Cad_Produto();
            cadProd.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listProd = new Form_List_Prod();
            listProd.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var listUser = new Form_List_User();
            listUser.Show();
            this.Visible = false;
        }
    }
}
