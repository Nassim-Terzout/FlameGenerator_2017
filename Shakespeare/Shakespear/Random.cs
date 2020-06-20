using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shakespear
{
    public partial class Randomform : Form
    {
        public Randomform()
              
            
            
        {
           


            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //terminate program
            Environment.Exit(0);
        }

        private void adj1_Click(object sender, EventArgs e)
        {

        }

        private void insult_Click(object sender, EventArgs e)
        {
           // Random x = new Random(1 - 30);
           // Random y = new Random(1 - 16);
            //Random z = new Random(1 - 10);
         

            //Setting up my random possible outcomes from G. Keep generating and selecting from array upon click.
             int b = G.R.Next(0, 29);
             int b2 = G.R.Next(0, 28);
             int b3 = G.R.Next(0, 18);

            //setting up my outcomes for the random generated numbers. This will allow for a sentence to be formed 
               binsult.Text = "Thou " + G.adj1[b] + ", " + G.adj2[b2] + " " + G.noun[b3] + "!";

            //Did the same here but for translation only
              btranslate.Text = "You " + G.adj12[b] + ", " + G.adj22[b2] + " " + G.noun2[b3] + "!";

       
        }

        private void binsult_Click(object sender, EventArgs e)
        {

        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            // How to go to the help from here
            // hide this form
            //show bothe= random help and random back button ONLY
            //show the help form.
            this.Hide();
            G.A.randhelp.Visible = true;
            G.A.Randombutton.Visible = true; 
            G.A.Show();
        }

        private void Dictionarybutton_Click(object sender, EventArgs e)
        {
            //hide this and show dictionary form
            this.Hide();
            G.D.Show();
        }

        private void btranslate_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {
            //go to main
            this.Hide();
            G.F.Show();
            

        }

        //private void translatebtn_Click(object sender, EventArgs e)
        // {
        //    if (Translatelbl.Visible == false)
        //   {
        //     Insultlbl.Visible = false;
        //      Translatelbl.Visible = true;
        // }
        // else if (Translatelbl.Visible == true)
        // {
        //    Insultlbl.Visible = true;
        //     Translatelbl.Visible = false;
        // }
        //}

        //}
    }
}

