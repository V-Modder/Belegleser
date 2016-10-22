using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belegleser
{
    public partial class CellEdit : Form
    {
        int currentRow = 0;
        int currentCell = 0;
        string value = "";

        public CellEdit(int currentRow, int currentCell, string value)
        {
            InitializeComponent();

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
    }
}
