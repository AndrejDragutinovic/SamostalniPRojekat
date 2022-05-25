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
    public partial class Zaposleni : Form
    {
        int broj_sloga = 0;
        DataTable tabela;
        public Zaposleni()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Zaposleni", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }


        private void Txt_Load()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_broj.Text = "";
                txt_plata.Text = "";
                btn_delete.Enabled = false;
            }
            else
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_email.Text = tabela.Rows[broj_sloga]["zaposleni_email"].ToString();
                txt_pass.Text = tabela.Rows[broj_sloga]["zaposleni_loz"].ToString();
                txt_broj.Text = tabela.Rows[broj_sloga]["broj_telefona"].ToString();
                txt_plata.Text = tabela.Rows[broj_sloga]["plata"].ToString();
                btn_delete.Enabled = true;
            }

            if (broj_sloga == 0)
            {
                btn_first.Enabled = false;
                btn_delete.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_delete.Enabled = true;
            }

            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void Zaposleni_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

      

        private void btn_first_Click_1(object sender, EventArgs e)
        {
            broj_sloga = 0;
            Txt_Load();
        }

        private void btn_previous_Click_1(object sender, EventArgs e)
        {
            broj_sloga--;
            Txt_Load();
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            broj_sloga++;
            Txt_Load();
        }

        private void btn_last_Click_1(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }
    }
}
