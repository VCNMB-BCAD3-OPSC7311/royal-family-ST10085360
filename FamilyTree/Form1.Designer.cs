namespace FamilyTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            cmbPred = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            panel2 = new Panel();
            TreeView = new TreeView();
            txtSearch = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbPred);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(42, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 312);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 144);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Predecessor";
            // 
            // cmbPred
            // 
            cmbPred.FormattingEnabled = true;
            cmbPred.Location = new Point(37, 174);
            cmbPred.Name = "cmbPred";
            cmbPred.Size = new Size(163, 23);
            cmbPred.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(37, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 71);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Member Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 1;
            label1.Text = "Add Member";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(82, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TreeView);
            panel2.Location = new Point(342, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 312);
            panel2.TabIndex = 1;
            // 
            // TreeView
            // 
            TreeView.Location = new Point(-1, -1);
            TreeView.Name = "TreeView";
            TreeView.Size = new Size(420, 312);
            TreeView.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(444, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 23);
            txtSearch.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 29);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 6;
            label4.Text = "Member Name";
            // 
            // button1
            // 
            button1.Location = new Point(638, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox cmbPred;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private Panel panel2;
        private TreeView TreeView;
        private TextBox txtSearch;
        private Label label4;
        private Button button1;
    }
}