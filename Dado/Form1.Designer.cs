namespace Dado
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLanzarX10 = new System.Windows.Forms.Button();
            this.btnLanzarX100 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnSuma2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.AutoSize = true;
            this.btnLanzar.Location = new System.Drawing.Point(12, 12);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(107, 30);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(133, 14);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(120, 301);
            this.txtResultado.TabIndex = 1;
            // 
            // btnLanzarX10
            // 
            this.btnLanzarX10.AutoSize = true;
            this.btnLanzarX10.Location = new System.Drawing.Point(12, 48);
            this.btnLanzarX10.Name = "btnLanzarX10";
            this.btnLanzarX10.Size = new System.Drawing.Size(107, 30);
            this.btnLanzarX10.TabIndex = 2;
            this.btnLanzarX10.Text = "Lanzar x10";
            this.btnLanzarX10.UseVisualStyleBackColor = true;
            this.btnLanzarX10.Click += new System.EventHandler(this.btnLanzarX10_Click_1);
            // 
            // btnLanzarX100
            // 
            this.btnLanzarX100.AutoSize = true;
            this.btnLanzarX100.Location = new System.Drawing.Point(12, 84);
            this.btnLanzarX100.Name = "btnLanzarX100";
            this.btnLanzarX100.Size = new System.Drawing.Size(107, 30);
            this.btnLanzarX100.TabIndex = 3;
            this.btnLanzarX100.Text = "Lanzar x100";
            this.btnLanzarX100.UseVisualStyleBackColor = true;
            this.btnLanzarX100.Click += new System.EventHandler(this.btnLanzarX100_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Location = new System.Drawing.Point(12, 120);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(107, 30);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "1 x 2 x 100";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnSuma2
            // 
            this.btnSuma2.AutoSize = true;
            this.btnSuma2.Location = new System.Drawing.Point(12, 156);
            this.btnSuma2.Name = "btnSuma2";
            this.btnSuma2.Size = new System.Drawing.Size(107, 30);
            this.btnSuma2.TabIndex = 5;
            this.btnSuma2.Text = "2D x 100";
            this.btnSuma2.UseVisualStyleBackColor = true;
            this.btnSuma2.Click += new System.EventHandler(this.btnSuma2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 327);
            this.Controls.Add(this.btnSuma2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnLanzarX100);
            this.Controls.Add(this.btnLanzarX10);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLanzar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLanzarX10;
        private System.Windows.Forms.Button btnLanzarX100;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnSuma2;
    }
}

