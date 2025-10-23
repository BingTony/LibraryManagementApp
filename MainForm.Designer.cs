using LibraryManagementApp.Models;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            BookLabel = new Label();
            dgvBooks = new DataGridView();
            lblUser = new Label();
            btnBookManage = new Button();
            btnBorrowManage = new Button();
            btnUserManage = new Button();
            btnLogout = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            bookBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            btnRefresh = new Button();
            ((ISupportInitialize)dgvBooks).BeginInit();
            ((ISupportInitialize)bookBindingSource).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BookLabel
            // 
            BookLabel.AutoSize = true;
            BookLabel.Location = new Point(37, 149);
            BookLabel.Name = "BookLabel";
            BookLabel.Size = new Size(76, 15);
            BookLabel.TabIndex = 2;
            BookLabel.Text = ">> 書本管理";
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvBooks.Location = new Point(138, 149);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(547, 289);
            dgvBooks.TabIndex = 8;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(586, 46);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 15);
            lblUser.TabIndex = 9;
            lblUser.Text = "使用者";
            // 
            // btnBookManage
            // 
            btnBookManage.Location = new Point(38, 101);
            btnBookManage.Name = "btnBookManage";
            btnBookManage.Size = new Size(75, 23);
            btnBookManage.TabIndex = 15;
            btnBookManage.Text = "書本管理";
            btnBookManage.UseVisualStyleBackColor = true;
            btnBookManage.Click += btnBookManage_Click;
            // 
            // btnBorrowManage
            // 
            btnBorrowManage.Location = new Point(138, 101);
            btnBorrowManage.Name = "btnBorrowManage";
            btnBorrowManage.Size = new Size(75, 23);
            btnBorrowManage.TabIndex = 16;
            btnBorrowManage.Text = "借閱管理";
            btnBorrowManage.UseVisualStyleBackColor = true;
            btnBorrowManage.Click += btnBorrowManage_Click;
            // 
            // btnUserManage
            // 
            btnUserManage.Location = new Point(242, 101);
            btnUserManage.Name = "btnUserManage";
            btnUserManage.Size = new Size(75, 23);
            btnUserManage.TabIndex = 17;
            btnUserManage.Text = "使用者管理";
            btnUserManage.UseVisualStyleBackColor = true;
            btnUserManage.Click += btnUserManage_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(701, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "登出";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(701, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "儲存修改";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(701, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "新增書本";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(701, 312);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "刪除書本";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 84);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(37, 180);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "重整清單";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(btnLogout);
            Controls.Add(btnUserManage);
            Controls.Add(btnBorrowManage);
            Controls.Add(btnBookManage);
            Controls.Add(lblUser);
            Controls.Add(dgvBooks);
            Controls.Add(BookLabel);
            Name = "MainForm";
            Text = "MainForm";
            ((ISupportInitialize)dgvBooks).EndInit();
            ((ISupportInitialize)bookBindingSource).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label BookLabel;
        private DataGridView dgvBooks;
        private Label lblUser;
        private Button btnBookManage;
        private Button btnBorrowManage;
        private Button btnUserManage;
        private Button btnLogout;
        private Button btnSave;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private Button btnAdd;
        private Button btnDelete;
        private BindingSource bookBindingSource;
        private PictureBox pictureBox1;
        private Button btnRefresh;
    }
}