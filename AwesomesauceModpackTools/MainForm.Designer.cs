namespace AwesomesauceModpackTools {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ManageModsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageModsButton
            // 
            this.ManageModsButton.Location = new System.Drawing.Point(12, 12);
            this.ManageModsButton.Name = "ManageModsButton";
            this.ManageModsButton.Size = new System.Drawing.Size(116, 23);
            this.ManageModsButton.TabIndex = 0;
            this.ManageModsButton.Text = "Manage Mods";
            this.ManageModsButton.UseVisualStyleBackColor = true;
            this.ManageModsButton.Click += new System.EventHandler(this.ManageModsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 303);
            this.Controls.Add(this.ManageModsButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesomesauce Modpack Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageModsButton;
    }
}