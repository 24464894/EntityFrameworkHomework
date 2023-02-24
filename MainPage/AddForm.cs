using MainPage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace MainPage
{
    public partial class AddForm : Form
    {
        public AddForm()
        {

        InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*ContactsTable data = new ContactsTable()
            {
                ProductNumber = textBox1.Text.Trim(),
                ProductName = textBox2.Text.Trim(),
                NumberOfProducts = textBox3.Text.Trim(),
                Price = textBox4.Text.Trim(),
                CommodityCategory = textBox5.Text.Trim(),
            };
            try
            {

                ContactsModel context = new ContactsModel();
                context.ContactsTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }*/
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alice\Desktop\EntityFrameworkHomework\MainPage\Contact.mdf;Integrated Security=True");
            
            string InsterQuey = "Insert into ContactsTable(ProductNumber,ProductName,NumberOfProducts,Price,CommodityCategory)ValueS('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsterQuey, con);
            cmd.ExecuteNonQuery();
        
            MessageBox.Show("存檔完成");
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
