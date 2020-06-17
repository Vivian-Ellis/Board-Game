namespace Game
{
    partial class Form1
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
            this.type = new System.Windows.Forms.Label();
            this.pvp = new System.Windows.Forms.RadioButton();
            this.pvc = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPvPGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPvCGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.position = new System.Windows.Forms.ToolStripTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Player1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Player2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentTurn = new System.Windows.Forms.Label();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(12, 39);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(146, 20);
            this.type.TabIndex = 2;
            this.type.Text = "Choose game type:";
            // 
            // pvp
            // 
            this.pvp.AutoSize = true;
            this.pvp.Location = new System.Drawing.Point(12, 85);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(100, 17);
            this.pvp.TabIndex = 1;
            this.pvp.TabStop = true;
            this.pvp.Text = "Player vs Player";
            this.pvp.UseVisualStyleBackColor = true;
            // 
            // pvc
            // 
            this.pvc.AutoSize = true;
            this.pvc.Location = new System.Drawing.Point(12, 62);
            this.pvc.Name = "pvc";
            this.pvc.Size = new System.Drawing.Size(116, 17);
            this.pvc.TabIndex = 0;
            this.pvc.TabStop = true;
            this.pvc.Text = "Player vs Computer";
            this.pvc.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.position});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPvPGameToolStripMenuItem,
            this.newPvCGameToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // newPvPGameToolStripMenuItem
            // 
            this.newPvPGameToolStripMenuItem.Name = "newPvPGameToolStripMenuItem";
            this.newPvPGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.newPvPGameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newPvPGameToolStripMenuItem.Text = "New PvP Game";
            this.newPvPGameToolStripMenuItem.Click += new System.EventHandler(this.newPvPGameToolStripMenuItem_Click);
            // 
            // newPvCGameToolStripMenuItem
            // 
            this.newPvCGameToolStripMenuItem.Name = "newPvCGameToolStripMenuItem";
            this.newPvCGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.newPvCGameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newPvCGameToolStripMenuItem.Text = "New PvC Game";
            this.newPvCGameToolStripMenuItem.Click += new System.EventHandler(this.newPvCGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // position
            // 
            this.position.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.position.BackColor = System.Drawing.SystemColors.Control;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(100, 23);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(16, 108);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 300);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Flip Coin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FlipCoin);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Player1,
            this.Player2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.SystemColors.Control;
            this.Player1.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(54, 17);
            this.Player1.Text = "Player 1: ";
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.SystemColors.Control;
            this.Player2.Margin = new System.Windows.Forms.Padding(130, 3, 0, 2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(54, 17);
            this.Player2.Text = "Player 2: ";
            // 
            // currentTurn
            // 
            this.currentTurn.AutoSize = true;
            this.currentTurn.Location = new System.Drawing.Point(316, 46);
            this.currentTurn.Name = "currentTurn";
            this.currentTurn.Size = new System.Drawing.Size(0, 13);
            this.currentTurn.TabIndex = 8;
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(488, 470);
            this.Controls.Add(this.currentTurn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pvp);
            this.Controls.Add(this.pvc);
            this.Controls.Add(this.type);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.RadioButton pvp;
        private System.Windows.Forms.RadioButton pvc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPvPGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPvCGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripTextBox position;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Player1;
        private System.Windows.Forms.ToolStripStatusLabel Player2;
        private System.Windows.Forms.Label currentTurn;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

