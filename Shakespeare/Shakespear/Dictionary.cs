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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dictionarybox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            // These are all the words in my program
            // With each if statement im saying if the text in the dropbox is equal to those given letters then make the output or definition equal to what is set it to be
            // the definition is based on the text in the dropbox which is what the user selects.
            //A bunch of if statements and else if statements until all words are defined....
            if (F.Text == "Adjective - Artless")
            {
                output.Text = "A Person who is unskillful ";
            }
            else if (F.Text == "Adjective - Bawdy")
            {
                output.Text = "A filthy individual ";
            }
            else if (F.Text == "Adjective - Cockered")
            {
                output.Text = "One who is spoiled";
            }
            else if (F.Text == "Adjective - Lumpish")
            {
                output.Text = "One who is despondent";
            }
            else if (F.Text == "Adjective - Mangled")
            {
                output.Text = "One who is disfigured";
            }
            else if (F.Text == "Adjective - Pribbling")
            {
                output.Text = "One who is petty";
            }
            else if (F.Text == "Adjective - Puny")
            {
                output.Text = "One who is inexperienced";
            }
            else if (F.Text == "Adjective - Loggerheaded")
            {
                output.Text = "A blockhead individual";
            }
            else if (F.Text == "Adjective - Craven")
            {
                output.Text = "A corward";
            }
            else if (F.Text == "Adjective - Spleeny")
            {
                output.Text = "A weakling";
            }
            else if (F.Text == "Adjective - Jarring")
            {
                output.Text = "A individual who is a Jerk";
            }
            else if (F.Text == "Adjective - Savage")
            {
                output.Text = "A ruthless Barbarian";
            }
            else if (F.Text == "Adjective - Yeasty")
            {
                output.Text = "A superficial human being";
            }
            else if (F.Text == "Adjective - Wayward")
            {
                output.Text = "Erratic individual";
            }
            else if (F.Text == "Adjective - Goatish")
            {
                output.Text = "A goatlike individual";
            }
            else if (F.Text == "Adjective - Beef-witted")
            {
                output.Text = "One who is brainless";
            }
            else if (F.Text == "Adjective - Fat-kidneyed")
            {
                output.Text = "One who is gross from their appearance";
            }
            else if (F.Text == "Adjective - Half-faced")
            {
                output.Text = "A defective human being";
            }
            else if (F.Text == "Adjective - Knotty-pated")
            {
                output.Text = "One who is dull and boring";
            }
            else if (F.Text == "Adjective - Onion eyed")
            {
                output.Text = "A teary eyed individual; somone who is emotionally weak";
            }
            else if (F.Text == "Adjective - Sheep-biting")
            {
                output.Text = "A theiveing and conniving individual";
            }
            else if (F.Text == "Adjective - Tardy-gaited")
            {
                output.Text = "A slow moving individual";
            }
            else if (F.Text == "Adjective - Toad-spotted")
            {
                output.Text = "A thickly stained individual";

            }
            else if (F.Text == "Adjective - Idle-headed")
            {
                output.Text = "A foolish individual";
            }
            else if (F.Text == "Adjective - Ill-nurtured")
            {
                output.Text = "An ill-bred individual";
            }
            else if (F.Text == "Adjective - Rump-fed")
            {
                output.Text = "A pampered individual; spoiled";
            }
            else if (F.Text == "Adjective - Weather-bitten")
            {
                output.Text = "A defaced individual";
            }
            else if (F.Text == "Adjective - Unchin-snouted")
            {
                output.Text = "The word ugly, used to describe an individual";

            }
            else if (F.Text == "Adjective - Milk-livered")
            {
                output.Text = "A individual who is a coward";

            }
            else if (F.Text == "Adjective - Earth-vexing")
            {
                output.Text = "Comapres an individual to the Plague";

            }
            else if (F.Text == "Noun - Baggage")
            {

                output.Text = " A Harlot";
            }
            else if (F.Text == "Noun - Harpy")
            {

                output.Text = "A Hag";
            }
            else if (F.Text == "Noun - Maggot-pie")
            {

                output.Text = "A Rotten object ";
            }
            else if (F.Text == "Noun - Measle")
            {
                output.Text = "A Tapeworm";

            }
            else if (F.Text == "Noun - Miscreant")
            {
                output.Text = "A Rascal";

            }
            else if (F.Text == "Noun - Puttock")
            {
                output.Text = "A greedy individual";

            }
            else if (F.Text == "Noun - Whey-faced")
            {
                output.Text = "A individual who has a pasty face";

            }
            else if (F.Text == "Noun - Strumpet")
            {

                output.Text = "A Pervert or somone with a perverted mind";
            }
            else if (F.Text == "Noun - Apple-John")
            {

                output.Text = "Withered";
            }
            else if (F.Text == "Noun - Boar Pig ")
            {
                output.Text = "A Male Swine";

            }
            else if (F.Text == "Noun - Vassal")
            {
                output.Text = "A Slave";

            }
            else if (F.Text == "Noun - Strumpet")
            {
                output.Text = "A Prostitute ";

            }
            else if (F.Text == "Noun - Lout")
            {
                output.Text = "A ill manered boor";

            }
            else if (F.Text == "Noun - Nuthook")
            {
                output.Text = "A theif";
            }
            else if (F.Text == "Noun - Scut")
            {
                output.Text = "a worthless indvidual";
            }
            if (F.Text == "Adjective - Abbhorent")
            {
                output.Text = "Person of disgusting character";
            }
            else if (F.Text == "Adjective - Accursed")
            {
                output.Text = "An outlow or a criminal";
            }
            else if (F.Text == "Adjective - Braid")
            {
                output.Text = "One who is deceitful";
            }
            else if (F.Text == "Adjective - Capricious")
            {
                output.Text = "One who is Lusty";
            }
            else if (F.Text == "Adjective - Cozening")
            {
                output.Text = "Someone who is cheating or cheats";
            }
            else if (F.Text == "Adjective - Cowish")
            {
                output.Text = "One who is cowardly";
            }
            else if (F.Text == "Adjective - Deboshed")
            {
                output.Text = "Being drunk or a heavy drinker";
            }
            else if (F.Text == "Adjective - Enseamed")
            {
                output.Text = "One who is fat or overweight";
            }
            else if (F.Text == "Adjective - Facinorous")
            {
                output.Text = "Being wicked or insane";
            }
            else if (F.Text == "Adjective - Fulsome")
            {
                output.Text = "One who is lustful";
            }
            else if (F.Text == "Adjective - Garish")
            {
                output.Text = "Lacking good taste";
            }
            else if (F.Text == "Adjective - Gorbellied")
            {
                output.Text = "Excessively fat or obese";
            }
            else if (F.Text == "Adjective - Horn-mad")
            {
                output.Text = "Crazy and mentally unstable";
            }
            else if (F.Text == "Adjective - Leasing")
            {
                output.Text = "One who lies a lot";
            }
            else if (F.Text == "Adjective - Lewd")
            {
                output.Text = "Ignorant and rude individual";
            }
            else if (F.Text == "Adjective - Lither")
            {
                output.Text = "One who is lazy";
            }
            else if (F.Text == "Adjective - Loathsome")
            {
                output.Text = "One who can be hated or detested";
            }
            else if (F.Text == "Adjective - Meacock")
            {
                output.Text = "Cowardly character";
            }
            else if (F.Text == "Adjective - Moonish")
            {
                output.Text = "One who is inconstant, changeable, two faced";
            }
            else if (F.Text == "Adjective - Mistempered")
            {
                output.Text = "Very angry individual, possibly bipolar";
            }
            else if (F.Text == "Adjective - Orgulous")
            {
                output.Text = "Proud individual";
            }
            else if (F.Text == "Adjective - Picking")
            {
                output.Text = "Insignificant and unwanted";
            }
            else if (F.Text == "Adjective - Prime")
            {
                output.Text = "Someone who is rank and leacherous";

            }
            else if (F.Text == "Adjective - Rash")
            {
                output.Text = "Both quick and violent";
            }
            else if (F.Text == "Adjective - Rawly")
            {
                output.Text = "Inadequate individual";
            }
            else if (F.Text == "Adjective - Reechy")
            {
                output.Text = "Dirty and smelly";
            }
            else if (F.Text == "Adjective - Ripe")
            {
                output.Text = "Drunk and reeking individual";
            }
            else if (F.Text == "Adjective - Roisting")
            {
                output.Text = "Violent individual";

            }
            else if (F.Text == "Noun - Bully-Rook")
            {
                output.Text = "A bragging cheater";

            }
            else if (F.Text == "Noun - Bona-Roba")
            {
                output.Text = "A harlot";

            }
            else if (F.Text == "Noun - Caitiff")
            {

                output.Text = "A slave or witch";
            }
            else if (F.Text == "Noun - Capocchia")
            {

                output.Text = "A simpleton";
            }
            else if (F.Text == "Noun - Churl")
            {

                output.Text = "Rude and impolite individual";
            }
            else if (F.Text == "Noun - Chuff")
            {
                output.Text = "A blunt clown";

            }
            else if (F.Text == "Noun - Coxcomb")
            {
                output.Text = "A concumbine, a mistress";

            }
            else if (F.Text == "Noun - Drab")
            {
                output.Text = "A harlot";

            }
            else if (F.Text == "Noun - Customer")
            {
                output.Text = "A comman woman";

            }
        }
           





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            // How to go to the help from here
            // hide this form
            //show bothe= dictionary help and dictionary back button ONLY
            //show the help form.
            this.Hide();
            G.A.dichelp.Visible = true;
            G.A.Dictionarybutton.Visible = true;
            G.A.Show();
           
        }

        private void Randombutton_Click(object sender, EventArgs e)
        {
            // hide this and go to random form.
            this.Hide();
            G.B.Show();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            //go to main
            this.Hide();
            G.F.Show();

        }
    }
}
