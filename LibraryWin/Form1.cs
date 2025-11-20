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

namespace LibraryWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radAud_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblLength.Visible = true;
            txtLength.Visible = true;
            lblNar.Visible = true;
            txtNar.Visible = true;
        }

        private void radBook_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblPages.Visible = true;
            txtPages.Visible = true;
        }

        private void HideAll()
        {
            lblLength.Visible = false;
            txtLength.Visible = false;
            lblNar.Visible = false;
            txtNar.Visible = false;
            lblPages.Visible = false;
            txtPages.Visible = false;
            lblDis.Visible = false;
            txtDis.Visible = false;
            lblIll.Visible = false;
            txtIll.Visible = false;
            lblIllPgs.Visible = false;
            txtIllPgs.Visible = false;
        }

        private void radDis_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblDis.Visible = true;
            txtDis.Visible = true;
        }

        private void radIll_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblIll.Visible = true;
            txtIll.Visible = true;
            lblIllPgs.Visible = true;
            txtIllPgs.Visible = true;
            lblPages.Visible = true;
            txtPages.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connectionString;

            //where, database, who, password, cetificate
            connectionString = @"Data Source=BB21312\FA25_OOP_SQL_AND; Initial Catalog=myfirstdb; User ID=LibraryUser; Password=1; TrustServerCertificate=True;";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            string bookTitle = txtName.Text;
            string bookAuthor = txtAuthor.Text;
            string bookPrice = txtPrice.Text;
            string bookGenre = txtGenre.Text;
            string bookQuantity = txtQuantity.Text;

            if (radBook.Checked)
            {
                //normal book
                MessageBox.Show("Normal Book Created!");
            }
            else if (radAud.Checked)
            {
                //audiobook
                MessageBox.Show("Audiobook Created!");
            }
            else if (radDis.Checked)
            {
                //discount book
                MessageBox.Show("Discount Book Created!");
            }
            else if (radIll.Checked)
            {
                //illustrated book
                MessageBox.Show("Illustrated Book Created!");
            }
            

            string sqlStatement = "INSERT INTO dbo.books (BookTitle, BookAuthor) VALUES (@bookTitle, @bookAuthor)";

            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
            myQuery.Parameters.AddWithValue("@bookTitle", bookTitle);
            myQuery.Parameters.AddWithValue("@bookAuthor", bookAuthor);
            myQuery.ExecuteNonQuery();

            currConnection.Close();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            listGet.Items.Clear();

            string connectionString;

            //where, database, who, password, cetificate
            connectionString = @"Data Source=BB21312\FA25_OOP_SQL_AND; Initial Catalog=myfirstdb; User ID=LibraryUser; Password=1; TrustServerCertificate=True;";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            string sqlStatement = "SELECT * FROM dbo.books";
            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            SqlDataReader myReader = myQuery.ExecuteReader();

            while (myReader.Read())
            {
                listGet.Items.Add("Book Title: " + myReader["BookTitle"] + ", ");
                listGet.Items.Add("Book Author: " + myReader["BookAuthor"] + ", ");
                listGet.Items.Add("Book ISBN: " + myReader["BookISBN"] + ", ");
                listGet.Items.Add("---------------------------------------");
            }

            currConnection.Close();
        }
    }
}
