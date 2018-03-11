using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor.Core
{
    public class Offer
    {
        public Offer()
        {
            this.Name = "Neues Angebot";
            this.Starts = DateTime.Now;
            this.Ends = DateTime.Now;
        }

        public Image Img { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Saving { get; set; }
        public string Volume { get; set; }
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public string Dimensions { get; set; }
        public string Parts { get; set; }
        public string Extras { get; set; }
        public bool IsValid { get {
                return !string.IsNullOrWhiteSpace(this.Name) &&
                    !string.IsNullOrWhiteSpace(this.Price);
                    //this.Img != null;
            } }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
