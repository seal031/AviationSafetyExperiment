namespace AviationSafetyExperiment.UserControls
{
    partial class TaskResultPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pagingPanel = new AviationSafetyExperiment.UserControls.PagingPanel();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.indicatorId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskResultId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorDesc = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorInstr = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.brandId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.brandName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.modelId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.modelName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskStep = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskResult = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.taskRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentCount = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.attachment = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskExecutor = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskDateTime = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.supplement = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.Filter = "所有文件(*.*)|*.*";
            // 
            // pagingPanel
            // 
            this.pagingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagingPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pagingPanel.Location = new System.Drawing.Point(0, 716);
            this.pagingPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pagingPanel.Name = "pagingPanel";
            this.pagingPanel.Size = new System.Drawing.Size(1101, 30);
            this.pagingPanel.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indicatorId,
            this.taskResultId,
            this.indicatorName,
            this.indicatorDesc,
            this.indicatorInstr,
            this.brandId,
            this.brandName,
            this.modelId,
            this.modelName,
            this.taskStep,
            this.taskRecord,
            this.taskResult,
            this.taskRemark,
            this.attachmentCount,
            this.attachment,
            this.taskExecutor,
            this.taskDateTime,
            this.supplement});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(1101, 716);
            this.dgv.TabIndex = 2;
            this.dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDoubleClick);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // indicatorId
            // 
            this.indicatorId.DataPropertyName = "indicatorId";
            this.indicatorId.HeaderText = "indicatorId";
            this.indicatorId.Name = "indicatorId";
            this.indicatorId.ReadOnly = true;
            this.indicatorId.Visible = false;
            // 
            // taskResultId
            // 
            this.taskResultId.DataPropertyName = "taskResultId";
            this.taskResultId.HeaderText = "taskResultId";
            this.taskResultId.Name = "taskResultId";
            this.taskResultId.Visible = false;
            // 
            // indicatorName
            // 
            this.indicatorName.DataPropertyName = "indicatorName";
            this.indicatorName.FillWeight = 50F;
            this.indicatorName.HeaderText = "指标名称";
            this.indicatorName.Name = "indicatorName";
            this.indicatorName.ReadOnly = true;
            // 
            // indicatorDesc
            // 
            this.indicatorDesc.DataPropertyName = "indicatorDesc";
            this.indicatorDesc.HeaderText = "指标描述";
            this.indicatorDesc.Name = "indicatorDesc";
            this.indicatorDesc.ReadOnly = true;
            // 
            // indicatorInstr
            // 
            this.indicatorInstr.DataPropertyName = "indicatorInstr";
            this.indicatorInstr.HeaderText = "操作说明";
            this.indicatorInstr.Name = "indicatorInstr";
            this.indicatorInstr.ReadOnly = true;
            // 
            // brandId
            // 
            this.brandId.DataPropertyName = "brandId";
            this.brandId.HeaderText = "brandId";
            this.brandId.Name = "brandId";
            this.brandId.ReadOnly = true;
            this.brandId.Visible = false;
            // 
            // brandName
            // 
            this.brandName.DataPropertyName = "brandName";
            this.brandName.FillWeight = 25F;
            this.brandName.HeaderText = "品牌";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // modelId
            // 
            this.modelId.DataPropertyName = "modelId";
            this.modelId.HeaderText = "modelId";
            this.modelId.Name = "modelId";
            this.modelId.ReadOnly = true;
            this.modelId.Visible = false;
            // 
            // modelName
            // 
            this.modelName.DataPropertyName = "modelName";
            this.modelName.FillWeight = 40F;
            this.modelName.HeaderText = "型号";
            this.modelName.Name = "modelName";
            this.modelName.ReadOnly = true;
            // 
            // taskStep
            // 
            this.taskStep.DataPropertyName = "taskStep";
            this.taskStep.HeaderText = "taskStep";
            this.taskStep.Name = "taskStep";
            this.taskStep.ReadOnly = true;
            this.taskStep.Visible = false;
            // 
            // taskRecord
            // 
            this.taskRecord.DataPropertyName = "taskRecord";
            this.taskRecord.FillWeight = 150F;
            this.taskRecord.HeaderText = "测试记录";
            this.taskRecord.Name = "taskRecord";
            // 
            // taskResult
            // 
            this.taskResult.DataPropertyName = "taskResult";
            this.taskResult.DropDownHeight = 106;
            this.taskResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskResult.DropDownWidth = 121;
            this.taskResult.FillWeight = 40F;
            this.taskResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskResult.HeaderText = "结论";
            this.taskResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.taskResult.IntegralHeight = false;
            this.taskResult.ItemHeight = 20;
            this.taskResult.Name = "taskResult";
            this.taskResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // taskRemark
            // 
            this.taskRemark.DataPropertyName = "taskRemark";
            this.taskRemark.FillWeight = 60F;
            this.taskRemark.HeaderText = "备注";
            this.taskRemark.Name = "taskRemark";
            // 
            // attachmentCount
            // 
            this.attachmentCount.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.attachmentCount.BackgroundStyle.Class = "DataGridViewBorder";
            this.attachmentCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.attachmentCount.ButtonCustom.Image = global::AviationSafetyExperiment.Properties.Resources.s_21;
            this.attachmentCount.ButtonCustom.Visible = true;
            this.attachmentCount.ButtonCustom2.Image = global::AviationSafetyExperiment.Properties.Resources.s_26;
            this.attachmentCount.ButtonCustom2.Visible = true;
            this.attachmentCount.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.attachmentCount.DataPropertyName = "attachmentCount";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("等线", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.attachmentCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.attachmentCount.FillWeight = 40F;
            this.attachmentCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.attachmentCount.HeaderText = "附件";
            this.attachmentCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentCount.Mask = "";
            this.attachmentCount.Name = "attachmentCount";
            this.attachmentCount.PasswordChar = '\0';
            this.attachmentCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.attachmentCount.Text = "";
            // 
            // attachment
            // 
            this.attachment.DataPropertyName = "attachment";
            this.attachment.HeaderText = "附件文件路径";
            this.attachment.Name = "attachment";
            this.attachment.Visible = false;
            // 
            // taskExecutor
            // 
            this.taskExecutor.DataPropertyName = "taskExecutor";
            this.taskExecutor.FillWeight = 20F;
            this.taskExecutor.HeaderText = "操作人";
            this.taskExecutor.Name = "taskExecutor";
            this.taskExecutor.ReadOnly = true;
            this.taskExecutor.Visible = false;
            // 
            // taskDateTime
            // 
            this.taskDateTime.DataPropertyName = "taskDateTime";
            this.taskDateTime.FillWeight = 30F;
            this.taskDateTime.HeaderText = "操作时间";
            this.taskDateTime.Name = "taskDateTime";
            this.taskDateTime.ReadOnly = true;
            // 
            // supplement
            // 
            this.supplement.DataPropertyName = "supplement";
            this.supplement.HeaderText = "补充内容";
            this.supplement.Name = "supplement";
            this.supplement.Visible = false;
            // 
            // TaskResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pagingPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskResultPanel";
            this.Size = new System.Drawing.Size(1101, 746);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private PagingPanel pagingPanel;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskResultId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorDesc;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorInstr;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn brandId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn brandName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn modelId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn modelName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskRecord;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn taskResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskRemark;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn attachmentCount;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn attachment;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskExecutor;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskDateTime;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn supplement;
    }
}
