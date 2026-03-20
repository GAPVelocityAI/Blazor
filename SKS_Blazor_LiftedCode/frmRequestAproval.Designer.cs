using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmRequestApproval
   {

#region "Upgrade Support "
      private static frmRequestApproval m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmRequestApproval>($"{typeof(frmRequestApproval).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmRequestApproval).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmRequestApproval).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmRequestApproval).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmRequestApproval DefInstance
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
      public static frmRequestApproval CreateInstance()
      {
         frmRequestApproval theInstance = new frmRequestApproval();
         theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "cmdApprove", "cmdInfo", "fgOrders", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "cmbStatus", "chkTo", "chkFrom", "txtProductID", "txtOrderID", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "dtFrom", "dtTo", "Label5", "Label8", "Label1", "Label6", "Label3", "Label4", "Label2", "Frame1", "listBoxComboBoxHelper1", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.Button cmdApprove { get; set; }

      public Gap.Blazor.Button cmdInfo { get; set; }

      public Gap.Blazor.DataGridViewFlex fgOrders { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      public Gap.Blazor.StatusStrip sbStatusBar { get; set; }

      public Gap.Blazor.Button cmdCancel { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.ComboBox cmbStatus { get; set; }

      public Gap.Blazor.CheckBox chkTo { get; set; }

      public Gap.Blazor.CheckBox chkFrom { get; set; }

      public Gap.Blazor.TextBox txtProductID { get; set; }

      public Gap.Blazor.TextBox txtOrderID { get; set; }

      public Gap.Blazor.TextBox txtContactLastName { get; set; }

      public Gap.Blazor.TextBox txtContactName { get; set; }

      public Gap.Blazor.Button cmdCustomers { get; set; }

      public Gap.Blazor.TextBox txtCompanyName { get; set; }

      public Gap.Blazor.DateTimePicker dtFrom { get; set; }

      public Gap.Blazor.DateTimePicker dtTo { get; set; }

      public Gap.Blazor.Label Label5 { get; set; }

      public Gap.Blazor.Label Label8 { get; set; }

      public Gap.Blazor.Label Label1 { get; set; }

      public Gap.Blazor.Label Label6 { get; set; }

      public Gap.Blazor.Label Label3 { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.Label Label2 { get; set; }

      public Gap.Blazor.GroupBox Frame1 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.ListControlHelper listBoxComboBoxHelper1 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestApproval));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         cmdApprove = new Gap.Blazor.Button();
         cmdInfo = new Gap.Blazor.Button();
         fgOrders = new Gap.Blazor.DataGridViewFlex(components);
         sbStatusBar = new Gap.Blazor.StatusStrip();
         sbStatusBar_Panels_Panel1 = new Gap.Blazor.ToolStripStatusLabel();
         cmdCancel = new Gap.Blazor.Button();
         cmdClose = new Gap.Blazor.Button();
         Frame1 = new Gap.Blazor.GroupBox();
         cmbStatus = new Gap.Blazor.ComboBox();
         chkTo = new Gap.Blazor.CheckBox();
         chkFrom = new Gap.Blazor.CheckBox();
         txtProductID = new Gap.Blazor.TextBox();
         txtOrderID = new Gap.Blazor.TextBox();
         txtContactLastName = new Gap.Blazor.TextBox();
         txtContactName = new Gap.Blazor.TextBox();
         cmdCustomers = new Gap.Blazor.Button();
         txtCompanyName = new Gap.Blazor.TextBox();
         dtFrom = new Gap.Blazor.DateTimePicker();
         dtTo = new Gap.Blazor.DateTimePicker();
         Label5 = new Gap.Blazor.Label();
         Label8 = new Gap.Blazor.Label();
         Label1 = new Gap.Blazor.Label();
         Label6 = new Gap.Blazor.Label();
         Label3 = new Gap.Blazor.Label();
         Label4 = new Gap.Blazor.Label();
         Label2 = new Gap.Blazor.Label();
         sbStatusBar.SuspendLayout();
         Frame1.SuspendLayout();
         SuspendLayout();
         listBoxComboBoxHelper1 = new Stub._UpgradeHelpers.Gui.Controls.ListControlHelper(components);
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // cmdApprove
         // 
         cmdApprove.AllowDrop = true;
         cmdApprove.BackColor = Gap.Blazor.SystemColors.Control;
         cmdApprove.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdApprove.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdApprove.Location = new System.Drawing.Point(232, 440);
         cmdApprove.Name = "cmdApprove";
         cmdApprove.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdApprove.Size = new System.Drawing.Size(89, 25);
         cmdApprove.TabIndex = 10;
         cmdApprove.Text = "&Create";
         cmdApprove.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdApprove.UseVisualStyleBackColor = false;
         cmdApprove.Click += new System.EventHandler(cmdApprove_Click);
         // 
         // cmdInfo
         // 
         cmdInfo.AllowDrop = true;
         cmdInfo.BackColor = Gap.Blazor.SystemColors.Control;
         cmdInfo.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdInfo.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdInfo.Location = new System.Drawing.Point(136, 440);
         cmdInfo.Name = "cmdInfo";
         cmdInfo.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdInfo.Size = new System.Drawing.Size(89, 25);
         cmdInfo.TabIndex = 9;
         cmdInfo.Text = "&Info";
         cmdInfo.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdInfo.UseVisualStyleBackColor = false;
         cmdInfo.Click += new System.EventHandler(cmdInfo_Click);
         // 
         // fgOrders
         // 
         fgOrders.AllowBigSelection = false;
         fgOrders.AllowDrop = true;
         fgOrders.AllowUserToAddRows = false;
         fgOrders.AllowUserToDeleteRows = false;
         fgOrders.Properties().AllowUserToResizeColumns = false;
         fgOrders.Properties().AllowUserToResizeRows = false;
         fgOrders.BorderStyle = Gap.Blazor.BorderStyle.None;
         fgOrders.Properties().ColumnHeadersHeightSizeMode = Gap.Blazor.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         fgOrders.ColumnsCount = 1;
         fgOrders.FixedColumns = 0;
         fgOrders.FixedRows = 0;
         fgOrders.Location = new System.Drawing.Point(8, 168);
         fgOrders.Name = "fgOrders";
         fgOrders.Properties().ReadOnly = true;
         fgOrders.RowsCount = 1;
         fgOrders.Properties().SelectionMode = Gap.Blazor.DataGridViewSelectionMode.FullRowSelect;
         fgOrders.ShowCellToolTips = false;
         fgOrders.Size = new System.Drawing.Size(505, 265);
         fgOrders.Properties().StandardTab = true;
         fgOrders.TabIndex = 8;
         fgOrders.DoubleClick += new System.EventHandler(fgOrders_DoubleClick);
         // 
         // sbStatusBar
         // 
         sbStatusBar.AllowDrop = true;
         sbStatusBar.Properties().BackColor = Gap.Blazor.SystemColors.Control;
         sbStatusBar.Dock = Gap.Blazor.DockStyle.Bottom;
         sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         sbStatusBar.Location = new System.Drawing.Point(0, 471);
         sbStatusBar.Name = "sbStatusBar";
         sbStatusBar.Properties().ShowItemToolTips = true;
         sbStatusBar.Size = new System.Drawing.Size(523, 25);
         sbStatusBar.TabIndex = 18;
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
         // cmdCancel
         // 
         cmdCancel.AllowDrop = true;
         cmdCancel.BackColor = Gap.Blazor.SystemColors.Control;
         cmdCancel.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdCancel.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdCancel.Location = new System.Drawing.Point(328, 440);
         cmdCancel.Name = "cmdCancel";
         cmdCancel.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdCancel.Size = new System.Drawing.Size(89, 25);
         cmdCancel.TabIndex = 11;
         cmdCancel.Text = "&Cancel";
         cmdCancel.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdCancel.UseVisualStyleBackColor = false;
         cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(424, 440);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(89, 25);
         cmdClose.TabIndex = 12;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // Frame1
         // 
         Frame1.AllowDrop = true;
         Frame1.BackColor = Gap.Blazor.SystemColors.Control;
         Frame1.Controls.Add(cmbStatus);
         Frame1.Controls.Add(chkTo);
         Frame1.Controls.Add(chkFrom);
         Frame1.Controls.Add(txtProductID);
         Frame1.Controls.Add(txtOrderID);
         Frame1.Controls.Add(txtContactLastName);
         Frame1.Controls.Add(txtContactName);
         Frame1.Controls.Add(cmdCustomers);
         Frame1.Controls.Add(txtCompanyName);
         Frame1.Controls.Add(dtFrom);
         Frame1.Controls.Add(dtTo);
         Frame1.Controls.Add(Label5);
         Frame1.Controls.Add(Label8);
         Frame1.Controls.Add(Label1);
         Frame1.Controls.Add(Label6);
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
         Frame1.Size = new System.Drawing.Size(505, 153);
         Frame1.TabIndex = 13;
         Frame1.Text = "Search customer";
         Frame1.Visible = true;
         // 
         // cmbStatus
         // 
         cmbStatus.AllowDrop = true;
         cmbStatus.BackColor = Gap.Blazor.SystemColors.Window;
         cmbStatus.CausesValidation = true;
         cmbStatus.DropDownStyle = Gap.Blazor.ComboBoxStyle.DropDownList;
         cmbStatus.Enabled = true;
         cmbStatus.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmbStatus.ForeColor = Gap.Blazor.SystemColors.WindowText;
         cmbStatus.IntegralHeight = true;
         cmbStatus.Location = new System.Drawing.Point(336, 16);
         cmbStatus.Name = "cmbStatus";
         cmbStatus.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmbStatus.Size = new System.Drawing.Size(145, 21);
         cmbStatus.Sorted = false;
         cmbStatus.TabIndex = 1;
         cmbStatus.TabStop = true;
         cmbStatus.Visible = true;
         cmbStatus.Items.AddRange(new object[] { "All", "Requested", "Cancelled", "Approved" });
         cmbStatus.SelectedIndexChanged += new System.EventHandler(cmbStatus_SelectedIndexChanged);
         // 
         // chkTo
         // 
         chkTo.AllowDrop = true;
         chkTo.Appearance = Gap.Blazor.Appearance.Normal;
         chkTo.BackColor = Gap.Blazor.SystemColors.Control;
         chkTo.CausesValidation = true;
         chkTo.CheckAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         chkTo.CheckState = Gap.Blazor.CheckState.Unchecked;
         chkTo.Enabled = true;
         chkTo.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         chkTo.ForeColor = Gap.Blazor.SystemColors.ControlText;
         chkTo.Location = new System.Drawing.Point(336, 80);
         chkTo.Name = "chkTo";
         chkTo.RightToLeft = Gap.Blazor.RightToLeft.No;
         chkTo.Size = new System.Drawing.Size(41, 17);
         chkTo.TabIndex = 23;
         chkTo.TabStop = false;
         chkTo.Text = "To:";
         chkTo.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         chkTo.Visible = true;
         // 
         // chkFrom
         // 
         chkFrom.AllowDrop = true;
         chkFrom.Appearance = Gap.Blazor.Appearance.Normal;
         chkFrom.BackColor = Gap.Blazor.SystemColors.Control;
         chkFrom.CausesValidation = true;
         chkFrom.CheckAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         chkFrom.CheckState = Gap.Blazor.CheckState.Unchecked;
         chkFrom.Enabled = true;
         chkFrom.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         chkFrom.ForeColor = Gap.Blazor.SystemColors.ControlText;
         chkFrom.Location = new System.Drawing.Point(88, 80);
         chkFrom.Name = "chkFrom";
         chkFrom.RightToLeft = Gap.Blazor.RightToLeft.No;
         chkFrom.Size = new System.Drawing.Size(47, 17);
         chkFrom.TabIndex = 22;
         chkFrom.TabStop = false;
         chkFrom.Text = "From:";
         chkFrom.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         chkFrom.Visible = true;
         // 
         // txtProductID
         // 
         txtProductID.AcceptsReturn = true;
         txtProductID.AllowDrop = true;
         txtProductID.BackColor = Gap.Blazor.SystemColors.Window;
         txtProductID.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtProductID.Cursor = Gap.Blazor.Cursors.IBeam;
         txtProductID.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtProductID.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtProductID.Location = new System.Drawing.Point(336, 112);
         txtProductID.MaxLength = 0;
         txtProductID.Name = "txtProductID";
         txtProductID.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtProductID.Size = new System.Drawing.Size(145, 20);
         txtProductID.TabIndex = 7;
         txtProductID.TextChanged += new System.EventHandler(txtProductID_TextChanged);
         // 
         // txtOrderID
         // 
         txtOrderID.AcceptsReturn = true;
         txtOrderID.AllowDrop = true;
         txtOrderID.BackColor = Gap.Blazor.SystemColors.Window;
         txtOrderID.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtOrderID.Cursor = Gap.Blazor.Cursors.IBeam;
         txtOrderID.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtOrderID.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtOrderID.Location = new System.Drawing.Point(88, 112);
         txtOrderID.MaxLength = 0;
         txtOrderID.Name = "txtOrderID";
         txtOrderID.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtOrderID.Size = new System.Drawing.Size(145, 20);
         txtOrderID.TabIndex = 6;
         txtOrderID.TextChanged += new System.EventHandler(txtOrderID_TextChanged);
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
         txtContactLastName.TabIndex = 3;
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
         txtContactName.TabIndex = 2;
         txtContactName.TextChanged += new System.EventHandler(txtContactName_TextChanged);
         // 
         // cmdCustomers
         // 
         cmdCustomers.AllowDrop = true;
         cmdCustomers.BackColor = Gap.Blazor.SystemColors.Control;
         cmdCustomers.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdCustomers.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdCustomers.Location = new System.Drawing.Point(240, 16);
         cmdCustomers.Name = "cmdCustomers";
         cmdCustomers.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdCustomers.Size = new System.Drawing.Size(25, 21);
         cmdCustomers.TabIndex = 14;
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
         // dtFrom
         // 
         dtFrom.AllowDrop = true;
         dtFrom.Checked = false;
         dtFrom.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         dtFrom.Format = Gap.Blazor.DateTimePickerFormat.Short;
         dtFrom.Location = new System.Drawing.Point(136, 80);
         dtFrom.Name = "dtFrom";
         dtFrom.Size = new System.Drawing.Size(97, 20);
         dtFrom.TabIndex = 4;
         dtFrom.ValueChanged += new System.EventHandler(dtFrom_ValueChanged);
         // 
         // dtTo
         // 
         dtTo.AllowDrop = true;
         dtTo.Checked = false;
         dtTo.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         dtTo.Format = Gap.Blazor.DateTimePickerFormat.Short;
         dtTo.Location = new System.Drawing.Point(384, 80);
         dtTo.Name = "dtTo";
         dtTo.Size = new System.Drawing.Size(97, 20);
         dtTo.TabIndex = 5;
         dtTo.ValueChanged += new System.EventHandler(dtTo_ValueChanged);
         // 
         // Label5
         // 
         Label5.AllowDrop = true;
         Label5.BackColor = Gap.Blazor.SystemColors.Control;
         Label5.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label5.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label5.Location = new System.Drawing.Point(288, 16);
         Label5.MinimumSize = new System.Drawing.Size(41, 17);
         Label5.Name = "Label5";
         Label5.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label5.Size = new System.Drawing.Size(41, 17);
         Label5.TabIndex = 24;
         Label5.Text = "Status";
         // 
         // Label8
         // 
         Label8.AllowDrop = true;
         Label8.BackColor = Gap.Blazor.SystemColors.Control;
         Label8.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label8.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label8.Location = new System.Drawing.Point(256, 112);
         Label8.MinimumSize = new System.Drawing.Size(73, 17);
         Label8.Name = "Label8";
         Label8.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label8.Size = new System.Drawing.Size(73, 17);
         Label8.TabIndex = 21;
         Label8.Text = "Product";
         // 
         // Label1
         // 
         Label1.AllowDrop = true;
         Label1.BackColor = Gap.Blazor.SystemColors.Control;
         Label1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label1.Location = new System.Drawing.Point(8, 112);
         Label1.MinimumSize = new System.Drawing.Size(89, 17);
         Label1.Name = "Label1";
         Label1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label1.Size = new System.Drawing.Size(89, 17);
         Label1.TabIndex = 20;
         Label1.Text = "Order";
         // 
         // Label6
         // 
         Label6.AllowDrop = true;
         Label6.BackColor = Gap.Blazor.SystemColors.Control;
         Label6.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label6.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label6.Location = new System.Drawing.Point(8, 80);
         Label6.MinimumSize = new System.Drawing.Size(65, 17);
         Label6.Name = "Label6";
         Label6.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label6.Size = new System.Drawing.Size(65, 17);
         Label6.TabIndex = 19;
         Label6.Text = "Date range:";
         // 
         // Label3
         // 
         Label3.AllowDrop = true;
         Label3.BackColor = Gap.Blazor.SystemColors.Control;
         Label3.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label3.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label3.Location = new System.Drawing.Point(256, 48);
         Label3.MinimumSize = new System.Drawing.Size(65, 17);
         Label3.Name = "Label3";
         Label3.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label3.Size = new System.Drawing.Size(65, 17);
         Label3.TabIndex = 17;
         Label3.Text = "Last Name";
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
         Label4.TabIndex = 16;
         Label4.Text = "Company";
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
         Label2.TabIndex = 15;
         Label2.Text = "First Name";
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         AutoScroll = true;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(523, 496);
         Controls.Add(cmdApprove);
         Controls.Add(cmdInfo);
         Controls.Add(fgOrders);
         Controls.Add(sbStatusBar);
         Controls.Add(cmdCancel);
         Controls.Add(cmdClose);
         Controls.Add(Frame1);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmRequestApproval";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         StartPosition = Gap.Blazor.FormStartPosition.Manual;
         Text = "Create Invoice";
         cmdApprove.SetStyle(0);
         cmdInfo.SetStyle(0);
         cmdCancel.SetStyle(0);
         cmdClose.SetStyle(0);
         cmdCustomers.SetStyle(0);
         cmbStatus.SetItemData(new int[] { 0, 0, 0, 0 });
         Activated += new System.EventHandler(frmRequestApproval_Activated);
         Closed += new System.EventHandler(Form_Closed);
         sbStatusBar.ResumeLayout(false);
         Frame1.ResumeLayout(false);
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