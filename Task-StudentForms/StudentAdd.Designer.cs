namespace Task_StudentForms
{
    partial class StudentAdd
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
            this.btnname = new System.Windows.Forms.TextBox();
            this.btnage = new System.Windows.Forms.TextBox();
            this.btnsurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.viewstudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(173, 124);
            this.btnname.Multiline = true;
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(113, 36);
            this.btnname.TabIndex = 0;
            // 
            // btnage
            // 
            this.btnage.Location = new System.Drawing.Point(497, 124);
            this.btnage.Multiline = true;
            this.btnage.Name = "btnage";
            this.btnage.Size = new System.Drawing.Size(136, 36);
            this.btnage.TabIndex = 1;
            // 
            // btnsurname
            // 
            this.btnsurname.Location = new System.Drawing.Point(329, 124);
            this.btnsurname.Multiline = true;
            this.btnsurname.Name = "btnsurname";
            this.btnsurname.Size = new System.Drawing.Size(124, 36);
            this.btnsurname.TabIndex = 2;
            this.btnsurname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(243, 227);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(428, 227);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 37);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // viewstudent
            // 
            this.viewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewstudent.Location = new System.Drawing.Point(56, 290);
            this.viewstudent.Name = "viewstudent";
            this.viewstudent.RowHeadersWidth = 51;
            this.viewstudent.RowTemplate.Height = 24;
            this.viewstudent.Size = new System.Drawing.Size(710, 128);
            this.viewstudent.TabIndex = 8;
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewstudent);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsurname);
            this.Controls.Add(this.btnage);
            this.Controls.Add(this.btnname);
            this.Name = "StudentAdd";
            this.Text = "StudentAdd";
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnname;
        private System.Windows.Forms.TextBox btnage;
        private System.Windows.Forms.TextBox btnsurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView viewstudent;
    }
}