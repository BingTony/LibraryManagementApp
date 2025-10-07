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
            this.UserLabel = new Label();
            BookLabel = new Label();
            LibraryManagementLabel = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new Point(624, 55);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new Size(35, 15);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User:";
            // 
            // BookLabel
            // 
            BookLabel.AutoSize = true;
            BookLabel.Location = new Point(64, 117);
            BookLabel.Name = "BookLabel";
            BookLabel.Size = new Size(76, 15);
            BookLabel.TabIndex = 2;
            BookLabel.Text = ">> 書本管理";
            // 
            // LibraryManagementLabel
            // 
            LibraryManagementLabel.AutoSize = true;
            LibraryManagementLabel.Location = new Point(64, 55);
            LibraryManagementLabel.Name = "LibraryManagementLabel";
            LibraryManagementLabel.Size = new Size(79, 15);
            LibraryManagementLabel.TabIndex = 7;
            LibraryManagementLabel.Text = "書本管理系統";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(165, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(LibraryManagementLabel);
            Controls.Add(BookLabel);
            Controls.Add(this.UserLabel);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label BookLabel;
        private Label LibraryManagementLabel;
        private DataGridView dataGridView1;
    }
}