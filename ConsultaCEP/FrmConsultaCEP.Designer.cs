namespace ConsultaCEP
{
    partial class FrmConsultaCEP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCEP));
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCEP = new System.Windows.Forms.Label();
            this.grpBoxResultado = new System.Windows.Forms.GroupBox();
            this.txblogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbCEP = new System.Windows.Forms.MaskedTextBox();
            this.grpBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(123, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Image = global::ConsultaCEP.Properties.Resources.refresh;
            this.btnLimpar.Location = new System.Drawing.Point(372, 21);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(32, 30);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(405, 20);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 30);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCEP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCEP.Location = new System.Drawing.Point(15, 11);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 16);
            this.lblCEP.TabIndex = 3;
            this.lblCEP.Text = "CEP:";
            // 
            // grpBoxResultado
            // 
            this.grpBoxResultado.Controls.Add(this.txblogradouro);
            this.grpBoxResultado.Controls.Add(this.label4);
            this.grpBoxResultado.Controls.Add(this.txbBairro);
            this.grpBoxResultado.Controls.Add(this.label3);
            this.grpBoxResultado.Controls.Add(this.txbCidade);
            this.grpBoxResultado.Controls.Add(this.label2);
            this.grpBoxResultado.Controls.Add(this.txbEstado);
            this.grpBoxResultado.Controls.Add(this.label1);
            this.grpBoxResultado.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpBoxResultado.Location = new System.Drawing.Point(11, 66);
            this.grpBoxResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxResultado.Name = "grpBoxResultado";
            this.grpBoxResultado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxResultado.Size = new System.Drawing.Size(436, 137);
            this.grpBoxResultado.TabIndex = 5;
            this.grpBoxResultado.TabStop = false;
            this.grpBoxResultado.Text = "Endereço do CEP";
            // 
            // txblogradouro
            // 
            this.txblogradouro.BackColor = System.Drawing.Color.White;
            this.txblogradouro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txblogradouro.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txblogradouro.Location = new System.Drawing.Point(216, 90);
            this.txblogradouro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txblogradouro.Name = "txblogradouro";
            this.txblogradouro.ReadOnly = true;
            this.txblogradouro.Size = new System.Drawing.Size(216, 20);
            this.txblogradouro.TabIndex = 6;
            this.txblogradouro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txblogradouro_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(216, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logradouro:";
            // 
            // txbBairro
            // 
            this.txbBairro.BackColor = System.Drawing.Color.White;
            this.txbBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBairro.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbBairro.Location = new System.Drawing.Point(4, 90);
            this.txbBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.ReadOnly = true;
            this.txbBairro.Size = new System.Drawing.Size(205, 20);
            this.txbBairro.TabIndex = 5;
            this.txbBairro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbBairro_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bairro:";
            // 
            // txbCidade
            // 
            this.txbCidade.BackColor = System.Drawing.Color.White;
            this.txbCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCidade.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCidade.Location = new System.Drawing.Point(4, 40);
            this.txbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.ReadOnly = true;
            this.txbCidade.Size = new System.Drawing.Size(181, 20);
            this.txbCidade.TabIndex = 3;
            this.txbCidade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbCidade_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cidade:";
            // 
            // txbEstado
            // 
            this.txbEstado.BackColor = System.Drawing.Color.White;
            this.txbEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEstado.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEstado.Location = new System.Drawing.Point(216, 40);
            this.txbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.ReadOnly = true;
            this.txbEstado.Size = new System.Drawing.Size(139, 20);
            this.txbEstado.TabIndex = 4;
            this.txbEstado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbEstado_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(216, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado:";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = global::ConsultaCEP.Properties.Resources.stop_sign;
            this.btnSair.Location = new System.Drawing.Point(405, 20);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::ConsultaCEP.Properties.Resources.endereco;
            this.btnBuscar.Location = new System.Drawing.Point(123, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(15, 30);
            this.txbCEP.Mask = "00000-999";
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(100, 20);
            this.txbCEP.TabIndex = 0;
            this.txbCEP.Click += new System.EventHandler(this.txbCEP_Click);
            this.txbCEP.TextChanged += new System.EventHandler(this.txbCEP_TextChanged);
            this.txbCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCEP_KeyDown);
            // 
            // FrmConsultaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(459, 216);
            this.ControlBox = false;
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpBoxResultado);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConsultaCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta CEP";
            this.grpBoxResultado.ResumeLayout(false);
            this.grpBoxResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.GroupBox grpBoxResultado;
        private System.Windows.Forms.TextBox txblogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txbCEP;
    }
}
