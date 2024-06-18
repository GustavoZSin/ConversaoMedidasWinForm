namespace ProvaPOOII
{
    partial class ValorReferenciaFrm
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
            txbValorReferencia = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txbValorReferencia
            // 
            txbValorReferencia.BorderStyle = BorderStyle.FixedSingle;
            txbValorReferencia.Location = new Point(175, 46);
            txbValorReferencia.Name = "txbValorReferencia";
            txbValorReferencia.Size = new Size(134, 27);
            txbValorReferencia.TabIndex = 1;
            txbValorReferencia.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Valor Referência:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(189, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(49, 100);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ValorReferenciaFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 172);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txbValorReferencia);
            Controls.Add(label1);
            Name = "ValorReferenciaFrm";
            Text = "Valor Referência";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbValorReferencia;
        private Label label1;
        private Button btnCancelar;
        private Button btnOk;
    }
}