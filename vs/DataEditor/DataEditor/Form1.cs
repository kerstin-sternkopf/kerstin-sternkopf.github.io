using DataEditor.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEditor
{
    public partial class Form1 : Form
    {
        private List<Offer> offers;
        public Form1()
        {
            InitializeComponent();

            this.offers = Core.Offers.ParseByXDocument();

            this.RenderItems();
        }

        private Offer currentOffer;

        private void RenderItems()
        {
            this.offersBox.Items.Clear();

            foreach (var item in this.offers)
            {
                this.offersBox.Items.Add(item);
            }

            if (this.offers.Count > 0)
            {
                this.offersBox.SelectedItem = this.offers[0];
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var offer = this.offersBox.SelectedItem as Offer;

            if(this.currentOffer != null)
            {
                this.nameTxt.DataBindings.Clear();
                this.priceTxt.DataBindings.Clear();
                this.savingTxt.DataBindings.Clear();
                this.volumeTxt.DataBindings.Clear();
                this.startsDate.DataBindings.Clear();
                this.endsDate.DataBindings.Clear();
                this.dimensionsTxt.DataBindings.Clear();
                this.partsTxt.DataBindings.Clear();
                this.extrasTxt.DataBindings.Clear();
                this.pictureBox.Image = null;
            }

            this.currentOffer = offer;

            if (offer != null)
            {
                this.nameTxt.DataBindings.Add("Text", offer, "Name");
                this.priceTxt.DataBindings.Add("Text", offer, "Price");
                this.savingTxt.DataBindings.Add("Text", offer, "Saving");
                this.volumeTxt.DataBindings.Add("Text", offer, "Volume");
                this.startsDate.DataBindings.Add("Value", offer, "Starts");
                this.endsDate.DataBindings.Add("Value", offer, "Ends");
                this.dimensionsTxt.DataBindings.Add("Text", offer, "Dimensions");
                this.partsTxt.DataBindings.Add("Text", offer, "Parts");
                this.extrasTxt.DataBindings.Add("Text", offer, "Extras");
                this.pictureBox.Image = offer.Img;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (Offers.AreValid(this.offers))
            {
                Offers.Serialize(this.offers);
                Offers.GenerateFile();
                MessageBox.Show("Speichern war erfolgreich!", "Erfolgreich!");
            }
            else
            {
                MessageBox.Show("Es sind noch leere Eingaben vorhanden!", "Fehler");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var offer = new Offer();
            this.offers.Add(offer);
            this.RenderItems();
            this.offersBox.SelectedItem = offer;
        }

        private void copyFromClipboardBtn_Click(object sender, EventArgs e)
        {
            if (this.currentOffer != null)
            {
                var img = Clipboard.GetImage();

                if (img != null)
                {
                    this.currentOffer.Img = img;
                    this.pictureBox.Image = this.currentOffer.Img;
                }
                else
                {
                    MessageBox.Show("Es wurde kein Bild in der Zwischenablage gefunden!");
                }
            }
        }

        private void removeImageBtn_Click(object sender, EventArgs e)
        {
            if (this.currentOffer != null && MessageBox.Show("Bild wirklich entfernen?", "Sicher?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.currentOffer.Img = null;
                this.pictureBox.Image = null;
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (this.currentOffer != null && MessageBox.Show("Angebot wirklich entfernen?", "Sicher?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.offers.Remove(this.currentOffer);
                this.RenderItems();
            }
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            if (Offers.AreValid(this.offers))
            {
                Offers.Serialize(this.offers);
                Offers.GenerateFile();
                Offers.ExecuteGit();
                MessageBox.Show("Veröffentlichen war erfolgreich!", "Erfolgreich!");
            }
        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// & im Name führt zu fehlerhaften WhatsApp Messages
            if (e.KeyChar.ToString() == "&")
            {
                e.Handled = true;
            }
        }
    }
}
