using System.ComponentModel;
using System.Drawing;

namespace Belegleser
{
    class Rechteckeigenschaften
    {
        Size size;
        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("Die Größe des Bereichs")]             // sample hint1
        [Category("Rechteck")]                   // Category that I want
        [DisplayName("Größe")]
        public Size Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        Point location;
        [Browsable(true)]
        [ReadOnly(false)]                          // but just read only
        [Description("Die Koordinaten der linken oberen Ecke")]             // sample hint1
        [Category("Rechteck")]                   // Category that I want
        [DisplayName("Position")]
        public Point Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        Color color;
        [Browsable(true)]
        [ReadOnly(false)]                          // but just read only
        [Description("Die Farbe")]             // sample hint1
        [Category("Rechteck")]                   // Category that I want
        [DisplayName("Farbe")]
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        string name;
        [Browsable(true)]
        [ReadOnly(false)]                          // but just read only
        [Description("Der Name")]             // sample hint1
        [Category("Rechteck")]                   // Category that I want
        [DisplayName("Name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        bool isIdentifiying;
        [Browsable(true)]
        [ReadOnly(false)]                          // but just read only
        [Description("Identifizieren")]             // sample hint1
        [Category("Rechteck")]                   // Category that I want
        [DisplayName("Identifizieren")]
        public bool IsIdentifiying
        {
            get { return this.isIdentifiying; }
            set { this.isIdentifiying = value; }
        }

        string identifiyingWord;
        [Browsable(true)]
        [ReadOnly(false)]                          // but just read only
        [Description("Identifizierungs Wort")]             // sample hint1
        [Category("Rechteck")]                   // Category that I want
        [DisplayName("Identifizieren")]
        public string IdentifiyingWord
        {
            get { return this.identifiyingWord; }
            set { this.identifiyingWord = value; }
        }
    }
}
