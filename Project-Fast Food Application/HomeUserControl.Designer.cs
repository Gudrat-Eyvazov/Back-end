namespace Project_Fast_Food_Application
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            Only = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            orderhome = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Only
            // 
            Only.AutoSize = true;
            Only.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Only.ForeColor = Color.Orange;
            Only.Location = new Point(41, 30);
            Only.Name = "Only";
            Only.Size = new Size(56, 23);
            Only.TabIndex = 0;
            Only.Text = "Only";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(41, 53);
            label1.Name = "label1";
            label1.Size = new Size(251, 145);
            label1.TabIndex = 1;
            label1.Text = "$22";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 187);
            label2.Name = "label2";
            label2.Size = new Size(276, 44);
            label2.TabIndex = 2;
            label2.Text = "Smash Burgers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 240);
            label3.Name = "label3";
            label3.Size = new Size(301, 23);
            label3.TabIndex = 3;
            label3.Text = "With Onion,Beef and Ketchup ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 273);
            label4.Name = "label4";
            label4.Size = new Size(402, 63);
            label4.TabIndex = 4;
            label4.Text = "If you're unfamiliar, the draw of a smash burger\r\nis its SUPER thin patties.Because they are so slim\r\nit's impossible for the ground beef to dry out\r\n";
            // 
            // orderhome
            // 
            orderhome.BackColor = Color.Orange;
            orderhome.FlatAppearance.BorderSize = 0;
            orderhome.FlatStyle = FlatStyle.Flat;
            orderhome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderhome.ForeColor = Color.White;
            orderhome.Location = new Point(73, 351);
            orderhome.Name = "orderhome";
            orderhome.Size = new Size(312, 43);
            orderhome.TabIndex = 5;
            orderhome.Text = "Order Now";
            orderhome.UseVisualStyleBackColor = false;
            orderhome.Click += orderhome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(481, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(orderhome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Only);
            Name = "HomeUserControl";
            Size = new Size(828, 419);
            Load += HomeUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Only;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button orderhome;
        private PictureBox pictureBox1;
    }
}
