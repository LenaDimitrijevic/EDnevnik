namespace EDnevnik
{
    partial class Osoba
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(279, 63);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(242, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(279, 89);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(242, 20);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(279, 115);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(242, 20);
            this.txt_prezime.TabIndex = 2;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(279, 141);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(242, 20);
            this.txt_adresa.TabIndex = 3;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Location = new System.Drawing.Point(279, 167);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(242, 20);
            this.txt_jmbg.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(279, 193);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(242, 20);
            this.txt_email.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(279, 219);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(242, 20);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Location = new System.Drawing.Point(279, 245);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(242, 20);
            this.txt_uloga.TabIndex = 7;
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(150, 330);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(74, 23);
            this.btn_first.TabIndex = 8;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(230, 330);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(74, 23);
            this.btn_prev.TabIndex = 9;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(310, 330);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(74, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(390, 330);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(74, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(470, 330);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(550, 330);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(74, 23);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(630, 330);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(74, 23);
            this.btn_last.TabIndex = 14;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "JMBG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lozinka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Uloga";
            // 
            // Osoba
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
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
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

