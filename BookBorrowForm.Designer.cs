namespace LibraryManagementApp
{
    partial class BookBorrowForm
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
            dgvBooks = new DataGridView();
            btnBorrow = new Button();
            btnReturn = new Button();
            btnClose = new Button();
            dgvBorrowRecords = new DataGridView();
            lblBookStock = new Label();
            lblBorrowedBooks = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(41, 39);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(574, 161);
            dgvBooks.TabIndex = 0;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(692, 39);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(75, 23);
            btnBorrow.TabIndex = 1;
            btnBorrow.Text = "借閱選擇書籍";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(692, 249);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "還書";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(692, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvBorrowRecords
            // 
            dgvBorrowRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRecords.Location = new Point(41, 249);
            dgvBorrowRecords.Name = "dgvBorrowRecords";
            dgvBorrowRecords.Size = new Size(574, 170);
            dgvBorrowRecords.TabIndex = 4;
            dgvBorrowRecords.CellContentClick += dgvBorrowRecords_CellContentClick;
            // 
            // lblBookStock
            // 
            lblBookStock.AutoSize = true;
            lblBookStock.Location = new Point(41, 9);
            lblBookStock.Name = "lblBookStock";
            lblBookStock.Size = new Size(55, 15);
            lblBookStock.TabIndex = 5;
            lblBookStock.Text = "書本庫存";
            lblBookStock.Click += label1_Click;
            // 
            // lblBorrowedBooks
            // 
            lblBorrowedBooks.AutoSize = true;
            lblBorrowedBooks.Location = new Point(41, 218);
            lblBorrowedBooks.Name = "lblBorrowedBooks";
            lblBorrowedBooks.Size = new Size(55, 15);
            lblBorrowedBooks.TabIndex = 6;
            lblBorrowedBooks.Text = "借閱清單";
            // 
            // BookBorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBorrowedBooks);
            Controls.Add(lblBookStock);
            Controls.Add(dgvBorrowRecords);
            Controls.Add(btnClose);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrow);
            Controls.Add(dgvBooks);
            Name = "BookBorrowForm";
            Text = "BookBorrowForm";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnBorrow;
        private Button btnReturn;
        private Button btnClose;
        private DataGridView dgvBorrowRecords;
        private Label lblBookStock;
        private Label lblBorrowedBooks;
    }
}