using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
    public partial class ModifyForm : Form
    {
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alice\Desktop\EntityFrameworkHomework\MainPage\Contact.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ContactsTable set   ProductName = @ProductName , NumberOfProducts = @NumberOfProducts , Price = @Price , CommodityCategory = @CommodityCategory where ProductNumber = @ProductNumber",con);

            cmd.Parameters.AddWithValue("@ProductNumber", textBox2.Text);
            cmd.Parameters.AddWithValue("@ProductName", textBox3.Text);
            cmd.Parameters.AddWithValue("@NumberOfProducts", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", textBox5.Text);
            cmd.Parameters.AddWithValue("@CommodityCategory", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }
    }
}
