namespace ListView
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
            this.lstvAlimento = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstvAlimento
            // 
            this.lstvAlimento.HideSelection = false;
            this.lstvAlimento.Location = new System.Drawing.Point(35, 12);
            this.lstvAlimento.Name = "lstvAlimento";
            this.lstvAlimento.Size = new System.Drawing.Size(440, 308);
            this.lstvAlimento.TabIndex = 0;
            this.lstvAlimento.UseCompatibleStateImageBehavior = false;
            this.lstvAlimento.SelectedIndexChanged += new System.EventHandler(this.lstvAlimento_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 494);
            this.Controls.Add(this.lstvAlimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvAlimento;
    }
}

