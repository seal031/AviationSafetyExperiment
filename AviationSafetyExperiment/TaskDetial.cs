﻿using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using AviationSafetyExperiment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using DevComponents.DotNetBar;

namespace AviationSafetyExperiment
{
    /// <summary>
    /// 显示任务详情组件
    /// </summary>
    public partial class TaskDetial : DevComponents.DotNetBar.Office2007Form
    {
        public int taskInfoId;
        private int currentStep;
        private int maxStep;
        private int maxRound;
        private int currentRound;
        private List<Tb_taskResult> taskResultMapList;
        public TaskDetial(int taskInfoId)
        {
            InitializeComponent();
            this.taskInfoId = taskInfoId;
            Utils.FtpHelper.processChangeEvent += FtpHelper_processChangeEvent;
        }

        private void FtpHelper_processChangeEvent(FtpProgress process)
        {
            
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
            //代码添加button按钮,查看页面布局
            List<Tb_taskResult> resultList = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId).ToList();
            try
            {
                maxRound = resultList.Max(x => x.taskRound);
            }
            catch (Exception ex)
            {
            }
            currentRound = 1;
            currentStep = 1;
            Point point = new Point();
            if (maxRound>=10)
            {
                point.X = 158;
                point.Y = Btn_nextRound.Location.Y;
                Btn_nextRound.Location = point;
            }
            else
            {
                point.X = 148;
                point.Y = Btn_nextRound.Location.Y;
                Btn_nextRound.Location = point;
            }

