using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStore.Form.Production
{
    public partial class Statistic : DevExpress.XtraEditors.XtraForm
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerStoreDataSet.StatisticProduct' table. You can move, or remove it, as needed.
            this.statisticProductTableAdapter.Fill(this.computerStoreDataSet.StatisticProduct);
            

        }
    }
}