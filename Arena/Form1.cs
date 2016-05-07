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
            public int health;

            public void setHealth()
            {
                health = r.Next(90, 141);
            }
        }

        public void generateFighter()
        {
            Fighter fighter1 = new Fighter();
            fighter1.setHealth();
            textBox1.Text = "An enemy aproaches with" + fighter1.health.ToString() + " hp and toting a pistol that deals out " + pistol["damage"] + " damage";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            generateFighter();
        }
    }
}
