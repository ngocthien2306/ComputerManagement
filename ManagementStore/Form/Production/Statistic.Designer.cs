
namespace ManagementStore.Form.Production
{
    partial class Statistic
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.statisticProductTableAdapter = new ManagementStore.ComputerStoreDataSetTableAdapters.StatisticProductTableAdapter();
            this.statisticProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerStoreDataSet = new ManagementStore.ComputerStoreDataSet();
            this.chartControlProduct = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.statisticProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticProductTableAdapter
            // 
            this.statisticProductTableAdapter.ClearBeforeFill = true;
            // 
            // statisticProductBindingSource
            // 
            this.statisticProductBindingSource.DataMember = "StatisticProduct";
            this.statisticProductBindingSource.DataSource = this.computerStoreDataSet;
            this.statisticProductBindingSource.Position = 0;
            // 
            // computerStoreDataSet
            // 
            this.computerStoreDataSet.DataSetName = "ComputerStoreDataSet";
            this.computerStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartControlProduct
            // 
            this.chartControlProduct.DataAdapter = this.statisticProductTableAdapter;
            this.chartControlProduct.DataSource = this.statisticProductBindingSource;
            xyDiagram1.AxisX.Title.Text = "Amount Product";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Day";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlProduct.Diagram = xyDiagram1;
            this.chartControlProduct.Legend.Name = "Default Legend";
            this.chartControlProduct.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlProduct.Location = new System.Drawing.Point(12, 13);
            this.chartControlProduct.Name = "chartControlProduct";
            this.chartControlProduct.SeriesDataMember = "CreatedAt";
            this.chartControlProduct.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlProduct.SeriesTemplate.ArgumentDataMember = "CreatedAt";
            this.chartControlProduct.SeriesTemplate.SeriesColorizer = null;
            this.chartControlProduct.SeriesTemplate.SeriesDataMember = "CreatedAt";
            this.chartControlProduct.SeriesTemplate.ValueDataMembersSerializable = "Amount";
            this.chartControlProduct.Size = new System.Drawing.Size(751, 630);
            this.chartControlProduct.TabIndex = 0;
            chartTitle1.Text = "Statistic Production";
            this.chartControlProduct.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 658);
            this.Controls.Add(this.chartControlProduct);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComputerStoreDataSetTableAdapters.StatisticProductTableAdapter statisticProductTableAdapter;
        private ComputerStoreDataSet computerStoreDataSet;
        private System.Windows.Forms.BindingSource statisticProductBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControlProduct;
    }
}