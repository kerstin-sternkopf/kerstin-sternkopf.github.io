namespace DataEditor
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
            this.addBtn = new System.Windows.Forms.Button();
            this.offersBox = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savingTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.volumeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dimensionsTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startsDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endsDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.copyFromClipboardBtn = new System.Windows.Forms.Button();
            this.removeImageBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.extrasTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.publishBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.partsTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(119, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Neues Angebot";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // offersBox
            // 
            this.offersBox.FormattingEnabled = true;
            this.offersBox.IntegralHeight = false;
            this.offersBox.Items.AddRange(new object[] {
            "Reisprofi",
            "Mess and Go"});
            this.offersBox.Location = new System.Drawing.Point(12, 41);
            this.offersBox.Name = "offersBox";
            this.offersBox.Size = new System.Drawing.Size(119, 221);
            this.offersBox.TabIndex = 3;
            this.offersBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(12, 268);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(119, 23);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Angebot löschen";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(6, 134);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(170, 20);
            this.nameTxt.TabIndex = 6;
            this.nameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTxt_KeyPress);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(6, 173);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(170, 20);
            this.priceTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preis:";
            // 
            // savingTxt
            // 
            this.savingTxt.Location = new System.Drawing.Point(182, 173);
            this.savingTxt.Name = "savingTxt";
            this.savingTxt.Size = new System.Drawing.Size(132, 20);
            this.savingTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geld gespart (optional):";
            // 
            // volumeTxt
            // 
            this.volumeTxt.Location = new System.Drawing.Point(6, 212);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(170, 20);
            this.volumeTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Volumen z.B. \"3l, 2l\" (optional):";
            // 
            // dimensionsTxt
            // 
            this.dimensionsTxt.Location = new System.Drawing.Point(182, 212);
            this.dimensionsTxt.Name = "dimensionsTxt";
            this.dimensionsTxt.Size = new System.Drawing.Size(279, 20);
            this.dimensionsTxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maße z.B. \"2x 3x4x2cm\" (optional):";
            // 
            // startsDate
            // 
            this.startsDate.CustomFormat = "dd.MM.yyyy";
            this.startsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startsDate.Location = new System.Drawing.Point(6, 251);
            this.startsDate.Name = "startsDate";
            this.startsDate.Size = new System.Drawing.Size(170, 20);
            this.startsDate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Beginn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ende:";
            // 
            // endsDate
            // 
            this.endsDate.CustomFormat = "dd.MM.yyyy";
            this.endsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endsDate.Location = new System.Drawing.Point(182, 251);
            this.endsDate.Name = "endsDate";
            this.endsDate.Size = new System.Drawing.Size(279, 20);
            this.endsDate.TabIndex = 17;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Location = new System.Drawing.Point(6, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(83, 83);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bild:";
            // 
            // copyFromClipboardBtn
            // 
            this.copyFromClipboardBtn.Location = new System.Drawing.Point(94, 32);
            this.copyFromClipboardBtn.Name = "copyFromClipboardBtn";
            this.copyFromClipboardBtn.Size = new System.Drawing.Size(120, 52);
            this.copyFromClipboardBtn.TabIndex = 21;
            this.copyFromClipboardBtn.Text = "Bild von Zwischenablage einfügen";
            this.copyFromClipboardBtn.UseVisualStyleBackColor = true;
            this.copyFromClipboardBtn.Click += new System.EventHandler(this.copyFromClipboardBtn_Click);
            // 
            // removeImageBtn
            // 
            this.removeImageBtn.Location = new System.Drawing.Point(94, 90);
            this.removeImageBtn.Name = "removeImageBtn";
            this.removeImageBtn.Size = new System.Drawing.Size(119, 23);
            this.removeImageBtn.TabIndex = 22;
            this.removeImageBtn.Text = "Bild entfernen";
            this.removeImageBtn.UseVisualStyleBackColor = true;
            this.removeImageBtn.Click += new System.EventHandler(this.removeImageBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Teile z.B. \"3\" (optional):";
            // 
            // extrasTxt
            // 
            this.extrasTxt.Location = new System.Drawing.Point(182, 134);
            this.extrasTxt.Name = "extrasTxt";
            this.extrasTxt.Size = new System.Drawing.Size(278, 20);
            this.extrasTxt.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Extras z.B. \"inkl. Rezeptideen\" (optional):";
            // 
            // publishBtn
            // 
            this.publishBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.publishBtn.Location = new System.Drawing.Point(403, 302);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(201, 23);
            this.publishBtn.TabIndex = 28;
            this.publishBtn.Text = "Speichern und Veröffentlichen";
            this.publishBtn.UseVisualStyleBackColor = true;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.partsTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.extrasTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.priceTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.savingTxt);
            this.groupBox1.Controls.Add(this.removeImageBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.copyFromClipboardBtn);
            this.groupBox1.Controls.Add(this.volumeTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.dimensionsTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.startsDate);
            this.groupBox1.Controls.Add(this.endsDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(137, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 279);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Angebot bearbeiten";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(319, 302);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Speichern";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // partsTxt
            // 
            this.partsTxt.Location = new System.Drawing.Point(320, 173);
            this.partsTxt.Name = "partsTxt";
            this.partsTxt.Size = new System.Drawing.Size(141, 20);
            this.partsTxt.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 337);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.publishBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.offersBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angebotseditor für Tupperware";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox offersBox;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox savingTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox volumeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dimensionsTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startsDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker endsDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button copyFromClipboardBtn;
        private System.Windows.Forms.Button removeImageBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox extrasTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox partsTxt;
    }
}

