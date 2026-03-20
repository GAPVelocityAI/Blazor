using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmOrderRequest
   {

#region "Upgrade Support "
      private static frmOrderRequest m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmOrderRequest>($"{typeof(frmOrderRequest).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmOrderRequest).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmOrderRequest).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmOrderRequest).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmOrderRequest DefInstance
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
      public static frmOrderRequest CreateInstance()
      {
         frmOrderRequest theInstance = new frmOrderRequest();
         theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "dtRequired", "cmdSave", "cmdAddProducts", "cmdClose", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "lvCustomers_ColumnHeader_1_", "lvCustomers_ColumnHeader_2_", "lvCustomers_ColumnHeader_3_", "lvCustomers_ColumnHeader_4_", "lvCustomers_ColumnHeader_5_", "lvCustomers_ColumnHeader_6_", "lvCustomers_ColumnHeader_7_", "lvCustomers", "Label3", "Label4", "Label2", "Frame1", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "dtPromised", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label7", "Label6", "listViewHelper1", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.TextBox txtSubTotal { get; set; }

      public Gap.Blazor.TextBox txtTotal { get; set; }

      public Gap.Blazor.TextBox txtTotalTax { get; set; }

      public Gap.Blazor.TextBox txtFreightCharge { get; set; }

      public Gap.Blazor.TextBox txtSalesTax { get; set; }

      public Gap.Blazor.TextBox txtEntry { get; set; }

      public Gap.Blazor.DataGridViewFlex fgProducts { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      public Gap.Blazor.StatusStrip sbStatusBar { get; set; }

      public Gap.Blazor.DateTimePicker dtRequired { get; set; }

      public Gap.Blazor.Button cmdSave { get; set; }

      public Gap.Blazor.Button cmdAddProducts { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.TextBox txtContactLastName { get; set; }

      public Gap.Blazor.TextBox txtContactName { get; set; }

      public Gap.Blazor.Button cmdCustomers { get; set; }

      public Gap.Blazor.TextBox txtCompanyName { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_1_ { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_2_ { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_3_ { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_4_ { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_5_ { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_6_ { get; set; }

      public Gap.Blazor.ColumnHeader lvCustomers_ColumnHeader_7_ { get; set; }

      public Gap.Blazor.ListView lvCustomers { get; set; }

      public Gap.Blazor.Label Label3 { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.Label Label2 { get; set; }

      public Gap.Blazor.GroupBox Frame1 { get; set; }

      public Gap.Blazor.TextBox txtCustomerContact { get; set; }

      public Gap.Blazor.TextBox txtCustomerCompany { get; set; }

      public Gap.Blazor.Label Label5 { get; set; }

      public Gap.Blazor.Label Label1 { get; set; }

      public Gap.Blazor.GroupBox Frame2 { get; set; }

      public Gap.Blazor.DateTimePicker dtPromised { get; set; }

      public Gap.Blazor.Label Label13 { get; set; }

      public Gap.Blazor.Label Label12 { get; set; }

      public Gap.Blazor.Label Label11 { get; set; }

      public Gap.Blazor.Label Label10 { get; set; }

      public Gap.Blazor.Label Label9 { get; set; }

      public Gap.Blazor.Label Label8 { get; set; }

      public Gap.Blazor.Label Label7 { get; set; }

      public Gap.Blazor.Label Label6 { get; set; }

      public Gap.Blazor.ListView listViewHelper1 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderRequest));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         txtSubTotal = new Gap.Blazor.TextBox();
         txtTotal = new Gap.Blazor.TextBox();
         txtTotalTax = new Gap.Blazor.TextBox();
         txtFreightCharge = new Gap.Blazor.TextBox();
         txtSalesTax = new Gap.Blazor.TextBox();
         txtEntry = new Gap.Blazor.TextBox();
         fgProducts = new Gap.Blazor.DataGridViewFlex(components);
         sbStatusBar = new Gap.Blazor.StatusStrip();
         sbStatusBar_Panels_Panel1 = new Gap.Blazor.ToolStripStatusLabel();
         dtRequired = new Gap.Blazor.DateTimePicker();
         cmdSave = new Gap.Blazor.Button();
         cmdAddProducts = new Gap.Blazor.Button();
         cmdClose = new Gap.Blazor.Button();
         Frame1 = new Gap.Blazor.GroupBox();
         txtContactLastName = new Gap.Blazor.TextBox();
         txtContactName = new Gap.Blazor.TextBox();
         cmdCustomers = new Gap.Blazor.Button();
         txtCompanyName = new Gap.Blazor.TextBox();
         lvCustomers = new Gap.Blazor.ListView();
         lvCustomers_ColumnHeader_1_ = new Gap.Blazor.ColumnHeader();
         lvCustomers_ColumnHeader_2_ = new Gap.Blazor.ColumnHeader();
         lvCustomers_ColumnHeader_3_ = new Gap.Blazor.ColumnHeader();
         lvCustomers_ColumnHeader_4_ = new Gap.Blazor.ColumnHeader();
         lvCustomers_ColumnHeader_5_ = new Gap.Blazor.ColumnHeader();
         lvCustomers_ColumnHeader_6_ = new Gap.Blazor.ColumnHeader();
         lvCustomers_ColumnHeader_7_ = new Gap.Blazor.ColumnHeader();
         Label3 = new Gap.Blazor.Label();
         Label4 = new Gap.Blazor.Label();
         Label2 = new Gap.Blazor.Label();
         Frame2 = new Gap.Blazor.GroupBox();
         txtCustomerContact = new Gap.Blazor.TextBox();
         txtCustomerCompany = new Gap.Blazor.TextBox();
         Label5 = new Gap.Blazor.Label();
         Label1 = new Gap.Blazor.Label();
         dtPromised = new Gap.Blazor.DateTimePicker();
         Label13 = new Gap.Blazor.Label();
         Label12 = new Gap.Blazor.Label();
         Label11 = new Gap.Blazor.Label();
         Label10 = new Gap.Blazor.Label();
         Label9 = new Gap.Blazor.Label();
         Label8 = new Gap.Blazor.Label();
         Label7 = new Gap.Blazor.Label();
         Label6 = new Gap.Blazor.Label();
         sbStatusBar.SuspendLayout();
         Frame1.SuspendLayout();
         lvCustomers.SuspendLayout();
         Frame2.SuspendLayout();
         SuspendLayout();
         listViewHelper1 = new Gap.Blazor.ListView(components);
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // txtSubTotal
         // 
         txtSubTotal.AcceptsReturn = true;
         txtSubTotal.AllowDrop = true;
         txtSubTotal.BackColor = Gap.Blazor.SystemColors.Menu;
         txtSubTotal.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtSubTotal.Cursor = Gap.Blazor.Cursors.IBeam;
         txtSubTotal.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtSubTotal.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtSubTotal.Location = new System.Drawing.Point(352, 616);
         txtSubTotal.MaxLength = 0;
         txtSubTotal.Name = "txtSubTotal";
         txtSubTotal.ReadOnly = true;
         txtSubTotal.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtSubTotal.Size = new System.Drawing.Size(145, 20);
         txtSubTotal.TabIndex = 31;
         txtSubTotal.TabStop = false;
         txtSubTotal.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // txtTotal
         // 
         txtTotal.AcceptsReturn = true;
         txtTotal.AllowDrop = true;
         txtTotal.BackColor = Gap.Blazor.SystemColors.Menu;
         txtTotal.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtTotal.Cursor = Gap.Blazor.Cursors.IBeam;
         txtTotal.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtTotal.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtTotal.Location = new System.Drawing.Point(96, 616);
         txtTotal.MaxLength = 0;
         txtTotal.Name = "txtTotal";
         txtTotal.ReadOnly = true;
         txtTotal.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtTotal.Size = new System.Drawing.Size(145, 20);
         txtTotal.TabIndex = 29;
         txtTotal.TabStop = false;
         txtTotal.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // txtTotalTax
         // 
         txtTotalTax.AcceptsReturn = true;
         txtTotalTax.AllowDrop = true;
         txtTotalTax.BackColor = Gap.Blazor.SystemColors.Menu;
         txtTotalTax.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtTotalTax.Cursor = Gap.Blazor.Cursors.IBeam;
         txtTotalTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtTotalTax.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtTotalTax.Location = new System.Drawing.Point(352, 592);
         txtTotalTax.MaxLength = 0;
         txtTotalTax.Name = "txtTotalTax";
         txtTotalTax.ReadOnly = true;
         txtTotalTax.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtTotalTax.Size = new System.Drawing.Size(145, 20);
         txtTotalTax.TabIndex = 27;
         txtTotalTax.TabStop = false;
         txtTotalTax.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // txtFreightCharge
         // 
         txtFreightCharge.AcceptsReturn = true;
         txtFreightCharge.AllowDrop = true;
         txtFreightCharge.BackColor = Gap.Blazor.SystemColors.Window;
         txtFreightCharge.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtFreightCharge.Cursor = Gap.Blazor.Cursors.IBeam;
         txtFreightCharge.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtFreightCharge.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtFreightCharge.Location = new System.Drawing.Point(96, 592);
         txtFreightCharge.MaxLength = 0;
         txtFreightCharge.Name = "txtFreightCharge";
         txtFreightCharge.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         txtFreightCharge.TabIndex = 8;
         txtFreightCharge.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         txtFreightCharge.KeyPress += new Gap.Blazor.KeyPressEventHandler(txtFreightCharge_KeyPress);
         txtFreightCharge.TextChanged += new System.EventHandler(txtFreightCharge_TextChanged);
         // 
         // txtSalesTax
         // 
         txtSalesTax.AcceptsReturn = true;
         txtSalesTax.AllowDrop = true;
         txtSalesTax.BackColor = Gap.Blazor.SystemColors.Window;
         txtSalesTax.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtSalesTax.Cursor = Gap.Blazor.Cursors.IBeam;
         txtSalesTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtSalesTax.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtSalesTax.Location = new System.Drawing.Point(96, 568);
         txtSalesTax.MaxLength = 0;
         txtSalesTax.Name = "txtSalesTax";
         txtSalesTax.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtSalesTax.Size = new System.Drawing.Size(145, 20);
         txtSalesTax.TabIndex = 7;
         txtSalesTax.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         txtSalesTax.KeyPress += new Gap.Blazor.KeyPressEventHandler(txtSalesTax_KeyPress);
         txtSalesTax.TextChanged += new System.EventHandler(txtSalesTax_TextChanged);
         // 
         // txtEntry
         // 
         txtEntry.AcceptsReturn = true;
         txtEntry.AllowDrop = true;
         txtEntry.BackColor = Gap.Blazor.SystemColors.Window;
         txtEntry.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtEntry.Cursor = Gap.Blazor.Cursors.IBeam;
         txtEntry.Enabled = false;
         txtEntry.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtEntry.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtEntry.Location = new System.Drawing.Point(96, 544);
         txtEntry.MaxLength = 0;
         txtEntry.Name = "txtEntry";
         txtEntry.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtEntry.Size = new System.Drawing.Size(145, 19);
         txtEntry.TabIndex = 24;
         txtEntry.Leave += new System.EventHandler(txtEntry_Leave);
         // 
         // fgProducts
         // 
         fgProducts.AllowDrop = true;
         fgProducts.AllowUserToAddRows = false;
         fgProducts.AllowUserToDeleteRows = false;
         fgProducts.Properties().AllowUserToResizeColumns = false;
         fgProducts.Properties().AllowUserToResizeRows = false;
         fgProducts.BorderStyle = Gap.Blazor.BorderStyle.None;
         fgProducts.Properties().ColumnHeadersHeightSizeMode = Gap.Blazor.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         fgProducts.ColumnsCount = 0;
         fgProducts.FixedColumns = 0;
         fgProducts.FixedRows = 0;
         fgProducts.Location = new System.Drawing.Point(8, 360);
         fgProducts.Name = "fgProducts";
         fgProducts.Properties().ReadOnly = true;
         fgProducts.RowsCount = 2;
         fgProducts.Properties().SelectionMode = Gap.Blazor.DataGridViewSelectionMode.CellSelect;
         fgProducts.ShowCellToolTips = false;
         fgProducts.Size = new System.Drawing.Size(505, 177);
         fgProducts.Properties().StandardTab = true;
         fgProducts.TabIndex = 6;
         fgProducts.CellLeave += new Gap.Blazor.DataGridViewCellEventHandler(fgProducts_CellLeave);
         fgProducts.Click += new System.EventHandler(fgProducts_Click);
         fgProducts.KeyPress += new Gap.Blazor.KeyPressEventHandler(fgProducts_KeyPress);
         // 
         // sbStatusBar
         // 
         sbStatusBar.AllowDrop = true;
         sbStatusBar.Properties().BackColor = Gap.Blazor.SystemColors.Control;
         sbStatusBar.Dock = Gap.Blazor.DockStyle.Bottom;
         sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         sbStatusBar.Location = new System.Drawing.Point(0, 678);
         sbStatusBar.Name = "sbStatusBar";
         sbStatusBar.Properties().ShowItemToolTips = true;
         sbStatusBar.Size = new System.Drawing.Size(523, 25);
         sbStatusBar.TabIndex = 23;
         sbStatusBar.Items.AddRange(new Gap.Blazor.ToolStripItem[] { sbStatusBar_Panels_Panel1 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         sbStatusBar_Panels_Panel1.BorderSides = (Gap.Blazor.ToolStripStatusLabelBorderSides)(Gap.Blazor.ToolStripStatusLabelBorderSides.Left | Gap.Blazor.ToolStripStatusLabelBorderSides.Top | Gap.Blazor.ToolStripStatusLabelBorderSides.Right | Gap.Blazor.ToolStripStatusLabelBorderSides.Bottom);
         sbStatusBar_Panels_Panel1.BorderStyle = Gap.Blazor.Border3DStyle.SunkenOuter;
         sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         sbStatusBar_Panels_Panel1.Margin = new Gap.Blazor.Padding(0);
         sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(523, 25);
         sbStatusBar_Panels_Panel1.Spring = true;
         sbStatusBar_Panels_Panel1.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         sbStatusBar_Panels_Panel1.TextImageRelation = Gap.Blazor.TextImageRelation.ImageBeforeText;
         // 
         // dtRequired
         // 
         dtRequired.AllowDrop = true;
         dtRequired.Checked = false;
         dtRequired.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         dtRequired.Format = Gap.Blazor.DateTimePickerFormat.Short;
         dtRequired.Location = new System.Drawing.Point(120, 320);
         dtRequired.Name = "dtRequired";
         dtRequired.Size = new System.Drawing.Size(97, 20);
         dtRequired.TabIndex = 4;
         dtRequired.ValueChanged += new System.EventHandler(dtRequired_ValueChanged);
         // 
         // cmdSave
         // 
         cmdSave.AllowDrop = true;
         cmdSave.BackColor = Gap.Blazor.SystemColors.Control;
         cmdSave.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdSave.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdSave.Location = new System.Drawing.Point(320, 648);
         cmdSave.Name = "cmdSave";
         cmdSave.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdSave.Size = new System.Drawing.Size(89, 25);
         cmdSave.TabIndex = 9;
         cmdSave.Text = "&Save";
         cmdSave.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdSave.UseVisualStyleBackColor = false;
         cmdSave.ClickAsync += new AsyncEventHandler(cmdSave_Click);
         // 
         // cmdAddProducts
         // 
         cmdAddProducts.AllowDrop = true;
         cmdAddProducts.BackColor = Gap.Blazor.SystemColors.Control;
         cmdAddProducts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdAddProducts.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdAddProducts.Location = new System.Drawing.Point(488, 336);
         cmdAddProducts.Name = "cmdAddProducts";
         cmdAddProducts.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdAddProducts.Size = new System.Drawing.Size(25, 21);
         cmdAddProducts.TabIndex = 21;
         cmdAddProducts.TabStop = false;
         cmdAddProducts.Text = "...";
         cmdAddProducts.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdAddProducts.UseVisualStyleBackColor = false;
         cmdAddProducts.ClickAsync += new AsyncEventHandler(cmdAddProducts_Click);
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(416, 648);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(89, 25);
         cmdClose.TabIndex = 10;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // Frame1
         // 
         Frame1.AllowDrop = true;
         Frame1.BackColor = Gap.Blazor.SystemColors.Control;
         Frame1.Controls.Add(txtContactLastName);
         Frame1.Controls.Add(txtContactName);
         Frame1.Controls.Add(cmdCustomers);
         Frame1.Controls.Add(txtCompanyName);
         Frame1.Controls.Add(lvCustomers);
         Frame1.Controls.Add(Label3);
         Frame1.Controls.Add(Label4);
         Frame1.Controls.Add(Label2);
         Frame1.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame1.Enabled = true;
         Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame1.Location = new System.Drawing.Point(8, 8);
         Frame1.Name = "Frame1";
         Frame1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame1.Size = new System.Drawing.Size(505, 249);
         Frame1.TabIndex = 12;
         Frame1.Text = "Search customer";
         Frame1.Visible = true;
         // 
         // txtContactLastName
         // 
         txtContactLastName.AcceptsReturn = true;
         txtContactLastName.AllowDrop = true;
         txtContactLastName.BackColor = Gap.Blazor.SystemColors.Window;
         txtContactLastName.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtContactLastName.Cursor = Gap.Blazor.Cursors.IBeam;
         txtContactLastName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtContactLastName.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtContactLastName.Location = new System.Drawing.Point(336, 48);
         txtContactLastName.MaxLength = 0;
         txtContactLastName.Name = "txtContactLastName";
         txtContactLastName.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtContactLastName.Size = new System.Drawing.Size(145, 20);
         txtContactLastName.TabIndex = 2;
         txtContactLastName.TextChanged += new System.EventHandler(txtContactLastName_TextChanged);
         // 
         // txtContactName
         // 
         txtContactName.AcceptsReturn = true;
         txtContactName.AllowDrop = true;
         txtContactName.BackColor = Gap.Blazor.SystemColors.Window;
         txtContactName.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtContactName.Cursor = Gap.Blazor.Cursors.IBeam;
         txtContactName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtContactName.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtContactName.Location = new System.Drawing.Point(88, 48);
         txtContactName.MaxLength = 0;
         txtContactName.Name = "txtContactName";
         txtContactName.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtContactName.Size = new System.Drawing.Size(145, 20);
         txtContactName.TabIndex = 1;
         txtContactName.TextChanged += new System.EventHandler(txtContactName_TextChanged);
         // 
         // cmdCustomers
         // 
         cmdCustomers.AllowDrop = true;
         cmdCustomers.BackColor = Gap.Blazor.SystemColors.Control;
         cmdCustomers.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdCustomers.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdCustomers.Location = new System.Drawing.Point(456, 16);
         cmdCustomers.Name = "cmdCustomers";
         cmdCustomers.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdCustomers.Size = new System.Drawing.Size(25, 21);
         cmdCustomers.TabIndex = 13;
         cmdCustomers.TabStop = false;
         cmdCustomers.Text = "...";
         cmdCustomers.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdCustomers.UseVisualStyleBackColor = false;
         cmdCustomers.ClickAsync += new AsyncEventHandler(cmdCustomers_Click);
         // 
         // txtCompanyName
         // 
         txtCompanyName.AcceptsReturn = true;
         txtCompanyName.AllowDrop = true;
         txtCompanyName.BackColor = Gap.Blazor.SystemColors.Window;
         txtCompanyName.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtCompanyName.Cursor = Gap.Blazor.Cursors.IBeam;
         txtCompanyName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtCompanyName.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtCompanyName.Location = new System.Drawing.Point(88, 16);
         txtCompanyName.MaxLength = 0;
         txtCompanyName.Name = "txtCompanyName";
         txtCompanyName.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtCompanyName.Size = new System.Drawing.Size(145, 20);
         txtCompanyName.TabIndex = 0;
         txtCompanyName.TextChanged += new System.EventHandler(txtCompanyName_TextChanged);
         // 
         // lvCustomers
         // 
         lvCustomers.AllowDrop = true;
         lvCustomers.BackColor = Gap.Blazor.SystemColors.Window;
         lvCustomers.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         lvCustomers.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lvCustomers.ForeColor = Gap.Blazor.SystemColors.WindowText;
         lvCustomers.FullRowSelect = true;
         lvCustomers.GridLines = true;
         lvCustomers.HideSelection = false;
         lvCustomers.Properties().HotTracking = true;
         lvCustomers.LabelEdit = false;
         lvCustomers.Location = new System.Drawing.Point(8, 80);
         lvCustomers.MultiSelect = false;
         lvCustomers.Name = "lvCustomers";
         lvCustomers.Size = new System.Drawing.Size(489, 161);
         lvCustomers.TabIndex = 3;
         lvCustomers.View = Gap.Blazor.ListViewMode.Details;
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_1_);
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_2_);
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_3_);
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_4_);
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_5_);
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_6_);
         lvCustomers.Columns.Add(lvCustomers_ColumnHeader_7_);
         // 
         // lvCustomers_ColumnHeader_1_
         // 
         lvCustomers_ColumnHeader_1_.Text = "Customer ID";
         lvCustomers_ColumnHeader_1_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_2_
         // 
         lvCustomers_ColumnHeader_2_.Text = "Company Name";
         lvCustomers_ColumnHeader_2_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_3_
         // 
         lvCustomers_ColumnHeader_3_.Text = "Contact Name";
         lvCustomers_ColumnHeader_3_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_4_
         // 
         lvCustomers_ColumnHeader_4_.Text = "Contact Last Name";
         lvCustomers_ColumnHeader_4_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_5_
         // 
         lvCustomers_ColumnHeader_5_.Text = "City";
         lvCustomers_ColumnHeader_5_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_6_
         // 
         lvCustomers_ColumnHeader_6_.Text = "State";
         lvCustomers_ColumnHeader_6_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_7_
         // 
         lvCustomers_ColumnHeader_7_.Text = "Country";
         lvCustomers_ColumnHeader_7_.Width = 97;
         // 
         // Label3
         // 
         Label3.AllowDrop = true;
         Label3.BackColor = Gap.Blazor.SystemColors.Control;
         Label3.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label3.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label3.Location = new System.Drawing.Point(240, 48);
         Label3.MinimumSize = new System.Drawing.Size(97, 17);
         Label3.Name = "Label3";
         Label3.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label3.Size = new System.Drawing.Size(97, 17);
         Label3.TabIndex = 16;
         Label3.Text = "Contact last name:";
         // 
         // Label4
         // 
         Label4.AllowDrop = true;
         Label4.BackColor = Gap.Blazor.SystemColors.Control;
         Label4.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label4.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label4.Location = new System.Drawing.Point(8, 16);
         Label4.MinimumSize = new System.Drawing.Size(89, 17);
         Label4.Name = "Label4";
         Label4.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label4.Size = new System.Drawing.Size(89, 17);
         Label4.TabIndex = 15;
         Label4.Text = "Company name:";
         // 
         // Label2
         // 
         Label2.AllowDrop = true;
         Label2.BackColor = Gap.Blazor.SystemColors.Control;
         Label2.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label2.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label2.Location = new System.Drawing.Point(8, 48);
         Label2.MinimumSize = new System.Drawing.Size(89, 17);
         Label2.Name = "Label2";
         Label2.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label2.Size = new System.Drawing.Size(89, 17);
         Label2.TabIndex = 14;
         Label2.Text = "Contact name:";
         // 
         // Frame2
         // 
         Frame2.AllowDrop = true;
         Frame2.BackColor = Gap.Blazor.SystemColors.Control;
         Frame2.Controls.Add(txtCustomerContact);
         Frame2.Controls.Add(txtCustomerCompany);
         Frame2.Controls.Add(Label5);
         Frame2.Controls.Add(Label1);
         Frame2.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame2.Enabled = true;
         Frame2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame2.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame2.Location = new System.Drawing.Point(8, 256);
         Frame2.Name = "Frame2";
         Frame2.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame2.Size = new System.Drawing.Size(505, 49);
         Frame2.TabIndex = 11;
         Frame2.Text = "Customer";
         Frame2.Visible = true;
         // 
         // txtCustomerContact
         // 
         txtCustomerContact.AcceptsReturn = true;
         txtCustomerContact.AllowDrop = true;
         txtCustomerContact.BackColor = Gap.Blazor.SystemColors.Menu;
         txtCustomerContact.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtCustomerContact.Cursor = Gap.Blazor.Cursors.IBeam;
         txtCustomerContact.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtCustomerContact.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtCustomerContact.Location = new System.Drawing.Point(288, 16);
         txtCustomerContact.MaxLength = 0;
         txtCustomerContact.Name = "txtCustomerContact";
         txtCustomerContact.ReadOnly = true;
         txtCustomerContact.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtCustomerContact.Size = new System.Drawing.Size(209, 20);
         txtCustomerContact.TabIndex = 20;
         txtCustomerContact.TabStop = false;
         // 
         // txtCustomerCompany
         // 
         txtCustomerCompany.AcceptsReturn = true;
         txtCustomerCompany.AllowDrop = true;
         txtCustomerCompany.BackColor = Gap.Blazor.SystemColors.Menu;
         txtCustomerCompany.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtCustomerCompany.Cursor = Gap.Blazor.Cursors.IBeam;
         txtCustomerCompany.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtCustomerCompany.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtCustomerCompany.Location = new System.Drawing.Point(72, 16);
         txtCustomerCompany.MaxLength = 0;
         txtCustomerCompany.Name = "txtCustomerCompany";
         txtCustomerCompany.ReadOnly = true;
         txtCustomerCompany.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
         txtCustomerCompany.TabIndex = 19;
         txtCustomerCompany.TabStop = false;
         // 
         // Label5
         // 
         Label5.AllowDrop = true;
         Label5.BackColor = Gap.Blazor.SystemColors.Control;
         Label5.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label5.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label5.Location = new System.Drawing.Point(8, 16);
         Label5.MinimumSize = new System.Drawing.Size(57, 17);
         Label5.Name = "Label5";
         Label5.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label5.Size = new System.Drawing.Size(57, 17);
         Label5.TabIndex = 18;
         Label5.Text = "Company:";
         // 
         // Label1
         // 
         Label1.AllowDrop = true;
         Label1.BackColor = Gap.Blazor.SystemColors.Control;
         Label1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label1.Location = new System.Drawing.Point(232, 16);
         Label1.MinimumSize = new System.Drawing.Size(57, 17);
         Label1.Name = "Label1";
         Label1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label1.Size = new System.Drawing.Size(57, 17);
         Label1.TabIndex = 17;
         Label1.Text = "Contact:";
         // 
         // dtPromised
         // 
         dtPromised.AllowDrop = true;
         dtPromised.Checked = false;
         dtPromised.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         dtPromised.Format = Gap.Blazor.DateTimePickerFormat.Short;
         dtPromised.Location = new System.Drawing.Point(352, 320);
         dtPromised.Name = "dtPromised";
         dtPromised.Size = new System.Drawing.Size(97, 20);
         dtPromised.TabIndex = 5;
         dtPromised.ValueChanged += new System.EventHandler(dtPromised_ValueChanged);
         // 
         // Label13
         // 
         Label13.AllowDrop = true;
         Label13.BackColor = Gap.Blazor.SystemColors.Control;
         Label13.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label13.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label13.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label13.Location = new System.Drawing.Point(8, 544);
         Label13.MinimumSize = new System.Drawing.Size(89, 17);
         Label13.Name = "Label13";
         Label13.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label13.Size = new System.Drawing.Size(89, 17);
         Label13.TabIndex = 33;
         Label13.Text = "Line quantity:";
         // 
         // Label12
         // 
         Label12.AllowDrop = true;
         Label12.BackColor = Gap.Blazor.SystemColors.Control;
         Label12.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label12.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label12.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label12.Location = new System.Drawing.Point(8, 592);
         Label12.MinimumSize = new System.Drawing.Size(89, 17);
         Label12.Name = "Label12";
         Label12.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label12.Size = new System.Drawing.Size(89, 17);
         Label12.TabIndex = 32;
         Label12.Text = "Freight Charge:";
         // 
         // Label11
         // 
         Label11.AllowDrop = true;
         Label11.BackColor = Gap.Blazor.SystemColors.Control;
         Label11.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label11.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label11.Location = new System.Drawing.Point(8, 616);
         Label11.MinimumSize = new System.Drawing.Size(89, 17);
         Label11.Name = "Label11";
         Label11.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label11.Size = new System.Drawing.Size(89, 17);
         Label11.TabIndex = 30;
         Label11.Text = "Total:";
         // 
         // Label10
         // 
         Label10.AllowDrop = true;
         Label10.BackColor = Gap.Blazor.SystemColors.Control;
         Label10.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label10.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label10.Location = new System.Drawing.Point(272, 592);
         Label10.MinimumSize = new System.Drawing.Size(89, 17);
         Label10.Name = "Label10";
         Label10.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label10.Size = new System.Drawing.Size(89, 17);
         Label10.TabIndex = 28;
         Label10.Text = "Total Tax:";
         // 
         // Label9
         // 
         Label9.AllowDrop = true;
         Label9.BackColor = Gap.Blazor.SystemColors.Control;
         Label9.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label9.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label9.Location = new System.Drawing.Point(272, 616);
         Label9.MinimumSize = new System.Drawing.Size(89, 17);
         Label9.Name = "Label9";
         Label9.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label9.Size = new System.Drawing.Size(89, 17);
         Label9.TabIndex = 26;
         Label9.Text = "Sub Total:";
         // 
         // Label8
         // 
         Label8.AllowDrop = true;
         Label8.BackColor = Gap.Blazor.SystemColors.Control;
         Label8.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label8.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label8.Location = new System.Drawing.Point(8, 568);
         Label8.MinimumSize = new System.Drawing.Size(89, 17);
         Label8.Name = "Label8";
         Label8.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label8.Size = new System.Drawing.Size(89, 17);
         Label8.TabIndex = 25;
         Label8.Text = "Sales Tax:";
         // 
         // Label7
         // 
         Label7.AllowDrop = true;
         Label7.BackColor = Gap.Blazor.SystemColors.Control;
         Label7.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label7.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label7.Location = new System.Drawing.Point(256, 320);
         Label7.MinimumSize = new System.Drawing.Size(105, 17);
         Label7.Name = "Label7";
         Label7.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label7.Size = new System.Drawing.Size(105, 17);
         Label7.TabIndex = 22;
         Label7.Text = "Promised by date:";
         // 
         // Label6
         // 
         Label6.AllowDrop = true;
         Label6.BackColor = Gap.Blazor.SystemColors.Control;
         Label6.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label6.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label6.Location = new System.Drawing.Point(8, 320);
         Label6.MinimumSize = new System.Drawing.Size(105, 17);
         Label6.Name = "Label6";
         Label6.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label6.Size = new System.Drawing.Size(105, 17);
         Label6.TabIndex = 34;
         Label6.Text = "Required by date:";
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         AutoScroll = true;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(523, 703);
         Controls.Add(txtSubTotal);
         Controls.Add(txtTotal);
         Controls.Add(txtTotalTax);
         Controls.Add(txtFreightCharge);
         Controls.Add(txtSalesTax);
         Controls.Add(txtEntry);
         Controls.Add(fgProducts);
         Controls.Add(sbStatusBar);
         Controls.Add(dtRequired);
         Controls.Add(cmdSave);
         Controls.Add(cmdAddProducts);
         Controls.Add(cmdClose);
         Controls.Add(Frame1);
         Controls.Add(Frame2);
         Controls.Add(dtPromised);
         Controls.Add(Label13);
         Controls.Add(Label12);
         Controls.Add(Label11);
         Controls.Add(Label10);
         Controls.Add(Label9);
         Controls.Add(Label8);
         Controls.Add(Label7);
         Controls.Add(Label6);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmOrderRequest";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         StartPosition = Gap.Blazor.FormStartPosition.Manual;
         Text = "Create Order";
         cmdSave.SetStyle(0);
         cmdAddProducts.SetStyle(0);
         cmdClose.SetStyle(0);
         cmdCustomers.SetStyle(0);
         Activated += new System.EventHandler(frmOrderRequest_Activated);
         Closed += new System.EventHandler(Form_Closed);
         FormClosing += new Gap.Blazor.FormClosingEventHandler(Form_FormClosing);
         listViewHelper1.SetItemClickMethod(lvCustomers, "lvCustomers_ItemClick");
         listViewHelper1.SetCorrectEventsBehavior(lvCustomers, true);
         sbStatusBar.ResumeLayout(false);
         Frame1.ResumeLayout(false);
         lvCustomers.ResumeLayout(false);
         Frame2.ResumeLayout(false);
         ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         MdiParent = SKS.frmMain.DefInstance;
         SKS.frmMain.DefInstance.Show();
      }
#endregion

   }

}