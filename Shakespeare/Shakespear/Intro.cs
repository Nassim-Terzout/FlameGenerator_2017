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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Random_Click(object sender, EventArgs e)
        {
            // hide and show random form
            this.Hide();
            G.B.Show();
            


        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void Dictionarybutton_Click(object sender, EventArgs e)
        {
            // hide and show dictionary
            this.Hide();
            G.D.Show();
            
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            // How to go to the help from here
            // hide this form
            //show both itnro help and intro back button ONLY
            //show the help form.
            this.Hide();
            
            G.A.introhelp.Visible = true;
            G.A.Introbutton.Visible = true;
            G.A.ShowDialog();
            this.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer to create a loading effect before allowing user to access program
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading . ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading . . ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading . . . ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading  ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading . ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading . . ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            black.Text = "Loading . . . ";
            Refresh();
            System.Threading.Thread.Sleep(1000);
            Refresh();
            loading.Enabled = false;
            // turn timer off, allow user to access program by turning off visibility of images.
            black.Visible = false;
            orange.Visible = false;
            img.Visible = false;

        }
    }
}
