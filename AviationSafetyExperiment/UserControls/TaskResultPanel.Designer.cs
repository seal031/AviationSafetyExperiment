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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pagingPanel = new AviationSafetyExperiment.UserControls.PagingPanel();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.indicatorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.indicatorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.indicatorDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.indicatorInstr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskRecord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskResultRadioGroup = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.taskExecutor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskResultId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attachmentCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.supplement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isFillFinish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isHaveModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskResultRadioGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
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
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MainView = this.gv;
            this.dgv.Name = "dgv";
            this.dgv.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.taskResultRadioGroup,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemButtonEdit1});
            this.dgv.Size = new System.Drawing.Size(1101, 716);
            this.dgv.TabIndex = 2;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.indicatorId,
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
            this.taskExecutor,
            this.taskResultId,
            this.taskRemark,
            this.taskDateTime,
            this.attachment,
            this.attachmentCount,
            this.supplement,
            this.isFillFinish,
            this.isHaveModi});
            this.gv.GridControl = this.dgv;
            this.gv.IndicatorWidth = 30;
            this.gv.Name = "gv";
            this.gv.OptionsCustomization.AllowFilter = false;
            this.gv.OptionsCustomization.AllowGroup = false;
            this.gv.OptionsCustomization.AllowSort = false;
            this.gv.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gv.OptionsMenu.EnableColumnMenu = false;
            this.gv.OptionsView.AllowCellMerge = true;
            this.gv.OptionsView.RowAutoHeight = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            this.gv.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gv_RowCellClick);
            this.gv.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_CustomDrawRowIndicator);
            this.gv.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_CellValueChanged);
            // 
            // indicatorId
            // 
            this.indicatorId.Caption = "indicatorId";
            this.indicatorId.FieldName = "indicatorId";
            this.indicatorId.Name = "indicatorId";
            this.indicatorId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // indicatorName
            // 
            this.indicatorName.Caption = "指标名称";
            this.indicatorName.FieldName = "indicatorName";
            this.indicatorName.Name = "indicatorName";
            this.indicatorName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.indicatorName.OptionsColumn.FixedWidth = true;
            this.indicatorName.OptionsColumn.ReadOnly = true;
            this.indicatorName.Visible = true;
            this.indicatorName.VisibleIndex = 0;
            // 
            // indicatorDesc
            // 
            this.indicatorDesc.Caption = "指标描述";
            this.indicatorDesc.ColumnEdit = this.repositoryItemMemoEdit1;
            this.indicatorDesc.FieldName = "indicatorDesc";
            this.indicatorDesc.Name = "indicatorDesc";
            this.indicatorDesc.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.indicatorDesc.OptionsColumn.ReadOnly = true;
            this.indicatorDesc.Visible = true;
            this.indicatorDesc.VisibleIndex = 1;
            this.indicatorDesc.Width = 150;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            this.repositoryItemMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            // 
            // indicatorInstr
            // 
            this.indicatorInstr.AppearanceCell.Options.UseTextOptions = true;
            this.indicatorInstr.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.indicatorInstr.Caption = "指标说明";
            this.indicatorInstr.ColumnEdit = this.repositoryItemMemoEdit1;
            this.indicatorInstr.FieldName = "indicatorInstr";
            this.indicatorInstr.Name = "indicatorInstr";
            this.indicatorInstr.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.indicatorInstr.OptionsColumn.ReadOnly = true;
            this.indicatorInstr.OptionsFilter.AllowAutoFilter = false;
            this.indicatorInstr.OptionsFilter.AllowFilter = false;
            this.indicatorInstr.Visible = true;
            this.indicatorInstr.VisibleIndex = 2;
            this.indicatorInstr.Width = 180;
            // 
            // brandId
            // 
            this.brandId.Caption = "brandId";
            this.brandId.FieldName = "brandId";
            this.brandId.Name = "brandId";
            // 
            // brandName
            // 
            this.brandName.Caption = "品牌";
            this.brandName.FieldName = "brandName";
            this.brandName.Name = "brandName";
            this.brandName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.brandName.OptionsColumn.ReadOnly = true;
            this.brandName.Visible = true;
            this.brandName.VisibleIndex = 3;
            this.brandName.Width = 93;
            // 
            // modelId
            // 
            this.modelId.Caption = "modelId";
            this.modelId.FieldName = "modelId";
            this.modelId.Name = "modelId";
            // 
            // modelName
            // 
            this.modelName.Caption = "型号";
            this.modelName.FieldName = "modelName";
            this.modelName.Name = "modelName";
            this.modelName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.modelName.OptionsColumn.ReadOnly = true;
            this.modelName.Visible = true;
            this.modelName.VisibleIndex = 4;
            this.modelName.Width = 93;
            // 
            // taskStep
            // 
            this.taskStep.Caption = "taskStep";
            this.taskStep.FieldName = "taskStep";
            this.taskStep.Name = "taskStep";
            this.taskStep.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.taskStep.OptionsColumn.ReadOnly = true;
            // 
            // taskRecord
            // 
            this.taskRecord.Caption = "测试记录";
            this.taskRecord.FieldName = "taskRecord";
            this.taskRecord.Name = "taskRecord";
            this.taskRecord.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.taskRecord.Visible = true;
            this.taskRecord.VisibleIndex = 5;
            this.taskRecord.Width = 100;
            // 
            // taskResult
            // 
            this.taskResult.Caption = "测试结论";
            this.taskResult.ColumnEdit = this.taskResultRadioGroup;
            this.taskResult.FieldName = "taskResult";
            this.taskResult.Name = "taskResult";
            this.taskResult.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.taskResult.Visible = true;
            this.taskResult.VisibleIndex = 6;
            this.taskResult.Width = 89;
            // 
            // taskResultRadioGroup
            // 
            this.taskResultRadioGroup.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "通过"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "未通过")});
            this.taskResultRadioGroup.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Column;
            this.taskResultRadioGroup.Name = "taskResultRadioGroup";
            // 
            // taskExecutor
            // 
            this.taskExecutor.Caption = "操作人";
            this.taskExecutor.FieldName = "taskExecutor";
            this.taskExecutor.Name = "taskExecutor";
            this.taskExecutor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.taskExecutor.OptionsColumn.ReadOnly = true;
            this.taskExecutor.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.taskExecutor.Width = 93;
            // 
            // taskResultId
            // 
            this.taskResultId.Caption = "taskResultId";
            this.taskResultId.FieldName = "taskResultId";
            this.taskResultId.Name = "taskResultId";
            // 
            // taskRemark
            // 
            this.taskRemark.Caption = "备注";
            this.taskRemark.FieldName = "taskRemark";
            this.taskRemark.Name = "taskRemark";
            this.taskRemark.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.taskRemark.Visible = true;
            this.taskRemark.VisibleIndex = 8;
            this.taskRemark.Width = 113;
            // 
            // taskDateTime
            // 
            this.taskDateTime.Caption = "操作时间";
            this.taskDateTime.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm:ss";
            this.taskDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.taskDateTime.FieldName = "taskDateTime";
            this.taskDateTime.Name = "taskDateTime";
            this.taskDateTime.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.taskDateTime.OptionsColumn.ReadOnly = true;
            this.taskDateTime.Visible = true;
            this.taskDateTime.VisibleIndex = 9;
            this.taskDateTime.Width = 93;
            // 
            // attachment
            // 
            this.attachment.Caption = "attachment";
            this.attachment.FieldName = "attachment";
            this.attachment.Name = "attachment";
            this.attachment.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // attachmentCount
            // 
            this.attachmentCount.AppearanceCell.Options.UseImage = true;
            this.attachmentCount.Caption = "附件及补漏报";
            this.attachmentCount.ColumnEdit = this.repositoryItemButtonEdit1;
            this.attachmentCount.FieldName = "attachmentCount";
            this.attachmentCount.Name = "attachmentCount";
            this.attachmentCount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.attachmentCount.OptionsColumn.ReadOnly = true;
            this.attachmentCount.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.attachmentCount.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.attachmentCount.Visible = true;
            this.attachmentCount.VisibleIndex = 7;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.repositoryItemButtonEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemButtonEdit1.Appearance.Options.UseImage = true;
            this.repositoryItemButtonEdit1.AppearanceDisabled.Options.UseImage = true;
            this.repositoryItemButtonEdit1.AppearanceFocused.Options.UseImage = true;
            this.repositoryItemButtonEdit1.AppearanceReadOnly.Options.UseImage = true;
            serializableAppearanceObject1.Image = global::AviationSafetyExperiment.Properties.Resources.s_13;
            serializableAppearanceObject1.Options.UseImage = true;
            serializableAppearanceObject2.Image = global::AviationSafetyExperiment.Properties.Resources.s_21;
            serializableAppearanceObject2.Options.UseImage = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "附件管理", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::AviationSafetyExperiment.Properties.Resources.s_13, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "附件管理", null, null, false),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "补报漏报", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::AviationSafetyExperiment.Properties.Resources.s_21, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "补报漏报", null, null, false)});
            this.repositoryItemButtonEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ReadOnly = true;
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            this.repositoryItemButtonEdit1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.repositoryItemButtonEdit1_MouseDown);
            // 
            // supplement
            // 
            this.supplement.Caption = "supplement";
            this.supplement.FieldName = "supplement";
            this.supplement.Name = "supplement";
            // 
            // isFillFinish
            // 
            this.isFillFinish.Caption = "isFillFinish";
            this.isFillFinish.FieldName = "isFillFinish";
            this.isFillFinish.Name = "isFillFinish";
            // 
            // isHaveModi
            // 
            this.isHaveModi.Caption = "isHaveModi";
            this.isHaveModi.FieldName = "isHaveModi";
            this.isHaveModi.Name = "isHaveModi";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.OptionsExport.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never;
            this.repositoryItemRichTextEdit1.OptionsHorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Auto;
            this.repositoryItemRichTextEdit1.ReadOnly = true;
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskResultRadioGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private PagingPanel pagingPanel;
        private DevExpress.XtraGrid.Columns.GridColumn indicatorId;
        private DevExpress.XtraGrid.Columns.GridColumn indicatorName;
        private DevExpress.XtraGrid.Columns.GridColumn indicatorDesc;
        private DevExpress.XtraGrid.Columns.GridColumn indicatorInstr;
        private DevExpress.XtraGrid.Columns.GridColumn brandId;
        private DevExpress.XtraGrid.Columns.GridColumn brandName;
        private DevExpress.XtraGrid.Columns.GridColumn modelId;
        private DevExpress.XtraGrid.Columns.GridColumn modelName;
        private DevExpress.XtraGrid.Columns.GridColumn taskStep;
        private DevExpress.XtraGrid.Columns.GridColumn taskRecord;
        private DevExpress.XtraGrid.Columns.GridColumn taskResult;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup taskResultRadioGroup;
        private DevExpress.XtraGrid.Columns.GridColumn taskExecutor;
        private DevExpress.XtraGrid.Columns.GridColumn taskDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn taskResultId;
        private DevExpress.XtraGrid.Columns.GridColumn taskRemark;
        private DevExpress.XtraGrid.Columns.GridColumn attachment;
        private DevExpress.XtraGrid.Columns.GridColumn attachmentCount;
        private DevExpress.XtraGrid.Columns.GridColumn supplement;
        private DevExpress.XtraGrid.Columns.GridColumn isFillFinish;
        private DevExpress.XtraGrid.Columns.GridColumn isHaveModi;
        public DevExpress.XtraGrid.Views.Grid.GridView gv;
        public DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
