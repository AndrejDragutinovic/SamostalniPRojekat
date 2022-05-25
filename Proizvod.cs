using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SamostalniPRojekat
{
    public partial class Proizvod : Form
    {
        SqlDataAdapter Adapter;
        DataTable tabela;

        string ime_tabele;
        public Proizvod(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void Proizvod_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("SELECT * FROM " + ime_tabele, Konekcija.Connect());
            tabela = new DataTable();
            Adapter.Fill(tabela);

            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();

            if (menjano != null)
            {
                Adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
