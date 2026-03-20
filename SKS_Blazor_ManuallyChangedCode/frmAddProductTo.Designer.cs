using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAddProductTo
   {

#region "Upgrade Support "
      private static frmAddProductTo m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmAddProductTo>($"{typeof(frmAddProductTo).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmAddProductTo).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmAddProductTo).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmAddProductTo).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmAddProductTo DefInstance
      {
         get
         {
            if ( m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed )
            {
               m_InitializingDefInstance = true;
               m_vb6FormDefInstance = CreateInstance();
               m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
         }
         set
         {
            m_vb6FormDefInstance = value;
         }
      }
#endregion

#region "Windows Form Designer generated code "
      public static frmAddProductTo CreateInstance()
      {
         frmAddProductTo theInstance = new frmAddProductTo();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "chkAll", "cmdRemove", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdClose", "cmdSave", "cmdProducts", "txtName", "txtCode", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label4", "Label5", "Frame1", "lvProductsBy_ColumnHeader_1_", "lvProductsBy_ColumnHeader_2_", "lvProductsBy_ColumnHeader_3_", "lvProductsBy_ColumnHeader_4_", "lvProductsBy", "lblProductsRelated", "listViewHelper1", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.CheckBox chkAll { get; set; }

      public Gap.Blazor.Button cmdRemove { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      public Gap.Blazor.StatusStrip sbStatusBar { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.Button cmdSave { get; set; }

      public Gap.Blazor.Button cmdProducts { get; set; }

      public Gap.Blazor.TextBox txtName { get; set; }

      public Gap.Blazor.TextBox txtCode { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_1_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_2_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_3_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_4_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_5_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_6_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_7_ { get; set; }

      public Gap.Blazor.ListView lvProducts { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.Label Label5 { get; set; }

      public Gap.Blazor.GroupBox Frame1 { get; set; }

      public Gap.Blazor.ColumnHeader lvProductsBy_ColumnHeader_1_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProductsBy_ColumnHeader_2_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProductsBy_ColumnHeader_3_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProductsBy_ColumnHeader_4_ { get; set; }

      public Gap.Blazor.ListView lvProductsBy { get; set; }

      public Gap.Blazor.Label lblProductsRelated { get; set; }

      public Gap.Blazor.ListView listViewHelper1 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductTo));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         chkAll = new Gap.Blazor.CheckBox();
         cmdRemove = new Gap.Blazor.Button();
         sbStatusBar = new Gap.Blazor.StatusStrip();
         sbStatusBar_Panels_Panel1 = new Gap.Blazor.ToolStripStatusLabel();
         cmdClose = new Gap.Blazor.Button();
         cmdSave = new Gap.Blazor.Button();
         Frame1 = new Gap.Blazor.GroupBox();
         cmdProducts = new Gap.Blazor.Button();
         txtName = new Gap.Blazor.TextBox();
         txtCode = new Gap.Blazor.TextBox();
         lvProducts = new Gap.Blazor.ListView();
         lvProducts_ColumnHeader_1_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_2_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_3_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_4_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_5_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_6_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_7_ = new Gap.Blazor.ColumnHeader();
         Label4 = new Gap.Blazor.Label();
         Label5 = new Gap.Blazor.Label();
         lvProductsBy = new Gap.Blazor.ListView();
         lvProductsBy_ColumnHeader_1_ = new Gap.Blazor.ColumnHeader();
         lvProductsBy_ColumnHeader_2_ = new Gap.Blazor.ColumnHeader();
         lvProductsBy_ColumnHeader_3_ = new Gap.Blazor.ColumnHeader();
         lvProductsBy_ColumnHeader_4_ = new Gap.Blazor.ColumnHeader();
         lblProductsRelated = new Gap.Blazor.Label();
         sbStatusBar.SuspendLayout();
         Frame1.SuspendLayout();
         lvProducts.SuspendLayout();
         lvProductsBy.SuspendLayout();
         SuspendLayout();
         listViewHelper1 = new Gap.Blazor.ListView(components);
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // chkAll
         // 
         chkAll.AllowDrop = true;
         chkAll.Appearance = Gap.Blazor.Appearance.Normal;
         chkAll.BackColor = Gap.Blazor.SystemColors.Control;
         chkAll.CausesValidation = true;
         chkAll.CheckAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         chkAll.CheckState = Gap.Blazor.CheckState.Unchecked;
         chkAll.Enabled = true;
         chkAll.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         chkAll.ForeColor = Gap.Blazor.SystemColors.ControlText;
         chkAll.Location = new System.Drawing.Point(112, 454);
         chkAll.Name = "chkAll";
         chkAll.RightToLeft = Gap.Blazor.RightToLeft.No;
         chkAll.Size = new System.Drawing.Size(81, 17);
         chkAll.TabIndex = 13;
         chkAll.TabStop = false;
         chkAll.Text = "Check All";
         chkAll.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         chkAll.Visible = true;
         chkAll.CheckStateChanged += new System.EventHandler(chkAll_CheckStateChanged);
         // 
         // cmdRemove
         // 
         cmdRemove.AllowDrop = true;
         cmdRemove.BackColor = Gap.Blazor.SystemColors.Control;
         cmdRemove.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdRemove.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdRemove.Location = new System.Drawing.Point(8, 448);
         cmdRemove.Name = "cmdRemove";
         cmdRemove.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdRemove.Size = new System.Drawing.Size(97, 25);
         cmdRemove.TabIndex = 12;
         cmdRemove.TabStop = false;
         cmdRemove.Text = "&Remove ";
         cmdRemove.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdRemove.UseVisualStyleBackColor = false;
         cmdRemove.Click += new System.EventHandler(cmdRemove_Click);
         // 
         // sbStatusBar
         // 
         sbStatusBar.AllowDrop = true;
         sbStatusBar.Properties().BackColor = Gap.Blazor.SystemColors.Control;
         sbStatusBar.Dock = Gap.Blazor.DockStyle.Bottom;
         sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         sbStatusBar.Location = new System.Drawing.Point(0, 488);
         sbStatusBar.Name = "sbStatusBar";
         sbStatusBar.Properties().ShowItemToolTips = true;
         sbStatusBar.Size = new System.Drawing.Size(424, 23);
         sbStatusBar.TabIndex = 11;
         sbStatusBar.Items.AddRange(new Gap.Blazor.ToolStripItem[] { sbStatusBar_Panels_Panel1 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         sbStatusBar_Panels_Panel1.BorderSides = (Gap.Blazor.ToolStripStatusLabelBorderSides)(Gap.Blazor.ToolStripStatusLabelBorderSides.Left | Gap.Blazor.ToolStripStatusLabelBorderSides.Top | Gap.Blazor.ToolStripStatusLabelBorderSides.Right | Gap.Blazor.ToolStripStatusLabelBorderSides.Bottom);
         sbStatusBar_Panels_Panel1.BorderStyle = Gap.Blazor.Border3DStyle.SunkenOuter;
         sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         sbStatusBar_Panels_Panel1.Margin = new Gap.Blazor.Padding(0);
         sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(423, 23);
         sbStatusBar_Panels_Panel1.Spring = true;
         sbStatusBar_Panels_Panel1.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         sbStatusBar_Panels_Panel1.TextImageRelation = Gap.Blazor.TextImageRelation.ImageBeforeText;
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(328, 448);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(89, 25);
         cmdClose.TabIndex = 7;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // cmdSave
         // 
         cmdSave.AllowDrop = true;
         cmdSave.BackColor = Gap.Blazor.SystemColors.Control;
         cmdSave.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdSave.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdSave.Location = new System.Drawing.Point(224, 448);
         cmdSave.Name = "cmdSave";
         cmdSave.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdSave.Size = new System.Drawing.Size(89, 25);
         cmdSave.TabIndex = 6;
         cmdSave.Text = "&Save";
         cmdSave.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdSave.UseVisualStyleBackColor = false;
         cmdSave.Click += new System.EventHandler(cmdSave_Click);
         // 
         // Frame1
         // 
         Frame1.AllowDrop = true;
         Frame1.BackColor = Gap.Blazor.SystemColors.Control;
         Frame1.Controls.Add(cmdProducts);
         Frame1.Controls.Add(txtName);
         Frame1.Controls.Add(txtCode);
         Frame1.Controls.Add(lvProducts);
         Frame1.Controls.Add(Label4);
         Frame1.Controls.Add(Label5);
         Frame1.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame1.Enabled = true;
         Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame1.Location = new System.Drawing.Point(8, 8);
         Frame1.Name = "Frame1";
         Frame1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame1.Size = new System.Drawing.Size(409, 233);
         Frame1.TabIndex = 4;
         Frame1.Text = "Search product ";
         Frame1.Visible = true;
         // 
         // cmdProducts
         // 
         cmdProducts.AllowDrop = true;
         cmdProducts.BackColor = Gap.Blazor.SystemColors.Control;
         cmdProducts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdProducts.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdProducts.Location = new System.Drawing.Point(360, 16);
         cmdProducts.Name = "cmdProducts";
         cmdProducts.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdProducts.Size = new System.Drawing.Size(25, 21);
         cmdProducts.TabIndex = 5;
         cmdProducts.TabStop = false;
         cmdProducts.Text = "...";
         cmdProducts.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdProducts.UseVisualStyleBackColor = false;
         cmdProducts.ClickAsync += new AsyncEventHandler(cmdProducts_Click);
         // 
         // txtName
         // 
         txtName.AcceptsReturn = true;
         txtName.AllowDrop = true;
         txtName.BackColor = Gap.Blazor.SystemColors.Window;
         txtName.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtName.Cursor = Gap.Blazor.Cursors.IBeam;
         txtName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtName.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtName.Location = new System.Drawing.Point(112, 40);
         txtName.MaxLength = 0;
         txtName.Name = "txtName";
         txtName.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtName.Size = new System.Drawing.Size(145, 20);
         txtName.TabIndex = 1;
         txtName.TextChanged += new System.EventHandler(txtName_TextChanged);
         // 
         // txtCode
         // 
         txtCode.AcceptsReturn = true;
         txtCode.AllowDrop = true;
         txtCode.BackColor = Gap.Blazor.SystemColors.Window;
         txtCode.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtCode.Cursor = Gap.Blazor.Cursors.IBeam;
         txtCode.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtCode.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtCode.Location = new System.Drawing.Point(112, 16);
         txtCode.MaxLength = 0;
         txtCode.Name = "txtCode";
         txtCode.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtCode.Size = new System.Drawing.Size(97, 20);
         txtCode.TabIndex = 0;
         txtCode.Leave += new System.EventHandler(txtCode_Leave);
         txtCode.TextChanged += new System.EventHandler(txtCode_TextChanged);
         // 
         // lvProducts
         // 
         lvProducts.AllowDrop = true;
         lvProducts.BackColor = Gap.Blazor.SystemColors.Window;
         lvProducts.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         lvProducts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lvProducts.ForeColor = Gap.Blazor.SystemColors.WindowText;
         lvProducts.FullRowSelect = true;
         lvProducts.GridLines = true;
         lvProducts.HideSelection = false;
         lvProducts.Properties().HotTracking = true;
         lvProducts.LabelEdit = false;
         lvProducts.Location = new System.Drawing.Point(8, 64);
         lvProducts.MultiSelect = false;
         lvProducts.Name = "lvProducts";
         lvProducts.Size = new System.Drawing.Size(393, 161);
         lvProducts.TabIndex = 2;
         lvProducts.View = Gap.Blazor.ListViewMode.Details;
         lvProducts.Columns.Add(lvProducts_ColumnHeader_1_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_2_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_3_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_4_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_5_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_6_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_7_);
         // 
         // lvProducts_ColumnHeader_1_
         // 
         lvProducts_ColumnHeader_1_.Text = "Code";
         lvProducts_ColumnHeader_1_.Width = 97;
         // 
         // lvProducts_ColumnHeader_2_
         // 
         lvProducts_ColumnHeader_2_.Text = "Name";
         lvProducts_ColumnHeader_2_.Width = 97;
         // 
         // lvProducts_ColumnHeader_3_
         // 
         lvProducts_ColumnHeader_3_.Text = "Price";
         lvProducts_ColumnHeader_3_.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         lvProducts_ColumnHeader_3_.Width = 97;
         // 
         // lvProducts_ColumnHeader_4_
         // 
         lvProducts_ColumnHeader_4_.Text = "Existence";
         lvProducts_ColumnHeader_4_.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         lvProducts_ColumnHeader_4_.Width = 97;
         // 
         // lvProducts_ColumnHeader_5_
         // 
         lvProducts_ColumnHeader_5_.Text = "Ordered";
         lvProducts_ColumnHeader_5_.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         lvProducts_ColumnHeader_5_.Width = 97;
         // 
         // lvProducts_ColumnHeader_6_
         // 
         lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
         lvProducts_ColumnHeader_6_.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         lvProducts_ColumnHeader_6_.Width = 97;
         // 
         // lvProducts_ColumnHeader_7_
         // 
         lvProducts_ColumnHeader_7_.Text = "Unit";
         lvProducts_ColumnHeader_7_.Width = 97;
         // 
         // Label4
         // 
         Label4.AllowDrop = true;
         Label4.BackColor = Gap.Blazor.SystemColors.Control;
         Label4.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label4.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label4.Location = new System.Drawing.Point(16, 40);
         Label4.MinimumSize = new System.Drawing.Size(89, 17);
         Label4.Name = "Label4";
         Label4.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label4.Size = new System.Drawing.Size(89, 17);
         Label4.TabIndex = 9;
         Label4.Text = "Name";
         // 
         // Label5
         // 
         Label5.AllowDrop = true;
         Label5.BackColor = Gap.Blazor.SystemColors.Control;
         Label5.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label5.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label5.Location = new System.Drawing.Point(16, 16);
         Label5.MinimumSize = new System.Drawing.Size(89, 17);
         Label5.Name = "Label5";
         Label5.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label5.Size = new System.Drawing.Size(89, 17);
         Label5.TabIndex = 8;
         Label5.Text = "Code";
         // 
         // lvProductsBy
         // 
         lvProductsBy.AllowDrop = true;
         lvProductsBy.BackColor = Gap.Blazor.SystemColors.Window;
         lvProductsBy.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         lvProductsBy.CheckBoxes = true;
         lvProductsBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lvProductsBy.ForeColor = Gap.Blazor.SystemColors.WindowText;
         lvProductsBy.FullRowSelect = true;
         lvProductsBy.GridLines = true;
         lvProductsBy.HideSelection = false;
         lvProductsBy.Properties().HotTracking = true;
         lvProductsBy.LabelEdit = false;
         lvProductsBy.Location = new System.Drawing.Point(8, 272);
         lvProductsBy.MultiSelect = false;
         lvProductsBy.Name = "lvProductsBy";
         lvProductsBy.Size = new System.Drawing.Size(409, 169);
         lvProductsBy.TabIndex = 3;
         lvProductsBy.View = Gap.Blazor.ListViewMode.Details;
         lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_1_);
         lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_2_);
         lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_3_);
         lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_4_);
         // 
         // lvProductsBy_ColumnHeader_1_
         // 
         lvProductsBy_ColumnHeader_1_.Text = "Code";
         lvProductsBy_ColumnHeader_1_.Width = 97;
         // 
         // lvProductsBy_ColumnHeader_2_
         // 
         lvProductsBy_ColumnHeader_2_.Text = "Name";
         lvProductsBy_ColumnHeader_2_.Width = 97;
         // 
         // lvProductsBy_ColumnHeader_3_
         // 
         lvProductsBy_ColumnHeader_3_.Text = "Price";
         lvProductsBy_ColumnHeader_3_.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         lvProductsBy_ColumnHeader_3_.Width = 61;
         // 
         // lvProductsBy_ColumnHeader_4_
         // 
         lvProductsBy_ColumnHeader_4_.Text = "Quantity per Unit";
         lvProductsBy_ColumnHeader_4_.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         lvProductsBy_ColumnHeader_4_.Width = 94;
         // 
         // lblProductsRelated
         // 
         lblProductsRelated.AllowDrop = true;
         lblProductsRelated.BackColor = Gap.Blazor.SystemColors.Control;
         lblProductsRelated.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblProductsRelated.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblProductsRelated.ForeColor = Gap.Blazor.SystemColors.ControlText;
         lblProductsRelated.Location = new System.Drawing.Point(8, 248);
         lblProductsRelated.MinimumSize = new System.Drawing.Size(409, 17);
         lblProductsRelated.Name = "lblProductsRelated";
         lblProductsRelated.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblProductsRelated.Size = new System.Drawing.Size(409, 17);
         lblProductsRelated.TabIndex = 10;
         lblProductsRelated.Text = "Products";
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(424, 511);
         Controls.Add(chkAll);
         Controls.Add(cmdRemove);
         Controls.Add(sbStatusBar);
         Controls.Add(cmdClose);
         Controls.Add(cmdSave);
         Controls.Add(Frame1);
         Controls.Add(lvProductsBy);
         Controls.Add(lblProductsRelated);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmAddProductTo";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         Text = "Create New Product Item";
         cmdRemove.SetStyle(0);
         cmdClose.SetStyle(0);
         cmdSave.SetStyle(0);
         cmdProducts.SetStyle(0);
         Activated += new System.EventHandler(frmAddProductTo_Activated);
         Closed += new System.EventHandler(Form_Closed);
         FormClosing += new Gap.Blazor.FormClosingEventHandler(Form_FormClosing);
         listViewHelper1.SetItemClickMethod(lvProducts, "lvProducts_ItemClick");
         listViewHelper1.SetCorrectEventsBehavior(lvProducts, true);
         sbStatusBar.ResumeLayout(false);
         Frame1.ResumeLayout(false);
         lvProducts.ResumeLayout(false);
         lvProductsBy.ResumeLayout(false);
         ResumeLayout(false);
      }
#endregion

   }

}