using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        private EventArgs e;
        public Form1()
        {
            InitializeComponent();
        }

        private void newPremButton_Click(object sender, EventArgs e)
        {
            PremisesDropDown.Visible = true;
        }

        private void PremisesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = (string)this.PremisesDropDown.SelectedItem;
            MakingOptionsVisible(item);

        }

        public object MakingOptionsVisible(string optionElected)
        {
            NameTB.Visible = true;
            nameLabel.Visible = true;
            string name = NameTB.Text;

            OwnerTB.Visible = true;
            ownerLabel.Visible = true;
            string owner = OwnerTB.Text;

            IDTB.Visible = true;
            idLabel.Visible = true;
            string id = IDTB.Text;

            OpeningHourTB.Visible = true;
            openingHLabel.Visible = true;
            string opening_hour = OpeningHourTB.Text;

            ClosingHourTB.Visible = true;
            closingHLabel.Visible = true;
            string closing_hour = ClosingHourTB.Text;

            if (optionElected == "Cinema")
            {
                variableLabel.Text = "Number of rooms";
                variableLabel.Visible = true;
                object sender = "a";
                object n1 = Form1_Load_Cinema(sender, e);
                
                Cinema newCinema = new Cinema
                    (name, owner, id, opening_hour, closing_hour);
                n1 = newCinema.NumberOfRooms;
                return newCinema;
            }
            
            else if (optionElected == "Restaurant")
            {
                variableLabel.Text = "Does it have exclusive tables?";
                variableLabel.Visible = true;
                bool n2 = (bool)Form1_Load("Restaurant", e);

                Restaurant newRest = new Restaurant
                    (name, owner, id, opening_hour, closing_hour);
                newRest.HasExclusiveTables = n2;
                return newRest;
            }
            
            else if (optionElected == "Store")
            {
                variableLabel.Text = "Category";
                variableLabel.Visible = true;
                string n3 = (string)Form1_Load("Store", e);

                Store newStore = new Store
                    (name, owner, id, opening_hour, closing_hour);
                newStore.Category = n3;
                return newStore;
            }

            else
            {
                Recreational newRec = new Recreational
                    (name, owner, id, opening_hour, closing_hour);
                return newRec;
            }
        }

        private object Form1_Load(object sender, EventArgs e)
        {
            if ((string)sender == "Store")
            {
                ComboBox storeOptions = new ComboBox();
                storeOptions.Location = new Point(280, 548);
                storeOptions.Items.Add("Clothing");
                storeOptions.Items.Add("Electronics");
                storeOptions.Items.Add("Music");
                storeOptions.Items.Add("Toy");

                this.Controls.Add(storeOptions);

                string storeKind = (string)storeOptions.SelectedItem;

                return storeKind;

            }

            else if ((string)sender == "Cinema")
            {
                TextBox numberOfRooms = new TextBox();
                numberOfRooms.Visible = true;
                numberOfRooms.Location = new Point(280, 548);

                this.Controls.Add(numberOfRooms);

                string n = numberOfRooms.Text;
                return n;
            }

            else if ((string)sender == "Restaurant")
            {
                RadioButton yesButton = new RadioButton();
                yesButton.Location = new Point(280, 548);

                RadioButton noButton = new RadioButton();
                noButton.Location = new Point(414, 548);
                
                this.Controls.Add(yesButton);
                this.Controls.Add(noButton);

                if (yesButton.Checked == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return 0;
            }
        }

        private string Form1_Load_Cinema(object sender, EventArgs e)
        {
            TextBox numberOfRooms = new TextBox();
            numberOfRooms.Visible = true;
            numberOfRooms.Location = new Point(280, 548);

            this.Controls.Add(numberOfRooms);

            string n = numberOfRooms.Text;
            return n;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Premise p = new Premise
                (NameTB.Text, OwnerTB.Text, IDTB.Text, 
                OpeningHourTB.Text, ClosingHourTB.Text);
            Console.WriteLine(p);
        }
    }
}
