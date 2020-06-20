namespace Shakespear
{
    partial class Helpp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Helpp));
            this.Exit = new System.Windows.Forms.Label();
            this.Randombutton = new System.Windows.Forms.Button();
            this.Dictionarybutton = new System.Windows.Forms.Button();
            this.yea = new System.Windows.Forms.Timer(this.components);
            this.dichelp = new System.Windows.Forms.Button();
            this.randhelp = new System.Windows.Forms.Button();
            this.introhelp = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Label();
            this.Introbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(633, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 42);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Randombutton
            // 
            this.Randombutton.BackColor = System.Drawing.Color.Black;
            this.Randombutton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randombutton.ForeColor = System.Drawing.Color.Red;
            this.Randombutton.Location = new System.Drawing.Point(272, 395);
            this.Randombutton.Name = "Randombutton";
            this.Randombutton.Size = new System.Drawing.Size(174, 53);
            this.Randombutton.TabIndex = 2;
            this.Randombutton.Text = "Back";
            this.Randombutton.UseVisualStyleBackColor = false;
            this.Randombutton.Visible = false;
            this.Randombutton.Click += new System.EventHandler(this.Randombutton_Click);
            // 
            // Dictionarybutton
            // 
            this.Dictionarybutton.BackColor = System.Drawing.Color.Black;
            this.Dictionarybutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dictionarybutton.ForeColor = System.Drawing.Color.Red;
            this.Dictionarybutton.Location = new System.Drawing.Point(272, 395);
            this.Dictionarybutton.Name = "Dictionarybutton";
            this.Dictionarybutton.Size = new System.Drawing.Size(174, 53);
            this.Dictionarybutton.TabIndex = 5;
            this.Dictionarybutton.Text = "Back";
            this.Dictionarybutton.UseVisualStyleBackColor = false;
            this.Dictionarybutton.Visible = false;
            this.Dictionarybutton.Click += new System.EventHandler(this.Dictionarybutton_Click);
            // 
            // yea
            // 
            this.yea.Tick += new System.EventHandler(this.yea_Tick);
            // 
            // dichelp
            // 
            this.dichelp.BackColor = System.Drawing.Color.Magenta;
            this.dichelp.BackgroundImage = global::Shakespear.Properties.Resources._8_2_scroll_png_clipart;
            this.dichelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dichelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dichelp.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dichelp.Location = new System.Drawing.Point(-2, -6);
            this.dichelp.Name = "dichelp";
            this.dichelp.Size = new System.Drawing.Size(689, 396);
            this.dichelp.TabIndex = 6;
            this.dichelp.Text = resources.GetString("dichelp.Text");
            this.dichelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dichelp.UseVisualStyleBackColor = false;
            this.dichelp.Visible = false;
            // 
            // randhelp
            // 
            this.randhelp.BackColor = System.Drawing.Color.Cyan;
            this.randhelp.BackgroundImage = global::Shakespear.Properties.Resources._8_2_scroll_png_clipart;
            this.randhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.randhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randhelp.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randhelp.Location = new System.Drawing.Point(-2, -6);
            this.randhelp.Name = "randhelp";
            this.randhelp.Size = new System.Drawing.Size(689, 395);
            this.randhelp.TabIndex = 8;
            this.randhelp.Text = resources.GetString("randhelp.Text");
            this.randhelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randhelp.UseVisualStyleBackColor = false;
            this.randhelp.Visible = false;
            this.randhelp.Click += new System.EventHandler(this.randhelp_Click);
            // 
            // introhelp
            // 
            this.introhelp.BackColor = System.Drawing.Color.Yellow;
            this.introhelp.BackgroundImage = global::Shakespear.Properties.Resources._8_2_scroll_png_clipart;
            this.introhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.introhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.introhelp.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introhelp.Location = new System.Drawing.Point(-2, -6);
            this.introhelp.Name = "introhelp";
            this.introhelp.Size = new System.Drawing.Size(689, 395);
            this.introhelp.TabIndex = 9;
            this.introhelp.Text = resources.GetString("introhelp.Text");
            this.introhelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.introhelp.UseVisualStyleBackColor = false;
            this.introhelp.Visible = false;
            this.introhelp.Click += new System.EventHandler(this.introhelp_Click);
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.Color.Red;
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out.Location = new System.Drawing.Point(633, 9);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(39, 42);
            this.Out.TabIndex = 10;
            this.Out.Text = "X";
            this.Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // Introbutton
            // 
            this.Introbutton.BackColor = System.Drawing.Color.Black;
            this.Introbutton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Introbutton.ForeColor = System.Drawing.Color.Red;
            this.Introbutton.Location = new System.Drawing.Point(272, 395);
            this.Introbutton.Name = "Introbutton";
            this.Introbutton.Size = new System.Drawing.Size(174, 53);
            this.Introbutton.TabIndex = 11;
            this.Introbutton.Text = "Back";
            this.Introbutton.UseVisualStyleBackColor = false;
            this.Introbutton.Visible = false;
            this.Introbutton.Click += new System.EventHandler(this.Introbutton_Click);
            // 
            // Helpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.Introbutton);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.introhelp);
            this.Controls.Add(this.randhelp);
            this.Controls.Add(this.Dictionarybutton);
            this.Controls.Add(this.Randombutton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dichelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Helpp";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Timer yea;
        private System.Windows.Forms.Label Out;
        public System.Windows.Forms.Button dichelp;
        public System.Windows.Forms.Button randhelp;
        public System.Windows.Forms.Button introhelp;
        public System.Windows.Forms.Button Dictionarybutton;
        public System.Windows.Forms.Button Introbutton;
        public System.Windows.Forms.Button Randombutton;
    }
}