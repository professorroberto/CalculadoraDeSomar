namespace CalculadoraDeSomar
{
    partial class frmAdicao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSomar1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSomar2 = new System.Windows.Forms.TextBox();
            this.btnSOMAR = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO 1";
            // 
            // txtSomar1
            // 
            this.txtSomar1.Location = new System.Drawing.Point(81, 13);
            this.txtSomar1.Name = "txtSomar1";
            this.txtSomar1.Size = new System.Drawing.Size(92, 20);
            this.txtSomar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NÚMERO 2";
            // 
            // txtSomar2
            // 
            this.txtSomar2.Location = new System.Drawing.Point(81, 42);
            this.txtSomar2.Name = "txtSomar2";
            this.txtSomar2.Size = new System.Drawing.Size(91, 20);
            this.txtSomar2.TabIndex = 3;
            // 
            // btnSOMAR
            // 
            this.btnSOMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSOMAR.Location = new System.Drawing.Point(14, 71);
            this.btnSOMAR.Name = "btnSOMAR";
            this.btnSOMAR.Size = new System.Drawing.Size(157, 26);
            this.btnSOMAR.TabIndex = 4;
            this.btnSOMAR.Text = "+";
            this.btnSOMAR.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(29, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(124, 24);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "RESULTADO";
            // 
            // frmAdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 362);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSOMAR);
            this.Controls.Add(this.txtSomar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSomar1);
            this.Controls.Add(this.label1);
            this.Name = "frmAdicao";
            this.Text = "Adição";
            this.Load += new System.EventHandler(this.frmAdicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSomar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSomar2;
        private System.Windows.Forms.Button btnSOMAR;
        private System.Windows.Forms.Label lblResultado;
    }
}