            if (maxRound > 0)
            {
                lbl_roundText.Text = string.Format("{0}/{1}", currentRound, maxRound);
            }
            else
            {
                lbl_roundText.Text = string.Format("{0}/{1}", currentRound, 1);
            }
            if (currentRound == maxRound || maxRound == 0)
            {
                Btn_nextRound.Enabled = false;
            }
            else
            {
                Btn_nextRound.Enabled = true;
            }
            if (currentRound == 1)
            {
                Btn_lastRound.Enabled = false;
            }
            else
            {
                Btn_lastRound.Enabled = true;
            }
            //taskRound_BtnColl.AutoSize = true;
            //this.task
            maxStep = trp.getHistory();//显示第一轮，并返回总步骤
            if (maxStep > 0)
            {
                lbl_current.Text = "1/" + maxStep;
                btn_previous.Enabled = false;
                if (maxStep > 1)
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
                lbl_current.Text = "尚无步骤";
                btn_next.Enabled = false;
                btn_previous.Enabled = false;
                point.X = 350;
                point.Y = btn_next.Location.Y;
                btn_next.Location = point;
                point.X = 388;
                point.Y = ben_closeHistory.Location.Y;
                ben_closeHistory.Location = point;
            }
        }
        /// <summary>
        /// 轮次切换,并在页面进行显示
        /// </summary>
        /// <param name="round"></param>
        private void roundSwitchShow(int round)
        {
            //ButtonItem btn_round = (ButtonItem)sender;
            //foreach (ButtonItem item in taskRound_BtnColl.Items)
            //{
            //    item.Checked = false;
            //}
            //btn_round.Checked = true;
            //currentRound = int.Parse(btn_round.Text);
            roundSwitch(round);
            trp.taskRound = round;
            trp.currentResultStep = currentStep;
            trp.maxResultStep = maxStep;
            List<TaskResultModel> resModelList = trp.getData(currentStep, round);
            trp.dgv.DataSource = null;
            trp.dgv.DataSource = resModelList;
            trp.dgv.AutoGenerateColumns = false;
            //setReadOnly(readOnly);
        }
        /// <summary>
        /// 轮次进行切换的时候,初始化步骤,
        /// </summary>
        private void roundSwitch(int round)
        {
            List<Tb_taskResult> taskResult = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId && t.taskRound == round).ToList();
            maxStep = 0;
            try
            {
                maxStep = taskResult.Max(x => x.taskStep);
            }
            catch (Exception ex)
            {
            }
            currentStep = 1;
            if (currentStep >= maxStep)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
            if (currentStep <= 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }
            lbl_current.Text = 1 + "/" + maxStep;
        }
        private void ben_closeHistory_Click(object sender, EventArgs e)
        {
            panel_history.Visible = false;
            trp.init(taskInfoId, readOnly: true);//隐藏panel_history，同时恢复显示最新测试结果
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            int step = trp.showPrevious();
            currentStep = step;
            lbl_current.Text = step + "/" + maxStep;
            if (step >= maxStep)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
            if (step <= 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }
            Point point = new Point();
            if (currentStep<10)
            {
                point.X = 325;
                point.Y = btn_next.Location.Y;
                btn_next.Location = point;
                point.X = 368;
                point.Y = ben_closeHistory.Location.Y;
                ben_closeHistory.Location = point;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int step = trp.showNext();
            currentStep = step;
            lbl_current.Text = step + "/" + maxStep;
            if (step >= maxStep)
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
            if (step <= 1)
            {
                btn_previous.Enabled = false;
            }
            else
            {
                btn_previous.Enabled = true;
            }
            Point point = new Point();
            if (currentStep >= 10)
            {
                point.X = 335;
                point.Y = btn_next.Location.Y;
                btn_next.Location = point;
                point.X = 378;
                point.Y = ben_closeHistory.Location.Y;
                ben_closeHistory.Location = point;
            }

        }

        private void reportCreate_Click(object sender, EventArgs e)
        {
            //taskInfoId
            taskResultMapList = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId && t.taskRound == 1).ToList();
            int maxResultStep = 0;
            try
            {
                maxResultStep = taskResultMapList.Max(x => x.taskStep);
            }
            catch (Exception ex)
            {
            }
            List<TaskResultModel> resultList = GetReportInfo(maxResultStep, 1);
            DialogSeleFile(resultList,taskInfoId.ToString());
        }
        private List<TaskResultModel> GetReportInfo(int step, int round)
        {
            var taskIndicatorMapList = TaskIndicatorMapCache.getCache().Where(i => i.taskId == taskInfoId).ToList();
            var indicatorList = IndicatorCache.getCache();
            var brandList = CodeCache.getBrand();
            var modelList = CodeCache.getModel();
            var taskModelList = TaskModelMapCache.getCache();
            var brand_model_list = (from brand in brandList
                                    from model in modelList
                                    where brand.id == model.parentId
                                    select new
                                    {
                                        modelId = model.id,
                                        modelName = model.codeName,
                                        brandId = brand.id,
                                        brandName = brand.codeName
                                    }).ToList();

            var task_model_indicator_list = (from taskIndicator in taskIndicatorMapList
                                             from taskModel in taskModelList
                                             from bm in brand_model_list
                                             where taskIndicator.taskId == taskInfoId && taskModel.taskId == taskInfoId && taskModel.ModelId == bm.modelId
                                             select new
                                             {
                                                 taskIndicator,
                                                 bm.brandId,
                                                 bm.brandName,
                                                 bm.modelId,
                                                 bm.modelName
                                             }).ToList();

            var list_indicator = (from indicator in task_model_indicator_list
                                  join result in taskResultMapList.Where(r => r.taskStep == step && r.taskRound == round) on new { indicator.taskIndicator.indicatorId, indicator.modelId } equals new { result.indicatorId, result.modelId } into temp
                                  from tt in temp.DefaultIfEmpty()
                                  select new
                                  {
                                      indicator,
                                      taskRecord = tt == null ? "" : tt.taskRecord,
                                      taskResult = tt == null ? 0 : tt.taskResult,
                                      taskRemark = tt == null ? "" : tt.taskRemark,
                                      attachment = tt == null ? "" : tt.attachment,
                                      taskExecutor = tt == null ? "" : tt.taskExecutor,
                                      taskDateTime = tt == null ? "" : tt.taskDateTime.ToString(),
                                      taskStep = tt == null ? 0 : tt.taskStep,
                                      modelId = tt == null ? 0 : tt.modelId,
                                      taskResultId = tt == null ? 0 : tt.id,
                                      supplement = tt == null ? "" : tt.supplement
                                  }).ToList();

            var allResultModelList = (from temp in list_indicator
                                      from indicator in indicatorList
                                      where temp.indicator.taskIndicator.indicatorId == indicator.id
                                      select new TaskResultModel
                                      {
                                          indicatorId = indicator.id,
                                          indicatorName = indicator.indicatorName,
                                          indicatorDesc = indicator.indicatorDesc,
                                          indicatorInstr = indicator.indicatorInstr,
                                          taskDateTime = temp.taskDateTime,
                                          taskStep = temp.taskStep,
                                          taskExecutor = temp.taskExecutor,
                                          taskRecord = temp.taskRecord,
                                          taskRemark = temp.taskRemark,
                                          attachment = temp.attachment,
                                          attachmentCount = (temp.attachment == string.Empty ? "" : temp.attachment.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Count() + "个")
                                          + (temp.supplement == "" ? "" : "(补)"),
                                          taskResult = temp.taskResult,
                                          modelId = temp.indicator.modelId,
                                          modelName = temp.indicator.modelName,
                                          brandId = temp.indicator.brandId,
                                          brandName = temp.indicator.brandName,
                                          taskResultId = temp.taskResultId,
                                          supplement = temp.supplement
                                      }).ToList();
            return allResultModelList;
        }
        private void DialogSeleFile(List<TaskResultModel> resultList,string infoId)
        {
            string path = Application.StartupPath + @"\ReportTemplate" + "\\ReportTemplate.docx";
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.Description = "选择要生成测试报告的文件夹";
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Office.WordHelper.CreateFileByTemplate(resultList,path, folderDlg.SelectedPath,infoId);
                MessageBoxEx.Show("报告生成成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tdbip_Load(object sender, EventArgs e)
        {

        }

        private void Btn_lastRound_Click(object sender, EventArgs e)
        {
            if (currentRound > 1)
            {
                currentRound--;
                lbl_roundText.Text = string.Format("{0}/{1}", currentRound, maxRound);
                roundSwitchShow(currentRound);
                if (currentRound == 1)
                {
                    Btn_lastRound.Enabled = false;
                }
                else
                {
                    Btn_lastRound.Enabled = true;
                }
                if (currentRound<maxRound)
                {
                    Btn_nextRound.Enabled = true;
                }
                else
                {
                    Btn_nextRound.Enabled = false;
                }
            }
        }

        private void Btn_nextRound_Click(object sender, EventArgs e)
        {
            if (currentRound < maxRound)
            {
                currentRound++;
                lbl_roundText.Text = string.Format("{0}/{1}", currentRound, maxRound);
                roundSwitchShow(currentRound);
                if (currentRound == maxRound)
                {
                    Btn_nextRound.Enabled = false;
                }
                else
                {
                    Btn_nextRound.Enabled = true;
                }
                if (currentRound > 1)
                {
                    Btn_lastRound.Enabled = true;
                }
                else
                {
                    Btn_lastRound.Enabled = false;
                }
            }
        }
    }
}
