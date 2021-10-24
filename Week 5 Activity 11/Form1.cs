using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int count = 0; // counter variable
        private async void RollDiceButton_Click(object sender, EventArgs e)
        {
            int sides;

            if (int.TryParse(sideSelection.Text, out sides) && (sides >= 4 && sides <= 20))
            {
                // create both dice
                Dice d1 = new Dice(sides);
                Dice d2 = new Dice(sides);

                // Roll each of the dice
                int face1 = d1.Roll();
                await Task.Delay(350); // slight delay to avoid both random numbers being from same seed
                int face2 = d2.Roll();
                count++; // increment counter for each roll

                // display rolls
                d1Display.Text = face1.ToString();
                d2Display.Text = face2.ToString();

                // if both values are 1 (snake eyes)
                if (face1 == face2 && face1 == 1)
                {
                    MessageBox.Show("It took " + count + " rolls to get snake eyes!");
                    count = 0;
                }
            }
            else
            {
                MessageBox.Show("Please enter a number of sides on the dice. (4-20)");
            }
        }
    }

    class Dice
    {
        private int face; // variable for value the dice
        private int sides; // variable for how many sides of the dice

        // constructor
        public Dice(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            Random r = new Random(); // random number

            face = r.Next(1, (this.sides + 1)); // uses random number to determine face value

            return face;
        }
    }
}
