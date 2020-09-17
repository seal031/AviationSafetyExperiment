namespace AviationSafetyExperiment.UserControls
{
    partial class TaskMainPanel
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
            this.expandablePanel_new = new DevComponents.DotNetBar.ExpandablePanel();
            this.tgp_new = new AviationSafetyExperiment.UserControls.TaskGridPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tqp = new AviationSafetyExperiment.UserControls.TaskQueryPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.expandablePanel_report = new DevComponents.DotNetBar.ExpandablePanel();
            this.dgv_report = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.expandablePanel_done = new DevComponents.DotNetBar.ExpandablePanel();
            this.tgp_done = new AviationSafetyExperiment.UserControls.TaskGridPanel();
            this.expandablePanel_running = new DevComponents.DotNetBar.ExpandablePanel();
            this.tgp_running = new AviationSafetyExperiment.UserControls.TaskGridPanel();
            this.expandablePanel_new.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.expandablePanel_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.expandablePanel_done.SuspendLayout();
            this.expandablePanel_running.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel_new
            // 
            this.expandablePanel_new.ButtonImageCollapse = global::AviationSafetyExperiment.Properties.Resources.s_14;
            this.expandablePanel_new.ButtonImageExpand = global::AviationSafetyExperiment.Properties.Resources.s_14;
            this.expandablePanel_new.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel_new.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel_new.Controls.Add(this.tgp_new);
            this.expandablePanel_new.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel_new.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            this.expandablePanel_new.Expanded = false;
            this.expandablePanel_new.ExpandedBounds = new System.Drawing.Rectangle(0, 0, 1019, 581);
            this.expandablePanel_new.ExpandOnTitleClick = true;
            this.expandablePanel_new.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel_new.Name = "expandablePanel_new";
            this.expandablePanel_new.Size = new System.Drawing.Size(1040, 25);
            this.expandablePanel_new.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel_new.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_new.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_new.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel_new.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel_new.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel_new.Style.GradientAngle = 90;
            this.expandablePanel_new.TabIndex = 0;
            this.expandablePanel_new.TitleHeight = 25;
            this.expandablePanel_new.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_new.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_new.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel_new.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel_new.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel_new.TitleStyle.GradientAngle = 90;
            this.expandablePanel_new.TitleText = "待处理任务";
            this.expandablePanel_new.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.expandablePanel_ExpandedChanged);
            // 
            // tgp_new
            // 
            this.tgp_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgp_new.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tgp_new.Location = new System.Drawing.Point(0, 25);
            this.tgp_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tgp_new.Name = "tgp_new";
            this.tgp_new.Size = new System.Drawing.Size(1040, 0);
            this.tgp_new.TabIndex = 2;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.tqp);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1040, 43);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            this.panelEx1.Text = "panelEx1";
            // 
            // tqp
            // 
            this.tqp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tqp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tqp.Location = new System.Drawing.Point(0, 0);
            this.tqp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tqp.Name = "tqp";
            this.tqp.Size = new System.Drawing.Size(1040, 43);
            this.tqp.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.AutoScroll = true;
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.expandablePanel_report);
            this.panelEx2.Controls.Add(this.expandablePanel_done);
            this.panelEx2.Controls.Add(this.expandablePanel_running);
            this.panelEx2.Controls.Add(this.expandablePanel_new);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 43);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1040, 717);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 2;
            // 
            // expandablePanel_report
            // 
            this.expandablePanel_report.ButtonImageCollapse = global::AviationSafetyExperiment.Properties.Resources.s_13;
            this.expandablePanel_report.ButtonImageExpand = global::AviationSafetyExperiment.Properties.Resources.s_13;
            this.expandablePanel_report.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel_report.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel_report.Controls.Add(this.dgv_report);
            this.expandablePanel_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel_report.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            this.expandablePanel_report.Expanded = false;
            this.expandablePanel_report.ExpandedBounds = new System.Drawing.Rectangle(0, 78, 1040, 581);
            this.expandablePanel_report.ExpandOnTitleClick = true;
            this.expandablePanel_report.Location = new System.Drawing.Point(0, 75);
            this.expandablePanel_report.Name = "expandablePanel_report";
            this.expandablePanel_report.Size = new System.Drawing.Size(1040, 25);
            this.expandablePanel_report.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel_report.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_report.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_report.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel_report.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel_report.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel_report.Style.GradientAngle = 90;
            this.expandablePanel_report.TabIndex = 3;
            this.expandablePanel_report.TitleHeight = 25;
            this.expandablePanel_report.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_report.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_report.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel_report.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel_report.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel_report.TitleStyle.GradientAngle = 90;
            this.expandablePanel_report.TitleText = "测试报告";
            this.expandablePanel_report.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.expandablePanel_ExpandedChanged);
            // 
            // dgv_report
            // 
            this.dgv_report.BackgroundColor = System.Drawing.Color.White;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_report.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_report.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_report.Location = new System.Drawing.Point(0, 26);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.RowTemplate.Height = 27;
            this.dgv_report.Size = new System.Drawing.Size(1040, 0);
            this.dgv_report.TabIndex = 3;
            // 
            // expandablePanel_done
            // 
            this.expandablePanel_done.ButtonImageCollapse = global::AviationSafetyExperiment.Properties.Resources.s_16;
            this.expandablePanel_done.ButtonImageExpand = global::AviationSafetyExperiment.Properties.Resources.s_16;
            this.expandablePanel_done.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel_done.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel_done.Controls.Add(this.tgp_done);
            this.expandablePanel_done.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel_done.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            this.expandablePanel_done.Expanded = false;
            this.expandablePanel_done.ExpandedBounds = new System.Drawing.Rectangle(0, 52, 1040, 581);
            this.expandablePanel_done.ExpandOnTitleClick = true;
            this.expandablePanel_done.Location = new System.Drawing.Point(0, 50);
            this.expandablePanel_done.Name = "expandablePanel_done";
            this.expandablePanel_done.Size = new System.Drawing.Size(1040, 25);
            this.expandablePanel_done.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel_done.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_done.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_done.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel_done.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel_done.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel_done.Style.GradientAngle = 90;
            this.expandablePanel_done.TabIndex = 2;
            this.expandablePanel_done.TitleHeight = 25;
            this.expandablePanel_done.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_done.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_done.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel_done.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel_done.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel_done.TitleStyle.GradientAngle = 90;
            this.expandablePanel_done.TitleText = "已完成任务";
            this.expandablePanel_done.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.expandablePanel_ExpandedChanged);
            // 
            // tgp_done
            // 
            this.tgp_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgp_done.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tgp_done.Location = new System.Drawing.Point(0, 25);
            this.tgp_done.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tgp_done.Name = "tgp_done";
            this.tgp_done.Size = new System.Drawing.Size(1040, 0);
            this.tgp_done.TabIndex = 3;
            // 
            // expandablePanel_running
            // 
            this.expandablePanel_running.ButtonImageCollapse = global::AviationSafetyExperiment.Properties.Resources.s_15;
            this.expandablePanel_running.ButtonImageExpand = global::AviationSafetyExperiment.Properties.Resources.s_15;
            this.expandablePanel_running.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel_running.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel_running.Controls.Add(this.tgp_running);
            this.expandablePanel_running.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel_running.ExpandButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            this.expandablePanel_running.Expanded = false;
            this.expandablePanel_running.ExpandedBounds = new System.Drawing.Rectangle(0, 26, 1019, 581);
            this.expandablePanel_running.ExpandOnTitleClick = true;
            this.expandablePanel_running.Location = new System.Drawing.Point(0, 25);
            this.expandablePanel_running.Name = "expandablePanel_running";
            this.expandablePanel_running.Size = new System.Drawing.Size(1040, 25);
            this.expandablePanel_running.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel_running.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_running.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_running.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel_running.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel_running.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel_running.Style.GradientAngle = 90;
            this.expandablePanel_running.TabIndex = 1;
            this.expandablePanel_running.TitleHeight = 25;
            this.expandablePanel_running.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel_running.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel_running.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel_running.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel_running.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel_running.TitleStyle.GradientAngle = 90;
            this.expandablePanel_running.TitleText = "处理中任务";
            this.expandablePanel_running.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.expandablePanel_ExpandedChanged);
            // 
            // tgp_running
            // 
            this.tgp_running.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgp_running.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tgp_running.Location = new System.Drawing.Point(0, 25);
            this.tgp_running.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tgp_running.Name = "tgp_running";
            this.tgp_running.Size = new System.Drawing.Size(1040, 0);
            this.tgp_running.TabIndex = 3;
            // 
            // TaskMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskMainPanel";
            this.Size = new System.Drawing.Size(1040, 760);
            this.expandablePanel_new.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.expandablePanel_report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.expandablePanel_done.ResumeLayout(false);
            this.expandablePanel_running.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel_new;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel_running;
        private TaskGridPanel tgp_running;
        private TaskQueryPanel tqp;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel_report;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel_done;
        private TaskGridPanel tgp_done;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_report;
        private TaskGridPanel tgp_new;
    }
}
