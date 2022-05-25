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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (txt_name.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("Unesite E-mail i Password!");
                    return;
                }
                else
                {
                    try
                    {
                        SqlConnection veza = Konekcija.Connect();
                        SqlCommand komanda = new SqlCommand("SELECT * FROM Zaposleni WHERE zaposleni_email = @username", veza);
                        komanda.Parameters.AddWithValue("@username", txt_name.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);

                        int brojac = tabela.Rows.Count;
                        if (brojac == 1)
                        {
                            if (String.Compare(tabela.Rows[0]["zaposleni_loz"].ToString(), txt_pass.Text) == 0)
                            {
                                MessageBox.Show("Login Successful!");


                                this.Hide();
                                Form1 Glavna = new Form1();
                                Glavna.Show();
                            }
                            else
                            {
                                MessageBox.Show("Neispravna Lozinka!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nepostojeci E-mail!");
                        }
                    }
                    catch (Exception Greska)
                    {
                        MessageBox.Show(Greska.Message);
                    }
                }
            }
        }
    }
}
