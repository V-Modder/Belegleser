using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Belegleser
{
    public partial class HabelFields : Form
    {
        DataGridView dtg = null;
        public HabelFields(DataGridView dtg)
        {
            this.dtg = dtg;
            InitializeComponent();
        }

        private string myConnectionString = "SERVER="+Config.getInstance().MySQLHost + ";" +
                                            "DATABASE=" + Config.getInstance().MySQLDatabase + ";" +
                                            "UID="+ Config.getInstance().MySQLUser +";" +
                                            "PASSWORD="+ Config.getInstance().MySQLPassword + ";";


        private void HabelFields_Load(object sender, EventArgs e)
        {
            this.dtg_habel_fields.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dtg_habel_fields.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='hdone030'";
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                dtg_habel_fields.Rows.Add(Reader["COLUMN_NAME"].ToString());
            }
            connection.Close();        }

        private void dtg_habel_fields_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg.Rows.Add(dtg_habel_fields.CurrentCell.Value.ToString());
        }
    }
}
