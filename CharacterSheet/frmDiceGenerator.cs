using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class frmDiceGenerator : Form
    {
        public frmDiceGenerator()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum += rollDie(txtd4.Text, 4);
            sum += rollDie(txtd6.Text, 6);
            sum += rollDie(txtd8.Text, 8);
            sum += rollDie(txtd10.Text, 10);
            sum += rollDie(txtd12.Text, 12);
            sum += rollDie(txtd20.Text, 20);
            sum += rollDie(txtd100.Text, 100);

            lblTotal.Text = "Total : " + Convert.ToString(sum);
        }

        public int rollDie(string text, int dieSide)
        {
            int dice;
            int sum = 0;
            dieSide += 1;
            Random rand = new Random();
            bool parsed = Int32.TryParse(text, out dice);

            if (parsed)
            {
                for (int i = dice; i > 0; i--)
                {
                    sum += rand.Next(1, dieSide);
                }

                return sum;
            }

            return sum;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
