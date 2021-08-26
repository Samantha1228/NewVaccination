using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace NewVaccination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("DData Source=LAPTOP-D8M6FQVA;Initial Catalog=VaccineRegister;");
            SqlCommand cmd = new SqlCommand("insert into VacRegister(ID, Surname, Name, Gender, Province) values(@ID, @Surname, @Name, @Gender, @Province)", cnn);
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Parameters.AddWithValue("@Surname", textBoxSurname.Text);
            cmd.Parameters.AddWithValue("@Name", textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@Gender", cbGender.Text);
            cmd.Parameters.AddWithValue("@Province", comboBoxProvince.Text);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
