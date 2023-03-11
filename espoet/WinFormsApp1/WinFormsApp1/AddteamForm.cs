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
    public partial class AddteamForm : Form
    {
        public static string Setname = "";
        public static string Setusername = "";
        public AddteamForm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void selectplayerbutton(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            PlayerForm playerForm = new PlayerForm();
            playerForm.ShowDialog();

            if (playerForm.DialogResult == DialogResult.OK)
            {
                string name = PlayerForm.Setname;
                string username = PlayerForm.SetUsername;
                if (button.Name == "buttonSec1")
                {
                    this.textBox1.Text = name;
                    this.textBox7.Text = username;
                }
                if (button.Name == "buttonSec2")
                {
                    this.textBox3.Text = name;
                    this.textBox8.Text = username;
                }
                if (button.Name == "buttonSec3")
                {
                    this.textBox4.Text = name;
                    this.textBox9.Text = username;
                }
                if (button.Name == "buttonSec4")
                {
                    this.textBox6.Text = name;
                    this.textBox10.Text = username;
                }
                if (button.Name == "buttonSec5")
                {
                    this.textBox5.Text = name;
                    this.textBox11.Text = username;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string team = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
