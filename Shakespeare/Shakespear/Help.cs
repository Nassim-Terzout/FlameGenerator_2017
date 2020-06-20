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
    public partial class Helpp : Form
    {
        
        public Helpp()
        {
            
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
            
        }

        private void Helptext1_Click(object sender, EventArgs e)
        {

        }

        private void yea_Tick(object sender, EventArgs e)
        {
           
              //  Hello and welcome to the Shakespear insult Generator!
//Press the Random Generator button to go to the Insult
//Generator.Press the Dictionary button to select from a
//list of all vocabulary and get a detailed description of
//each word. If you would like to return to the main menu
//press the Main Menu button. To exit the program press
//the red X in the top right corner then press the red X on
//the main menu.Have fun!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void introhelp_Click(object sender, EventArgs e)
        {

        }

        private void Dictionarybutton_Click(object sender, EventArgs e)
        {
            
            
            //NOTE : i used 3 buttons and 3 texts for the help form. Based on which help user requires one of each will be selected in order to combine and make a help form that can inform the user of what to do and also give him the back button to return to his selected form.
            //Also i used visibilty to show 2 help factors at all time and hide the other 4!
            
            //Close and show dictionary. Set all buttons and texts to visible = false;
            Randombutton.Visible = false;
            Introbutton.Visible = false;
            Dictionarybutton.Visible = false;
            introhelp.Visible = false;
            dichelp.Visible = false;
            randhelp.Visible = false;
            this.Hide();
            G.D.Show();
        }

        private void Randombutton_Click(object sender, EventArgs e)
        {
            //Close and show random generator. Set all buttons and texts to visible = false;
            Randombutton.Visible = false;
            Introbutton.Visible = false;
            Dictionarybutton.Visible = false;
            introhelp.Visible = false;
            dichelp.Visible = false;
            randhelp.Visible = false;
            this.Hide();
            G.B.Show();
        }

        private void randhelp_Click(object sender, EventArgs e)
        {

        }

        private void Introbutton_Click(object sender, EventArgs e)
        {
            //Close and show intro. Set all buttons and texts to visible = false;
            Randombutton.Visible = false;
            Introbutton.Visible = false;
            Dictionarybutton.Visible = false;
            introhelp.Visible = false;
            dichelp.Visible = false;
            randhelp.Visible = false;
            this.Hide();
            
            
            

        }
    }
}
