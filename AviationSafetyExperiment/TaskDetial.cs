using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    /// <summary>
    /// 显示任务详情组件
    /// </summary>
    public partial class TaskDetial : DevComponents.DotNetBar.Office2007Form
    {
        public int taskInfoId;
        private int maxRound;

        public TaskDetial(int taskInfoId)
        {
            InitializeComponent();
            this.taskInfoId = taskInfoId;
        }

        public void init()
        {
            tdbip.init(taskInfoId);
            trp.init(taskInfoId, readOnly: true);
            tlp.init(taskInfoId);
        }

        private void lbl_showHistory_Click(object sender, EventArgs e)
        {
            panel_history.Visible = true;
            maxRound = trp.getHistory();//显示第一轮，并返回总轮次
            if (maxRound > 0)
            {
                lbl_current.Text = "1/" + maxRound;
                btn_previous.Enabled = false;
                if (maxRound >= 1)
                {
                    btn_next.Enabled = true;
                }
                else
                {
                    btn_next.Enabled = false;
                }
            }
            else
            {
                lbl_current.Text = "尚无轮次";
                btn_next.Enabled = false;
                btn_previous.Enabled = false;
            }
        }

        private void ben_closeHistory_Click(object sender, EventArgs e)
        {
            panel_history.Visible = false;
            trp.init(taskInfoId, readOnly: true);//隐藏panel_history，同时恢复显示最新测试结果
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            int currentRound = trp.showPrevious();
            lbl_current.Text = currentRound + "/" + maxRound;
            if (currentRound >= maxRound)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
            if (currentRound <= 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int currentRound = trp.showNext();
            lbl_current.Text = currentRound + "/" + maxRound;
            if (currentRound >= maxRound)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
            if (currentRound <= 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }
        }
    }
}
