using Library;
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
            connectionString = @"Data Source=DESKTOP-8425NTP; Initial Catalog=Library; User ID=LibraryUser; Password=1; TrustServerCertificate=True;";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            string title = txtName.Text;
            string author = txtAuthor.Text;
            string price = txtPrice.Text;
            string genre = txtGenre.Text;
            string quantity = txtQuantity.Text;

            if (radBook.Checked)
            {
                string pages = txtPages.Text;

                string sqlStatement = "INSERT INTO dbo.Book (title, author, price, genre, quantity, pages) VALUES (@title, @author, @price, @genre, @quantity, @pages)";
                SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
                myQuery.Parameters.AddWithValue("@title", title);
                myQuery.Parameters.AddWithValue("@author", author);
                myQuery.Parameters.AddWithValue("@price", price);
                myQuery.Parameters.AddWithValue("@genre", genre);
                myQuery.Parameters.AddWithValue("@quantity", quantity);
                myQuery.Parameters.AddWithValue("@pages", pages);
                myQuery.ExecuteNonQuery();
            }
            else if (radAud.Checked)
            {
                string narrator = txtNar.Text;
                string length = txtLength.Text;

                string sqlStatement = "INSERT INTO dbo.Audio_Book (title, author, price, genre, quantity, narrator, length) VALUES (@title, @author, @price, @genre, @quantity, @narrator, @length)";
                SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
                myQuery.Parameters.AddWithValue("@title", title);
                myQuery.Parameters.AddWithValue("@author", author);
                myQuery.Parameters.AddWithValue("@price", price);
                myQuery.Parameters.AddWithValue("@genre", genre);
                myQuery.Parameters.AddWithValue("@quantity", quantity);
                myQuery.Parameters.AddWithValue("@narrator", narrator);
                myQuery.Parameters.AddWithValue("@length", length);

                myQuery.ExecuteNonQuery();
            }
            else if (radDis.Checked)
            {
                string discount = txtDis.Text;

                string sqlStatement = "INSERT INTO dbo.Discount_Book (title, author, price, genre, quantity, discount) VALUES (@title, @author, @price, @genre, @quantity, @discount)";
                SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
                myQuery.Parameters.AddWithValue("@title", title);
                myQuery.Parameters.AddWithValue("@author", author);
                myQuery.Parameters.AddWithValue("@price", price);
                myQuery.Parameters.AddWithValue("@genre", genre);
                myQuery.Parameters.AddWithValue("@quantity", quantity);
                myQuery.Parameters.AddWithValue("@discount", discount);

                myQuery.ExecuteNonQuery();
            }
            else if (radIll.Checked)
            {
                string illustrator = txtIll.Text;
                string illustratedPages = txtIllPgs.Text;
                //illustrated book
                MessageBox.Show("Illustrated Book Created!");

                string sqlStatement = "INSERT INTO dbo.Illustrated_Book (title, author, price, genre, quantity, illustrator, illustratedPages) VALUES (@title, @author, @price, @genre, @quantity, @illustrator, @illustratedPages)";
                SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
                myQuery.Parameters.AddWithValue("@title", title);
                myQuery.Parameters.AddWithValue("@author", author);
                myQuery.Parameters.AddWithValue("@price", price);
                myQuery.Parameters.AddWithValue("@genre", genre);
                myQuery.Parameters.AddWithValue("@quantity", quantity);
                myQuery.Parameters.AddWithValue("@illustrator", illustrator);
                myQuery.Parameters.AddWithValue("@illustratedPages", illustratedPages);

                myQuery.ExecuteNonQuery();
            }
            

            //string sqlStatement = "INSERT INTO dbo.books (BookTitle, BookAuthor) VALUES (@bookTitle, @bookAuthor)";

            //SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
            //myQuery.Parameters.AddWithValue("@bookTitle", bookTitle);
            //myQuery.Parameters.AddWithValue("@bookAuthor", bookAuthor);
            //myQuery.ExecuteNonQuery();

            currConnection.Close();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            list.Items.Clear();

            string connectionString;

            //where, database, who, password, cetificate
            connectionString = @"Data Source=DESKTOP-8425NTP; Initial Catalog=Library; User ID=LibraryUser; Password=1; TrustServerCertificate=True;";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            string sqlStatement = "SELECT * FROM dbo.Book";
            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);

            SqlDataReader myReader = myQuery.ExecuteReader();

            if(myReader.HasRows != false)
            {
                list.Items.Add("--BOOKS--\n");

                while (myReader.Read())
                {
                    list.Items.Add("Book Title: " + myReader["title"] + ", ");
                    list.Items.Add("Book Author: " + myReader["author"] + ", ");
                    list.Items.Add("Book Price: " + myReader["price"] + ", ");
                    list.Items.Add("Book Genre: " + myReader["genre"] + ", ");
                    list.Items.Add("Book Quantity: " + myReader["quantity"] + ", ");
                    list.Items.Add("Book Pages: " + myReader["pages"] + ", ");
                    list.Items.Add("Book ISBN: " + myReader["ISBN"] + ", ");
                    list.Items.Add("---------------------------------------");
                }
            }

            sqlStatement = "SELECT * FROM dbo.Audio_Book";
            myQuery = new SqlCommand(sqlStatement, currConnection);

            currConnection.Close();

            currConnection.Open();
            myReader = myQuery.ExecuteReader();

            if(myReader.HasRows != false)
            {
                list.Items.Add("--AUDIOBOOKS--\n");
                while (myReader.Read())
                {
                    list.Items.Add("Book Title: " + myReader["title"] + ", ");
                    list.Items.Add("Book Author: " + myReader["author"] + ", ");
                    list.Items.Add("Book Price: " + myReader["price"] + ", ");
                    list.Items.Add("Book Genre: " + myReader["genre"] + ", ");
                    list.Items.Add("Book Quantity: " + myReader["quantity"] + ", ");
                    list.Items.Add("Book Narrator: " + myReader["narrator"] + ", ");
                    list.Items.Add("Book Length: " + myReader["length"] + ", ");
                    list.Items.Add("Book ISBN: " + myReader["BookISBN"] + ", ");
                    list.Items.Add("---------------------------------------");
                }
            }

            sqlStatement = "SELECT * FROM dbo.Discount_Book";

            currConnection.Close();

            currConnection.Open();
            myReader = new SqlCommand(sqlStatement, currConnection).ExecuteReader();

            if(myReader.HasRows != false)
            {
                list.Items.Add("--DISCOUNT BOOKS--\n");
                while (myReader.Read())
                {
                    list.Items.Add("Book Title: " + myReader["title"] + ", ");
                    list.Items.Add("Book Author: " + myReader["author"] + ", ");
                    list.Items.Add("Book Price: " + myReader["price"] + ", ");
                    list.Items.Add("Book Genre: " + myReader["genre"] + ", ");
                    list.Items.Add("Book Quantity: " + myReader["quantity"] + ", ");
                    list.Items.Add("Book Discount: " + myReader["discount"] + ", ");
                    list.Items.Add("Book ISBN: " + myReader["ISBN"] + ", ");
                    list.Items.Add("---------------------------------------");
                }
            }

            sqlStatement = "SELECT * FROM dbo.Illustrated_Book";

            currConnection.Close();

            currConnection.Open();
            myReader = new SqlCommand(sqlStatement, currConnection).ExecuteReader();

            if(myReader.HasRows != false)
            {
                list.Items.Add("--ILLUSTRATED BOOKS--\n");
                while (myReader.Read())
                {
                    list.Items.Add("Book Title: " + myReader["title"] + ", ");
                    list.Items.Add("Book Author: " + myReader["author"] + ", ");
                    list.Items.Add("Book Price: " + myReader["price"] + ", ");
                    list.Items.Add("Book Genre: " + myReader["genre"] + ", ");
                    list.Items.Add("Book Quantity: " + myReader["quantity"] + ", ");
                    list.Items.Add("Book Illustrator: " + myReader["illustrator"] + ", ");
                    list.Items.Add("Book Illustrated Pages: " + myReader["illustratedPages"] + ", ");
                    list.Items.Add("Book ISBN: " + myReader["ISBN"] + ", ");
                    list.Items.Add("---------------------------------------");
                }
            }

            currConnection.Close();



        }
    }
}
