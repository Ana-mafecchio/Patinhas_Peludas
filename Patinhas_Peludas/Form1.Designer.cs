namespace Patinhas_Peludas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNomedoGato = new System.Windows.Forms.Label();
            this.tbNomedogato = new System.Windows.Forms.TextBox();
            this.dgvTeladeRegistro = new System.Windows.Forms.DataGridView();
            this.tbNomedoAdotante = new System.Windows.Forms.TextBox();
            this.lbNomedoAdotante = new System.Windows.Forms.Label();
            this.btnSalvarRegistro = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbCastrado = new System.Windows.Forms.Label();
            this.cbConfirmarCastrado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeladeRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomedoGato
            // 
            this.lbNomedoGato.AutoSize = true;
            this.lbNomedoGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomedoGato.Location = new System.Drawing.Point(103, 39);
            this.lbNomedoGato.Name = "lbNomedoGato";
            this.lbNomedoGato.Size = new System.Drawing.Size(111, 18);
            this.lbNomedoGato.TabIndex = 0;
            this.lbNomedoGato.Text = "Nome do Gato:";
            this.lbNomedoGato.Click += new System.EventHandler(this.lbNomedoGato_Click);
            // 
            // tbNomedogato
            // 
            this.tbNomedogato.Location = new System.Drawing.Point(245, 40);
            this.tbNomedogato.Name = "tbNomedogato";
            this.tbNomedogato.Size = new System.Drawing.Size(293, 20);
            this.tbNomedogato.TabIndex = 1;
            // 
            // dgvTeladeRegistro
            // 
            this.dgvTeladeRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeladeRegistro.Location = new System.Drawing.Point(106, 199);
            this.dgvTeladeRegistro.Name = "dgvTeladeRegistro";
            this.dgvTeladeRegistro.Size = new System.Drawing.Size(571, 208);
            this.dgvTeladeRegistro.TabIndex = 2;
            // 
            // tbNomedoAdotante
            // 
            this.tbNomedoAdotante.Location = new System.Drawing.Point(245, 78);
            this.tbNomedoAdotante.Name = "tbNomedoAdotante";
            this.tbNomedoAdotante.Size = new System.Drawing.Size(293, 20);
            this.tbNomedoAdotante.TabIndex = 3;
            // 
            // lbNomedoAdotante
            // 
            this.lbNomedoAdotante.AutoSize = true;
            this.lbNomedoAdotante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomedoAdotante.Location = new System.Drawing.Point(103, 78);
            this.lbNomedoAdotante.Name = "lbNomedoAdotante";
            this.lbNomedoAdotante.Size = new System.Drawing.Size(136, 18);
            this.lbNomedoAdotante.TabIndex = 4;
            this.lbNomedoAdotante.Text = "Nome do Adotante:";
            // 
            // btnSalvarRegistro
            // 
            this.btnSalvarRegistro.Location = new System.Drawing.Point(106, 149);
            this.btnSalvarRegistro.Name = "btnSalvarRegistro";
            this.btnSalvarRegistro.Size = new System.Drawing.Size(143, 34);
            this.btnSalvarRegistro.TabIndex = 5;
            this.btnSalvarRegistro.Text = "Salvar";
            this.btnSalvarRegistro.UseVisualStyleBackColor = true;
            this.btnSalvarRegistro.Click += new System.EventHandler(this.btnSalvarRegistro_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(255, 149);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(141, 34);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(403, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 34);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(544, 149);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 34);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lbCastrado
            // 
            this.lbCastrado.AutoSize = true;
            this.lbCastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCastrado.Location = new System.Drawing.Point(103, 123);
            this.lbCastrado.Name = "lbCastrado";
            this.lbCastrado.Size = new System.Drawing.Size(73, 18);
            this.lbCastrado.TabIndex = 10;
            this.lbCastrado.Text = "Castrado:";
            // 
            // cbConfirmarCastrado
            // 
            this.cbConfirmarCastrado.FormattingEnabled = true;
            this.cbConfirmarCastrado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbConfirmarCastrado.Location = new System.Drawing.Point(245, 120);
            this.cbConfirmarCastrado.Name = "cbConfirmarCastrado";
            this.cbConfirmarCastrado.Size = new System.Drawing.Size(293, 21);
            this.cbConfirmarCastrado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbConfirmarCastrado);
            this.Controls.Add(this.lbCastrado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalvarRegistro);
            this.Controls.Add(this.lbNomedoAdotante);
            this.Controls.Add(this.tbNomedoAdotante);
            this.Controls.Add(this.dgvTeladeRegistro);
            this.Controls.Add(this.tbNomedogato);
            this.Controls.Add(this.lbNomedoGato);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeladeRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomedoGato;
        private System.Windows.Forms.TextBox tbNomedogato;
        private System.Windows.Forms.DataGridView dgvTeladeRegistro;
        private System.Windows.Forms.TextBox tbNomedoAdotante;
        private System.Windows.Forms.Label lbNomedoAdotante;
        private System.Windows.Forms.Button btnSalvarRegistro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbCastrado;
        private System.Windows.Forms.ComboBox cbConfirmarCastrado;
    }
}

