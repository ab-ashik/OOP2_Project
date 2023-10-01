namespace WindowsFormsApp1
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.forgotPassLink = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(144, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 41);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Log In";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(112, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(98, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 1);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(94, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(94, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Control;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(98, 157);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(261, 26);
            this.txtemail.TabIndex = 4;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Control;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(98, 225);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(261, 30);
            this.txtpass.TabIndex = 4;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passCheck.Location = new System.Drawing.Point(98, 261);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(102, 17);
            this.passCheck.TabIndex = 5;
            this.passCheck.Text = "Show Password";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // forgotPassLink
            // 
            this.forgotPassLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.forgotPassLink.AutoSize = true;
            this.forgotPassLink.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLink.LinkColor = System.Drawing.Color.Blue;
            this.forgotPassLink.Location = new System.Drawing.Point(140, 355);
            this.forgotPassLink.Name = "forgotPassLink";
            this.forgotPassLink.Size = new System.Drawing.Size(138, 20);
            this.forgotPassLink.TabIndex = 6;
            this.forgotPassLink.TabStop = true;
            this.forgotPassLink.Text = "Forgot Password?";
            this.forgotPassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassLink_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 438);
            this.Controls.Add(this.forgotPassLink);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            this.Load += new System.EventHandler(this.LOGIN_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.LinkLabel forgotPassLink;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

