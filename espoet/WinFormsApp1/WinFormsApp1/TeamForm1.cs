using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TeamForm1 : Form
    {
        BindingList<Team> Teamlist = new BindingList<Team>();
        public TeamForm1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Teamlist;
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddteamForm addteamForm = new AddteamForm();
            addteamForm.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.toolStripDropDownButton1.HideDropDown();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addTeamToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddteamForm addteamfrom = new AddteamForm();
            addteamfrom.ShowDialog();
            if (addteamfrom.DialogResult == DialogResult.OK)
            {
                string team = addteamfrom.textBox2.Text;

                string name1 = addteamfrom.textBox1.Text;
                string username1 = addteamfrom.textBox7.Text;

                string name2 = addteamfrom.textBox3.Text;
                string username2 = addteamfrom.textBox8.Text;

                string name3 = addteamfrom.textBox4.Text;
                string username3 = addteamfrom.textBox9.Text;

                string name4 = addteamfrom.textBox6.Text;
                string username4 = addteamfrom.textBox10.Text;

                string name5 = addteamfrom.textBox5.Text;
                string username5 = addteamfrom.textBox11.Text;

                Team newTeam = new Team(team, name1, username1, name2, username2, name3, username3, name4, username4, name5, username5);
                Teamlist.Add(newTeam);

                this.dataGridView1.DataSource = Teamlist;
            }
        }

        private void closeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.closeToolStripMenuItem1.HideDropDown();
        }

        private void saveFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Team item in Teamlist)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            item.Teamnname,
                            item.Name1,
                            item.Username1,
                            item.Name2,
                            item.Username2,
                            item.Name3,
                            item.Username3,
                            item.Name4,
                            item.Username4,
                            item.Name5,
                            item.Username5
                            ));
                    }
                }
            }
        }

        private void openFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 11)
                        {
                            Team teams = new Team(
                                line[0],
                                line[1],
                                line[2],
                                line[3],
                                line[4],
                                line[5],
                                line[6],
                                line[7],
                                line[8],
                                line[9],
                                line[10]
                            );
                            Teamlist.Add(teams);
                        }
                    }
                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Teamlist;
            }
    }
    }
}
