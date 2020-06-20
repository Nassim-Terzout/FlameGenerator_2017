namespace Shakespear
{
    partial class Intro
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
            this.Exit = new System.Windows.Forms.Label();
            this.Randombutton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.Dictionarybutton = new System.Windows.Forms.Button();
            this.Design1 = new System.Windows.Forms.PictureBox();
            this.Designborder = new System.Windows.Forms.PictureBox();
            this.clipart = new System.Windows.Forms.PictureBox();
            this.Shakespearface = new System.Windows.Forms.PictureBox();
            this.introtxt = new System.Windows.Forms.Label();
            this.orange = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.loading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Design1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Designborder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shakespearface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(633, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 42);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Randombutton
            // 
            this.Randombutton.BackColor = System.Drawing.Color.Black;
            this.Randombutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Randombutton.ForeColor = System.Drawing.Color.Red;
            this.Randombutton.Location = new System.Drawing.Point(250, 357);
            this.Randombutton.Name = "Randombutton";
            this.Randombutton.Size = new System.Drawing.Size(183, 53);
            this.Randombutton.TabIndex = 1;
            this.Randombutton.Text = "Random Generator";
            this.Randombutton.UseVisualStyleBackColor = false;
            this.Randombutton.Click += new System.EventHandler(this.Random_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.Black;
            this.Helpbutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.ForeColor = System.Drawing.Color.Red;
            this.Helpbutton.Location = new System.Drawing.Point(471, 357);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(155, 53);
            this.Helpbutton.TabIndex = 3;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = false;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // Dictionarybutton
            // 
            this.Dictionarybutton.BackColor = System.Drawing.Color.Black;
            this.Dictionarybutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dictionarybutton.ForeColor = System.Drawing.Color.Red;
            this.Dictionarybutton.Location = new System.Drawing.Point(52, 357);
            this.Dictionarybutton.Name = "Dictionarybutton";
            this.Dictionarybutton.Size = new System.Drawing.Size(155, 53);
            this.Dictionarybutton.TabIndex = 4;
            this.Dictionarybutton.Text = "Dictionary";
            this.Dictionarybutton.UseVisualStyleBackColor = false;
            this.Dictionarybutton.Click += new System.EventHandler(this.Dictionarybutton_Click);
            // 
            // Design1
            // 
            this.Design1.BackColor = System.Drawing.Color.Transparent;
            this.Design1.BackgroundImage = global::Shakespear.Properties.Resources.Transparent_scroll_border_clip_art_Black_scroll_with_transparent_background;
            this.Design1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Design1.Location = new System.Drawing.Point(12, -19);
            this.Design1.Name = "Design1";
            this.Design1.Size = new System.Drawing.Size(639, 141);
            this.Design1.TabIndex = 6;
            this.Design1.TabStop = false;
            // 
            // Designborder
            // 
            this.Designborder.BackColor = System.Drawing.Color.Transparent;
            this.Designborder.BackgroundImage = global::Shakespear.Properties.Resources._77776666;
            this.Designborder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Designborder.Location = new System.Drawing.Point(451, 128);
            this.Designborder.Name = "Designborder";
            this.Designborder.Size = new System.Drawing.Size(200, 209);
            this.Designborder.TabIndex = 7;
            this.Designborder.TabStop = false;
            // 
            // clipart
            // 
            this.clipart.BackColor = System.Drawing.Color.Transparent;
            this.clipart.BackgroundImage = global::Shakespear.Properties.Resources.Shakespeare_3;
            this.clipart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clipart.Location = new System.Drawing.Point(12, 128);
            this.clipart.Name = "clipart";
            this.clipart.Size = new System.Drawing.Size(207, 209);
            this.clipart.TabIndex = 5;
            this.clipart.TabStop = false;
            // 
            // Shakespearface
            // 
            this.Shakespearface.BackColor = System.Drawing.Color.Transparent;
            this.Shakespearface.BackgroundImage = global::Shakespear.Properties.Resources.article_1160423_0275F5820000044D_397_468x428;
            this.Shakespearface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shakespearface.Location = new System.Drawing.Point(471, 156);
            this.Shakespearface.Name = "Shakespearface";
            this.Shakespearface.Size = new System.Drawing.Size(155, 156);
            this.Shakespearface.TabIndex = 8;
            this.Shakespearface.TabStop = false;
            // 
            // introtxt
            // 
            this.introtxt.BackColor = System.Drawing.Color.Transparent;
            this.introtxt.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introtxt.Location = new System.Drawing.Point(225, 128);
            this.introtxt.Name = "introtxt";
            this.introtxt.Size = new System.Drawing.Size(220, 209);
            this.introtxt.TabIndex = 9;
            this.introtxt.Text = "Welcome to the Shakespeare insult generator! Please press any of the three button" +
    "s below to proceed!";
            this.introtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orange.Location = new System.Drawing.Point(-1, -1);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(685, 378);
            this.orange.TabIndex = 10;
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.black.ForeColor = System.Drawing.Color.Red;
            this.black.Location = new System.Drawing.Point(-1, 368);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(685, 99);
            this.black.TabIndex = 11;
            this.black.Text = "Loading";
            this.black.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.img.BackgroundImage = global::Shakespear.Properties.Resources.is_this_an_emojiiseebeforemetwitterplaysitspartinshakespeare4009_thumb_1280_1280;
            this.img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img.Location = new System.Drawing.Point(62, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(528, 353);
            this.img.TabIndex = 12;
            this.img.TabStop = false;
            // 
            // loading
            // 
            this.loading.Enabled = true;
            this.loading.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Shakespear.Properties.Resources._143568158;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.img);
            this.Controls.Add(this.black);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.introtxt);
            this.Controls.Add(this.Shakespearface);
            this.Controls.Add(this.Designborder);
            this.Controls.Add(this.clipart);
            this.Controls.Add(this.Dictionarybutton);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.Randombutton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Design1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Design1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Designborder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shakespearface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button Randombutton;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button Dictionarybutton;
        private System.Windows.Forms.PictureBox Design1;
        private System.Windows.Forms.PictureBox Designborder;
        private System.Windows.Forms.PictureBox clipart;
        private System.Windows.Forms.PictureBox Shakespearface;
        private System.Windows.Forms.Label introtxt;
        private System.Windows.Forms.Label orange;
        private System.Windows.Forms.Label black;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Timer loading;
    }
}

