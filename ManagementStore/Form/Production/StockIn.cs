using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ManagementStore.Extensions;
using ManagementStore.Model;
using ManagementStore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStore.Form.Production
{
    public partial class StockIn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProductServices productServices = new ProductServices();
        WarehouseServices warehouseServices = new WarehouseServices();
        int storedId = 0;
        public StockIn()
        {
            InitializeComponent();
        }

        #region
        public void LoadOptionSearch()
        {
            string query = "";

            var categorys = productServices.GetListCategory();
            var warehouses = warehouseServices.GetListWarehouse();

            ccbWHSave.DataSource = warehouses;
            ccbWHSave.DisplayMember = "WHName";
            ccbWHSave.ValueMember = "WHCode";
            ccbWHSave.SelectedValue = 2;

            warehouses.Add(new WareHouse { WHId = 1, WHName = "All", Capacity = -1, WHCode = "All" });
            query = @"select * from[dbo].[GetListComCode](@GroupCode)";
            var brands = productServices.GetListData(query, new object[1] { "BRAS00" }, new string[1] { "@GroupCode" });
            var prices = productServices.GetListData(query, new object[1] { "PRIP00" }, new string[1] { "@GroupCode" });

            ccbCategory.DataSource = categorys;
            ccbCategory.DisplayMember = "Name";
            ccbCategory.ValueMember = "Id";
            ccbCategory.SelectedValue = 1002;

            ccbBrands.DataSource = brands;
            ccbBrands.DisplayMember = "Name";
            ccbBrands.ValueMember = "ID";
            ccbBrands.SelectedValue = "BRAS01";

            ccbPrice.DataSource = prices;
            ccbPrice.DisplayMember = "Name";
            ccbPrice.ValueMember = "ID";
            ccbPrice.SelectedValue = "PRIP01";

            ccbWarehouse.DataSource = warehouses;
            ccbWarehouse.DisplayMember = "WHName";
            ccbWarehouse.ValueMember = "WHCode";
            ccbWarehouse.SelectedValue = "All";

        }

        public DataTable GetListProduct()
        {
            // using function to select product data
            string query = @"select * from[dbo].[GetListProduct](@ProductName, @Brands, @Category, @Rams, @StartPrice, @EndPrice, @UserId, @WHCode)";
            string price = ccbPrice.SelectedValue.ToString();
            SearchExtensions.PriceOptionSearch(price);
            string[] arrParams = new string[8];
            arrParams[0] = "@ProductName";
            arrParams[1] = "@Brands";
            arrParams[2] = "@Category";
            arrParams[3] = "@Rams";
            arrParams[4] = "@StartPrice";
            arrParams[5] = "@EndPrice";
            arrParams[6] = "@UserId";
            arrParams[7] = "@WHCode";

            object[] arrParamsValue = new object[8];
            arrParamsValue[0] = txtInputPName.Text;
            arrParamsValue[1] = ccbBrands.Text == "All" ? "" : ccbBrands.SelectedValue.ToString();
            arrParamsValue[2] = ccbCategory.Text == "All" ? 0 : Convert.ToInt32(ccbCategory.SelectedValue.ToString());
            arrParamsValue[3] = "";
            arrParamsValue[4] = SearchExtensions.StartPrice;
            arrParamsValue[5] = SearchExtensions.EndPrice;
            arrParamsValue[6] = CurrentUser.AppUser.Id;
            arrParamsValue[7] = ccbWarehouse.Text == "All" ? "" : ccbWarehouse.SelectedValue.ToString();
            var products = productServices.GetListData(query, arrParamsValue, arrParams);
            return products;
        }
        #endregion

        private void StockIn_Load(object sender, EventArgs e)
        {
            LoadOptionSearch();

            btnUpdateWH.Enabled = false;

            gridControlProduct.DataSource = GetListProduct();
 

        }



        private void gridViewProduct_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //int selectedRows = gridViewProduct.GetSelectedRows()[0];

            //if (selectedRows >= 0)
            //{
            //    var cellValue = gridViewProduct.GetRowCellValue(selectedRows, "PId");
            //    txtInputProductId.Text = cellValue.ToString();
            //}
            
        }

        private void gridViewProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int[] selectedRows = gridViewProduct.GetSelectedRows();

            foreach(var hande in selectedRows)
            {
                if (hande >= 0)
                {
                    var PId = gridViewProduct.GetRowCellValue(hande, "PId");
                    var WHCode = gridViewProduct.GetRowCellValue(hande, "WHCode");
                    storedId = (int) gridViewProduct.GetRowCellValue(hande, "StoredId");
                    txtInputProductId.Text = PId.ToString();
                    ccbWHSave.SelectedValue = WHCode.ToString();
                }
            }
            btnUpdateWH.Enabled = true;
        }

        private void barBtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
        }

        private void btnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlProduct.DataSource = GetListProduct();

        }

        private void btnUpdateWH_ItemClick(object sender, ItemClickEventArgs e)
        {
            string wh = ccbWHSave.Text;
            if(wh != "")
            {
                int PId = Convert.ToInt32(txtInputProductId.Text);
                string WHCode = ccbWHSave.SelectedValue.ToString();
                int quantity = (int)numericQuantity.Value;
                var result = warehouseServices.UpdateItemStockInWareHouse(storedId, quantity, WHCode, PId, CurrentUser.AppUser.Id);
                if (result.Success)
                {
                    XtraMessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControlProduct.DataSource = GetListProduct();

                }
                else
                {
                    XtraMessageBox.Show(result.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Please select warehouse stock in item!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btnExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            string path = "production.xlsx";
            //gridViewProduct.Focused = false;
            gridViewProduct.ExportToXlsx(path);
            Process.Start(path);
        }

        private void btnExportPdf_ItemClick(object sender, ItemClickEventArgs e)
        {
            string path = "production.pdf";
            //gridViewProduct.Focused = false;
            gridViewProduct.ExportToPdf(path);
            Process.Start(path);
        }

        private void btnExportDocx_ItemClick(object sender, ItemClickEventArgs e)
        {
            string path = "production.docx";
            //gridViewProduct.Focused = false;
            gridViewProduct.ExportToDocx(path);
            Process.Start(path);
        }

        #region custom view grid
        private void gridViewProduct_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            //int dx = e.Bounds.Height;
            //Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Wheat, Color.FloralWhite, LinearGradientMode.Vertical);
            //Rectangle r = e.Bounds;
            ////Draw a 3D border
            //BorderPainter painter = BorderHelper.GetPainter(DevExpress.XtraEditors.Controls.BorderStyles.Style3D);
            //AppearanceObject borderAppearance = new AppearanceObject(e.Appearance);
            //borderAppearance.BorderColor = Color.DarkGray;
            //painter.DrawObject(new BorderObjectInfoArgs(e.Cache, borderAppearance, r));
            ////Fill the inner region of the cell
            //r.Inflate(-1, -1);
            //e.Cache.FillRectangle(brush, r);
            ////Draw a summary value
            //r.Inflate(-2, 0);
            //e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);
            ////Prevent default drawing of the cell
            //e.Handled = true;
        }
        #endregion

    }
}