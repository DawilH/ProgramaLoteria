﻿namespace ProgramaLoteria
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
            this.txtloto1 = new System.Windows.Forms.TextBox();
            this.txtloto2 = new System.Windows.Forms.TextBox();
            this.txtloto3 = new System.Windows.Forms.TextBox();
            this.txtcantidad1 = new System.Windows.Forms.TextBox();
            this.txtcantidad2 = new System.Windows.Forms.TextBox();
            this.txtcantidad3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtloto1
            // 
            this.txtloto1.Location = new System.Drawing.Point(25, 143);
            this.txtloto1.Multiline = true;
            this.txtloto1.Name = "txtloto1";
            this.txtloto1.Size = new System.Drawing.Size(114, 30);
            this.txtloto1.TabIndex = 0;
            // 
            // txtloto2
            // 
            this.txtloto2.Location = new System.Drawing.Point(197, 143);
            this.txtloto2.Multiline = true;
            this.txtloto2.Name = "txtloto2";
            this.txtloto2.Size = new System.Drawing.Size(114, 30);
            this.txtloto2.TabIndex = 1;
            // 
            // txtloto3
            // 
            this.txtloto3.Location = new System.Drawing.Point(386, 143);
            this.txtloto3.Multiline = true;
            this.txtloto3.Name = "txtloto3";
            this.txtloto3.Size = new System.Drawing.Size(114, 30);
            this.txtloto3.TabIndex = 2;
            // 
            // txtcantidad1
            // 
            this.txtcantidad1.Location = new System.Drawing.Point(25, 291);
            this.txtcantidad1.Multiline = true;
            this.txtcantidad1.Name = "txtcantidad1";
            this.txtcantidad1.Size = new System.Drawing.Size(114, 30);
            this.txtcantidad1.TabIndex = 3;
            // 
            // txtcantidad2
            // 
            this.txtcantidad2.Location = new System.Drawing.Point(197, 291);
            this.txtcantidad2.Multiline = true;
            this.txtcantidad2.Name = "txtcantidad2";
            this.txtcantidad2.Size = new System.Drawing.Size(114, 30);
            this.txtcantidad2.TabIndex = 4;
            // 
            // txtcantidad3
            // 
            this.txtcantidad3.Location = new System.Drawing.Point(386, 291);
            this.txtcantidad3.Multiline = true;
            this.txtcantidad3.Name = "txtcantidad3";
            this.txtcantidad3.Size = new System.Drawing.Size(114, 30);
            this.txtcantidad3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(188, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOTERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "1er Loto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "2do Loto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "3er Loto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad 1er Loto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad 2do Loto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad 3er Loto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 530);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcantidad3);
            this.Controls.Add(this.txtcantidad2);
            this.Controls.Add(this.txtcantidad1);
            this.Controls.Add(this.txtloto3);
            this.Controls.Add(this.txtloto2);
            this.Controls.Add(this.txtloto1);
            this.Name = "Form1";
            this.Text = "Loteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtloto1;
        private System.Windows.Forms.TextBox txtloto2;
        private System.Windows.Forms.TextBox txtloto3;
        private System.Windows.Forms.TextBox txtcantidad1;
        private System.Windows.Forms.TextBox txtcantidad2;
        private System.Windows.Forms.TextBox txtcantidad3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

