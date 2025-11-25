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
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtNar = new System.Windows.Forms.TextBox();
            this.lblNar = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.lblDis = new System.Windows.Forms.Label();
            this.txtIllPgs = new System.Windows.Forms.TextBox();
            this.lblIllPgs = new System.Windows.Forms.Label();
            this.txtIll = new System.Windows.Forms.TextBox();
            this.lblIll = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.btnDis = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(269, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(269, 74);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(266, 114);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(269, 161);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.Location = new System.Drawing.Point(269, 198);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(46, 13);
            this.lblQuan.TabIndex = 5;
            this.lblQuan.Text = "Quantity";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(269, 245);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(37, 13);
            this.lblPages.TabIndex = 6;
            this.lblPages.Text = "Pages";
            this.lblPages.Visible = false;
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
            this.radBook.CheckedChanged += new System.EventHandler(this.radBook_CheckedChanged);
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
            this.radAud.CheckedChanged += new System.EventHandler(this.radAud_CheckedChanged);
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
            this.radDis.CheckedChanged += new System.EventHandler(this.radDis_CheckedChanged);
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
            this.radIll.CheckedChanged += new System.EventHandler(this.radIll_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(149, 71);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(146, 114);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(149, 161);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 15;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(149, 198);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 16;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(149, 245);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 20);
            this.txtPages.TabIndex = 17;
            this.txtPages.Visible = false;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(149, 286);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 19;
            this.txtLength.Visible = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(269, 286);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 18;
            this.lblLength.Text = "Length";
            this.lblLength.Visible = false;
            // 
            // txtNar
            // 
            this.txtNar.Location = new System.Drawing.Point(149, 245);
            this.txtNar.Name = "txtNar";
            this.txtNar.Size = new System.Drawing.Size(100, 20);
            this.txtNar.TabIndex = 21;
            this.txtNar.Visible = false;
            // 
            // lblNar
            // 
            this.lblNar.AutoSize = true;
            this.lblNar.Location = new System.Drawing.Point(269, 245);
            this.lblNar.Name = "lblNar";
            this.lblNar.Size = new System.Drawing.Size(45, 13);
            this.lblNar.TabIndex = 20;
            this.lblNar.Text = "Narrator";
            this.lblNar.Visible = false;
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(149, 245);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(100, 20);
            this.txtDis.TabIndex = 23;
            this.txtDis.Visible = false;
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(269, 245);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(49, 13);
            this.lblDis.TabIndex = 22;
            this.lblDis.Text = "Discount";
            this.lblDis.Visible = false;
            // 
            // txtIllPgs
            // 
            this.txtIllPgs.Location = new System.Drawing.Point(149, 334);
            this.txtIllPgs.Name = "txtIllPgs";
            this.txtIllPgs.Size = new System.Drawing.Size(100, 20);
            this.txtIllPgs.TabIndex = 27;
            this.txtIllPgs.Visible = false;
            // 
            // lblIllPgs
            // 
            this.lblIllPgs.AutoSize = true;
            this.lblIllPgs.Location = new System.Drawing.Point(269, 337);
            this.lblIllPgs.Name = "lblIllPgs";
            this.lblIllPgs.Size = new System.Drawing.Size(85, 13);
            this.lblIllPgs.TabIndex = 26;
            this.lblIllPgs.Text = "Illustrated Pages";
            this.lblIllPgs.Visible = false;
            // 
            // txtIll
            // 
            this.txtIll.Location = new System.Drawing.Point(149, 286);
            this.txtIll.Name = "txtIll";
            this.txtIll.Size = new System.Drawing.Size(100, 20);
            this.txtIll.TabIndex = 25;
            this.txtIll.Visible = false;
            // 
            // lblIll
            // 
            this.lblIll.AutoSize = true;
            this.lblIll.Location = new System.Drawing.Point(266, 286);
            this.lblIll.Name = "lblIll";
            this.lblIll.Size = new System.Drawing.Size(49, 13);
            this.lblIll.TabIndex = 24;
            this.lblIll.Text = "Illustrator";
            this.lblIll.Visible = false;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(450, 29);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(233, 160);
            this.list.TabIndex = 28;
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(536, 212);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(75, 23);
            this.btnDis.TabIndex = 29;
            this.btnDis.Text = "Display";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 267);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtIllPgs);
            this.Controls.Add(this.lblIllPgs);
            this.Controls.Add(this.txtIll);
            this.Controls.Add(this.lblIll);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.txtNar);
            this.Controls.Add(this.lblNar);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
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
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
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
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtNar;
        private System.Windows.Forms.Label lblNar;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.TextBox txtIllPgs;
        private System.Windows.Forms.Label lblIllPgs;
        private System.Windows.Forms.TextBox txtIll;
        private System.Windows.Forms.Label lblIll;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Button btnCreate;
    }
}

