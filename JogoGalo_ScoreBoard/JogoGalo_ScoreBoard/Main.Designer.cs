
namespace JogoGalo_ScoreBoard
{
    partial class JogoGalo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBtnEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripGame,
            this.scoreBoardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripGame
            // 
            this.menuStripGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripBtnNew,
            this.menuStripBtnEnd,
            this.menuStripExit});
            this.menuStripGame.Name = "menuStripGame";
            this.menuStripGame.Size = new System.Drawing.Size(50, 20);
            this.menuStripGame.Text = "Game";
            // 
            // menuStripBtnNew
            // 
            this.menuStripBtnNew.Name = "menuStripBtnNew";
            this.menuStripBtnNew.Size = new System.Drawing.Size(180, 22);
            this.menuStripBtnNew.Text = "New Game";
            this.menuStripBtnNew.Click += new System.EventHandler(this.menuStripBtnNew_Click);
            // 
            // menuStripBtnEnd
            // 
            this.menuStripBtnEnd.Name = "menuStripBtnEnd";
            this.menuStripBtnEnd.Size = new System.Drawing.Size(180, 22);
            this.menuStripBtnEnd.Text = "End Game";
            this.menuStripBtnEnd.Click += new System.EventHandler(this.menuStripBtnEnd_Click);
            // 
            // menuStripExit
            // 
            this.menuStripExit.Name = "menuStripExit";
            this.menuStripExit.Size = new System.Drawing.Size(180, 22);
            this.menuStripExit.Text = "Exit";
            this.menuStripExit.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // scoreBoardToolStripMenuItem
            // 
            this.scoreBoardToolStripMenuItem.Name = "scoreBoardToolStripMenuItem";
            this.scoreBoardToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.scoreBoardToolStripMenuItem.Text = "ScoreBoard";
            // 
            // JogoGalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Nova Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JogoGalo";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripGame;
        private System.Windows.Forms.ToolStripMenuItem menuStripBtnNew;
        private System.Windows.Forms.ToolStripMenuItem menuStripBtnEnd;
        private System.Windows.Forms.ToolStripMenuItem menuStripExit;
        private System.Windows.Forms.ToolStripMenuItem scoreBoardToolStripMenuItem;
    }
}

