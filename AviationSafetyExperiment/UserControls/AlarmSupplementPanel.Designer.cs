namespace AviationSafetyExperiment.UserControls
{
    partial class AlarmSupplementPanel
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
            this.taskId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.alarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classify = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskId,
            this.alarmType,
            this.alarmForm,
            this.classify,
            this.describe});
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
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(453, 197);
            this.dgv.TabIndex = 3;
            // 
            // taskId
            // 
            this.taskId.DataPropertyName = "taskId";
            this.taskId.HeaderText = "taskId";
            this.taskId.Name = "taskId";
            this.taskId.Visible = false;
            // 
            // alarmType
            // 
            this.alarmType.DataPropertyName = "alarmType";
            this.alarmType.FillWeight = 105.3593F;
            this.alarmType.HeaderText = "报警类型";
            this.alarmType.Name = "alarmType";
            // 
            // alarmForm
            // 
            this.alarmForm.DataPropertyName = "alarmForm";
            this.alarmForm.FillWeight = 104.0609F;
            this.alarmForm.HeaderText = "报警形式";
            this.alarmForm.Name = "alarmForm";
            // 
            // classify
            // 
            this.classify.DataPropertyName = "classify";
            this.classify.DisplayMember = "Text";
            this.classify.DropDownHeight = 106;
            this.classify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classify.DropDownWidth = 121;
            this.classify.FillWeight = 100.2899F;
            this.classify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classify.HeaderText = "分类";
            this.classify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.classify.IntegralHeight = false;
            this.classify.ItemHeight = 16;
            this.classify.Name = "classify";
            this.classify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // describe
            // 
            this.describe.DataPropertyName = "describe";
            this.describe.FillWeight = 100.2899F;
            this.describe.HeaderText = "描述";
            this.describe.Name = "describe";
            // 
            // AlarmSupplementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Name = "AlarmSupplementPanel";
            this.Size = new System.Drawing.Size(453, 197);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn taskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmForm;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn classify;
        private System.Windows.Forms.DataGridViewTextBoxColumn describe;
    }
}
