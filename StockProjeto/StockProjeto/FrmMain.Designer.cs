
namespace StockProjeto
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblProducts = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnList = new System.Windows.Forms.ToolStripButton();
            this.toolStripLblStock = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnListStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMoveStock = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Arial Nova Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblProducts,
            this.toolStripSeparator1,
            this.toolStripBtnAdd,
            this.toolStripBtnEdit,
            this.toolStripBtnDelete,
            this.toolStripBtnList,
            this.toolStripLblStock,
            this.toolStripSeparator2,
            this.toolStripBtnListStock,
            this.toolStripBtnMoveStock});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(884, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblProducts
            // 
            this.toolStripLblProducts.Name = "toolStripLblProducts";
            this.toolStripLblProducts.Size = new System.Drawing.Size(73, 24);
            this.toolStripLblProducts.Text = "Produtos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnAdd
            // 
            this.toolStripBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAdd.Image")));
            this.toolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdd.Name = "toolStripBtnAdd";
            this.toolStripBtnAdd.Size = new System.Drawing.Size(93, 24);
            this.toolStripBtnAdd.Text = "Adicionar";
            this.toolStripBtnAdd.Click += new System.EventHandler(this.toolStripBtnAdd_Click);
            // 
            // toolStripBtnEdit
            // 
            this.toolStripBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEdit.Image")));
            this.toolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEdit.Name = "toolStripBtnEdit";
            this.toolStripBtnEdit.Size = new System.Drawing.Size(68, 24);
            this.toolStripBtnEdit.Text = "Editar";
            this.toolStripBtnEdit.Click += new System.EventHandler(this.toolStripBtnEdit_Click);
            // 
            // toolStripBtnDelete
            // 
            this.toolStripBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDelete.Image")));
            this.toolStripBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDelete.Name = "toolStripBtnDelete";
            this.toolStripBtnDelete.Size = new System.Drawing.Size(82, 24);
            this.toolStripBtnDelete.Text = "Eliminar";
            this.toolStripBtnDelete.Click += new System.EventHandler(this.toolStripBtnDelete_Click);
            // 
            // toolStripBtnList
            // 
            this.toolStripBtnList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnList.Image")));
            this.toolStripBtnList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnList.Name = "toolStripBtnList";
            this.toolStripBtnList.Size = new System.Drawing.Size(51, 24);
            this.toolStripBtnList.Text = "Ver";
            this.toolStripBtnList.Click += new System.EventHandler(this.toolStripBtnList_Click);
            // 
            // toolStripLblStock
            // 
            this.toolStripLblStock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLblStock.Name = "toolStripLblStock";
            this.toolStripLblStock.Size = new System.Drawing.Size(49, 24);
            this.toolStripLblStock.Text = "Stock";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnListStock
            // 
            this.toolStripBtnListStock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnListStock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnListStock.Image")));
            this.toolStripBtnListStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnListStock.Name = "toolStripBtnListStock";
            this.toolStripBtnListStock.Size = new System.Drawing.Size(51, 24);
            this.toolStripBtnListStock.Text = "Ver";
            this.toolStripBtnListStock.Click += new System.EventHandler(this.toolStripBtnListStock_Click);
            // 
            // toolStripBtnMoveStock
            // 
            this.toolStripBtnMoveStock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnMoveStock.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMoveStock.Image")));
            this.toolStripBtnMoveStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMoveStock.Name = "toolStripBtnMoveStock";
            this.toolStripBtnMoveStock.Size = new System.Drawing.Size(72, 24);
            this.toolStripBtnMoveStock.Text = "Mover";
            this.toolStripBtnMoveStock.Click += new System.EventHandler(this.toolStripBtnMoveStock_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Nova Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "FrmMain";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnList;
        private System.Windows.Forms.ToolStripButton toolStripBtnEdit;
        private System.Windows.Forms.ToolStripButton toolStripBtnDelete;
        private System.Windows.Forms.ToolStripButton toolStripBtnListStock;
        private System.Windows.Forms.ToolStripButton toolStripBtnMoveStock;
        private System.Windows.Forms.ToolStripLabel toolStripLblProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLblStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

