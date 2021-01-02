namespace IP_Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.octet1 = new System.Windows.Forms.TextBox();
            this.octet2 = new System.Windows.Forms.TextBox();
            this.octet3 = new System.Windows.Forms.TextBox();
            this.octet4 = new System.Windows.Forms.TextBox();
            this.netmask = new System.Windows.Forms.TextBox();
            this.submask = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bigBox = new System.Windows.Forms.TextBox();
            this.subnet_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(188, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(272, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(356, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(116, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Address (Host or Network)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(371, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Netmask";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(188, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Netmask for sub/supernet";
            this.label10.Visible = false;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculate_button.Location = new System.Drawing.Point(141, 514);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(198, 39);
            this.calculate_button.TabIndex = 8;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // octet1
            // 
            this.octet1.AllowDrop = true;
            this.octet1.Location = new System.Drawing.Point(38, 71);
            this.octet1.Name = "octet1";
            this.octet1.Size = new System.Drawing.Size(60, 27);
            this.octet1.TabIndex = 1;
            this.octet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.octet1.Validating += new System.ComponentModel.CancelEventHandler(this.octet1_Validating);
            // 
            // octet2
            // 
            this.octet2.Location = new System.Drawing.Point(122, 72);
            this.octet2.Name = "octet2";
            this.octet2.Size = new System.Drawing.Size(60, 27);
            this.octet2.TabIndex = 2;
            this.octet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.octet2.Validating += new System.ComponentModel.CancelEventHandler(this.octet2_Validating);
            // 
            // octet3
            // 
            this.octet3.Location = new System.Drawing.Point(206, 72);
            this.octet3.Name = "octet3";
            this.octet3.Size = new System.Drawing.Size(60, 27);
            this.octet3.TabIndex = 3;
            this.octet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.octet3.Validating += new System.ComponentModel.CancelEventHandler(this.octet3_Validating);
            // 
            // octet4
            // 
            this.octet4.Location = new System.Drawing.Point(293, 72);
            this.octet4.Name = "octet4";
            this.octet4.Size = new System.Drawing.Size(60, 27);
            this.octet4.TabIndex = 4;
            this.octet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.octet4.Validating += new System.ComponentModel.CancelEventHandler(this.octet4_Validating);
            // 
            // netmask
            // 
            this.netmask.Location = new System.Drawing.Point(380, 72);
            this.netmask.Name = "netmask";
            this.netmask.Size = new System.Drawing.Size(60, 27);
            this.netmask.TabIndex = 5;
            this.netmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.netmask.Validating += new System.ComponentModel.CancelEventHandler(this.netmask_Validating);
            // 
            // submask
            // 
            this.submask.Location = new System.Drawing.Point(380, 121);
            this.submask.Name = "submask";
            this.submask.Size = new System.Drawing.Size(60, 27);
            this.submask.TabIndex = 7;
            this.submask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submask.Visible = false;
            this.submask.Validating += new System.ComponentModel.CancelEventHandler(this.submask_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bigBox
            // 
            this.bigBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigBox.Location = new System.Drawing.Point(39, 187);
            this.bigBox.Multiline = true;
            this.bigBox.Name = "bigBox";
            this.bigBox.Size = new System.Drawing.Size(400, 303);
            this.bigBox.TabIndex = 15;
            // 
            // subnet_check
            // 
            this.subnet_check.AutoSize = true;
            this.subnet_check.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.subnet_check.Location = new System.Drawing.Point(38, 127);
            this.subnet_check.Name = "subnet_check";
            this.subnet_check.Size = new System.Drawing.Size(135, 24);
            this.subnet_check.TabIndex = 6;
            this.subnet_check.Text = "calculate subnet";
            this.subnet_check.UseVisualStyleBackColor = true;
            this.subnet_check.CheckedChanged += new System.EventHandler(this.subnet_check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 585);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.subnet_check);
            this.Controls.Add(this.bigBox);
            this.Controls.Add(this.submask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.octet2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.octet1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.octet3);
            this.Controls.Add(this.netmask);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.octet4);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox octet1;
        private System.Windows.Forms.TextBox octet2;
        private System.Windows.Forms.TextBox octet3;
        private System.Windows.Forms.TextBox octet4;
        private System.Windows.Forms.TextBox netmask;
        private System.Windows.Forms.TextBox submask;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox subnet_check;
        private System.Windows.Forms.TextBox bigBox;
    }
}

