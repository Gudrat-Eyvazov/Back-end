namespace StudentAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            add = new Button();
            update = new Button();
            delete = new Button();
            studentview = new DataGridView();
            buttonshow = new Button();
            ((System.ComponentModel.ISupportInitialize)studentview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 36);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 196);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 117);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(234, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 5;
            // 
            // add
            // 
            add.Location = new Point(542, 84);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 6;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // update
            // 
            update.Location = new Point(542, 196);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 7;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(542, 140);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 8;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // studentview
            // 
            studentview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentview.Location = new Point(110, 279);
            studentview.Name = "studentview";
            studentview.RowHeadersWidth = 51;
            studentview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentview.Size = new Size(526, 135);
            studentview.TabIndex = 9;
            studentview.AutoSizeColumnModeChanged += studentview_AutoSizeColumnModeChanged;
            studentview.CellEnter += studentview_CellEnter;
            // 
            // buttonshow
            // 
            buttonshow.Location = new Point(542, 35);
            buttonshow.Name = "buttonshow";
            buttonshow.Size = new Size(94, 29);
            buttonshow.TabIndex = 10;
            buttonshow.Text = "show";
            buttonshow.UseVisualStyleBackColor = true;
            buttonshow.Click += buttonshow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonshow);
            Controls.Add(studentview);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)studentview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button add;
        private Button update;
        private Button delete;
        private DataGridView studentview;
        private Button buttonshow;
    }
}
