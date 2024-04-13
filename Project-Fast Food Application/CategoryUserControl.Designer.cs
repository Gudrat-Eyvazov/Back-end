namespace Project_Fast_Food_Application
{
    partial class CategoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dqvcategory = new DataGridView();
            Btnadd = new Button();
            txtcategoryname = new TextBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dqvcategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dqvcategory);
            panel1.Controls.Add(Btnadd);
            panel1.Controls.Add(txtcategoryname);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(63, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 356);
            panel1.TabIndex = 1;
            // 
            // dqvcategory
            // 
            dqvcategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dqvcategory.Location = new Point(25, 180);
            dqvcategory.Name = "dqvcategory";
            dqvcategory.RowHeadersWidth = 51;
            dqvcategory.Size = new Size(584, 148);
            dqvcategory.TabIndex = 7;
            dqvcategory.CellContentClick += dqvcategory_CellContentClick;
            // 
            // Btnadd
            // 
            Btnadd.BackColor = Color.FromArgb(5, 97, 185);
            Btnadd.FlatAppearance.BorderSize = 0;
            Btnadd.FlatStyle = FlatStyle.Flat;
            Btnadd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnadd.ForeColor = Color.White;
            Btnadd.Location = new Point(190, 92);
            Btnadd.Name = "Btnadd";
            Btnadd.Size = new Size(242, 44);
            Btnadd.TabIndex = 6;
            Btnadd.Text = "Add";
            Btnadd.UseVisualStyleBackColor = false;
            Btnadd.Click += Btnadd_Click;
            // 
            // txtcategoryname
            // 
            txtcategoryname.Location = new Point(353, 29);
            txtcategoryname.Name = "txtcategoryname";
            txtcategoryname.Size = new Size(210, 27);
            txtcategoryname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(5, 97, 185);
            label2.Location = new Point(25, 29);
            label2.Name = "label2";
            label2.Size = new Size(295, 27);
            label2.TabIndex = 2;
            label2.Text = "Enter the Category Name";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "CategoryUserControl";
            Size = new Size(828, 419);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dqvcategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Btnadd;
        private TextBox txtcategoryname;
        private Label label2;
        private DataGridView dqvcategory;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
