namespace WindowsFormsApp10
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
            this.oilLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.oilcomboB = new System.Windows.Forms.ComboBox();
            this.aznRadioB = new System.Windows.Forms.RadioButton();
            this.litrRadioB = new System.Windows.Forms.RadioButton();
            this.oilsumLbl = new System.Windows.Forms.Label();
            this.oilsumtxtB = new System.Windows.Forms.TextBox();
            this.pricetxtB = new System.Windows.Forms.TextBox();
            this.moneytxtB = new System.Windows.Forms.TextBox();
            this.litretxtB = new System.Windows.Forms.TextBox();
            this.benzinLbl = new System.Windows.Forms.Label();
            this.minimarketLbl = new System.Windows.Forms.Label();
            this.productcheckedlistB = new System.Windows.Forms.CheckedListBox();
            this.productpriceLbl = new System.Windows.Forms.Label();
            this.amoutLbl = new System.Windows.Forms.Label();
            this.hotdogamoutmaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.hamburgeramoutmaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.freeamoutmaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.cocacolaamoutmaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.hotdogpricemaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.hamburgerpricemaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.freepricemaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.cocacolapricemaskedtxtB = new System.Windows.Forms.MaskedTextBox();
            this.marketsumLbl = new System.Windows.Forms.Label();
            this.marketsumtxtB = new System.Windows.Forms.TextBox();
            this.sumtxtB = new System.Windows.Forms.TextBox();
            this.sumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oilLbl
            // 
            this.oilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilLbl.Location = new System.Drawing.Point(12, 84);
            this.oilLbl.Name = "oilLbl";
            this.oilLbl.Size = new System.Drawing.Size(122, 38);
            this.oilLbl.TabIndex = 0;
            this.oilLbl.Text = "Oil";
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(12, 147);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(100, 42);
            this.priceLbl.TabIndex = 1;
            this.priceLbl.Text = "Price";
            // 
            // oilcomboB
            // 
            this.oilcomboB.BackColor = System.Drawing.Color.White;
            this.oilcomboB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilcomboB.FormattingEnabled = true;
            this.oilcomboB.Location = new System.Drawing.Point(155, 84);
            this.oilcomboB.Name = "oilcomboB";
            this.oilcomboB.Size = new System.Drawing.Size(169, 39);
            this.oilcomboB.TabIndex = 2;
            this.oilcomboB.SelectedIndexChanged += new System.EventHandler(this.oilcomboB_SelectedIndexChanged);
            // 
            // aznRadioB
            // 
            this.aznRadioB.AutoSize = true;
            this.aznRadioB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aznRadioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aznRadioB.Location = new System.Drawing.Point(12, 201);
            this.aznRadioB.Name = "aznRadioB";
            this.aznRadioB.Size = new System.Drawing.Size(118, 35);
            this.aznRadioB.TabIndex = 5;
            this.aznRadioB.TabStop = true;
            this.aznRadioB.Text = "Money";
            this.aznRadioB.UseVisualStyleBackColor = false;
            this.aznRadioB.CheckedChanged += new System.EventHandler(this.aznRadioB_CheckedChanged);
            // 
            // litrRadioB
            // 
            this.litrRadioB.AutoSize = true;
            this.litrRadioB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.litrRadioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litrRadioB.Location = new System.Drawing.Point(12, 267);
            this.litrRadioB.Name = "litrRadioB";
            this.litrRadioB.Size = new System.Drawing.Size(90, 35);
            this.litrRadioB.TabIndex = 7;
            this.litrRadioB.TabStop = true;
            this.litrRadioB.Text = "Litre";
            this.litrRadioB.UseVisualStyleBackColor = false;
            // 
            // oilsumLbl
            // 
            this.oilsumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilsumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.oilsumLbl.Location = new System.Drawing.Point(6, 325);
            this.oilsumLbl.Name = "oilsumLbl";
            this.oilsumLbl.Size = new System.Drawing.Size(128, 58);
            this.oilsumLbl.TabIndex = 11;
            this.oilsumLbl.Text = "Oil Sum";
            // 
            // oilsumtxtB
            // 
            this.oilsumtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilsumtxtB.Location = new System.Drawing.Point(155, 325);
            this.oilsumtxtB.Name = "oilsumtxtB";
            this.oilsumtxtB.Size = new System.Drawing.Size(169, 40);
            this.oilsumtxtB.TabIndex = 12;
            // 
            // pricetxtB
            // 
            this.pricetxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxtB.Location = new System.Drawing.Point(155, 147);
            this.pricetxtB.Name = "pricetxtB";
            this.pricetxtB.Size = new System.Drawing.Size(169, 40);
            this.pricetxtB.TabIndex = 13;
            // 
            // moneytxtB
            // 
            this.moneytxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytxtB.Location = new System.Drawing.Point(155, 198);
            this.moneytxtB.Name = "moneytxtB";
            this.moneytxtB.Size = new System.Drawing.Size(100, 38);
            this.moneytxtB.TabIndex = 14;
            this.moneytxtB.TextChanged += new System.EventHandler(this.moneytxtB_TextChanged);
            // 
            // litretxtB
            // 
            this.litretxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litretxtB.Location = new System.Drawing.Point(155, 264);
            this.litretxtB.Name = "litretxtB";
            this.litretxtB.Size = new System.Drawing.Size(100, 38);
            this.litretxtB.TabIndex = 15;
            this.litretxtB.TextChanged += new System.EventHandler(this.litretxtB_TextChanged);
            // 
            // benzinLbl
            // 
            this.benzinLbl.BackColor = System.Drawing.Color.Lime;
            this.benzinLbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benzinLbl.Location = new System.Drawing.Point(12, 9);
            this.benzinLbl.Name = "benzinLbl";
            this.benzinLbl.Size = new System.Drawing.Size(309, 63);
            this.benzinLbl.TabIndex = 16;
            this.benzinLbl.Text = "Oil";
            this.benzinLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimarketLbl
            // 
            this.minimarketLbl.BackColor = System.Drawing.Color.Lime;
            this.minimarketLbl.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimarketLbl.Location = new System.Drawing.Point(442, 9);
            this.minimarketLbl.Name = "minimarketLbl";
            this.minimarketLbl.Size = new System.Drawing.Size(478, 63);
            this.minimarketLbl.TabIndex = 17;
            this.minimarketLbl.Text = "Mini - Market";
            this.minimarketLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productcheckedlistB
            // 
            this.productcheckedlistB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productcheckedlistB.FormattingEnabled = true;
            this.productcheckedlistB.Location = new System.Drawing.Point(449, 137);
            this.productcheckedlistB.Name = "productcheckedlistB";
            this.productcheckedlistB.Size = new System.Drawing.Size(219, 136);
            this.productcheckedlistB.TabIndex = 18;
            // 
            // productpriceLbl
            // 
            this.productpriceLbl.BackColor = System.Drawing.Color.Silver;
            this.productpriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productpriceLbl.Location = new System.Drawing.Point(683, 87);
            this.productpriceLbl.Name = "productpriceLbl";
            this.productpriceLbl.Size = new System.Drawing.Size(111, 39);
            this.productpriceLbl.TabIndex = 19;
            this.productpriceLbl.Text = "Price";
            // 
            // amoutLbl
            // 
            this.amoutLbl.BackColor = System.Drawing.Color.Silver;
            this.amoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amoutLbl.Location = new System.Drawing.Point(820, 87);
            this.amoutLbl.Name = "amoutLbl";
            this.amoutLbl.Size = new System.Drawing.Size(100, 39);
            this.amoutLbl.TabIndex = 20;
            this.amoutLbl.Text = "Amout";
            // 
            // hotdogamoutmaskedtxtB
            // 
            this.hotdogamoutmaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogamoutmaskedtxtB.Location = new System.Drawing.Point(820, 137);
            this.hotdogamoutmaskedtxtB.Name = "hotdogamoutmaskedtxtB";
            this.hotdogamoutmaskedtxtB.Size = new System.Drawing.Size(100, 29);
            this.hotdogamoutmaskedtxtB.TabIndex = 25;
            // 
            // hamburgeramoutmaskedtxtB
            // 
            this.hamburgeramoutmaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgeramoutmaskedtxtB.Location = new System.Drawing.Point(820, 172);
            this.hamburgeramoutmaskedtxtB.Name = "hamburgeramoutmaskedtxtB";
            this.hamburgeramoutmaskedtxtB.Size = new System.Drawing.Size(100, 29);
            this.hamburgeramoutmaskedtxtB.TabIndex = 26;
            // 
            // freeamoutmaskedtxtB
            // 
            this.freeamoutmaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeamoutmaskedtxtB.Location = new System.Drawing.Point(820, 207);
            this.freeamoutmaskedtxtB.Name = "freeamoutmaskedtxtB";
            this.freeamoutmaskedtxtB.Size = new System.Drawing.Size(100, 29);
            this.freeamoutmaskedtxtB.TabIndex = 27;
            // 
            // cocacolaamoutmaskedtxtB
            // 
            this.cocacolaamoutmaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocacolaamoutmaskedtxtB.Location = new System.Drawing.Point(820, 242);
            this.cocacolaamoutmaskedtxtB.Name = "cocacolaamoutmaskedtxtB";
            this.cocacolaamoutmaskedtxtB.Size = new System.Drawing.Size(100, 29);
            this.cocacolaamoutmaskedtxtB.TabIndex = 28;
            // 
            // hotdogpricemaskedtxtB
            // 
            this.hotdogpricemaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogpricemaskedtxtB.Location = new System.Drawing.Point(683, 137);
            this.hotdogpricemaskedtxtB.Name = "hotdogpricemaskedtxtB";
            this.hotdogpricemaskedtxtB.Size = new System.Drawing.Size(111, 29);
            this.hotdogpricemaskedtxtB.TabIndex = 29;
            this.hotdogpricemaskedtxtB.Text = "4.00";
            this.hotdogpricemaskedtxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hamburgerpricemaskedtxtB
            // 
            this.hamburgerpricemaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerpricemaskedtxtB.Location = new System.Drawing.Point(683, 172);
            this.hamburgerpricemaskedtxtB.Name = "hamburgerpricemaskedtxtB";
            this.hamburgerpricemaskedtxtB.Size = new System.Drawing.Size(111, 29);
            this.hamburgerpricemaskedtxtB.TabIndex = 30;
            this.hamburgerpricemaskedtxtB.Text = "5.40";
            this.hamburgerpricemaskedtxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // freepricemaskedtxtB
            // 
            this.freepricemaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freepricemaskedtxtB.Location = new System.Drawing.Point(683, 207);
            this.freepricemaskedtxtB.Name = "freepricemaskedtxtB";
            this.freepricemaskedtxtB.Size = new System.Drawing.Size(111, 29);
            this.freepricemaskedtxtB.TabIndex = 31;
            this.freepricemaskedtxtB.Text = "7.20";
            this.freepricemaskedtxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cocacolapricemaskedtxtB
            // 
            this.cocacolapricemaskedtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocacolapricemaskedtxtB.Location = new System.Drawing.Point(683, 242);
            this.cocacolapricemaskedtxtB.Name = "cocacolapricemaskedtxtB";
            this.cocacolapricemaskedtxtB.Size = new System.Drawing.Size(111, 29);
            this.cocacolapricemaskedtxtB.TabIndex = 32;
            this.cocacolapricemaskedtxtB.Text = "4.40";
            this.cocacolapricemaskedtxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // marketsumLbl
            // 
            this.marketsumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketsumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.marketsumLbl.Location = new System.Drawing.Point(443, 322);
            this.marketsumLbl.Name = "marketsumLbl";
            this.marketsumLbl.Size = new System.Drawing.Size(196, 43);
            this.marketsumLbl.TabIndex = 33;
            this.marketsumLbl.Text = "Market Sum";
            // 
            // marketsumtxtB
            // 
            this.marketsumtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marketsumtxtB.Location = new System.Drawing.Point(683, 319);
            this.marketsumtxtB.Name = "marketsumtxtB";
            this.marketsumtxtB.Size = new System.Drawing.Size(169, 38);
            this.marketsumtxtB.TabIndex = 34;
            // 
            // sumtxtB
            // 
            this.sumtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumtxtB.Location = new System.Drawing.Point(449, 424);
            this.sumtxtB.Name = "sumtxtB";
            this.sumtxtB.Size = new System.Drawing.Size(173, 49);
            this.sumtxtB.TabIndex = 36;
            // 
            // sumLbl
            // 
            this.sumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sumLbl.Location = new System.Drawing.Point(272, 424);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(171, 49);
            this.sumLbl.TabIndex = 37;
            this.sumLbl.Text = "Sum";
            this.sumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 503);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.sumtxtB);
            this.Controls.Add(this.marketsumtxtB);
            this.Controls.Add(this.marketsumLbl);
            this.Controls.Add(this.cocacolapricemaskedtxtB);
            this.Controls.Add(this.freepricemaskedtxtB);
            this.Controls.Add(this.hamburgerpricemaskedtxtB);
            this.Controls.Add(this.hotdogpricemaskedtxtB);
            this.Controls.Add(this.cocacolaamoutmaskedtxtB);
            this.Controls.Add(this.freeamoutmaskedtxtB);
            this.Controls.Add(this.hamburgeramoutmaskedtxtB);
            this.Controls.Add(this.hotdogamoutmaskedtxtB);
            this.Controls.Add(this.amoutLbl);
            this.Controls.Add(this.productpriceLbl);
            this.Controls.Add(this.productcheckedlistB);
            this.Controls.Add(this.minimarketLbl);
            this.Controls.Add(this.benzinLbl);
            this.Controls.Add(this.litretxtB);
            this.Controls.Add(this.moneytxtB);
            this.Controls.Add(this.pricetxtB);
            this.Controls.Add(this.oilsumtxtB);
            this.Controls.Add(this.oilsumLbl);
            this.Controls.Add(this.litrRadioB);
            this.Controls.Add(this.aznRadioB);
            this.Controls.Add(this.oilcomboB);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.oilLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oilLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.ComboBox oilcomboB;
        private System.Windows.Forms.RadioButton aznRadioB;
        private System.Windows.Forms.RadioButton litrRadioB;
        private System.Windows.Forms.Label oilsumLbl;
        private System.Windows.Forms.TextBox oilsumtxtB;
        private System.Windows.Forms.TextBox pricetxtB;
        private System.Windows.Forms.TextBox moneytxtB;
        private System.Windows.Forms.TextBox litretxtB;
        private System.Windows.Forms.Label benzinLbl;
        private System.Windows.Forms.Label minimarketLbl;
        private System.Windows.Forms.CheckedListBox productcheckedlistB;
        private System.Windows.Forms.Label productpriceLbl;
        private System.Windows.Forms.Label amoutLbl;
        private System.Windows.Forms.MaskedTextBox hotdogamoutmaskedtxtB;
        private System.Windows.Forms.MaskedTextBox hamburgeramoutmaskedtxtB;
        private System.Windows.Forms.MaskedTextBox freeamoutmaskedtxtB;
        private System.Windows.Forms.MaskedTextBox cocacolaamoutmaskedtxtB;
        private System.Windows.Forms.MaskedTextBox hotdogpricemaskedtxtB;
        private System.Windows.Forms.MaskedTextBox hamburgerpricemaskedtxtB;
        private System.Windows.Forms.MaskedTextBox freepricemaskedtxtB;
        private System.Windows.Forms.MaskedTextBox cocacolapricemaskedtxtB;
        private System.Windows.Forms.Label marketsumLbl;
        private System.Windows.Forms.TextBox marketsumtxtB;
        private System.Windows.Forms.TextBox sumtxtB;
        private System.Windows.Forms.Label sumLbl;
    }
}

