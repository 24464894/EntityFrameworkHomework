using MainPage.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainPage
{


    public partial class ViewForm : Form
    {
         

        
        public ViewForm()
        {
            InitializeComponent();
            BindData();
        }
        public void BindData()
        {
            /*var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            dataGridView1.DataSource = list;*/
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataAdapter da;
            SqlDataReader dr;


            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alice\Desktop\EntityFrameworkHomework\MainPage\Contact.mdf;Integrated Security=True");
            cn.Open();                                                   
                                                                         
            cmd = new SqlCommand("Select * from ContactsTable", cn);     
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();

        }

    }
}
