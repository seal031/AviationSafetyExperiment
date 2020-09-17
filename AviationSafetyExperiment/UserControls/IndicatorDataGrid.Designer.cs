namespace AviationSafetyExperiment.UserControls
{
    partial class IndicatorDataGrid
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
            this.col_number = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.col_name = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.col_detail = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.col_record = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.col_conclusion = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.col_remark = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_number,
            this.col_name,
            this.col_detail,
            this.col_record,
            this.col_conclusion,
            this.col_remark});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(1319, 663);
            this.dgv.TabIndex = 1;
            // 
            // col_number
            // 
            this.col_number.FillWeight = 1F;
            this.col_number.HeaderText = "序号";
            this.col_number.Name = "col_number";
            this.col_number.ReadOnly = true;
            // 
            // col_name
            // 
            this.col_name.FillWeight = 5F;
            this.col_name.HeaderText = "指标名称";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_detail
            // 
            this.col_detail.FillWeight = 10F;
            this.col_detail.HeaderText = "指标说明";
            this.col_detail.Name = "col_detail";
            this.col_detail.ReadOnly = true;
            // 
            // col_record
            // 
            this.col_record.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.col_record.BackgroundStyle.Class = "DataGridViewBorder";
            this.col_record.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.col_record.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.col_record.FillWeight = 10F;
            this.col_record.ForeColor = System.Drawing.SystemColors.ControlText;
            this.col_record.HeaderText = "测试记录";
            this.col_record.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.col_record.Mask = "";
            this.col_record.Name = "col_record";
            this.col_record.PasswordChar = '\0';
            this.col_record.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.col_record.Text = "";
            // 
            // col_conclusion
            // 
            this.col_conclusion.DisplayMember = "Text";
            this.col_conclusion.DropDownHeight = 106;
            this.col_conclusion.DropDownWidth = 121;
            this.col_conclusion.FillWeight = 3F;
            this.col_conclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.col_conclusion.HeaderText = "测试结论";
            this.col_conclusion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.col_conclusion.IntegralHeight = false;
            this.col_conclusion.ItemHeight = 20;
            this.col_conclusion.Name = "col_conclusion";
            this.col_conclusion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // col_remark
            // 
            this.col_remark.DisplayMember = "Text";
            this.col_remark.DropDownHeight = 106;
            this.col_remark.DropDownWidth = 121;
            this.col_remark.FillWeight = 10F;
            this.col_remark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.col_remark.HeaderText = "备注";
            this.col_remark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.col_remark.IntegralHeight = false;
            this.col_remark.ItemHeight = 20;
            this.col_remark.Name = "col_remark";
            this.col_remark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // IndicatorDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IndicatorDataGrid";
            this.Size = new System.Drawing.Size(1319, 663);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn col_number;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn col_name;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn col_detail;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn col_record;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn col_conclusion;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn col_remark;
    }
}
