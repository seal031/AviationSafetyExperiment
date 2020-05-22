namespace AviationSafetyExperiment.UserControls
{
    partial class TaskProcessSlidePanel
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
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.btn_taskDefine = new DevComponents.DotNetBar.ButtonItem();
            this.btn_taskApprove = new DevComponents.DotNetBar.ButtonItem();
            this.btn_taskProcess = new DevComponents.DotNetBar.ButtonItem();
            this.btn_taskExecute = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_taskDefine,
            this.btn_taskApprove,
            this.btn_taskProcess,
            this.btn_taskExecute});
            this.itemPanel1.ItemSpacing = 20;
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(150, 500);
            this.itemPanel1.TabIndex = 0;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // btn_taskDefine
            // 
            this.btn_taskDefine.FontBold = true;
            this.btn_taskDefine.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btn_taskDefine.Name = "btn_taskDefine";
            this.btn_taskDefine.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_taskDefine.Text = "任务定义";
            // 
            // btn_taskApprove
            // 
            this.btn_taskApprove.FontBold = true;
            this.btn_taskApprove.Name = "btn_taskApprove";
            this.btn_taskApprove.Text = "任务审核";
            // 
            // btn_taskProcess
            // 
            this.btn_taskProcess.FontBold = true;
            this.btn_taskProcess.Name = "btn_taskProcess";
            this.btn_taskProcess.Text = "任务过程管理";
            // 
            // btn_taskExecute
            // 
            this.btn_taskExecute.FontBold = true;
            this.btn_taskExecute.Name = "btn_taskExecute";
            this.btn_taskExecute.Text = "任务执行管理";
            // 
            // TaskProcessSlidePanel
            // 
            this.Controls.Add(this.itemPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "TaskProcessSlidePanel";
            this.Size = new System.Drawing.Size(150, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        public DevComponents.DotNetBar.ButtonItem btn_taskDefine;
        public DevComponents.DotNetBar.ButtonItem btn_taskApprove;
        public DevComponents.DotNetBar.ButtonItem btn_taskProcess;
        public DevComponents.DotNetBar.ButtonItem btn_taskExecute;
    }
}
