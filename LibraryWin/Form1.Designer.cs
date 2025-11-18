namespace LibraryWin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblQuan = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.radBook = new System.Windows.Forms.RadioButton();
            this.radAud = new System.Windows.Forms.RadioButton();
            this.radDis = new System.Windows.Forms.RadioButton();
            this.radIll = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(283, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(283, 108);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 1;
            this.lblISBN.Text = "ISBN";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(283, 148);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(283, 192);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(283, 235);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(283, 272);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(46, 13);
            this.lblQuan.TabIndex = 5;
            this.lblQuan.Text = "Quantity";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(283, 319);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(37, 13);
            this.lblPages.TabIndex = 6;
            this.lblPages.Text = "Pages";
            // 
            // radBook
            // 
            this.radBook.AutoSize = true;
            this.radBook.Location = new System.Drawing.Point(12, 71);
            this.radBook.Name = "radBook";
            this.radBook.Size = new System.Drawing.Size(50, 17);
            this.radBook.TabIndex = 7;
            this.radBook.TabStop = true;
            this.radBook.Text = "Book";
            this.radBook.UseVisualStyleBackColor = true;
            // 
            // radAud
            // 
            this.radAud.AutoSize = true;
            this.radAud.Location = new System.Drawing.Point(12, 119);
            this.radAud.Name = "radAud";
            this.radAud.Size = new System.Drawing.Size(80, 17);
            this.radAud.TabIndex = 8;
            this.radAud.TabStop = true;
            this.radAud.Text = "Audio Book";
            this.radAud.UseVisualStyleBackColor = true;
            // 
            // radDis
            // 
            this.radDis.AutoSize = true;
            this.radDis.Location = new System.Drawing.Point(12, 171);
            this.radDis.Name = "radDis";
            this.radDis.Size = new System.Drawing.Size(95, 17);
            this.radDis.TabIndex = 9;
            this.radDis.TabStop = true;
            this.radDis.Text = "Discount Book";
            this.radDis.UseVisualStyleBackColor = true;
            // 
            // radIll
            // 
            this.radIll.AutoSize = true;
            this.radIll.Location = new System.Drawing.Point(12, 218);
            this.radIll.Name = "radIll";
            this.radIll.Size = new System.Drawing.Size(98, 17);
            this.radIll.TabIndex = 10;
            this.radIll.TabStop = true;
            this.radIll.Text = "Illustrated Book";
            this.radIll.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(163, 105);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 12;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(163, 145);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(163, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(163, 235);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 15;
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(163, 272);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 20);
            this.txtQuan.TabIndex = 16;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(163, 319);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 20);
            this.txtPages.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radIll);
            this.Controls.Add(this.radDis);
            this.Controls.Add(this.radAud);
            this.Controls.Add(this.radBook);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblQuan);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblQuan;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.RadioButton radBook;
        private System.Windows.Forms.RadioButton radAud;
        private System.Windows.Forms.RadioButton radDis;
        private System.Windows.Forms.RadioButton radIll;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtPages;
    }
}

