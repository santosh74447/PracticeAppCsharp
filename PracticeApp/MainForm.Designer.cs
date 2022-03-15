
namespace PracticeApp
{
    partial class MainForm
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
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPRegisterUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPViewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExistingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerUserToolStripMenuItem,
            this.viewUserToolStripMenuItem,
            this.sPRegisterUserToolStripMenuItem,
            this.sPViewUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.updateExistingUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.registerUserToolStripMenuItem.Text = "Register User";
            // 
            // viewUserToolStripMenuItem
            // 
            this.viewUserToolStripMenuItem.Name = "viewUserToolStripMenuItem";
            this.viewUserToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.viewUserToolStripMenuItem.Text = "View User";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            // 
            // updateExistingUserToolStripMenuItem
            // 
            this.updateExistingUserToolStripMenuItem.Name = "updateExistingUserToolStripMenuItem";
            this.updateExistingUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.updateExistingUserToolStripMenuItem.Text = "Update Existing User";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // sPRegisterUserToolStripMenuItem
            // 
            this.sPRegisterUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem1,
            this.updateExistingUserToolStripMenuItem1,
            this.deleteExistingUserToolStripMenuItem});
            this.sPRegisterUserToolStripMenuItem.Name = "sPRegisterUserToolStripMenuItem";
            this.sPRegisterUserToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.sPRegisterUserToolStripMenuItem.Text = "SP Register User";
            // 
            // sPViewUserToolStripMenuItem
            // 
            this.sPViewUserToolStripMenuItem.Name = "sPViewUserToolStripMenuItem";
            this.sPViewUserToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.sPViewUserToolStripMenuItem.Text = "SP View User";
            // 
            // addNewUserToolStripMenuItem1
            // 
            this.addNewUserToolStripMenuItem1.Name = "addNewUserToolStripMenuItem1";
            this.addNewUserToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.addNewUserToolStripMenuItem1.Text = "Add New User";
            // 
            // updateExistingUserToolStripMenuItem1
            // 
            this.updateExistingUserToolStripMenuItem1.Name = "updateExistingUserToolStripMenuItem1";
            this.updateExistingUserToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.updateExistingUserToolStripMenuItem1.Text = "Update Existing User";
            // 
            // deleteExistingUserToolStripMenuItem
            // 
            this.deleteExistingUserToolStripMenuItem.Name = "deleteExistingUserToolStripMenuItem";
            this.deleteExistingUserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deleteExistingUserToolStripMenuItem.Text = "Delete Existing User";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sPRegisterUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateExistingUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteExistingUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sPViewUserToolStripMenuItem;
    }
}