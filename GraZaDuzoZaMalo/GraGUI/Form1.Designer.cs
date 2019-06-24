namespace GraGUI
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
            this.components = new System.ComponentModel.Container();
            this.button_NowaGra = new System.Windows.Forms.Button();
            this.groupBox_Losuj = new System.Windows.Forms.GroupBox();
            this.button_Losuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.label_Do = new System.Windows.Forms.Label();
            this.textBox_Od = new System.Windows.Forms.TextBox();
            this.label_Od = new System.Windows.Forms.Label();
            this.button_Przerwij = new System.Windows.Forms.Button();
            this.button_Historia = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Sprawdz = new System.Windows.Forms.Button();
            this.label_Zaczynajmy = new System.Windows.Forms.Label();
            this.textBox_Propozycja = new System.Windows.Forms.TextBox();
            this.groupBox_Podsumowanie = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Wylosowana = new System.Windows.Forms.Label();
            this.label_Proby = new System.Windows.Forms.Label();
            this.label_CzasGry = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Losuj.SuspendLayout();
            this.groupBox_Podsumowanie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_NowaGra
            // 
            this.button_NowaGra.Location = new System.Drawing.Point(17, 16);
            this.button_NowaGra.Margin = new System.Windows.Forms.Padding(4);
            this.button_NowaGra.Name = "button_NowaGra";
            this.button_NowaGra.Size = new System.Drawing.Size(100, 28);
            this.button_NowaGra.TabIndex = 0;
            this.button_NowaGra.Text = "Nowa gra";
            this.button_NowaGra.UseVisualStyleBackColor = true;
            this.button_NowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBox_Losuj
            // 
            this.groupBox_Losuj.Controls.Add(this.button_Losuj);
            this.groupBox_Losuj.Controls.Add(this.textBoxDo);
            this.groupBox_Losuj.Controls.Add(this.label_Do);
            this.groupBox_Losuj.Controls.Add(this.textBox_Od);
            this.groupBox_Losuj.Controls.Add(this.label_Od);
            this.groupBox_Losuj.Location = new System.Drawing.Point(17, 64);
            this.groupBox_Losuj.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Losuj.Name = "groupBox_Losuj";
            this.groupBox_Losuj.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Losuj.Size = new System.Drawing.Size(403, 123);
            this.groupBox_Losuj.TabIndex = 1;
            this.groupBox_Losuj.TabStop = false;
            this.groupBox_Losuj.Text = "Losowanie";
            this.groupBox_Losuj.Visible = false;
            this.groupBox_Losuj.Enter += new System.EventHandler(this.groupBox_Losuj_Enter);
            // 
            // button_Losuj
            // 
            this.button_Losuj.Location = new System.Drawing.Point(276, 49);
            this.button_Losuj.Margin = new System.Windows.Forms.Padding(4);
            this.button_Losuj.Name = "button_Losuj";
            this.button_Losuj.Size = new System.Drawing.Size(100, 28);
            this.button_Losuj.TabIndex = 2;
            this.button_Losuj.Text = "Wylosuj";
            this.button_Losuj.UseVisualStyleBackColor = true;
            this.button_Losuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(109, 78);
            this.textBoxDo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(132, 22);
            this.textBoxDo.TabIndex = 3;
            // 
            // label_Do
            // 
            this.label_Do.AutoSize = true;
            this.label_Do.Location = new System.Drawing.Point(23, 81);
            this.label_Do.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Do.Name = "label_Do";
            this.label_Do.Size = new System.Drawing.Size(76, 17);
            this.label_Do.TabIndex = 2;
            this.label_Do.Text = "Zakres do:";
            // 
            // textBox_Od
            // 
            this.textBox_Od.Location = new System.Drawing.Point(109, 21);
            this.textBox_Od.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Od.Name = "textBox_Od";
            this.textBox_Od.Size = new System.Drawing.Size(132, 22);
            this.textBox_Od.TabIndex = 1;
            this.textBox_Od.TextChanged += new System.EventHandler(this.textBox_Od_TextChanged);
            // 
            // label_Od
            // 
            this.label_Od.AutoSize = true;
            this.label_Od.Location = new System.Drawing.Point(24, 25);
            this.label_Od.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Od.Name = "label_Od";
            this.label_Od.Size = new System.Drawing.Size(76, 17);
            this.label_Od.TabIndex = 0;
            this.label_Od.Text = "Zakres od:";
            // 
            // button_Przerwij
            // 
            this.button_Przerwij.Location = new System.Drawing.Point(273, 16);
            this.button_Przerwij.Name = "button_Przerwij";
            this.button_Przerwij.Size = new System.Drawing.Size(120, 27);
            this.button_Przerwij.TabIndex = 2;
            this.button_Przerwij.Text = "Przerwij";
            this.button_Przerwij.UseVisualStyleBackColor = true;
            this.button_Przerwij.Click += new System.EventHandler(this.button_Przerwij_Click);
            // 
            // button_Historia
            // 
            this.button_Historia.Location = new System.Drawing.Point(16, 474);
            this.button_Historia.Name = "button_Historia";
            this.button_Historia.Size = new System.Drawing.Size(100, 35);
            this.button_Historia.TabIndex = 4;
            this.button_Historia.Text = "Historia Gry";
            this.button_Historia.UseVisualStyleBackColor = true;
            this.button_Historia.Click += new System.EventHandler(this.button_Historia_Click);
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(273, 474);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(120, 35);
            this.button_Info.TabIndex = 5;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Sprawdz
            // 
            this.button_Sprawdz.Location = new System.Drawing.Point(265, 51);
            this.button_Sprawdz.Name = "button_Sprawdz";
            this.button_Sprawdz.Size = new System.Drawing.Size(120, 27);
            this.button_Sprawdz.TabIndex = 6;
            this.button_Sprawdz.Text = "Sprawdź";
            this.button_Sprawdz.UseVisualStyleBackColor = true;
            this.button_Sprawdz.Click += new System.EventHandler(this.button_Sprawdz_Click);
            // 
            // label_Zaczynajmy
            // 
            this.label_Zaczynajmy.AutoSize = true;
            this.label_Zaczynajmy.Location = new System.Drawing.Point(6, 18);
            this.label_Zaczynajmy.Name = "label_Zaczynajmy";
            this.label_Zaczynajmy.Size = new System.Drawing.Size(213, 17);
            this.label_Zaczynajmy.TabIndex = 8;
            this.label_Zaczynajmy.Text = "Wylosowano liczbę. Zaczynajmy!";
            // 
            // textBox_Propozycja
            // 
            this.textBox_Propozycja.Location = new System.Drawing.Point(9, 56);
            this.textBox_Propozycja.Name = "textBox_Propozycja";
            this.textBox_Propozycja.Size = new System.Drawing.Size(159, 22);
            this.textBox_Propozycja.TabIndex = 9;
            // 
            // groupBox_Podsumowanie
            // 
            this.groupBox_Podsumowanie.Controls.Add(this.label5);
            this.groupBox_Podsumowanie.Controls.Add(this.label4);
            this.groupBox_Podsumowanie.Controls.Add(this.label3);
            this.groupBox_Podsumowanie.Controls.Add(this.label_Wylosowana);
            this.groupBox_Podsumowanie.Controls.Add(this.label_Proby);
            this.groupBox_Podsumowanie.Controls.Add(this.label_CzasGry);
            this.groupBox_Podsumowanie.Location = new System.Drawing.Point(17, 332);
            this.groupBox_Podsumowanie.Name = "groupBox_Podsumowanie";
            this.groupBox_Podsumowanie.Size = new System.Drawing.Size(403, 136);
            this.groupBox_Podsumowanie.TabIndex = 10;
            this.groupBox_Podsumowanie.TabStop = false;
            this.groupBox_Podsumowanie.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label_Wylosowana
            // 
            this.label_Wylosowana.AutoSize = true;
            this.label_Wylosowana.Location = new System.Drawing.Point(40, 102);
            this.label_Wylosowana.Name = "label_Wylosowana";
            this.label_Wylosowana.Size = new System.Drawing.Size(131, 17);
            this.label_Wylosowana.TabIndex = 2;
            this.label_Wylosowana.Text = "Wylosowana liczba:";
            // 
            // label_Proby
            // 
            this.label_Proby.AutoSize = true;
            this.label_Proby.Location = new System.Drawing.Point(40, 63);
            this.label_Proby.Name = "label_Proby";
            this.label_Proby.Size = new System.Drawing.Size(86, 17);
            this.label_Proby.TabIndex = 1;
            this.label_Proby.Text = "Liczba prób:";
            // 
            // label_CzasGry
            // 
            this.label_CzasGry.AutoSize = true;
            this.label_CzasGry.Location = new System.Drawing.Point(40, 18);
            this.label_CzasGry.Name = "label_CzasGry";
            this.label_CzasGry.Size = new System.Drawing.Size(111, 17);
            this.label_CzasGry.TabIndex = 0;
            this.label_CzasGry.Text = "Czas Twojej gry:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Propozycja);
            this.groupBox1.Controls.Add(this.label_Zaczynajmy);
            this.groupBox1.Controls.Add(this.button_Sprawdz);
            this.groupBox1.Location = new System.Drawing.Point(17, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Podsumowanie);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button_Historia);
            this.Controls.Add(this.button_Przerwij);
            this.Controls.Add(this.groupBox_Losuj);
            this.Controls.Add(this.button_NowaGra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Losuj.ResumeLayout(false);
            this.groupBox_Losuj.PerformLayout();
            this.groupBox_Podsumowanie.ResumeLayout(false);
            this.groupBox_Podsumowanie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NowaGra;
        private System.Windows.Forms.GroupBox groupBox_Losuj;
        private System.Windows.Forms.Button button_Losuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label label_Do;
        private System.Windows.Forms.TextBox textBox_Od;
        private System.Windows.Forms.Label label_Od;
        private System.Windows.Forms.Button button_Przerwij;
        private System.Windows.Forms.Button button_Historia;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_Sprawdz;
        private System.Windows.Forms.Label label_Zaczynajmy;
        private System.Windows.Forms.TextBox textBox_Propozycja;
        private System.Windows.Forms.GroupBox groupBox_Podsumowanie;
        private System.Windows.Forms.Label label_Wylosowana;
        private System.Windows.Forms.Label label_Proby;
        private System.Windows.Forms.Label label_CzasGry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

