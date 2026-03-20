using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAddStockManual
   {

#region "Upgrade Support "
      private static frmAddStockManual m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmAddStockManual>($"{typeof(frmAddStockManual).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmAddStockManual).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmAddStockManual).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmAddStockManual).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmAddStockManual DefInstance
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
      public static frmAddStockManual CreateInstance()
      {
         frmAddStockManual theInstance = new frmAddStockManual();
         theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "cmdSave", "cmdClose", "sbStatusBar_Panels_Panel1", "sbStatusBar", "txtUnit", "txtProductName", "txtQuantityPerUnit", "_txtValues_2", "_txtValues_1", "_txtValues_0", "cmdProducts", "txtName", "txtCode", "Label4", "Label5", "Frame1", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "lblNewQuantity", "Label10", "Label9", "Label8", "Label7", "Label6", "Label1", "Label2", "Label3", "txtValues", "listViewHelper1", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.Button cmdSave { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      public Gap.Blazor.StatusStrip sbStatusBar { get; set; }

      public Gap.Blazor.TextBox txtUnit { get; set; }

      public Gap.Blazor.TextBox txtProductName { get; set; }

      public Gap.Blazor.TextBox txtQuantityPerUnit { get; set; }

      public Gap.Blazor.TextBox _txtValues_2 { get; set; }

      public Gap.Blazor.TextBox _txtValues_1 { get; set; }

      public Gap.Blazor.TextBox _txtValues_0 { get; set; }

      public Gap.Blazor.Button cmdProducts { get; set; }

      public Gap.Blazor.TextBox txtName { get; set; }

      public Gap.Blazor.TextBox txtCode { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.Label Label5 { get; set; }

      public Gap.Blazor.GroupBox Frame1 { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_1_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_2_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_3_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_4_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_5_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_6_ { get; set; }

      public Gap.Blazor.ColumnHeader lvProducts_ColumnHeader_7_ { get; set; }

      public Gap.Blazor.ListView lvProducts { get; set; }

      public Gap.Blazor.Label lblNewQuantity { get; set; }

      public Gap.Blazor.Label Label10 { get; set; }

      public Gap.Blazor.Label Label9 { get; set; }

      public Gap.Blazor.Label Label8 { get; set; }

      public Gap.Blazor.Label Label7 { get; set; }

      public Gap.Blazor.Label Label6 { get; set; }

      public Gap.Blazor.Label Label1 { get; set; }

      public Gap.Blazor.Label Label2 { get; set; }

      public Gap.Blazor.Label Label3 { get; set; }

      public Gap.Blazor.TextBox[] txtValues = new Gap.Blazor.TextBox[3];

      public Gap.Blazor.ListView listViewHelper1 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStockManual));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         cmdSave = new Gap.Blazor.Button();
         cmdClose = new Gap.Blazor.Button();
         sbStatusBar = new Gap.Blazor.StatusStrip();
         sbStatusBar_Panels_Panel1 = new Gap.Blazor.ToolStripStatusLabel();
         txtUnit = new Gap.Blazor.TextBox();
         txtProductName = new Gap.Blazor.TextBox();
         txtQuantityPerUnit = new Gap.Blazor.TextBox();
         _txtValues_2 = new Gap.Blazor.TextBox();
         _txtValues_1 = new Gap.Blazor.TextBox();
         _txtValues_0 = new Gap.Blazor.TextBox();
         Frame1 = new Gap.Blazor.GroupBox();
         cmdProducts = new Gap.Blazor.Button();
         txtName = new Gap.Blazor.TextBox();
         txtCode = new Gap.Blazor.TextBox();
         Label4 = new Gap.Blazor.Label();
         Label5 = new Gap.Blazor.Label();
         lvProducts = new Gap.Blazor.ListView();
         lvProducts_ColumnHeader_1_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_2_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_3_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_4_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_5_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_6_ = new Gap.Blazor.ColumnHeader();
         lvProducts_ColumnHeader_7_ = new Gap.Blazor.ColumnHeader();
         lblNewQuantity = new Gap.Blazor.Label();
         Label10 = new Gap.Blazor.Label();
         Label9 = new Gap.Blazor.Label();
         Label8 = new Gap.Blazor.Label();
         Label7 = new Gap.Blazor.Label();
         Label6 = new Gap.Blazor.Label();
         Label1 = new Gap.Blazor.Label();
         Label2 = new Gap.Blazor.Label();
         Label3 = new Gap.Blazor.Label();
         sbStatusBar.SuspendLayout();
         Frame1.SuspendLayout();
         lvProducts.SuspendLayout();
         SuspendLayout();
         listViewHelper1 = new Gap.Blazor.ListView(components);
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // cmdSave
         // 
         cmdSave.AllowDrop = true;
         cmdSave.BackColor = Gap.Blazor.SystemColors.Control;
         cmdSave.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdSave.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdSave.Location = new System.Drawing.Point(224, 376);
         cmdSave.Name = "cmdSave";
         cmdSave.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdSave.Size = new System.Drawing.Size(89, 25);
         cmdSave.TabIndex = 24;
         cmdSave.Text = "&Save";
         cmdSave.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdSave.UseVisualStyleBackColor = false;
         cmdSave.ClickAsync += new AsyncEventHandler(cmdSave_Click);
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(328, 376);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(89, 25);
         cmdClose.TabIndex = 23;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // sbStatusBar
         // 
         sbStatusBar.AllowDrop = true;
         sbStatusBar.Properties().BackColor = Gap.Blazor.SystemColors.Control;
         sbStatusBar.Dock = Gap.Blazor.DockStyle.Bottom;
         sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         sbStatusBar.Location = new System.Drawing.Point(0, 416);
         sbStatusBar.Name = "sbStatusBar";
         sbStatusBar.Properties().ShowItemToolTips = true;
         sbStatusBar.Size = new System.Drawing.Size(424, 23);
         sbStatusBar.TabIndex = 20;
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
         // txtUnit
         // 
         txtUnit.AcceptsReturn = true;
         txtUnit.AllowDrop = true;
         txtUnit.BackColor = Gap.Blazor.SystemColors.Menu;
         txtUnit.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtUnit.Cursor = Gap.Blazor.Cursors.IBeam;
         txtUnit.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtUnit.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtUnit.Location = new System.Drawing.Point(320, 264);
         txtUnit.MaxLength = 0;
         txtUnit.Name = "txtUnit";
         txtUnit.ReadOnly = true;
         txtUnit.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtUnit.Size = new System.Drawing.Size(81, 20);
         txtUnit.TabIndex = 18;
         txtUnit.TabStop = false;
         // 
         // txtProductName
         // 
         txtProductName.AcceptsReturn = true;
         txtProductName.AllowDrop = true;
         txtProductName.BackColor = Gap.Blazor.SystemColors.Menu;
         txtProductName.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtProductName.Cursor = Gap.Blazor.Cursors.IBeam;
         txtProductName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtProductName.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtProductName.Location = new System.Drawing.Point(96, 264);
         txtProductName.MaxLength = 0;
         txtProductName.Name = "txtProductName";
         txtProductName.ReadOnly = true;
         txtProductName.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtProductName.Size = new System.Drawing.Size(145, 20);
         txtProductName.TabIndex = 16;
         txtProductName.TabStop = false;
         // 
         // txtQuantityPerUnit
         // 
         txtQuantityPerUnit.AcceptsReturn = true;
         txtQuantityPerUnit.AllowDrop = true;
         txtQuantityPerUnit.BackColor = Gap.Blazor.SystemColors.Menu;
         txtQuantityPerUnit.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtQuantityPerUnit.Cursor = Gap.Blazor.Cursors.IBeam;
         txtQuantityPerUnit.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtQuantityPerUnit.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtQuantityPerUnit.Location = new System.Drawing.Point(320, 296);
         txtQuantityPerUnit.MaxLength = 0;
         txtQuantityPerUnit.Name = "txtQuantityPerUnit";
         txtQuantityPerUnit.ReadOnly = true;
         txtQuantityPerUnit.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtQuantityPerUnit.Size = new System.Drawing.Size(81, 20);
         txtQuantityPerUnit.TabIndex = 15;
         txtQuantityPerUnit.TabStop = false;
         txtQuantityPerUnit.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // _txtValues_2
         // 
         _txtValues_2.AcceptsReturn = true;
         _txtValues_2.AllowDrop = true;
         _txtValues_2.BackColor = Gap.Blazor.SystemColors.Window;
         _txtValues_2.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtValues_2.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtValues_2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtValues_2.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtValues_2.Location = new System.Drawing.Point(320, 328);
         _txtValues_2.MaxLength = 0;
         _txtValues_2.Name = "_txtValues_2";
         _txtValues_2.ReadOnly = true;
         _txtValues_2.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtValues_2.Size = new System.Drawing.Size(81, 20);
         _txtValues_2.TabIndex = 5;
         _txtValues_2.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         _txtValues_2.Enter += new System.EventHandler(txtValues_Enter);
         _txtValues_2.KeyPress += new Gap.Blazor.KeyPressEventHandler(txtValues_KeyPress);
         _txtValues_2.TextChanged += new System.EventHandler(txtValues_TextChanged);
         // 
         // _txtValues_1
         // 
         _txtValues_1.AcceptsReturn = true;
         _txtValues_1.AllowDrop = true;
         _txtValues_1.BackColor = Gap.Blazor.SystemColors.Window;
         _txtValues_1.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtValues_1.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtValues_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtValues_1.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtValues_1.Location = new System.Drawing.Point(96, 328);
         _txtValues_1.MaxLength = 0;
         _txtValues_1.Name = "_txtValues_1";
         _txtValues_1.ReadOnly = true;
         _txtValues_1.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtValues_1.Size = new System.Drawing.Size(81, 20);
         _txtValues_1.TabIndex = 4;
         _txtValues_1.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         _txtValues_1.Enter += new System.EventHandler(txtValues_Enter);
         _txtValues_1.KeyPress += new Gap.Blazor.KeyPressEventHandler(txtValues_KeyPress);
         _txtValues_1.TextChanged += new System.EventHandler(txtValues_TextChanged);
         // 
         // _txtValues_0
         // 
         _txtValues_0.AcceptsReturn = true;
         _txtValues_0.AllowDrop = true;
         _txtValues_0.BackColor = Gap.Blazor.SystemColors.Window;
         _txtValues_0.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtValues_0.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtValues_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtValues_0.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtValues_0.Location = new System.Drawing.Point(96, 296);
         _txtValues_0.MaxLength = 0;
         _txtValues_0.Name = "_txtValues_0";
         _txtValues_0.ReadOnly = true;
         _txtValues_0.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtValues_0.Size = new System.Drawing.Size(81, 20);
         _txtValues_0.TabIndex = 3;
         _txtValues_0.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         _txtValues_0.Enter += new System.EventHandler(txtValues_Enter);
         _txtValues_0.KeyPress += new Gap.Blazor.KeyPressEventHandler(txtValues_KeyPress);
         _txtValues_0.TextChanged += new System.EventHandler(txtValues_TextChanged);
         // 
         // Frame1
         // 
         Frame1.AllowDrop = true;
         Frame1.BackColor = Gap.Blazor.SystemColors.Control;
         Frame1.Controls.Add(cmdProducts);
         Frame1.Controls.Add(txtName);
         Frame1.Controls.Add(txtCode);
         Frame1.Controls.Add(Label4);
         Frame1.Controls.Add(Label5);
         Frame1.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame1.Enabled = true;
         Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame1.Location = new System.Drawing.Point(8, 32);
         Frame1.Name = "Frame1";
         Frame1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame1.Size = new System.Drawing.Size(409, 65);
         Frame1.TabIndex = 6;
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
         cmdProducts.TabIndex = 7;
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
         txtName.LeaveAsync += new AsyncEventHandler(txtName_Leave);
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
         txtCode.LeaveAsync += new AsyncEventHandler(txtCode_Leave);
         txtCode.TextChanged += new System.EventHandler(txtCode_TextChanged);
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
         Label4.Text = "Name ";
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
         lvProducts.Location = new System.Drawing.Point(8, 104);
         lvProducts.MultiSelect = false;
         lvProducts.Name = "lvProducts";
         lvProducts.Size = new System.Drawing.Size(409, 153);
         lvProducts.TabIndex = 2;
         lvProducts.View = Gap.Blazor.ListViewMode.Details;
         lvProducts.Columns.Add(lvProducts_ColumnHeader_1_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_2_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_3_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_4_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_5_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_6_);
         lvProducts.Columns.Add(lvProducts_ColumnHeader_7_);
         lvProducts.ClickAsync += new AsyncEventHandler(lvProducts_Click);
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
         // lblNewQuantity
         // 
         lblNewQuantity.AllowDrop = true;
         lblNewQuantity.BackColor = Gap.Blazor.SystemColors.Control;
         lblNewQuantity.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblNewQuantity.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblNewQuantity.ForeColor = Gap.Blazor.SystemColors.ControlText;
         lblNewQuantity.Location = new System.Drawing.Point(104, 363);
         lblNewQuantity.MinimumSize = new System.Drawing.Size(89, 17);
         lblNewQuantity.Name = "lblNewQuantity";
         lblNewQuantity.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblNewQuantity.Size = new System.Drawing.Size(89, 17);
         lblNewQuantity.TabIndex = 22;
         // 
         // Label10
         // 
         Label10.AllowDrop = true;
         Label10.BackColor = Gap.Blazor.SystemColors.Control;
         Label10.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label10.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label10.Location = new System.Drawing.Point(8, 363);
         Label10.MinimumSize = new System.Drawing.Size(73, 17);
         Label10.Name = "Label10";
         Label10.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label10.Size = new System.Drawing.Size(73, 17);
         Label10.TabIndex = 21;
         Label10.Text = "Stock quantity";
         // 
         // Label9
         // 
         Label9.AllowDrop = true;
         Label9.BackColor = Gap.Blazor.SystemColors.Control;
         Label9.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label9.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label9.Location = new System.Drawing.Point(288, 264);
         Label9.MinimumSize = new System.Drawing.Size(25, 17);
         Label9.Name = "Label9";
         Label9.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label9.Size = new System.Drawing.Size(25, 17);
         Label9.TabIndex = 19;
         Label9.Text = "Unit";
         // 
         // Label8
         // 
         Label8.AllowDrop = true;
         Label8.BackColor = Gap.Blazor.SystemColors.Control;
         Label8.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label8.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label8.Location = new System.Drawing.Point(8, 264);
         Label8.MinimumSize = new System.Drawing.Size(74, 17);
         Label8.Name = "Label8";
         Label8.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label8.Size = new System.Drawing.Size(74, 17);
         Label8.TabIndex = 17;
         Label8.Text = "Product";
         // 
         // Label7
         // 
         Label7.AllowDrop = true;
         Label7.BackColor = Gap.Blazor.SystemColors.Control;
         Label7.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label7.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label7.Location = new System.Drawing.Point(224, 296);
         Label7.MinimumSize = new System.Drawing.Size(89, 17);
         Label7.Name = "Label7";
         Label7.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label7.Size = new System.Drawing.Size(89, 17);
         Label7.TabIndex = 14;
         Label7.Text = "Units";
         // 
         // Label6
         // 
         Label6.AllowDrop = true;
         Label6.BackColor = Gap.Blazor.SystemColors.Control;
         Label6.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label6.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label6.Location = new System.Drawing.Point(224, 331);
         Label6.MinimumSize = new System.Drawing.Size(73, 17);
         Label6.Name = "Label6";
         Label6.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label6.Size = new System.Drawing.Size(73, 17);
         Label6.TabIndex = 13;
         Label6.Text = "Unit Price";
         // 
         // Label1
         // 
         Label1.AllowDrop = true;
         Label1.BackColor = Gap.Blazor.SystemColors.Control;
         Label1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label1.Location = new System.Drawing.Point(8, 331);
         Label1.MinimumSize = new System.Drawing.Size(73, 17);
         Label1.Name = "Label1";
         Label1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label1.Size = new System.Drawing.Size(73, 17);
         Label1.TabIndex = 12;
         Label1.Text = "Price";
         // 
         // Label2
         // 
         Label2.AllowDrop = true;
         Label2.BackColor = Gap.Blazor.SystemColors.Control;
         Label2.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label2.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label2.Location = new System.Drawing.Point(8, 299);
         Label2.MinimumSize = new System.Drawing.Size(74, 17);
         Label2.Name = "Label2";
         Label2.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label2.Size = new System.Drawing.Size(74, 17);
         Label2.TabIndex = 11;
         Label2.Text = "Quantity";
         // 
         // Label3
         // 
         Label3.AllowDrop = true;
         Label3.BackColor = Gap.Blazor.SystemColors.Control;
         Label3.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label3.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label3.Location = new System.Drawing.Point(16, 8);
         Label3.MinimumSize = new System.Drawing.Size(121, 17);
         Label3.Name = "Label3";
         Label3.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label3.Size = new System.Drawing.Size(121, 17);
         Label3.TabIndex = 10;
         Label3.Text = "Select a product first";
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         AutoScroll = true;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(424, 439);
         Controls.Add(cmdSave);
         Controls.Add(cmdClose);
         Controls.Add(sbStatusBar);
         Controls.Add(txtUnit);
         Controls.Add(txtProductName);
         Controls.Add(txtQuantityPerUnit);
         Controls.Add(_txtValues_2);
         Controls.Add(_txtValues_1);
         Controls.Add(_txtValues_0);
         Controls.Add(Frame1);
         Controls.Add(lvProducts);
         Controls.Add(lblNewQuantity);
         Controls.Add(Label10);
         Controls.Add(Label9);
         Controls.Add(Label8);
         Controls.Add(Label7);
         Controls.Add(Label6);
         Controls.Add(Label1);
         Controls.Add(Label2);
         Controls.Add(Label3);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmAddStockManual";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         StartPosition = Gap.Blazor.FormStartPosition.Manual;
         Text = "Inventory Update";
         cmdSave.SetStyle(0);
         cmdClose.SetStyle(0);
         cmdProducts.SetStyle(0);
         Activated += new System.EventHandler(frmAddStockManual_Activated);
         Closed += new System.EventHandler(Form_Closed);
         FormClosing += new Gap.Blazor.FormClosingEventHandler(Form_FormClosing);
         listViewHelper1.SetItemClickMethod(lvProducts, "lvProducts_ItemClick");
         listViewHelper1.SetCorrectEventsBehavior(lvProducts, true);
         sbStatusBar.ResumeLayout(false);
         Frame1.ResumeLayout(false);
         lvProducts.ResumeLayout(false);
         ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         InitializetxtValues();
         MdiParent = SKS.frmMain.DefInstance;
         SKS.frmMain.DefInstance.Show();
      }

      void InitializetxtValues()
      {
         txtValues = new Gap.Blazor.TextBox[3];
         txtValues[2] = _txtValues_2;
         txtValues[1] = _txtValues_1;
         txtValues[0] = _txtValues_0;
      }
#endregion

   }

}