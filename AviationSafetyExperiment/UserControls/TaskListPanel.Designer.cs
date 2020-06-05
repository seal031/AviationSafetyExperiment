﻿namespace AviationSafetyExperiment.UserControls
{
    partial class TaskListPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.taskGridPanel = new AviationSafetyExperiment.UserControls.TaskGridPanel();
            this.taskQueryPanel = new AviationSafetyExperiment.UserControls.TaskQueryPanel();
            this.SuspendLayout();
            // 
            // taskGridPanel
            // 
            this.taskGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskGridPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskGridPanel.Location = new System.Drawing.Point(0, 47);
            this.taskGridPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskGridPanel.Name = "taskGridPanel";
            this.taskGridPanel.Size = new System.Drawing.Size(1235, 732);
            this.taskGridPanel.TabIndex = 1;
            // 
            // taskQueryPanel
            // 
            this.taskQueryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskQueryPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskQueryPanel.Location = new System.Drawing.Point(0, 0);
            this.taskQueryPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskQueryPanel.Name = "taskQueryPanel";
            this.taskQueryPanel.Size = new System.Drawing.Size(1235, 47);
            this.taskQueryPanel.TabIndex = 0;
            // 
            // TaskListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskGridPanel);
            this.Controls.Add(this.taskQueryPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskListPanel";
            this.Size = new System.Drawing.Size(1235, 779);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskQueryPanel taskQueryPanel;
        private TaskGridPanel taskGridPanel;
    }
}
