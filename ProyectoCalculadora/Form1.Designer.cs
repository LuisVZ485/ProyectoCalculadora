
namespace ProyectoCalculadora
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
            this.cajaResultado = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaResultado
            // 
            this.cajaResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cajaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaResultado.Location = new System.Drawing.Point(64, 64);
            this.cajaResultado.Name = "cajaResultado";
            this.cajaResultado.Size = new System.Drawing.Size(269, 31);
            this.cajaResultado.TabIndex = 0;
            this.cajaResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(64, 45);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(35, 13);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "label1";
            this.lblHistorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 389);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.cajaResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaResultado;
        private System.Windows.Forms.Label lblHistorial;
    }
}

