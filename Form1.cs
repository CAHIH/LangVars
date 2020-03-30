using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> RusWords = new Dictionary<string, string>();
        Dictionary<string, string> EngWords = new Dictionary<string, string>();
        Dictionary<string, string> UkrWords = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            RusWords.Add("Новичок" , "Новичок");
            RusWords.Add("Любитель" , "Любитель");
            EngWords.Add("Новичок", "Newbie");
            EngWords.Add("Любитель", "Amateur");
            UkrWords.Add("Новичок", "Новачок(укр)");
            UkrWords.Add("Любитель", "Любитель(укр)");

        }
     
    private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            button1.Text = EngWords["Новичок"];
            button2.Text = EngWords["Любитель"];


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.Text = RusWords["Новичок"];
            button2.Text = RusWords["Любитель"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Text = UkrWords["Новачок(укр)"];
            button2.Text = UkrWords["Любитель(укр)"];

        }
    }

}
