namespace AviationSafetyExperiment.UserControls
{
    partial class TaskGridPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgv_taskList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.taskId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskClassName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskBrandModelName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskCode = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskStartTime = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskStateId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskStateName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.percent = new DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn();
            this.btn_pass = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btn_reject = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btn_open = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btn_done = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btn_close = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.pagingPanel = new AviationSafetyExperiment.UserControls.PagingPanel();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taskList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgv_taskList);
            this.panelEx1.Controls.Add(this.pagingPanel);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1014, 622);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dgv_taskList
            // 
            this.dgv_taskList.AllowUserToDeleteRows = false;
            this.dgv_taskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskId,
            this.taskName,
            this.taskClassName,
            this.taskBrandModelName,
            this.taskCode,
            this.taskStartTime,
            this.taskStateId,
            this.taskStateName,
            this.percent,
            this.btn_pass,
            this.btn_reject,
            this.btn_open,
            this.btn_done,
            this.btn_close});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_taskList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_taskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_taskList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_taskList.Location = new System.Drawing.Point(0, 0);
            this.dgv_taskList.MultiSelect = false;
            this.dgv_taskList.Name = "dgv_taskList";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_taskList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_taskList.RowTemplate.Height = 45;
            this.dgv_taskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_taskList.Size = new System.Drawing.Size(1014, 587);
            this.dgv_taskList.TabIndex = 2;
            this.dgv_taskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taskList_CellContentClick);
            this.dgv_taskList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_taskList_CellMouseDoubleClick);
            this.dgv_taskList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_taskList_RowPostPaint);
            // 
            // taskId
            // 
            this.taskId.DataPropertyName = "taskId";
            this.taskId.HeaderText = "taskId";
            this.taskId.Name = "taskId";
            this.taskId.ReadOnly = true;
            this.taskId.Visible = false;
            // 
            // taskName
            // 
            this.taskName.DataPropertyName = "taskName";
            this.taskName.HeaderText = "任务名称";
            this.taskName.Name = "taskName";
            this.taskName.ReadOnly = true;
            this.taskName.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskName.WordWrap = true;
            // 
            // taskClassName
            // 
            this.taskClassName.DataPropertyName = "taskClassName";
            this.taskClassName.HeaderText = "任务分类";
            this.taskClassName.Name = "taskClassName";
            this.taskClassName.ReadOnly = true;
            this.taskClassName.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskClassName.WordWrap = true;
            // 
            // taskBrandModelName
            // 
            this.taskBrandModelName.DataPropertyName = "taskBrandModelName";
            this.taskBrandModelName.HeaderText = "品牌型号";
            this.taskBrandModelName.Name = "taskBrandModelName";
            this.taskBrandModelName.ReadOnly = true;
            this.taskBrandModelName.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskBrandModelName.WordWrap = true;
            // 
            // taskCode
            // 
            this.taskCode.DataPropertyName = "taskCode";
            this.taskCode.HeaderText = "任务编码";
            this.taskCode.Name = "taskCode";
            this.taskCode.ReadOnly = true;
            this.taskCode.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskCode.WordWrap = true;
            // 
            // taskStartTime
            // 
            this.taskStartTime.DataPropertyName = "taskStartTime";
            this.taskStartTime.HeaderText = "创建时间";
            this.taskStartTime.Name = "taskStartTime";
            this.taskStartTime.ReadOnly = true;
            this.taskStartTime.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskStartTime.WordWrap = true;
            // 
            // taskStateId
            // 
            this.taskStateId.DataPropertyName = "taskStateId";
            this.taskStateId.HeaderText = "taskStateId";
            this.taskStateId.Name = "taskStateId";
            this.taskStateId.ReadOnly = true;
            this.taskStateId.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskStateId.Visible = false;
            this.taskStateId.WordWrap = true;
            // 
            // taskStateName
            // 
            this.taskStateName.DataPropertyName = "taskStateName";
            this.taskStateName.HeaderText = "任务状态";
            this.taskStateName.Name = "taskStateName";
            this.taskStateName.ReadOnly = true;
            this.taskStateName.TextAlignment = System.Drawing.StringAlignment.Center;
            this.taskStateName.WordWrap = true;
            // 
            // percent
            // 
            this.percent.DataPropertyName = "percent";
            this.percent.HeaderText = "完成进度";
            this.percent.Name = "percent";
            this.percent.Text = null;
            this.percent.TextVisible = true;
            // 
            // btn_pass
            // 
            this.btn_pass.FillWeight = 30F;
            this.btn_pass.HeaderText = "操作";
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.ReadOnly = true;
            this.btn_pass.Text = "通过";
            this.btn_pass.UseColumnTextForButtonValue = true;
            this.btn_pass.Visible = false;
            // 
            // btn_reject
            // 
            this.btn_reject.FillWeight = 30F;
            this.btn_reject.HeaderText = "操作";
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.ReadOnly = true;
            this.btn_reject.Text = "驳回";
            this.btn_reject.UseColumnTextForButtonValue = true;
            this.btn_reject.Visible = false;
            // 
            // btn_open
            // 
            this.btn_open.FillWeight = 40F;
            this.btn_open.HeaderText = "操作";
            this.btn_open.Name = "btn_open";
            this.btn_open.ReadOnly = true;
            this.btn_open.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btn_open.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btn_open.Text = "打开任务";
            this.btn_open.UseColumnTextForButtonValue = true;
            this.btn_open.Visible = false;
            // 
            // btn_done
            // 
            this.btn_done.FillWeight = 30F;
            this.btn_done.HeaderText = "操作";
            this.btn_done.Name = "btn_done";
            this.btn_done.ReadOnly = true;
            this.btn_done.Text = "完成";
            this.btn_done.UseColumnTextForButtonValue = true;
            this.btn_done.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.FillWeight = 30F;
            this.btn_close.HeaderText = "操作";
            this.btn_close.Name = "btn_close";
            this.btn_close.ReadOnly = true;
            this.btn_close.Text = "关闭";
            this.btn_close.UseColumnTextForButtonValue = true;
            this.btn_close.Visible = false;
            // 
            // pagingPanel
            // 
            this.pagingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagingPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pagingPanel.Location = new System.Drawing.Point(0, 587);
            this.pagingPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pagingPanel.Name = "pagingPanel";
            this.pagingPanel.Size = new System.Drawing.Size(1014, 35);
            this.pagingPanel.TabIndex = 1;
            // 
            // TaskGridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskGridPanel";
            this.Size = new System.Drawing.Size(1014, 622);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_taskList;
        private PagingPanel pagingPanel;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskClassName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskBrandModelName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskCode;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskStartTime;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskStateId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskStateName;
        private DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn percent;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btn_pass;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btn_reject;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btn_open;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btn_done;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn btn_close;
    }
}
