using LibraryManagementApp.Models;
using LibraryManagementApp.Repos;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    partial class MainForm
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
            components = new Container();
            BookLabel = new Label();
            LibraryManagementLabel = new Label();
            dgvBooks = new DataGridView();
            bookBindingSource = new BindingSource(components);
            lblUser = new Label();
            lblBookTitle = new Label();
            lblAuthor = new Label();
            lblPublisher = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            btnBookManage = new Button();
            btnBorrowManage = new Button();
            btnUserManage = new Button();
            btnLogout = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((ISupportInitialize)dgvBooks).BeginInit();
            ((ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BookLabel
            // 
            BookLabel.AutoSize = true;
            BookLabel.Location = new Point(73, 158);
            BookLabel.Name = "BookLabel";
            BookLabel.Size = new Size(76, 15);
            BookLabel.TabIndex = 2;
            BookLabel.Text = ">> 書本管理";
            // 
            // LibraryManagementLabel
            // 
            LibraryManagementLabel.AutoSize = true;
            LibraryManagementLabel.Location = new Point(74, 55);
            LibraryManagementLabel.Name = "LibraryManagementLabel";
            LibraryManagementLabel.Size = new Size(79, 15);
            LibraryManagementLabel.TabIndex = 7;
            LibraryManagementLabel.Text = "書本管理系統";
            // 
            // dgvBooks
            // 
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.DataSource = bookBindingSource;
            dgvBooks.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvBooks.Location = new Point(174, 158);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(547, 237);
            dgvBooks.TabIndex = 8;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(622, 55);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 15);
            lblUser.TabIndex = 9;
            lblUser.Text = "使用者";
            lblUser.Click += lblUser_Click;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(15, 411);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(31, 15);
            lblBookTitle.TabIndex = 10;
            lblBookTitle.Text = "書名";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(116, 411);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(31, 15);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "作者";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(215, 411);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(43, 15);
            lblPublisher.TabIndex = 12;
            lblPublisher.Text = "出版社";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(325, 411);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(31, 15);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "分類";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(428, 411);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(31, 15);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "數量";
            // 
            // btnBookManage
            // 
            btnBookManage.Location = new Point(74, 96);
            btnBookManage.Name = "btnBookManage";
            btnBookManage.Size = new Size(75, 23);
            btnBookManage.TabIndex = 15;
            btnBookManage.Text = "書本管理";
            btnBookManage.UseVisualStyleBackColor = true;
            btnBookManage.Click += btnBookManage_Click;
            // 
            // btnBorrowManage
            // 
            btnBorrowManage.Location = new Point(183, 96);
            btnBorrowManage.Name = "btnBorrowManage";
            btnBorrowManage.Size = new Size(75, 23);
            btnBorrowManage.TabIndex = 16;
            btnBorrowManage.Text = "借閱管理";
            btnBorrowManage.UseVisualStyleBackColor = true;
            btnBorrowManage.Click += btnBorrowManage_Click;
            // 
            // btnUserManage
            // 
            btnUserManage.Location = new Point(295, 96);
            btnUserManage.Name = "btnUserManage";
            btnUserManage.Size = new Size(75, 23);
            btnUserManage.TabIndex = 17;
            btnUserManage.Text = "使用者管理";
            btnUserManage.UseVisualStyleBackColor = true;
            btnUserManage.Click += btnUserManage_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(622, 96);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "登出";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(725, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "儲存修改";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(725, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "新增書本";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(725, 269);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "刪除書本";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(btnLogout);
            Controls.Add(btnUserManage);
            Controls.Add(btnBorrowManage);
            Controls.Add(btnBookManage);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblPublisher);
            Controls.Add(lblAuthor);
            Controls.Add(lblBookTitle);
            Controls.Add(lblUser);
            Controls.Add(dgvBooks);
            Controls.Add(LibraryManagementLabel);
            Controls.Add(BookLabel);
            Name = "MainForm";
            Text = "MainForm";
            ((ISupportInitialize)dgvBooks).EndInit();
            ((ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTitle;
        private Label label2;
        private Label BookLabel;
        private Label LibraryManagementLabel;
        private DataGridView dgvBooks;
        private Label lblUser;
        private Label lblAuthor;
        private Label lblPublisher;
        private Label lblCategory;
        private Label lblQuantity;
        private Button btnBookManage;
        private Button btnBorrowManage;
        private Button btnUserManage;
        private Button btnLogout;
        private BindingSource bookBindingSource;
        private Button btnSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private Button btnAdd;
        private Button btnDelete;
    }
}