using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifa_menu
{
    public partial class Form1 : Form
    {

        private Dictionary<string, Image> teamOptions;
        private Dictionary<string, Image> headOptions;
        private Dictionary<string, Image> positionOptions;
        private Dictionary<string, Image> nationalityOptions;
        private Dictionary<string, Image> dripOptions;
        private Dictionary<string, string> selections = new Dictionary<string, string>();
        public Form1()
        {

            InitializeComponent();
            // keyb
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;



            headOptions = new Dictionary<string, Image>(); ;
            headOptions.Add("Black", Properties.Resources.black1);
            headOptions.Add("Lightskin Mode", Properties.Resources.lightskin_mode);
            headOptions.Add("White", Properties.Resources.white1);
          
            dripOptions = new Dictionary<string, Image>();
            dripOptions.Add("Black Nike Fit", Properties.Resources.Untitled_design_removebg_preview);
            dripOptions.Add("Red Adidas Fit", Properties.Resources.Untitled_design__1__removebg_preview);
            dripOptions.Add("Blue New Balance Fit", Properties.Resources.Untitled_design__2__removebg_preview);
            dripOptions.Add("Green Default NPC Fit", Properties.Resources.Untitled_design__3__removebg_preview);
            teamOptions = new Dictionary<string, Image>();
            teamOptions.Add("Chelsea", Properties.Resources.Chelsea_FC_svg);
            teamOptions.Add("Liverpool", Properties.Resources._526_liverpoolfc);
            teamOptions.Add("Real Madrid", Properties.Resources.Real_Madrid_CF_svg__1_);
            teamOptions.Add("Toronto FC", Properties.Resources.Toronto_FC_Logo_svg);
            nationalityOptions = new Dictionary<string, Image>();
            nationalityOptions.Add("Nigeria", Properties.Resources.Flag_Nigeria);
            nationalityOptions.Add("England", Properties.Resources.Flag_England);
            nationalityOptions.Add("China", Properties.Resources.Flag_China);

            positionOptions = new Dictionary<string, Image>();
            positionOptions.Add("CM", Properties.Resources.cm);
            positionOptions.Add("GK", Properties.Resources.gk);
            positionOptions.Add("ST", Properties.Resources.st);



        }

        private void DisplayImages(Dictionary<string, Image> images, params PictureBox[] pictureBoxes)
        {
            for(int i = 0; i < pictureBoxes.Length; i++)
            {
                if (i >= images.Count)
                {
                    pictureBoxes[i].Image = null;
                    break;
                }

                var menuItemName = images.ElementAt(i).Key;
                if (images.ContainsKey(menuItemName))
                {
                    pictureBoxes[i].Image = images[menuItemName];
                }
            }
        }
        
     



        private string currentTeam = "Chelsea";
        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var menuItem = (ToolStripMenuItem)sender;
            var selectedTeam = menuItem.Text;

            // change the current team selection
            currentTeam = selectedTeam;

            // display the selected team image
            if (teamOptions.ContainsKey(currentTeam))
            {
                team1.Image = teamOptions[currentTeam];
            }
            DisplayImages(teamOptions, preview1, preview2, preview3, previewx);
        }

            

        private string nat = "Nigeria";
        private void nationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var menuItem = (ToolStripMenuItem)sender;
            var selectedNationality = menuItem.Text;

           // change
            nat = selectedNationality;
            // contain
            if (nationalityOptions.ContainsKey(nat))
            {
                pictureBox7.Image = nationalityOptions[nat];
            }
            DisplayImages(nationalityOptions, preview1, preview2, preview3, previewx);

        }

        private string drips = "Black Nike Fit";
        private void facialHairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var menuItem = (ToolStripMenuItem)sender;
            var selectedDrip = menuItem.Text;

            // change
            drips = selectedDrip;
            // contain
            if (dripOptions.ContainsKey(drips))
            {
                drip.Image = dripOptions[drips];
            }
            DisplayImages(dripOptions, preview1, preview2, preview3, previewx);

        }

        private string face = "Black";
        private void faceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var selectedHead = menuItem.Text;

            // change
            face = selectedHead;
            // contain
            if (headOptions.ContainsKey(face))
            {
                face1.Image = headOptions[face];
            }
            DisplayImages(headOptions, preview1, preview2, preview3, previewx);
        }
        private string position = "CM";
        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var selectedpos = menuItem.Text;

            // change
            position = selectedpos;
            // contain
            if (positionOptions.ContainsKey(position))
            {
                pos.Image = positionOptions[position];
            }
            DisplayImages(positionOptions, preview1, preview2, preview3, previewx);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save current selections to the selections dictionary
            selections["team"] = currentTeam;
            selections["nationality"] = nat;
            selections["drip"] = drips;
            selections["face"] = face;
            selections["position"] = position;

            // Clear 
            currentTeam = "Chelsea";
            nat = "Nigeria";
            drips = "Black Nike Fit";
            face = "Black";
            position = "CM";

            // Reset 
            team1.Image = teamOptions[currentTeam];
            pictureBox7.Image = nationalityOptions[nat];
            drip.Image = dripOptions[drips];
            face1.Image = headOptions[face];
            pos.Image = positionOptions[position];
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save current selections to the selections dictionary
            selections["team"] = currentTeam;
            selections["nationality"] = nat;
            selections["drip"] = drips;
            selections["face"] = face;
            selections["position"] = position;

  

            // Close the program
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
