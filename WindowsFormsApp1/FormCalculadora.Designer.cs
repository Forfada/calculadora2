
namespace WindowsFormsApp1
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPot = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.lblImparPar = new System.Windows.Forms.Label();
            this.lblCompara = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtn1.Location = new System.Drawing.Point(198, 101);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(450, 23);
            this.txtn1.TabIndex = 0;
            // 
            // txtn2
            // 
            this.txtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtn2.Location = new System.Drawing.Point(198, 187);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(450, 23);
            this.txtn2.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSomar.Location = new System.Drawing.Point(140, 327);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(96, 46);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSub.Location = new System.Drawing.Point(264, 327);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(96, 46);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "&Subtrair";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMulti.Location = new System.Drawing.Point(392, 326);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(96, 46);
            this.btnMulti.TabIndex = 4;
            this.btnMulti.Text = "&Multiplicar";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDiv.Location = new System.Drawing.Point(515, 327);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(96, 46);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "&Dividir";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPot
            // 
            this.btnPot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPot.Location = new System.Drawing.Point(636, 327);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(96, 46);
            this.btnPot.TabIndex = 8;
            this.btnPot.Text = "Potenciação";
            this.btnPot.UseVisualStyleBackColor = false;
            this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(455, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(581, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 46);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.bt7_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-37, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(870, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "_________________________________________________________________________________" +
    "________________________________________________________";
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSinal.Location = new System.Drawing.Point(417, 143);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(23, 25);
            this.lblSinal.TabIndex = 14;
            this.lblSinal.Text = "?";
            // 
            // lblResul
            // 
            this.lblResul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResul.Location = new System.Drawing.Point(347, 231);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(150, 49);
            this.lblResul.TabIndex = 15;
            this.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResul.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCompara
            // 
            this.btnCompara.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCompara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCompara.Location = new System.Drawing.Point(324, 392);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(96, 46);
            this.btnCompara.TabIndex = 17;
            this.btnCompara.Text = "Comparar";
            this.btnCompara.UseVisualStyleBackColor = false;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnParImpar.Location = new System.Drawing.Point(198, 392);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(96, 46);
            this.btnParImpar.TabIndex = 16;
            this.btnParImpar.Text = "Par ou Impar";
            this.btnParImpar.UseVisualStyleBackColor = false;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // lblImparPar
            // 
            this.lblImparPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImparPar.Location = new System.Drawing.Point(525, 231);
            this.lblImparPar.Name = "lblImparPar";
            this.lblImparPar.Size = new System.Drawing.Size(140, 49);
            this.lblImparPar.TabIndex = 18;
            this.lblImparPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompara
            // 
            this.lblCompara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCompara.Location = new System.Drawing.Point(198, 231);
            this.lblCompara.Name = "lblCompara";
            this.lblCompara.Size = new System.Drawing.Size(119, 49);
            this.lblCompara.TabIndex = 19;
            this.lblCompara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl3.Location = new System.Drawing.Point(671, 231);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(119, 49);
            this.lbl3.TabIndex = 20;
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblCompara);
            this.Controls.Add(this.lblImparPar);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPot);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnParImpar;
        private System.Windows.Forms.Label lblImparPar;
        private System.Windows.Forms.Label lblCompara;
        private System.Windows.Forms.Label lbl3;
    }
}

