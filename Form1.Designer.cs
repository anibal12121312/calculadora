
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn_por = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btn_ce = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 296);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.Location = new System.Drawing.Point(102, 296);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(75, 23);
            this.btn_punto.TabIndex = 1;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = true;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(183, 296);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(75, 23);
            this.btn_igual.TabIndex = 2;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(277, 296);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 3;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 257);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 20);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(102, 256);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(183, 256);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_menos
            // 
            this.btn_menos.Location = new System.Drawing.Point(277, 256);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(73, 23);
            this.btn_menos.TabIndex = 7;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 218);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(102, 218);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(183, 218);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn_por
            // 
            this.btn_por.Location = new System.Drawing.Point(273, 218);
            this.btn_por.Name = "btn_por";
            this.btn_por.Size = new System.Drawing.Size(75, 22);
            this.btn_por.TabIndex = 11;
            this.btn_por.Text = "x";
            this.btn_por.UseVisualStyleBackColor = true;
            this.btn_por.Click += new System.EventHandler(this.btn_por_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 178);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(102, 178);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(183, 178);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(275, 178);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 15;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(183, 138);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(75, 23);
            this.btn_c.TabIndex = 16;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(275, 138);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 17;
            this.btn_remover.Text = "<=";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(2, 12);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(357, 97);
            this.pantalla.TabIndex = 19;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ce
            // 
            this.btn_ce.Location = new System.Drawing.Point(102, 138);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(75, 23);
            this.btn_ce.TabIndex = 20;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Location = new System.Drawing.Point(12, 138);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cerrar.TabIndex = 21;
            this.Btn_cerrar.Text = "Cerrar";
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 355);
            this.Controls.Add(this.Btn_cerrar);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn_por);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_punto);
            this.Controls.Add(this.btn0);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn_por;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button Btn_cerrar;
    }
}

