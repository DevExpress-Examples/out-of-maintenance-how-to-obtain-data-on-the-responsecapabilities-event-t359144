namespace ResponseCapabilitiesHandler {
    partial class Form1 {
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
            DevExpress.XtraMap.ImageLayer imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.WmsDataProvider wmsDataProvider1 = new DevExpress.XtraMap.WmsDataProvider();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            wmsDataProvider1.ServerUri = "INSERT_YOUR_SERVER_URI";
            imageLayer1.DataProvider = wmsDataProvider1;
            imageLayer1.Name = "WmsImageLayer";
            this.mapControl.Layers.Add(imageLayer1);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(700, 700);
            this.mapControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 710);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapControl);
            this.Name = "Form1";
            this.Text = "WmsDataProvider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private System.Windows.Forms.Label label1;
    }
}

