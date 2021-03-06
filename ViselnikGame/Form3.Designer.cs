﻿//<copyright file="Form3.Designer.cs" company="OmGTU"> 
//Copyright (c) OmGTU. All rights reserved.
//</copyright> 
//<author>
//Kalita Aleksandr, Valyn Ivan, Loshchinina Tatyana
//</author> 
namespace OmGTU.Advance.Profit.Loyal.ViselnikGame
{
    /// <summary>
    /// Copy of a class of the form.
    /// </summary>
    partial class Form3
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::ViselnikGame.Properties.Resources.buttonFood;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(554, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "FOOD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Categories);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::ViselnikGame.Properties.Resources.buttonTransport;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(554, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "TRANSPORT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Categories);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.BackgroundImage = global::ViselnikGame.Properties.Resources.buttonAnimals;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(554, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "ANIMALS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Categories);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.BackgroundImage = global::ViselnikGame.Properties.Resources.buttonBack;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(554, 663);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(310, 73);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ViselnikGame.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1292, 732);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HANGED MAN";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Button Food
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// Button transport
        /// </summary>
       private System.Windows.Forms.Button button2;

        /// <summary>
        /// Button animals
        /// </summary>
       private System.Windows.Forms.Button button3;

        /// <summary>
        /// Button back
        /// </summary>
        private System.Windows.Forms.Button button4;
    }
}