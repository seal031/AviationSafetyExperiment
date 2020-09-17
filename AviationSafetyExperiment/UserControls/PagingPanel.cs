using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace AviationSafetyExperiment.UserControls
{
    public partial class PagingPanel : UserControl
    {
        int pageSize = 10;     //每页显示行数
        public int nMax = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 1;   //当前页号
        int nCurrent = 0;      //当前记录行

        public IPagging pagging;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public PagingPanel()
        {
            InitializeComponent();
            ccb_pageSize.SelectedIndexChanged -= ccb_pageSize_SelectedIndexChanged;
            ccb_pageSize.SelectedIndex = 0;
            ccb_pageSize.SelectedIndexChanged += ccb_pageSize_SelectedIndexChanged;
        }

        private void btn_head_Click(object sender, EventArgs e)
        {
            pageCurrent = 1;
            paggingWork();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if (pageCurrent == 1)
            {
                MessageBoxEx.Show("已经是第一页了");
            }
            else
            {
                pageCurrent--;
            }
            paggingWork();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (nMax > 0)
            {
                if (pageCurrent == (nMax % pageSize > 0 ? nMax / pageSize + 1 : nMax / pageSize))
                {
                    MessageBoxEx.Show("已经是最后一页了");
                }
                else
                {
                    pageCurrent++;
                }
                paggingWork();
            }
        }

        private void btn_tail_Click(object sender, EventArgs e)
        {
            pageCurrent = nMax % pageSize > 0 ? nMax / pageSize + 1 : nMax / pageSize;
            paggingWork();
        }

        private void ccb_pageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = int.Parse(ccb_pageSize.SelectedItem.ToString());
            paggingWork();
        }

        private void paggingWork()
        {
            setDetail(nMax);
            pagging.doPagging(pageCurrent, pageSize);
        }

        public void setDetail(int nMax)
        {
            this.nMax = nMax;
            lbl_currentPage.Text = "第"+pageCurrent + "页";
            lbl_detail.Text = "共" + (nMax % pageSize > 0 ? nMax / pageSize + 1 : nMax / pageSize) + "页" + nMax + "行";
        }
    }
}
