using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belegleser
{
    public partial class CellEdit : Form
    {
        private int currentRow = 0;
        private int currentCell = 0;
        private string value = "";
        private MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));
        private FastColoredTextBoxNS.AutocompleteMenu popupMenu;

        public CellEdit(int currentRow, int currentCell, string value)
        {
            InitializeComponent();
            //
            //popupMenu
            //
            popupMenu = new FastColoredTextBoxNS.AutocompleteMenu(this.txt_celledit);
            popupMenu.MinFragmentLength = 2;
            popupMenu.Items.MaximumSize = new System.Drawing.Size(200, 300);
            popupMenu.Items.Width = 200;

            this.currentCell = currentCell;
            this.currentRow = currentRow;
            this.value = value;
            this.txt_celledit.Text = value;
        }

        private void CellEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.value = this.txt_celledit.Text;
        }

        public string Value
        {
            get { return value; }
        }

        public int CurrentRow
        {
            get { return currentRow; }
        }

        public int CurrentCell
        {
            get { return currentCell; }
        }

        private void CellEdit_Load(object sender, EventArgs e)
        {
            txt_celledit.SyntaxHighlighter = new SyntaxHighlighterDotLiquid();
            txt_celledit.Language = (FastColoredTextBoxNS.Language)Language.DotLiquid;
            txt_celledit.ClearStylesBuffer();
            txt_celledit.Range.ClearStyle(StyleIndex.All);
            txt_celledit.AddStyle(SameWordsStyle);
            txt_celledit.OnSyntaxHighlight(new TextChangedEventArgs(txt_celledit.Range));
            //set words as autocomplete source
            popupMenu.Items.SetAutocompleteItems(((SyntaxHighlighterDotLiquid)txt_celledit.SyntaxHighlighter).WordList);
        }

        private void CellEdit_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Process.Start("https://shopify.github.io/liquid/");
        }
    }
}
