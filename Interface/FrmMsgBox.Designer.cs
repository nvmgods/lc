
namespace RavenDevLauncher.Interface
{
    partial class FrmMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMsgBox));
            this.HeadLine = new System.Windows.Forms.Label();
            this.MessageForm = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadLine
            // 
            resources.ApplyResources(this.HeadLine, "HeadLine");
            this.HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.HeadLine.ForeColor = System.Drawing.Color.Coral;
            this.HeadLine.Name = "HeadLine";
            // 
            // MessageForm
            // 
            this.MessageForm.BackColor = System.Drawing.Color.Transparent;
            this.MessageForm.ForeColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.MessageForm, "MessageForm");
            this.MessageForm.Name = "MessageForm";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmMsgBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RavenDevLauncher.Properties.Resources.msg_box;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MessageForm);
            this.Controls.Add(this.HeadLine);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMsgBox";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label HeadLine;
        private System.Windows.Forms.Label MessageForm;
        private System.Windows.Forms.Button btnOK;
    }
}