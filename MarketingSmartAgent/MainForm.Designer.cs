namespace MarketingSmartAgent
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
      this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
      this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControlProducts
      // 
      this.gridControlProducts.Location = new System.Drawing.Point(12, 12);
      this.gridControlProducts.MainView = this.gridViewProducts;
      this.gridControlProducts.Name = "gridControlProducts";
      this.gridControlProducts.Size = new System.Drawing.Size(1169, 580);
      this.gridControlProducts.TabIndex = 0;
      this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
      // 
      // gridViewProducts
      // 
      this.gridViewProducts.GridControl = this.gridControlProducts;
      this.gridViewProducts.Name = "gridViewProducts";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1193, 604);
      this.Controls.Add(this.gridControlProducts);
      this.Name = "MainForm";
      ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControlProducts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
  }
}

