
namespace Задача5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mat_i = new System.Windows.Forms.TextBox();
            this.bel_i = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bel_d = new System.Windows.Forms.TextBox();
            this.mat_d = new System.Windows.Forms.TextBox();
            this.ezik = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.profil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оценки от изпитите:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "БЕЛ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Математика";
            // 
            // mat_i
            // 
            this.mat_i.Location = new System.Drawing.Point(149, 92);
            this.mat_i.Name = "mat_i";
            this.mat_i.Size = new System.Drawing.Size(51, 22);
            this.mat_i.TabIndex = 3;
            // 
            // bel_i
            // 
            this.bel_i.Location = new System.Drawing.Point(149, 59);
            this.bel_i.Name = "bel_i";
            this.bel_i.Size = new System.Drawing.Size(51, 22);
            this.bel_i.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изчисли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вашият бал е:";
            // 
            // bal
            // 
            this.bal.AutoSize = true;
            this.bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bal.ForeColor = System.Drawing.Color.Red;
            this.bal.Location = new System.Drawing.Point(163, 171);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(0, 32);
            this.bal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Оценки от дипломата:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "БЕЛ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Математика";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Чужд език";
            // 
            // bel_d
            // 
            this.bel_d.Location = new System.Drawing.Point(402, 62);
            this.bel_d.Name = "bel_d";
            this.bel_d.Size = new System.Drawing.Size(63, 22);
            this.bel_d.TabIndex = 12;
            // 
            // mat_d
            // 
            this.mat_d.Location = new System.Drawing.Point(402, 90);
            this.mat_d.Name = "mat_d";
            this.mat_d.Size = new System.Drawing.Size(63, 22);
            this.mat_d.TabIndex = 13;
            // 
            // ezik
            // 
            this.ezik.Location = new System.Drawing.Point(402, 118);
            this.ezik.Name = "ezik";
            this.ezik.Size = new System.Drawing.Size(63, 22);
            this.ezik.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Класирани сте в профил:";
            // 
            // profil
            // 
            this.profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profil.ForeColor = System.Drawing.Color.Red;
            this.profil.Location = new System.Drawing.Point(57, 210);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(408, 36);
            this.profil.TabIndex = 16;
            this.profil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(523, 288);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ezik);
            this.Controls.Add(this.mat_d);
            this.Controls.Add(this.bel_d);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bel_i);
            this.Controls.Add(this.mat_i);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 335);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(541, 335);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Класиране";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mat_i;
        private System.Windows.Forms.TextBox bel_i;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bel_d;
        private System.Windows.Forms.TextBox mat_d;
        private System.Windows.Forms.TextBox ezik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label profil;
    }
}

