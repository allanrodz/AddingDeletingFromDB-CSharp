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

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cycmb.DataSource = Enum.GetValues(typeof(Counties));
        }

        //Step 1: Connect the DB
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\Allan\projects\c#\form1\form1\MyNewDB.mdf;Integrated Security=True");

      
        // Step 8: Show DB in a DGV
        SqlDataAdapter da;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            string fn = fntb.Text;
            string sn = sntb.Text;
            string dob = dobdtp.Text;
            string cy = cycmb.SelectedItem.ToString();

            //Step 2: create an insert statement
            string insert = "INSERT INTO Friend (FirstName, Surname, DOB, County) VALUES (@fn, @sn, @dob, @cy)";

            //Step 3: Create a command
            SqlCommand cmd = new SqlCommand(insert, con);

            //Step 4: Populate SQL variables
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@sn", sn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@cy", cy);


            //Step 5: Open Connection
            con.Open();

            //Step 6: execute the command
            cmd.ExecuteNonQuery();

            //Step 7: Close the connection
            con.Close();


            fntb.Clear();
            sntb.Clear();

        }

        private void Showbtn_Click(object sender, EventArgs e)
        {

            da = new SqlDataAdapter();
            dt = new DataTable();

            con.Open();

            string select = "SELECT * FROM Friend";

            SqlCommand cmd = new SqlCommand(select, con);

            da.SelectCommand = cmd;
            da.Fill(dt);

            dgv.DataSource = dt;

            con.Close();

        }

        private void Delbtn_Click(object sender, EventArgs e)
        {

            
            int num = int.Parse(txtnum.Text);

            string del = "DELETE FROM Friend WHERE FriendID = @num";

            SqlCommand cmd = new SqlCommand(del, con);

            cmd.Parameters.AddWithValue("@num", num);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            txtnum.Clear();

            MessageBox.Show("Record Deleted from DB", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
