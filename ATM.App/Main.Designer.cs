
namespace ATM.App
{
    partial class Main
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
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnCardBalance = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCards = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.White;
            this.btnChangePass.Image = global::ATM.App.Properties.Resources._1371475973_document_edit;
            this.btnChangePass.Location = new System.Drawing.Point(147, 121);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(103, 93);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.White;
            this.btnTransactions.Image = global::ATM.App.Properties.Resources.list2;
            this.btnTransactions.Location = new System.Drawing.Point(12, 121);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(103, 93);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Recent Transactions";
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnCardBalance
            // 
            this.btnCardBalance.BackColor = System.Drawing.Color.White;
            this.btnCardBalance.Image = global::ATM.App.Properties.Resources.servicesCosts;
            this.btnCardBalance.Location = new System.Drawing.Point(147, 46);
            this.btnCardBalance.Name = "btnCardBalance";
            this.btnCardBalance.Size = new System.Drawing.Size(103, 73);
            this.btnCardBalance.TabIndex = 3;
            this.btnCardBalance.Text = "Card Balance";
            this.btnCardBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCardBalance.UseVisualStyleBackColor = false;
            this.btnCardBalance.Click += new System.EventHandler(this.btnCardBalance_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.White;
            this.btnTransfer.Image = global::ATM.App.Properties.Resources._1371476394_refresh_red;
            this.btnTransfer.Location = new System.Drawing.Point(12, 46);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(103, 73);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Trancfer";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnCards,
            this.btnSignOut});
            this.profileToolStripMenuItem.Image = global::ATM.App.Properties.Resources._1371476468_preferences_contact_list;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::ATM.App.Properties.Resources._1371475973_document_edit;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 26);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCards
            // 
            this.btnCards.Image = global::ATM.App.Properties.Resources._1370791030_credit_card;
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(197, 26);
            this.btnCards.Text = "My Credit Cards";
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::ATM.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(197, 26);
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 227);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnCardBalance);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnCards;
        private System.Windows.Forms.ToolStripMenuItem btnSignOut;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCardBalance;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnChangePass;
    }
}

