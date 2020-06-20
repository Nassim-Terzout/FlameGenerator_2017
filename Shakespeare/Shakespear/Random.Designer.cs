namespace Shakespear
{
    partial class Randomform
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
            this.Exit = new System.Windows.Forms.Label();
            this.insult = new System.Windows.Forms.Button();
            this.Dictionarybutton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.btranslate = new System.Windows.Forms.Button();
            this.binsult = new System.Windows.Forms.Button();
            this.transtxt = new System.Windows.Forms.Button();
            this.orgtxt = new System.Windows.Forms.Button();
            this.design = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.design)).BeginInit();
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
            // insult
            // 
            this.insult.BackColor = System.Drawing.Color.Black;
            this.insult.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insult.ForeColor = System.Drawing.Color.White;
            this.insult.Location = new System.Drawing.Point(195, 70);
            this.insult.Name = "insult";
            this.insult.Size = new System.Drawing.Size(304, 46);
            this.insult.TabIndex = 5;
            this.insult.Text = "Generate Insult and Translation!";
            this.insult.UseVisualStyleBackColor = false;
            this.insult.Click += new System.EventHandler(this.insult_Click);
            // 
            // Dictionarybutton
            // 
            this.Dictionarybutton.BackColor = System.Drawing.Color.Black;
            this.Dictionarybutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dictionarybutton.ForeColor = System.Drawing.Color.Red;
            this.Dictionarybutton.Location = new System.Drawing.Point(12, 389);
            this.Dictionarybutton.Name = "Dictionarybutton";
            this.Dictionarybutton.Size = new System.Drawing.Size(214, 60);
            this.Dictionarybutton.TabIndex = 7;
            this.Dictionarybutton.Text = "Dictionary";
            this.Dictionarybutton.UseVisualStyleBackColor = false;
            this.Dictionarybutton.Click += new System.EventHandler(this.Dictionarybutton_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.BackColor = System.Drawing.Color.Black;
            this.Helpbutton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helpbutton.ForeColor = System.Drawing.Color.Red;
            this.Helpbutton.Location = new System.Drawing.Point(457, 389);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(215, 60);
            this.Helpbutton.TabIndex = 8;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = false;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // btranslate
            // 
            this.btranslate.BackColor = System.Drawing.Color.Red;
            this.btranslate.BackgroundImage = global::Shakespear.Properties.Resources.open_book_transparent_background_3;
            this.btranslate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btranslate.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btranslate.Location = new System.Drawing.Point(338, 174);
            this.btranslate.Name = "btranslate";
            this.btranslate.Size = new System.Drawing.Size(345, 196);
            this.btranslate.TabIndex = 10;
            this.btranslate.UseVisualStyleBackColor = false;
            this.btranslate.Click += new System.EventHandler(this.btranslate_Click);
            // 
            // binsult
            // 
            this.binsult.BackColor = System.Drawing.Color.Red;
            this.binsult.BackgroundImage = global::Shakespear.Properties.Resources.Capturereererre;
            this.binsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.binsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binsult.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binsult.Location = new System.Drawing.Point(2, 174);
            this.binsult.Name = "binsult";
            this.binsult.Size = new System.Drawing.Size(330, 196);
            this.binsult.TabIndex = 9;
            this.binsult.UseVisualStyleBackColor = false;
            this.binsult.Click += new System.EventHandler(this.binsult_Click);
            // 
            // transtxt
            // 
            this.transtxt.BackColor = System.Drawing.Color.Transparent;
            this.transtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transtxt.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transtxt.ForeColor = System.Drawing.Color.Black;
            this.transtxt.Location = new System.Drawing.Point(338, 122);
            this.transtxt.Name = "transtxt";
            this.transtxt.Size = new System.Drawing.Size(334, 46);
            this.transtxt.TabIndex = 11;
            this.transtxt.Text = "Translated Version!";
            this.transtxt.UseVisualStyleBackColor = false;
            // 
            // orgtxt
            // 
            this.orgtxt.BackColor = System.Drawing.Color.Transparent;
            this.orgtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orgtxt.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgtxt.ForeColor = System.Drawing.Color.Black;
            this.orgtxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orgtxt.Location = new System.Drawing.Point(12, 122);
            this.orgtxt.Name = "orgtxt";
            this.orgtxt.Size = new System.Drawing.Size(320, 46);
            this.orgtxt.TabIndex = 12;
            this.orgtxt.Text = "Shakespeare Themed Insult!";
            this.orgtxt.UseVisualStyleBackColor = false;
            // 
            // design
            // 
            this.design.BackColor = System.Drawing.Color.Transparent;
            this.design.BackgroundImage = global::Shakespear.Properties.Resources.Transparent_scroll_border_clip_art_Black_scroll_with_transparent_background;
            this.design.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.design.Location = new System.Drawing.Point(1, -8);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(671, 99);
            this.design.TabIndex = 13;
            this.design.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Black;
            this.Main.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.ForeColor = System.Drawing.Color.Red;
            this.Main.Location = new System.Drawing.Point(232, 389);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(219, 60);
            this.Main.TabIndex = 14;
            this.Main.Text = "Main Menu";
            this.Main.UseVisualStyleBackColor = false;
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // Randomform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Shakespear.Properties.Resources._1435681581;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.orgtxt);
            this.Controls.Add(this.transtxt);
            this.Controls.Add(this.btranslate);
            this.Controls.Add(this.binsult);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.Dictionarybutton);
            this.Controls.Add(this.insult);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.design);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randomform";
            this.Text = "Random";
            ((System.ComponentModel.ISupportInitialize)(this.design)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button insult;
        private System.Windows.Forms.Button Dictionarybutton;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button binsult;
        private System.Windows.Forms.Button btranslate;
        private System.Windows.Forms.Button transtxt;
        private System.Windows.Forms.Button orgtxt;
        private System.Windows.Forms.PictureBox design;
        private System.Windows.Forms.Button Main;
    }
}