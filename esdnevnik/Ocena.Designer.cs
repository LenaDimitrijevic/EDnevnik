namespace EDnevnik
{
    partial class Ocena
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
            this.cmb_Godina = new System.Windows.Forms.ComboBox();
            this.cmb_Profesor = new System.Windows.Forms.ComboBox();
            this.cmb_Predmet = new System.Windows.Forms.ComboBox();
            this.cmb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_Ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_Ocena = new System.Windows.Forms.ComboBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.grid_Ocene = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Godina
            // 
            this.cmb_Godina.FormattingEnabled = true;
            this.cmb_Godina.Location = new System.Drawing.Point(37, 51);
            this.cmb_Godina.Name = "cmb_Godina";
            this.cmb_Godina.Size = new System.Drawing.Size(120, 21);
            this.cmb_Godina.TabIndex = 0;
            // 
            // cmb_Profesor
            // 
            this.cmb_Profesor.FormattingEnabled = true;
            this.cmb_Profesor.Location = new System.Drawing.Point(197, 51);
            this.cmb_Profesor.Name = "cmb_Profesor";
            this.cmb_Profesor.Size = new System.Drawing.Size(120, 21);
            this.cmb_Profesor.TabIndex = 1;
            // 
            // cmb_Predmet
            // 
            this.cmb_Predmet.FormattingEnabled = true;
            this.cmb_Predmet.Location = new System.Drawing.Point(356, 51);
            this.cmb_Predmet.Name = "cmb_Predmet";
            this.cmb_Predmet.Size = new System.Drawing.Size(120, 21);
            this.cmb_Predmet.TabIndex = 2;
            // 
            // cmb_Odeljenje
            // 
            this.cmb_Odeljenje.FormattingEnabled = true;
            this.cmb_Odeljenje.Location = new System.Drawing.Point(512, 51);
            this.cmb_Odeljenje.Name = "cmb_Odeljenje";
            this.cmb_Odeljenje.Size = new System.Drawing.Size(120, 21);
            this.cmb_Odeljenje.TabIndex = 3;
            // 
            // cmb_Ucenik
            // 
            this.cmb_Ucenik.FormattingEnabled = true;
            this.cmb_Ucenik.Location = new System.Drawing.Point(37, 103);
            this.cmb_Ucenik.Name = "cmb_Ucenik";
            this.cmb_Ucenik.Size = new System.Drawing.Size(120, 21);
            this.cmb_Ucenik.TabIndex = 4;
            // 
            // cmb_Ocena
            // 
            this.cmb_Ocena.FormattingEnabled = true;
            this.cmb_Ocena.Location = new System.Drawing.Point(197, 103);
            this.cmb_Ocena.Name = "cmb_Ocena";
            this.cmb_Ocena.Size = new System.Drawing.Size(120, 21);
            this.cmb_Ocena.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(356, 103);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(120, 20);
            this.txt_Id.TabIndex = 6;
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(512, 103);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(120, 20);
            this.Datum.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(681, 50);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(70, 20);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Dodaj";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(681, 76);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(70, 20);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Izmeni";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(681, 105);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(70, 20);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Brisi";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // grid_Ocene
            // 
            this.grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Ocene.Location = new System.Drawing.Point(25, 161);
            this.grid_Ocene.Name = "grid_Ocene";
            this.grid_Ocene.Size = new System.Drawing.Size(742, 255);
            this.grid_Ocene.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Godina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ucenik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ocena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Datum";
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_Ocene);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.cmb_Ocena);
            this.Controls.Add(this.cmb_Ucenik);
            this.Controls.Add(this.cmb_Odeljenje);
            this.Controls.Add(this.cmb_Predmet);
            this.Controls.Add(this.cmb_Profesor);
            this.Controls.Add(this.cmb_Godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Godina;
        private System.Windows.Forms.ComboBox cmb_Profesor;
        private System.Windows.Forms.ComboBox cmb_Predmet;
        private System.Windows.Forms.ComboBox cmb_Odeljenje;
        private System.Windows.Forms.ComboBox cmb_Ucenik;
        private System.Windows.Forms.ComboBox cmb_Ocena;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView grid_Ocene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}