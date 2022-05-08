namespace EDnevnik
{
    partial class Upisnica
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.grid_upisnica = new System.Windows.Forms.DataGridView();
            this.txt_upisnica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_upisnica)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(193, 173);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(64, 20);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(346, 173);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(64, 20);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(503, 173);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 20);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(193, 98);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(115, 21);
            this.cmb_godina.TabIndex = 3;
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(346, 98);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(115, 21);
            this.cmb_odeljenje.TabIndex = 4;
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(503, 98);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(115, 21);
            this.cmb_ucenik.TabIndex = 5;
            // 
            // grid_upisnica
            // 
            this.grid_upisnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_upisnica.Location = new System.Drawing.Point(42, 214);
            this.grid_upisnica.Name = "grid_upisnica";
            this.grid_upisnica.Size = new System.Drawing.Size(719, 205);
            this.grid_upisnica.TabIndex = 6;
            // 
            // txt_upisnica
            // 
            this.txt_upisnica.Location = new System.Drawing.Point(42, 99);
            this.txt_upisnica.Name = "txt_upisnica";
            this.txt_upisnica.Size = new System.Drawing.Size(115, 20);
            this.txt_upisnica.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Odeljenje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ucenik";
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_upisnica);
            this.Controls.Add(this.grid_upisnica);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_godina);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Name = "Upisnica";
            this.Text = "Upisnica";
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_upisnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.DataGridView grid_upisnica;
        private System.Windows.Forms.TextBox txt_upisnica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}