
namespace Dekstop_App
{
    partial class Form2
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
            this.btnSign_In = new System.Windows.Forms.Button();
            this.Sign_up = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSign_In
            // 
            this.btnSign_In.BackgroundImage = global::Dekstop_App.Properties.Resources.arrangement_fast_food_wooden_background_23_21483213161;
            this.btnSign_In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSign_In.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign_In.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign_In.ForeColor = System.Drawing.Color.Black;
            this.btnSign_In.Location = new System.Drawing.Point(253, 194);
            this.btnSign_In.Name = "btnSign_In";
            this.btnSign_In.Size = new System.Drawing.Size(139, 69);
            this.btnSign_In.TabIndex = 1;
            this.btnSign_In.Text = "SIGN IN\r\n";
            this.btnSign_In.UseVisualStyleBackColor = true;
            this.btnSign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Sign_up
            // 
            this.Sign_up.BackgroundImage = global::Dekstop_App.Properties.Resources.arrangement_fast_food_wooden_background_23_21483213161;
            this.Sign_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_up.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_up.ForeColor = System.Drawing.Color.Black;
            this.Sign_up.Location = new System.Drawing.Point(418, 194);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(139, 69);
            this.Sign_up.TabIndex = 2;
            this.Sign_up.Text = "SIGN UP";
            this.Sign_up.UseVisualStyleBackColor = true;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::Dekstop_App.Properties.Resources.arrangement_fast_food_wooden_background_23_21483213161;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(335, 269);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 69);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Header.Image = global::Dekstop_App.Properties.Resources.vvv;
            this.Header.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Header.Location = new System.Drawing.Point(145, 47);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(507, 94);
            this.Header.TabIndex = 4;
            this.Header.Click += new System.EventHandler(this.Label_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dekstop_App.Properties.Resources.arrangement_fast_food_wooden_background_23_2148321316;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.btnSign_In);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSign_In;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Header;
    }
}