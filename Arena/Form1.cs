using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random r = new Random();

        Dictionary<string, int> pistol = new Dictionary<string, int>()
        {
            {"damage", r.Next(10, 15)}
        };

        public class Fighter
        {
            public int health = r.Next(90, 141);
        }

        Fighter fighter1 = new Fighter();

        public void generateFighter()
        {
            textBox1.AppendText("An enemy aproaches with " + fighter1.health.ToString() + " hp and a pistol that deals out " + pistol["damage"] + " damage..." + Environment.NewLine);
        }

        public void shootEm()
        {
            fighter1.health = fighter1.health - pistol["damage"];
            textBox1.AppendText(fighter1.health.ToString() +Environment.NewLine);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            generateFighter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shootEm();
        }
    }
}
