
namespace Dekstop_App
{
    partial class Sign_In
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
            this.Sign_In_label = new System.Windows.Forms.Label();
            this.Sign_In_pass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdback = new System.Windows.Forms.Button();
            this.entercmd = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sign_In_label
            // 
            this.Sign_In_label.AutoSize = true;
            this.Sign_In_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In_label.Location = new System.Drawing.Point(134, 107);
            this.Sign_In_label.Name = "Sign_In_label";
            this.Sign_In_label.Size = new System.Drawing.Size(119, 25);
            this.Sign_In_label.TabIndex = 0;
            this.Sign_In_label.Text = "UserName ";
            // 
            // Sign_In_pass
            // 
            this.Sign_In_pass.AutoSize = true;
            this.Sign_In_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In_pass.Location = new System.Drawing.Point(134, 145);
            this.Sign_In_pass.Name = "Sign_In_pass";
            this.Sign_In_pass.Size = new System.Drawing.Size(106, 25);
            this.Sign_In_pass.TabIndex = 4;
            this.Sign_In_pass.Text = "Password";
            this.Sign_In_pass.Click += new System.EventHandler(this.Sign_In_pass_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(318, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 29);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmdback
            // 
            this.cmdback.BackgroundImage = global::Dekstop_App.Properties.Resources.arrangement_fast_food_wooden_background_23_21483213161;
            this.cmdback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdback.ForeColor = System.Drawing.Color.Black;
            this.cmdback.Location = new System.Drawing.Point(139, 228);
            this.cmdback.Name = "cmdback";
            this.cmdback.Size = new System.Drawing.Size(114, 39);
            this.cmdback.TabIndex = 7;
            this.cmdback.Text = "Back";
            this.cmdback.UseVisualStyleBackColor = true;
            this.cmdback.Click += new System.EventHandler(this.cmdback_Click);
            // 
            // entercmd
            // 
            this.entercmd.BackgroundImage = global::Dekstop_App.Properties.Resources.arrangement_fast_food_wooden_background_23_21483213161;
            this.entercmd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.entercmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entercmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entercmd.ForeColor = System.Drawing.Color.Black;
            this.entercmd.Location = new System.Drawing.Point(475, 228);
            this.entercmd.Name = "entercmd";
            this.entercmd.Size = new System.Drawing.Size(114, 39);
            this.entercmd.TabIndex = 8;
            this.entercmd.Text = "Enter";
            this.entercmd.UseVisualStyleBackColor = true;
            this.entercmd.Click += new System.EventHandler(this.entercmd_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Image = global::Dekstop_App.Properties.Resources.download__1_;
            this.logo.Location = new System.Drawing.Point(367, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(35, 13);
            this.logo.TabIndex = 9;
            this.logo.Text = "label1";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtpass.Location = new System.Drawing.Point(318, 143);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(271, 29);
            this.txtpass.TabIndex = 6;
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dekstop_App.Properties.Resources._8eec6faf1016ad5439f459a775a52727;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 332);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.entercmd);
            this.Controls.Add(this.cmdback);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Sign_In_pass);
            this.Controls.Add(this.Sign_In_label);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Sign_In";
            this.Text = "Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sign_In_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sign_In_label;
        private System.Windows.Forms.Label Sign_In_pass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdback;
        private System.Windows.Forms.Button entercmd;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.TextBox txtpass;
    }
}