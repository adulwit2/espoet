using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Team
    {
        [DisplayName("ชื่อทีม")]
        public string Teamnname { get; set; }
        [DisplayName("ชื่อ คนที่1")]
        public string Name1 { get; set; }
        [DisplayName("ชื่อในเกมส์คนที่1")]
        public string Username1 { get; set; }
        [DisplayName("ชื่อ คนที่2")]
        public string Name2 { get; set; }
        [DisplayName("ชื่อในเกมส์คนที่2")]
        public string Username2 { get; set; }
        [DisplayName("ชื่อ คนที่3")]
        public string Name3 { get; set; }
        [DisplayName("ชื่อในเกมส์คนที่3")]
        public string Username3 { get; set; }
        [DisplayName("ชื่อ คนที่4")]
        public string Name4 { get; set; }
        [DisplayName("ชื่อในเกมส์คนที่4")]
        public string Username4 { get; set; }
        [DisplayName("ชื่อ คนที่5")]
        public string Name5 { get; set; }
        [DisplayName("ชื่อในเกมส์คนที่5")]
        public string Username5 { get; set; }

        public Team(string teamnname, string name1, string username1, string name2, string username2, string name3, string username3, string name4, string username4, string name5, string username5)
        {
            this.Teamnname = teamnname;
            this.Name1 = name1;
            this.Username1 = username1;
            this.Name2 = name2;
            this.Username2 = username2;
            this.Name3 = name3;
            this.Username3 = username3;
            this.Name4 = name4;
            this.Username4 = username4;
            this.Name5 = name5;
            this.Username5 = username5;
        }
    }
}
