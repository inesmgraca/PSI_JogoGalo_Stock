
namespace StockProjeto
{
    partial class FrmMoveStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoveStock));
            this.btnMoveStock = new System.Windows.Forms.Button();
            this.txtQtMov = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmbBoxCodigo = new System.Windows.Forms.ComboBox();
            this.rdBtnAddStock = new System.Windows.Forms.RadioButton();
            this.rdBtnRemoveStock = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoveStock
            // 
            this.btnMoveStock.Location = new System.Drawing.Point(315, 349);
            this.btnMoveStock.Name = "btnMoveStock";
            this.btnMoveStock.Size = new System.Drawing.Size(85, 30);
            this.btnMoveStock.TabIndex = 9;
            this.btnMoveStock.Text = "Adicionar";
            this.btnMoveStock.UseVisualStyleBackColor = true;
            this.btnMoveStock.Click += new System.EventHandler(this.btnMoveStock_Click);
            // 
            // txtQtMov
            // 
            this.txtQtMov.Location = new System.Drawing.Point(50, 185);
            this.txtQtMov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQtMov.Name = "txtQtMov";
            this.txtQtMov.Size = new System.Drawing.Size(350, 27);
            this.txtQtMov.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(50, 150);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(207, 20);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Quantidade de stock movido";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(50, 50);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(141, 20);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código do Produto";
            // 
            // cmbBoxCodigo
            // 
            this.cmbBoxCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCodigo.FormattingEnabled = true;
            this.cmbBoxCodigo.Location = new System.Drawing.Point(50, 84);
            this.cmbBoxCodigo.Name = "cmbBoxCodigo";
            this.cmbBoxCodigo.Size = new System.Drawing.Size(350, 28);
            this.cmbBoxCodigo.TabIndex = 10;
            // 
            // rdBtnAddStock
            // 
            this.rdBtnAddStock.AutoSize = true;
            this.rdBtnAddStock.Checked = true;
            this.rdBtnAddStock.Location = new System.Drawing.Point(100, 285);
            this.rdBtnAddStock.Name = "rdBtnAddStock";
            this.rdBtnAddStock.Size = new System.Drawing.Size(104, 24);
            this.rdBtnAddStock.TabIndex = 11;
            this.rdBtnAddStock.TabStop = true;
            this.rdBtnAddStock.Text = "Adicionado";
            this.rdBtnAddStock.UseVisualStyleBackColor = true;
            // 
            // rdBtnRemoveStock
            // 
            this.rdBtnRemoveStock.AutoSize = true;
            this.rdBtnRemoveStock.Location = new System.Drawing.Point(250, 285);
            this.rdBtnRemoveStock.Name = "rdBtnRemoveStock";
            this.rdBtnRemoveStock.Size = new System.Drawing.Size(96, 24);
            this.rdBtnRemoveStock.TabIndex = 12;
            this.rdBtnRemoveStock.Text = "Removido";
            this.rdBtnRemoveStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stock foi:";
            // 
            // FrmMoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBtnRemoveStock);
            this.Controls.Add(this.rdBtnAddStock);
            this.Controls.Add(this.cmbBoxCodigo);
            this.Controls.Add(this.btnMoveStock);
            this.Controls.Add(this.txtQtMov);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Arial Nova Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(475, 469);
            this.Name = "FrmMoveStock";
            this.Text = "Mover Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveStock;
        private System.Windows.Forms.TextBox txtQtMov;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbBoxCodigo;
        private System.Windows.Forms.RadioButton rdBtnAddStock;
        private System.Windows.Forms.RadioButton rdBtnRemoveStock;
        private System.Windows.Forms.Label label1;
    }
}