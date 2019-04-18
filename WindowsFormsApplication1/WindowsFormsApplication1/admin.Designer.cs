namespace WindowsFormsApplication1
{
    partial class admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.blank_red_button;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(842, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dd;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(23, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Flight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dd;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(23, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Flight";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dd;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(23, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 72);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit Flight Date";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dd;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(588, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dd;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(23, 542);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 72);
            this.button6.TabIndex = 6;
            this.button6.Text = "Edit Flight Dist.";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 222);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Inner_page_4___1579_;
            this.ClientSize = new System.Drawing.Size(1073, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "admin";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}