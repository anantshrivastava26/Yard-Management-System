namespace YardManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxCoilId = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.crane = new System.Windows.Forms.PictureBox();
            this.checkBoxChangeImage = new System.Windows.Forms.CheckBox();
            this.labelCoilId = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crane)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCoilId
            // 
            resources.ApplyResources(this.textBoxCoilId, "textBoxCoilId");
            this.textBoxCoilId.Name = "textBoxCoilId";
            // 
            // textBoxLabel
            // 
            resources.ApplyResources(this.textBoxLabel, "textBoxLabel");
            this.textBoxLabel.Name = "textBoxLabel";
            // 
            // buttonGo
            // 
            resources.ApplyResources(this.buttonGo, "buttonGo");
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // crane
            // 
            this.crane.Image = global::YardManagement.Properties.Resources.pngegg;
            resources.ApplyResources(this.crane, "crane");
            this.crane.Name = "crane";
            this.crane.TabStop = false;
            // 
            // checkBoxChangeImage
            // 
            resources.ApplyResources(this.checkBoxChangeImage, "checkBoxChangeImage");
            this.checkBoxChangeImage.Name = "checkBoxChangeImage";
            this.checkBoxChangeImage.UseVisualStyleBackColor = true;
            // 
            // labelCoilId
            // 
            resources.ApplyResources(this.labelCoilId, "labelCoilId");
            this.labelCoilId.Name = "labelCoilId";
            // 
            // labelLabel
            // 
            resources.ApplyResources(this.labelLabel, "labelLabel");
            this.labelLabel.Name = "labelLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.labelCoilId);
            this.Controls.Add(this.checkBoxChangeImage);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxCoilId);
            this.Controls.Add(this.crane);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.crane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
