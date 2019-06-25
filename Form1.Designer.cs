namespace Practicar_Herencias
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
            this.AgregarAlistbox = new System.Windows.Forms.Button();
            this.AgregarACmb = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AgregarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarAlistbox
            // 
            this.AgregarAlistbox.Location = new System.Drawing.Point(549, 253);
            this.AgregarAlistbox.Name = "AgregarAlistbox";
            this.AgregarAlistbox.Size = new System.Drawing.Size(112, 56);
            this.AgregarAlistbox.TabIndex = 0;
            this.AgregarAlistbox.Text = "AgregarAlistbox";
            this.AgregarAlistbox.UseVisualStyleBackColor = true;
            this.AgregarAlistbox.Click += new System.EventHandler(this.AgregarAlistbox_Click);
            // 
            // AgregarACmb
            // 
            this.AgregarACmb.Location = new System.Drawing.Point(549, 195);
            this.AgregarACmb.Name = "AgregarACmb";
            this.AgregarACmb.Size = new System.Drawing.Size(112, 52);
            this.AgregarACmb.TabIndex = 1;
            this.AgregarACmb.Text = "AgregarACmb";
            this.AgregarACmb.UseVisualStyleBackColor = true;
            this.AgregarACmb.Click += new System.EventHandler(this.AgregarACmb_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(528, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 204);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 160);
            this.listBox1.TabIndex = 3;
            // 
            // AgregarPersona
            // 
            this.AgregarPersona.Location = new System.Drawing.Point(571, 98);
            this.AgregarPersona.Name = "AgregarPersona";
            this.AgregarPersona.Size = new System.Drawing.Size(114, 54);
            this.AgregarPersona.TabIndex = 4;
            this.AgregarPersona.Text = "AgregarPersona";
            this.AgregarPersona.UseVisualStyleBackColor = true;
            this.AgregarPersona.Click += new System.EventHandler(this.AgregarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgregarPersona);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AgregarACmb);
            this.Controls.Add(this.AgregarAlistbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarAlistbox;
        private System.Windows.Forms.Button AgregarACmb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AgregarPersona;
    }
}

