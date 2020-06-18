using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DATA_GRID_VIEW
{
    public partial class Form1 : Form
    {

        public string CmdText = "SELECT * FROM [Tablica]";
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\123\\Desktop\\BAZA.mdb";
        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Tablica]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
