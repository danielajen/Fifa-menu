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
        private Dictionary<string, PictureBox> previewBoxes = new Dictionary<string, PictureBox>();

        private Dictionary<string, Image> teamOptions;
        private Dictionary<string, Image> headOptions;
        private Dictionary<string, Image> positionOptions;
        private Dictionary<string, Image> nationalityOptions;
        private Dictionary<string, Image> dripOptions;
        private Dictionary<string, string> selections = new Dictionary<string, string>();
        public Form1()
        {

            InitializeComponent();
            previewBoxes.Add("Team", pictureBox3);
            previewBoxes.Add("Nationality", pictureBox5);
            previewBoxes.Add("Drip", pictureBox6);

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
        private void ShowPreviewImages(Dictionary<string, Image> previewImages)
        {
            // iterate through the dictionary and set the corresponding PictureBox controls to display the images
            foreach (var previewImage in previewImages)
            {
                if (previewImage.Value != null && previewBoxes.ContainsKey(previewImage.Key))
                {
                    if (previewBoxes[previewImage.Key] == pictureBox3 ||
                    previewBoxes[previewImage.Key] == pictureBox5 ||
                    previewBoxes[previewImage.Key] == pictureBox6)
                    {
                        previewBoxes[previewImage.Key].Image = previewImage.Value;
                        previewBoxes[previewImage.Key].Visible = true;
                    }
                }
            }
        }

        private void HideAllPreviewImages()
        {
            // iterate through all preview PictureBox controls and hide them
            foreach (var previewBox in previewBoxes)
            {
                previewBox.Value.Visible = false;
            }
        }

        private string currentTeam = "Chelsea";
        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPreviewImages();

            var menuItem = (ToolStripMenuItem)sender;
            var selectedTeam = menuItem.Text;

            // change the current team selection
            currentTeam = selectedTeam;

            // display the selected team image
            if (teamOptions.ContainsKey(currentTeam))
            {
                team1.Image = teamOptions[currentTeam];
            }

            // show all preview images for the current menu item
            if (currentTeam == "Chelsea")
            {
                ShowPreviewImages(headOptions);
            }
            else if (currentTeam == "Liverpool")
            {
                ShowPreviewImages(nationalityOptions);
            }
            else if (currentTeam == "Real Madrid")
            {
                ShowPreviewImages(dripOptions);
            }
            else if (currentTeam == "Toronto FC")
            {
                ShowPreviewImages(positionOptions);
            }
        }

        private string nat = "Nigeria";
        private void nationalityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPreviewImages();
            var menuItem = (ToolStripMenuItem)sender;
            var selectedNationality = menuItem.Text;

           // change
            nat = selectedNationality;
            // contain
            if (nationalityOptions.ContainsKey(nat))
            {
                pictureBox7.Image = nationalityOptions[nat];
            }
            ShowPreviewImages(nationalityOptions);
        }

        private string drips = "Black Nike Fit";
        private void facialHairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllPreviewImages();
            var menuItem = (ToolStripMenuItem)sender;
            var selectedDrip = menuItem.Text;

            // change
            drips = selectedDrip;
            // contain
            if (dripOptions.ContainsKey(drips))
            {
                drip.Image = dripOptions[drips];
            }
            ShowPreviewImages(dripOptions);
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
        }
    }
}
