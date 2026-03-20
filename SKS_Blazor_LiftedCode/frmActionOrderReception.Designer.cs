using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmActionOrderReception
   {

#region "Upgrade Support "
      private static frmActionOrderReception m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmActionOrderReception>($"{typeof(frmActionOrderReception).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmActionOrderReception).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmActionOrderReception).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmActionOrderReception).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmActionOrderReception DefInstance
      {
         get
         {
            if ( m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed )
            {
               m_InitializingDefInstance = true;
               m_vb6FormDefInstance = await CreateInstance();
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
      public static async Task<frmActionOrderReception> CreateInstance()
      {
         frmActionOrderReception theInstance = new frmActionOrderReception();
         await theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "txtReceivedBy", "cmdApprove", "txtStatus", "txtReceived", "txtChangedBy", "txtChanged", "txtOrderID", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgDetails", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label3", "Label19", "lblChangedBy", "Label4", "lblChanged", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.TextBox txtReceivedBy { get; set; }

      public Gap.Blazor.Button cmdApprove { get; set; }

      public Gap.Blazor.TextBox txtStatus { get; set; }

      public Gap.Blazor.TextBox txtReceived { get; set; }

      public Gap.Blazor.TextBox txtChangedBy { get; set; }

      public Gap.Blazor.TextBox txtChanged { get; set; }

      public Gap.Blazor.TextBox txtOrderID { get; set; }

      public Gap.Blazor.TextBox txtNotes { get; set; }

      public Gap.Blazor.TextBox txtSubTotal { get; set; }

      public Gap.Blazor.TextBox txtTotal { get; set; }

      public Gap.Blazor.TextBox txtTotalTax { get; set; }

      public Gap.Blazor.TextBox txtFreightCharge { get; set; }

      public Gap.Blazor.TextBox txtSalesTax { get; set; }

      public Gap.Blazor.TextBox txtEntry { get; set; }

      public Gap.Blazor.DataGridViewFlex fgDetails { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      public Gap.Blazor.StatusStrip sbStatusBar { get; set; }

      public Gap.Blazor.Button cmdCancel { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.TextBox txtProviderContact { get; set; }

      public Gap.Blazor.TextBox txtProviderCompany { get; set; }

      public Gap.Blazor.Label Label5 { get; set; }

      public Gap.Blazor.Label Label1 { get; set; }

      public Gap.Blazor.GroupBox Frame2 { get; set; }

      public Gap.Blazor.Label Label7 { get; set; }

      public Gap.Blazor.Label Label3 { get; set; }

      public Gap.Blazor.Label Label19 { get; set; }

      public Gap.Blazor.Label lblChangedBy { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.Label lblChanged { get; set; }

      public Gap.Blazor.Label Label12 { get; set; }

      public Gap.Blazor.Label Label11 { get; set; }

      public Gap.Blazor.Label Label10 { get; set; }

      public Gap.Blazor.Label Label9 { get; set; }

      public Gap.Blazor.Label Label8 { get; set; }

      public Gap.Blazor.Label Label6 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionOrderReception));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         txtReceivedBy = new Gap.Blazor.TextBox();
         cmdApprove = new Gap.Blazor.Button();
         txtStatus = new Gap.Blazor.TextBox();
         txtReceived = new Gap.Blazor.TextBox();
         txtChangedBy = new Gap.Blazor.TextBox();
         txtChanged = new Gap.Blazor.TextBox();
         txtOrderID = new Gap.Blazor.TextBox();
         txtNotes = new Gap.Blazor.TextBox();
         txtSubTotal = new Gap.Blazor.TextBox();
         txtTotal = new Gap.Blazor.TextBox();
         txtTotalTax = new Gap.Blazor.TextBox();
         txtFreightCharge = new Gap.Blazor.TextBox();
         txtSalesTax = new Gap.Blazor.TextBox();
         txtEntry = new Gap.Blazor.TextBox();
         fgDetails = new Gap.Blazor.DataGridViewFlex(components);
         sbStatusBar = new Gap.Blazor.StatusStrip();
         sbStatusBar_Panels_Panel1 = new Gap.Blazor.ToolStripStatusLabel();
         cmdCancel = new Gap.Blazor.Button();
         cmdClose = new Gap.Blazor.Button();
         Frame2 = new Gap.Blazor.GroupBox();
         txtProviderContact = new Gap.Blazor.TextBox();
         txtProviderCompany = new Gap.Blazor.TextBox();
         Label5 = new Gap.Blazor.Label();
         Label1 = new Gap.Blazor.Label();
         Label7 = new Gap.Blazor.Label();
         Label3 = new Gap.Blazor.Label();
         Label19 = new Gap.Blazor.Label();
         lblChangedBy = new Gap.Blazor.Label();
         Label4 = new Gap.Blazor.Label();
         lblChanged = new Gap.Blazor.Label();
         Label12 = new Gap.Blazor.Label();
         Label11 = new Gap.Blazor.Label();
         Label10 = new Gap.Blazor.Label();
         Label9 = new Gap.Blazor.Label();
         Label8 = new Gap.Blazor.Label();
         Label6 = new Gap.Blazor.Label();
         sbStatusBar.SuspendLayout();
         Frame2.SuspendLayout();
         SuspendLayout();
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // txtReceivedBy
         // 
         txtReceivedBy.AcceptsReturn = true;
         txtReceivedBy.AllowDrop = true;
         txtReceivedBy.BackColor = Gap.Blazor.SystemColors.Menu;
         txtReceivedBy.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtReceivedBy.Cursor = Gap.Blazor.Cursors.IBeam;
         txtReceivedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtReceivedBy.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtReceivedBy.Location = new System.Drawing.Point(96, 64);
         txtReceivedBy.MaxLength = 0;
         txtReceivedBy.Name = "txtReceivedBy";
         txtReceivedBy.ReadOnly = true;
         txtReceivedBy.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtReceivedBy.Size = new System.Drawing.Size(105, 20);
         txtReceivedBy.TabIndex = 33;
         // 
         // cmdApprove
         // 
         cmdApprove.AllowDrop = true;
         cmdApprove.BackColor = Gap.Blazor.SystemColors.Control;
         cmdApprove.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdApprove.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdApprove.Location = new System.Drawing.Point(232, 456);
         cmdApprove.Name = "cmdApprove";
         cmdApprove.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdApprove.Size = new System.Drawing.Size(89, 25);
         cmdApprove.TabIndex = 0;
         cmdApprove.Text = "&Add";
         cmdApprove.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdApprove.UseVisualStyleBackColor = false;
         cmdApprove.Click += new System.EventHandler(cmdApprove_Click);
         // 
         // txtStatus
         // 
         txtStatus.AcceptsReturn = true;
         txtStatus.AllowDrop = true;
         txtStatus.BackColor = Gap.Blazor.SystemColors.Menu;
         txtStatus.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtStatus.Cursor = Gap.Blazor.Cursors.IBeam;
         txtStatus.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtStatus.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtStatus.Location = new System.Drawing.Point(408, 8);
         txtStatus.MaxLength = 0;
         txtStatus.Name = "txtStatus";
         txtStatus.ReadOnly = true;
         txtStatus.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtStatus.Size = new System.Drawing.Size(105, 20);
         txtStatus.TabIndex = 31;
         // 
         // txtReceived
         // 
         txtReceived.AcceptsReturn = true;
         txtReceived.AllowDrop = true;
         txtReceived.BackColor = Gap.Blazor.SystemColors.Menu;
         txtReceived.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtReceived.Cursor = Gap.Blazor.Cursors.IBeam;
         txtReceived.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtReceived.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtReceived.Location = new System.Drawing.Point(96, 36);
         txtReceived.MaxLength = 0;
         txtReceived.Name = "txtReceived";
         txtReceived.ReadOnly = true;
         txtReceived.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtReceived.Size = new System.Drawing.Size(105, 20);
         txtReceived.TabIndex = 29;
         // 
         // txtChangedBy
         // 
         txtChangedBy.AcceptsReturn = true;
         txtChangedBy.AllowDrop = true;
         txtChangedBy.BackColor = Gap.Blazor.SystemColors.Menu;
         txtChangedBy.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtChangedBy.Cursor = Gap.Blazor.Cursors.IBeam;
         txtChangedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtChangedBy.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtChangedBy.Location = new System.Drawing.Point(408, 64);
         txtChangedBy.MaxLength = 0;
         txtChangedBy.Name = "txtChangedBy";
         txtChangedBy.ReadOnly = true;
         txtChangedBy.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtChangedBy.Size = new System.Drawing.Size(105, 20);
         txtChangedBy.TabIndex = 25;
         // 
         // txtChanged
         // 
         txtChanged.AcceptsReturn = true;
         txtChanged.AllowDrop = true;
         txtChanged.BackColor = Gap.Blazor.SystemColors.Menu;
         txtChanged.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtChanged.Cursor = Gap.Blazor.Cursors.IBeam;
         txtChanged.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtChanged.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtChanged.Location = new System.Drawing.Point(408, 36);
         txtChanged.MaxLength = 0;
         txtChanged.Name = "txtChanged";
         txtChanged.ReadOnly = true;
         txtChanged.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtChanged.Size = new System.Drawing.Size(105, 20);
         txtChanged.TabIndex = 24;
         // 
         // txtOrderID
         // 
         txtOrderID.AcceptsReturn = true;
         txtOrderID.AllowDrop = true;
         txtOrderID.BackColor = Gap.Blazor.SystemColors.Menu;
         txtOrderID.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtOrderID.Cursor = Gap.Blazor.Cursors.IBeam;
         txtOrderID.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtOrderID.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtOrderID.Location = new System.Drawing.Point(96, 8);
         txtOrderID.MaxLength = 0;
         txtOrderID.Name = "txtOrderID";
         txtOrderID.ReadOnly = true;
         txtOrderID.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtOrderID.Size = new System.Drawing.Size(105, 20);
         txtOrderID.TabIndex = 23;
         // 
         // txtNotes
         // 
         txtNotes.AcceptsReturn = true;
         txtNotes.AllowDrop = true;
         txtNotes.BackColor = Gap.Blazor.SystemColors.Menu;
         txtNotes.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtNotes.Cursor = Gap.Blazor.Cursors.IBeam;
         txtNotes.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtNotes.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtNotes.Location = new System.Drawing.Point(56, 152);
         txtNotes.MaxLength = 0;
         txtNotes.Multiline = true;
         txtNotes.Name = "txtNotes";
         txtNotes.ReadOnly = true;
         txtNotes.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtNotes.Size = new System.Drawing.Size(457, 44);
         txtNotes.TabIndex = 3;
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
         txtSubTotal.Location = new System.Drawing.Point(368, 408);
         txtSubTotal.MaxLength = 0;
         txtSubTotal.Name = "txtSubTotal";
         txtSubTotal.ReadOnly = true;
         txtSubTotal.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtSubTotal.Size = new System.Drawing.Size(145, 20);
         txtSubTotal.TabIndex = 21;
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
         txtTotal.Location = new System.Drawing.Point(88, 432);
         txtTotal.MaxLength = 0;
         txtTotal.Name = "txtTotal";
         txtTotal.ReadOnly = true;
         txtTotal.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtTotal.Size = new System.Drawing.Size(145, 20);
         txtTotal.TabIndex = 19;
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
         txtTotalTax.Location = new System.Drawing.Point(368, 384);
         txtTotalTax.MaxLength = 0;
         txtTotalTax.Name = "txtTotalTax";
         txtTotalTax.ReadOnly = true;
         txtTotalTax.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtTotalTax.Size = new System.Drawing.Size(145, 20);
         txtTotalTax.TabIndex = 17;
         txtTotalTax.TabStop = false;
         txtTotalTax.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // txtFreightCharge
         // 
         txtFreightCharge.AcceptsReturn = true;
         txtFreightCharge.AllowDrop = true;
         txtFreightCharge.BackColor = Gap.Blazor.SystemColors.Menu;
         txtFreightCharge.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtFreightCharge.Cursor = Gap.Blazor.Cursors.IBeam;
         txtFreightCharge.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtFreightCharge.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtFreightCharge.Location = new System.Drawing.Point(88, 408);
         txtFreightCharge.MaxLength = 0;
         txtFreightCharge.Name = "txtFreightCharge";
         txtFreightCharge.ReadOnly = true;
         txtFreightCharge.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         txtFreightCharge.TabIndex = 6;
         txtFreightCharge.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // txtSalesTax
         // 
         txtSalesTax.AcceptsReturn = true;
         txtSalesTax.AllowDrop = true;
         txtSalesTax.BackColor = Gap.Blazor.SystemColors.Menu;
         txtSalesTax.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtSalesTax.Cursor = Gap.Blazor.Cursors.IBeam;
         txtSalesTax.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtSalesTax.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtSalesTax.Location = new System.Drawing.Point(88, 384);
         txtSalesTax.MaxLength = 0;
         txtSalesTax.Name = "txtSalesTax";
         txtSalesTax.ReadOnly = true;
         txtSalesTax.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtSalesTax.Size = new System.Drawing.Size(145, 20);
         txtSalesTax.TabIndex = 5;
         txtSalesTax.TextAlign = Gap.Blazor.HorizontalAlignment.Right;
         // 
         // txtEntry
         // 
         txtEntry.AcceptsReturn = true;
         txtEntry.AllowDrop = true;
         txtEntry.BackColor = Gap.Blazor.SystemColors.Window;
         txtEntry.BorderStyle = Gap.Blazor.BorderStyle.None;
         txtEntry.Cursor = Gap.Blazor.Cursors.IBeam;
         txtEntry.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtEntry.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtEntry.Location = new System.Drawing.Point(416, 312);
         txtEntry.MaxLength = 0;
         txtEntry.Name = "txtEntry";
         txtEntry.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtEntry.Size = new System.Drawing.Size(73, 19);
         txtEntry.TabIndex = 14;
         txtEntry.Visible = false;
         // 
         // fgDetails
         // 
         fgDetails.AllowDrop = true;
         fgDetails.AllowUserToAddRows = false;
         fgDetails.AllowUserToDeleteRows = false;
         fgDetails.Properties().AllowUserToResizeColumns = false;
         fgDetails.Properties().AllowUserToResizeRows = false;
         fgDetails.BorderStyle = Gap.Blazor.BorderStyle.None;
         fgDetails.Properties().ColumnHeadersHeightSizeMode = Gap.Blazor.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         fgDetails.ColumnsCount = 0;
         fgDetails.FixedColumns = 0;
         fgDetails.FixedRows = 0;
         fgDetails.Location = new System.Drawing.Point(8, 200);
         fgDetails.Name = "fgDetails";
         fgDetails.Properties().ReadOnly = true;
         fgDetails.RowsCount = 5;
         fgDetails.Properties().SelectionMode = Gap.Blazor.DataGridViewSelectionMode.CellSelect;
         fgDetails.ShowCellToolTips = false;
         fgDetails.Size = new System.Drawing.Size(505, 177);
         fgDetails.Properties().StandardTab = true;
         fgDetails.TabIndex = 4;
         // 
         // sbStatusBar
         // 
         sbStatusBar.AllowDrop = true;
         sbStatusBar.Properties().BackColor = Gap.Blazor.SystemColors.Control;
         sbStatusBar.Dock = Gap.Blazor.DockStyle.Bottom;
         sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         sbStatusBar.Location = new System.Drawing.Point(0, 494);
         sbStatusBar.Name = "sbStatusBar";
         sbStatusBar.Properties().ShowItemToolTips = true;
         sbStatusBar.Size = new System.Drawing.Size(523, 25);
         sbStatusBar.TabIndex = 13;
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
         cmdCancel.Location = new System.Drawing.Point(328, 456);
         cmdCancel.Name = "cmdCancel";
         cmdCancel.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdCancel.Size = new System.Drawing.Size(89, 25);
         cmdCancel.TabIndex = 1;
         cmdCancel.Text = "&Cancel";
         cmdCancel.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdCancel.UseVisualStyleBackColor = false;
         cmdCancel.ClickAsync += new AsyncEventHandler(cmdCancel_Click);
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(424, 456);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(89, 25);
         cmdClose.TabIndex = 2;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // Frame2
         // 
         Frame2.AllowDrop = true;
         Frame2.BackColor = Gap.Blazor.SystemColors.Control;
         Frame2.Controls.Add(txtProviderContact);
         Frame2.Controls.Add(txtProviderCompany);
         Frame2.Controls.Add(Label5);
         Frame2.Controls.Add(Label1);
         Frame2.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame2.Enabled = true;
         Frame2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame2.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame2.Location = new System.Drawing.Point(8, 96);
         Frame2.Name = "Frame2";
         Frame2.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame2.Size = new System.Drawing.Size(505, 49);
         Frame2.TabIndex = 7;
         Frame2.Text = "Supplier";
         Frame2.Visible = true;
         // 
         // txtProviderContact
         // 
         txtProviderContact.AcceptsReturn = true;
         txtProviderContact.AllowDrop = true;
         txtProviderContact.BackColor = Gap.Blazor.SystemColors.Menu;
         txtProviderContact.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtProviderContact.Cursor = Gap.Blazor.Cursors.IBeam;
         txtProviderContact.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtProviderContact.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtProviderContact.Location = new System.Drawing.Point(288, 16);
         txtProviderContact.MaxLength = 0;
         txtProviderContact.Name = "txtProviderContact";
         txtProviderContact.ReadOnly = true;
         txtProviderContact.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtProviderContact.Size = new System.Drawing.Size(209, 20);
         txtProviderContact.TabIndex = 11;
         txtProviderContact.TabStop = false;
         // 
         // txtProviderCompany
         // 
         txtProviderCompany.AcceptsReturn = true;
         txtProviderCompany.AllowDrop = true;
         txtProviderCompany.BackColor = Gap.Blazor.SystemColors.Menu;
         txtProviderCompany.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtProviderCompany.Cursor = Gap.Blazor.Cursors.IBeam;
         txtProviderCompany.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtProviderCompany.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtProviderCompany.Location = new System.Drawing.Point(72, 16);
         txtProviderCompany.MaxLength = 0;
         txtProviderCompany.Name = "txtProviderCompany";
         txtProviderCompany.ReadOnly = true;
         txtProviderCompany.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtProviderCompany.Size = new System.Drawing.Size(145, 20);
         txtProviderCompany.TabIndex = 10;
         txtProviderCompany.TabStop = false;
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
         Label5.TabIndex = 9;
         Label5.Text = "Name:";
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
         Label1.TabIndex = 8;
         Label1.Text = "Contact:";
         // 
         // Label7
         // 
         Label7.AllowDrop = true;
         Label7.BackColor = Gap.Blazor.SystemColors.Control;
         Label7.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label7.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label7.Location = new System.Drawing.Point(8, 64);
         Label7.MinimumSize = new System.Drawing.Size(57, 17);
         Label7.Name = "Label7";
         Label7.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label7.Size = new System.Drawing.Size(57, 17);
         Label7.TabIndex = 34;
         Label7.Text = "By:";
         Label7.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // Label3
         // 
         Label3.AllowDrop = true;
         Label3.BackColor = Gap.Blazor.SystemColors.Control;
         Label3.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label3.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label3.Location = new System.Drawing.Point(328, 8);
         Label3.MinimumSize = new System.Drawing.Size(49, 17);
         Label3.Name = "Label3";
         Label3.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label3.Size = new System.Drawing.Size(49, 17);
         Label3.TabIndex = 32;
         Label3.Text = "Status:";
         Label3.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // Label19
         // 
         Label19.AllowDrop = true;
         Label19.BackColor = Gap.Blazor.SystemColors.Control;
         Label19.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label19.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label19.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label19.Location = new System.Drawing.Point(8, 32);
         Label19.MinimumSize = new System.Drawing.Size(57, 17);
         Label19.Name = "Label19";
         Label19.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label19.Size = new System.Drawing.Size(57, 17);
         Label19.TabIndex = 30;
         Label19.Text = "Received:";
         Label19.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // lblChangedBy
         // 
         lblChangedBy.AllowDrop = true;
         lblChangedBy.BackColor = Gap.Blazor.SystemColors.Control;
         lblChangedBy.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblChangedBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblChangedBy.ForeColor = Gap.Blazor.SystemColors.ControlText;
         lblChangedBy.Location = new System.Drawing.Point(320, 64);
         lblChangedBy.MinimumSize = new System.Drawing.Size(57, 17);
         lblChangedBy.Name = "lblChangedBy";
         lblChangedBy.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblChangedBy.Size = new System.Drawing.Size(57, 17);
         lblChangedBy.TabIndex = 28;
         lblChangedBy.Text = "By:";
         lblChangedBy.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // Label4
         // 
         Label4.AllowDrop = true;
         Label4.BackColor = Gap.Blazor.SystemColors.Control;
         Label4.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label4.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label4.Location = new System.Drawing.Point(16, 8);
         Label4.MinimumSize = new System.Drawing.Size(49, 17);
         Label4.Name = "Label4";
         Label4.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label4.Size = new System.Drawing.Size(49, 17);
         Label4.TabIndex = 27;
         Label4.Text = "Order Id:";
         Label4.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // lblChanged
         // 
         lblChanged.AllowDrop = true;
         lblChanged.BackColor = Gap.Blazor.SystemColors.Control;
         lblChanged.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblChanged.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblChanged.ForeColor = Gap.Blazor.SystemColors.ControlText;
         lblChanged.Location = new System.Drawing.Point(312, 36);
         lblChanged.MinimumSize = new System.Drawing.Size(65, 17);
         lblChanged.Name = "lblChanged";
         lblChanged.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblChanged.Size = new System.Drawing.Size(65, 17);
         lblChanged.TabIndex = 26;
         lblChanged.Text = "Changed:";
         lblChanged.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // Label12
         // 
         Label12.AllowDrop = true;
         Label12.BackColor = Gap.Blazor.SystemColors.Control;
         Label12.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label12.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label12.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label12.Location = new System.Drawing.Point(8, 408);
         Label12.MinimumSize = new System.Drawing.Size(57, 17);
         Label12.Name = "Label12";
         Label12.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label12.Size = new System.Drawing.Size(57, 17);
         Label12.TabIndex = 22;
         Label12.Text = "Freight:";
         // 
         // Label11
         // 
         Label11.AllowDrop = true;
         Label11.BackColor = Gap.Blazor.SystemColors.Control;
         Label11.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label11.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label11.Location = new System.Drawing.Point(8, 432);
         Label11.MinimumSize = new System.Drawing.Size(89, 17);
         Label11.Name = "Label11";
         Label11.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label11.Size = new System.Drawing.Size(89, 17);
         Label11.TabIndex = 20;
         Label11.Text = "Total:";
         // 
         // Label10
         // 
         Label10.AllowDrop = true;
         Label10.BackColor = Gap.Blazor.SystemColors.Control;
         Label10.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label10.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label10.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label10.Location = new System.Drawing.Point(288, 384);
         Label10.MinimumSize = new System.Drawing.Size(89, 17);
         Label10.Name = "Label10";
         Label10.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label10.Size = new System.Drawing.Size(89, 17);
         Label10.TabIndex = 18;
         Label10.Text = "Total Tax:";
         // 
         // Label9
         // 
         Label9.AllowDrop = true;
         Label9.BackColor = Gap.Blazor.SystemColors.Control;
         Label9.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label9.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label9.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label9.Location = new System.Drawing.Point(288, 408);
         Label9.MinimumSize = new System.Drawing.Size(89, 17);
         Label9.Name = "Label9";
         Label9.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label9.Size = new System.Drawing.Size(89, 17);
         Label9.TabIndex = 16;
         Label9.Text = "Sub Total:";
         // 
         // Label8
         // 
         Label8.AllowDrop = true;
         Label8.BackColor = Gap.Blazor.SystemColors.Control;
         Label8.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label8.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label8.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label8.Location = new System.Drawing.Point(8, 384);
         Label8.MinimumSize = new System.Drawing.Size(89, 17);
         Label8.Name = "Label8";
         Label8.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label8.Size = new System.Drawing.Size(89, 17);
         Label8.TabIndex = 15;
         Label8.Text = "Sales Tax:";
         // 
         // Label6
         // 
         Label6.AllowDrop = true;
         Label6.BackColor = Gap.Blazor.SystemColors.Control;
         Label6.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label6.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label6.Location = new System.Drawing.Point(8, 160);
         Label6.MinimumSize = new System.Drawing.Size(33, 17);
         Label6.Name = "Label6";
         Label6.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label6.Size = new System.Drawing.Size(33, 17);
         Label6.TabIndex = 12;
         Label6.Text = "Notes:";
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         AutoScroll = true;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(523, 519);
         Controls.Add(txtReceivedBy);
         Controls.Add(cmdApprove);
         Controls.Add(txtStatus);
         Controls.Add(txtReceived);
         Controls.Add(txtChangedBy);
         Controls.Add(txtChanged);
         Controls.Add(txtOrderID);
         Controls.Add(txtNotes);
         Controls.Add(txtSubTotal);
         Controls.Add(txtTotal);
         Controls.Add(txtTotalTax);
         Controls.Add(txtFreightCharge);
         Controls.Add(txtSalesTax);
         Controls.Add(txtEntry);
         Controls.Add(fgDetails);
         Controls.Add(sbStatusBar);
         Controls.Add(cmdCancel);
         Controls.Add(cmdClose);
         Controls.Add(Frame2);
         Controls.Add(Label7);
         Controls.Add(Label3);
         Controls.Add(Label19);
         Controls.Add(lblChangedBy);
         Controls.Add(Label4);
         Controls.Add(lblChanged);
         Controls.Add(Label12);
         Controls.Add(Label11);
         Controls.Add(Label10);
         Controls.Add(Label9);
         Controls.Add(Label8);
         Controls.Add(Label6);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmActionOrderReception";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         StartPosition = Gap.Blazor.FormStartPosition.Manual;
         Text = "Add Stock to Inventory";
         cmdApprove.SetStyle(0);
         cmdCancel.SetStyle(0);
         cmdClose.SetStyle(0);
         Activated += new System.EventHandler(frmActionOrderReception_Activated);
         Closed += new System.EventHandler(Form_Closed);
         sbStatusBar.ResumeLayout(false);
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