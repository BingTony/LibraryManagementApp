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
            BookLabel = new Label();
            LibraryManagementLabel = new Label();
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(454, 77);
            dataGridView1.TabIndex = 8;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(622, 55);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 15);
            lblUser.TabIndex = 9;
            lblUser.Text = "使用者";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(73, 254);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(31, 15);
            lblBookTitle.TabIndex = 10;
            lblBookTitle.Text = "書名";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(174, 254);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(31, 15);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "作者";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(273, 254);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(43, 15);
            lblPublisher.TabIndex = 12;
            lblPublisher.Text = "出版社";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(383, 254);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(31, 15);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "分類";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(486, 254);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(dataGridView1);
            Controls.Add(LibraryManagementLabel);
            Controls.Add(BookLabel);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookTitle;
        private Label label2;
        private Label BookLabel;
        private Label LibraryManagementLabel;
        private DataGridView dataGridView1;
        private Label lblUser;
        private Label lblAuthor;
        private Label lblPublisher;
        private Label lblCategory;
        private Label lblQuantity;
        private Button btnBookManage;
        private Button btnBorrowManage;
        private Button btnUserManage;
        private Button btnLogout;
    }
}