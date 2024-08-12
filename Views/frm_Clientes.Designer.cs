namespace Clientes_y_Proveedores
{
    partial class frm_Clientes
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
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombreCl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ApeCl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DireccCl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TelefCl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CeduCl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CorreoCl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(86, 531);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(173, 92);
            this.btn_Grabar.TabIndex = 0;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(298, 531);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(173, 92);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(517, 531);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(173, 92);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(742, 531);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(173, 92);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 25;
            this.lstClientes.Location = new System.Drawing.Point(771, 118);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(401, 379);
            this.lstClientes.TabIndex = 4;
            this.lstClientes.DoubleClick += new System.EventHandler(this.lstClientes_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de Clientes";
            // 
            // txt_NombreCl
            // 
            this.txt_NombreCl.Location = new System.Drawing.Point(86, 103);
            this.txt_NombreCl.Name = "txt_NombreCl";
            this.txt_NombreCl.Size = new System.Drawing.Size(295, 30);
            this.txt_NombreCl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido del Cliente";
            // 
            // txt_ApeCl
            // 
            this.txt_ApeCl.Location = new System.Drawing.Point(421, 103);
            this.txt_ApeCl.Name = "txt_ApeCl";
            this.txt_ApeCl.Size = new System.Drawing.Size(282, 30);
            this.txt_ApeCl.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dirección";
            // 
            // txt_DireccCl
            // 
            this.txt_DireccCl.Location = new System.Drawing.Point(86, 288);
            this.txt_DireccCl.Name = "txt_DireccCl";
            this.txt_DireccCl.Size = new System.Drawing.Size(617, 30);
            this.txt_DireccCl.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Teléfono";
            // 
            // txt_TelefCl
            // 
            this.txt_TelefCl.Location = new System.Drawing.Point(86, 199);
            this.txt_TelefCl.Name = "txt_TelefCl";
            this.txt_TelefCl.Size = new System.Drawing.Size(295, 30);
            this.txt_TelefCl.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cédula";
            // 
            // txt_CeduCl
            // 
            this.txt_CeduCl.Location = new System.Drawing.Point(421, 199);
            this.txt_CeduCl.Name = "txt_CeduCl";
            this.txt_CeduCl.Size = new System.Drawing.Size(282, 30);
            this.txt_CeduCl.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Correo";
            // 
            // txt_CorreoCl
            // 
            this.txt_CorreoCl.Location = new System.Drawing.Point(86, 386);
            this.txt_CorreoCl.Name = "txt_CorreoCl";
            this.txt_CorreoCl.Size = new System.Drawing.Size(617, 30);
            this.txt_CorreoCl.TabIndex = 17;
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.txt_CorreoCl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CeduCl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TelefCl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DireccCl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ApeCl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NombreCl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Grabar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frm_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombreCl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ApeCl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DireccCl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TelefCl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CeduCl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CorreoCl;
    }
}

