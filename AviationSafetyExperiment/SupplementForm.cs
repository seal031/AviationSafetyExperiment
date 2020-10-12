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
    public partial class SupplementForm : DevComponents.DotNetBar.Office2007Form
    {
        private ResultSupplement supplement;
        private int taskInfoId;
        public SupplementForm(string supplementJsonString,int taskId)
        {
            InitializeComponent();
            this.taskInfoId = taskId;
            try
            {
                supplement = ResultSupplement.fromJson(supplementJsonString);
            }
            catch (Exception ex)
            {
                supplement = null;
            }
            DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn control = (DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn)alarmSupplementPan.dgv.Columns["classify"];
            control.BeforeCellPaint += Control_BeforeCellPaint;
        }
        private void Control_BeforeCellPaint(object sender, DevComponents.DotNetBar.Controls.BeforeCellPaintEventArgs e)
        {
            int omitCount = 0;
            int misinformationCount = 0;
            foreach (DataGridViewRow item in alarmSupplementPan.dgv.Rows)
            {
                if (item.Cells["classify"].Value != null)
                {
                    if (item.Cells["classify"].Value.ToString() == "补报")
                    {
                        misinformationCount++;
                    }
                    else if (item.Cells["classify"].Value.ToString() == "漏报")
                    {
                        omitCount++;
                    }
                }
            }
            ii_omitCount.Value = omitCount;
            ii_misinformationCount.Value = misinformationCount;
            ii_usableCount.Value = ii_testCount.Value - omitCount - misinformationCount;
        }

        private void SupplementForm_Shown(object sender, EventArgs e)
        {
            if (supplement != null)
            {
                //txt_alarmType.Text = supplement.alarmType;
                //txt_alarmForm.Text = supplement.alarmForm;
                alarmSupplementPan.dgv.Rows.Add(supplement.alarmInputList.Count);
                for (int i = 0; i < supplement.alarmInputList.Count; i++)
                {
                    DataGridViewRow row = alarmSupplementPan.dgv.Rows[i];
                    row.Cells[0].Value = supplement.alarmInputList[i].taskId;
                    row.Cells[1].Value = supplement.alarmInputList[i].alarmType;
                    row.Cells[2].Value = supplement.alarmInputList[i].alarmForm;
                    row.Cells[3].Value = supplement.alarmInputList[i].classify;
                    row.Cells[4].Value = supplement.alarmInputList[i].describe;
                }
                //alarmSupplementPan.dgv.DataSource = supplement.alarmInputList;
                ii_testCount.Text = supplement.totalTest.ToString();
                ii_alarmCount.Text = supplement.alarmTest.ToString();
                ii_omitCount.Text = supplement.omitCount.ToString();
                ii_misinformationCount.Text = supplement.misinformationCount.ToString();
                ii_usableCount.Text = supplement.usableCount.ToString();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (supplement == null)
            {
                supplement = new Db.Entity.ResultSupplement();
            }
            //supplement.alarmInputList = this.alarmSupplementPan.dgv.Rows;
            List<ResultSupplement.AlarmInput> inputList = new List<ResultSupplement.AlarmInput>();
            foreach (DataGridViewRow item in this.alarmSupplementPan.dgv.Rows)
            {
                ResultSupplement.AlarmInput alarm = new ResultSupplement.AlarmInput();
                if (item.Cells[0].Value == null && item.Cells[1].Value == null && item.Cells[2].Value == null
                    &&item.Cells[3].Value == null && item.Cells[4].Value == null)
                {
                    continue;
                }
                else
                {
                    alarm.taskId = taskInfoId;
                    alarm.alarmType = item.Cells[1].Value == null ? "" : item.Cells[1].Value.ToString();
                    alarm.alarmForm = item.Cells[2].Value == null ? "" : item.Cells[2].Value.ToString();
                    alarm.classify = item.Cells[3].Value == null ? "" : item.Cells[3].Value.ToString();
                    alarm.describe = item.Cells[4].Value == null ? "" : item.Cells[4].Value.ToString();
                }
                inputList.Add(alarm);
            }
            supplement.alarmInputList = inputList;
            //supplement.alarmType = txt_alarmType.Text.Trim();
            //supplement.alarmForm = txt_alarmForm.Text.Trim();
            supplement.totalTest = ii_testCount.Value;
            supplement.alarmTest = ii_alarmCount.Value;
            supplement.omitCount = ii_omitCount.Value;
            supplement.misinformationCount = ii_misinformationCount.Value;
            supplement.usableCount = ii_usableCount.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string getSupplimentJsonString()
        {
            if (supplement == null)
            { return string.Empty; }
            else
            {
                return supplement.toJson();
            }
        }

        private void ii_alarmCount_MouseLeave(object sender, EventArgs e)
        {
            //if (ii_alarmCount.Value != 0)
            //{
            //    if (ii_alarmCount.Value != alarmSupplementPan.dgv.Rows.Count)
            //    {
            //        alarmSupplementPan.dgv.Rows.Clear();
            //        for (int i = 0; i < ii_alarmCount.Value; i++)
            //        {
            //            alarmSupplementPan.dgv.Rows.Add();
            //        }
            //    }
            //}
        }
    }
}
