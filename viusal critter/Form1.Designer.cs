namespace viusal_critter
{
    partial class Form1
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
            this.txb_containt = new System.Windows.Forms.TextBox();
            this.lbl_changecolor = new System.Windows.Forms.Label();
            this.rbt_red = new System.Windows.Forms.RadioButton();
            this.rbt_green = new System.Windows.Forms.RadioButton();
            this.rbt_blue = new System.Windows.Forms.RadioButton();
            this.btn_changename = new System.Windows.Forms.Button();
            this.lbl_mood = new System.Windows.Forms.Label();
            this.cmb_mood = new System.Windows.Forms.ComboBox();
            this.txb_display = new System.Windows.Forms.TextBox();
            this.btn_fontsize = new System.Windows.Forms.Button();
            this.cmb_fontsize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txb_containt
            // 
            this.txb_containt.Location = new System.Drawing.Point(10, 284);
            this.txb_containt.Name = "txb_containt";
            this.txb_containt.Size = new System.Drawing.Size(118, 22);
            this.txb_containt.TabIndex = 2;
            // 
            // lbl_changecolor
            // 
            this.lbl_changecolor.AutoSize = true;
            this.lbl_changecolor.Location = new System.Drawing.Point(12, 330);
            this.lbl_changecolor.Name = "lbl_changecolor";
            this.lbl_changecolor.Size = new System.Drawing.Size(116, 17);
            this.lbl_changecolor.TabIndex = 4;
            this.lbl_changecolor.Text = "Change My Color";
            // 
            // rbt_red
            // 
            this.rbt_red.AutoSize = true;
            this.rbt_red.Location = new System.Drawing.Point(18, 368);
            this.rbt_red.Name = "rbt_red";
            this.rbt_red.Size = new System.Drawing.Size(55, 21);
            this.rbt_red.TabIndex = 5;
            this.rbt_red.TabStop = true;
            this.rbt_red.Text = "Red";
            this.rbt_red.UseVisualStyleBackColor = true;
            this.rbt_red.CheckedChanged += new System.EventHandler(this.rbt_red_CheckedChanged);
            // 
            // rbt_green
            // 
            this.rbt_green.AutoSize = true;
            this.rbt_green.Location = new System.Drawing.Point(18, 407);
            this.rbt_green.Name = "rbt_green";
            this.rbt_green.Size = new System.Drawing.Size(69, 21);
            this.rbt_green.TabIndex = 6;
            this.rbt_green.TabStop = true;
            this.rbt_green.Text = "Green";
            this.rbt_green.UseVisualStyleBackColor = true;
            this.rbt_green.CheckedChanged += new System.EventHandler(this.rbt_green_CheckedChanged);
            // 
            // rbt_blue
            // 
            this.rbt_blue.AutoSize = true;
            this.rbt_blue.Location = new System.Drawing.Point(21, 448);
            this.rbt_blue.Name = "rbt_blue";
            this.rbt_blue.Size = new System.Drawing.Size(57, 21);
            this.rbt_blue.TabIndex = 7;
            this.rbt_blue.TabStop = true;
            this.rbt_blue.Text = "Blue";
            this.rbt_blue.UseVisualStyleBackColor = true;
            this.rbt_blue.CheckedChanged += new System.EventHandler(this.rbt_blue_CheckedChanged);
            // 
            // btn_changename
            // 
            this.btn_changename.Location = new System.Drawing.Point(10, 245);
            this.btn_changename.Name = "btn_changename";
            this.btn_changename.Size = new System.Drawing.Size(136, 23);
            this.btn_changename.TabIndex = 9;
            this.btn_changename.Text = "Change containt";
            this.btn_changename.UseVisualStyleBackColor = true;
            this.btn_changename.Click += new System.EventHandler(this.btn_changename_Click);
            // 
            // lbl_mood
            // 
            this.lbl_mood.AutoSize = true;
            this.lbl_mood.Location = new System.Drawing.Point(386, 245);
            this.lbl_mood.Name = "lbl_mood";
            this.lbl_mood.Size = new System.Drawing.Size(90, 17);
            this.lbl_mood.TabIndex = 0;
            this.lbl_mood.Text = "Set My Mood";
            // 
            // cmb_mood
            // 
            this.cmb_mood.FormattingEnabled = true;
            this.cmb_mood.Items.AddRange(new object[] {
            "Happy",
            "Sad",
            "Ok"});
            this.cmb_mood.Location = new System.Drawing.Point(389, 284);
            this.cmb_mood.Name = "cmb_mood";
            this.cmb_mood.Size = new System.Drawing.Size(121, 24);
            this.cmb_mood.TabIndex = 1;
            // 
            // txb_display
            // 
            this.txb_display.Location = new System.Drawing.Point(15, 21);
            this.txb_display.Multiline = true;
            this.txb_display.Name = "txb_display";
            this.txb_display.Size = new System.Drawing.Size(495, 218);
            this.txb_display.TabIndex = 10;
            this.txb_display.Text = "HELLO! THIS IS ONLY EXAMPLE TO KNOE BETTER ABOUT C#. \r\nHERE I PRATICE ABOUT.\r\n1)F" +
    "ONT COLOR CHANGE.\r\n2)FONT SIZE CHANGE.\r\n3)DROP DOWN COMBO LIST.\r\n4)CHANGE THE TE" +
    "XT";
            // 
            // btn_fontsize
            // 
            this.btn_fontsize.Location = new System.Drawing.Point(193, 245);
            this.btn_fontsize.Name = "btn_fontsize";
            this.btn_fontsize.Size = new System.Drawing.Size(136, 23);
            this.btn_fontsize.TabIndex = 12;
            this.btn_fontsize.Text = "Change Font Size";
            this.btn_fontsize.UseVisualStyleBackColor = true;
            this.btn_fontsize.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_fontsize
            // 
            this.cmb_fontsize.FormattingEnabled = true;
            this.cmb_fontsize.Items.AddRange(new object[] {
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.cmb_fontsize.Location = new System.Drawing.Point(193, 284);
            this.cmb_fontsize.Name = "cmb_fontsize";
            this.cmb_fontsize.Size = new System.Drawing.Size(121, 24);
            this.cmb_fontsize.TabIndex = 13;
            this.cmb_fontsize.SelectedIndexChanged += new System.EventHandler(this.cmb_fontsize_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 504);
            this.Controls.Add(this.cmb_fontsize);
            this.Controls.Add(this.btn_fontsize);
            this.Controls.Add(this.txb_display);
            this.Controls.Add(this.btn_changename);
            this.Controls.Add(this.rbt_blue);
            this.Controls.Add(this.rbt_green);
            this.Controls.Add(this.rbt_red);
            this.Controls.Add(this.lbl_changecolor);
            this.Controls.Add(this.txb_containt);
            this.Controls.Add(this.cmb_mood);
            this.Controls.Add(this.lbl_mood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_containt;
        private System.Windows.Forms.Label lbl_changecolor;
        private System.Windows.Forms.RadioButton rbt_red;
        private System.Windows.Forms.RadioButton rbt_green;
        private System.Windows.Forms.RadioButton rbt_blue;
        private System.Windows.Forms.Button btn_changename;
        private System.Windows.Forms.Label lbl_mood;
        private System.Windows.Forms.ComboBox cmb_mood;
        private System.Windows.Forms.TextBox txb_display;
        private System.Windows.Forms.Button btn_fontsize;
        private System.Windows.Forms.ComboBox cmb_fontsize;
    }
}

