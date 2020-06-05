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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.indicatorId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskResultId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorDesc = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.brandId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.brandName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.modelId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.modelName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskRound = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskResult = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.taskRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskExecutor = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.taskDateTime = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.brandId,
            this.brandName,
            this.modelId,
            this.modelName,
            this.taskRound,
            this.taskRecord,
            this.taskResult,
            this.taskRemark,
            this.taskExecutor,
            this.taskDateTime});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(1101, 746);
            this.dgv.TabIndex = 0;
            this.dgv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_CellBeginEdit);
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
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
            this.modelName.HeaderText = "型号";
            this.modelName.Name = "modelName";
            this.modelName.ReadOnly = true;
            // 
            // taskRound
            // 
            this.taskRound.DataPropertyName = "taskRound";
            this.taskRound.HeaderText = "taskRound";
            this.taskRound.Name = "taskRound";
            this.taskRound.ReadOnly = true;
            this.taskRound.Visible = false;
            // 
            // taskRecord
            // 
            this.taskRecord.DataPropertyName = "taskRecord";
            this.taskRecord.HeaderText = "测试记录";
            this.taskRecord.Name = "taskRecord";
            // 
            // taskResult
            // 
            this.taskResult.DataPropertyName = "taskResult";
            this.taskResult.DropDownHeight = 106;
            this.taskResult.DropDownWidth = 121;
            this.taskResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskResult.HeaderText = "测试结论";
            this.taskResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.taskResult.IntegralHeight = false;
            this.taskResult.ItemHeight = 20;
            this.taskResult.Name = "taskResult";
            this.taskResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // taskRemark
            // 
            this.taskRemark.DataPropertyName = "taskRemark";
            this.taskRemark.HeaderText = "备注";
            this.taskRemark.Name = "taskRemark";
            // 
            // taskExecutor
            // 
            this.taskExecutor.DataPropertyName = "taskExecutor";
            this.taskExecutor.HeaderText = "操作人";
            this.taskExecutor.Name = "taskExecutor";
            this.taskExecutor.ReadOnly = true;
            // 
            // taskDateTime
            // 
            this.taskDateTime.DataPropertyName = "taskDateTime";
            this.taskDateTime.HeaderText = "操作时间";
            this.taskDateTime.Name = "taskDateTime";
            this.taskDateTime.ReadOnly = true;
            // 
            // TaskResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskResultPanel";
            this.Size = new System.Drawing.Size(1101, 746);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskResultId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorDesc;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn brandId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn brandName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn modelId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn modelName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskRound;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskRecord;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn taskResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskRemark;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskExecutor;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskDateTime;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgv;
    }
}
