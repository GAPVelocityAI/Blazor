using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmMain
   {

#region "Upgrade Support "
      private static frmMain m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmMain>($"{typeof(frmMain).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmMain).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmMain).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmMain).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmMain DefInstance
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
      public static async Task<frmMain> CreateInstance()
      {
         frmMain theInstance = new frmMain();
         await theInstance.MDIForm_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuCustomer { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuProviders { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuExit { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuFile { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuCreateOrderRequest { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuOrderRequestsApproval { get; set; }

      public Gap.Blazor.ToolStripSeparator lExit2 { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuCreateOrderReception { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuOrderReceptionsApproval { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuOrders { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuAddStockManually { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuAdjustStockManually { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuMainInventory { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuProducts { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuSecurity { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuAccounts { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuAbout { get; set; }

      public Gap.Blazor.ToolStripMenuItem mnuHelp { get; set; }

      public Gap.Blazor.MenuStrip MainMenu1 { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel2 { get; set; }

      public Gap.Blazor.ToolStripStatusLabel sbStatusBar_Panels_Panel3 { get; set; }

      public Gap.Blazor.StatusStrip sbStatusBar { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         MainMenu1 = new Gap.Blazor.MenuStrip();
         mnuFile = new Gap.Blazor.ToolStripMenuItem();
         mnuCustomer = new Gap.Blazor.ToolStripMenuItem();
         mnuProviders = new Gap.Blazor.ToolStripMenuItem();
         mnuExit = new Gap.Blazor.ToolStripMenuItem();
         mnuOrders = new Gap.Blazor.ToolStripMenuItem();
         mnuCreateOrderRequest = new Gap.Blazor.ToolStripMenuItem();
         mnuOrderRequestsApproval = new Gap.Blazor.ToolStripMenuItem();
         lExit2 = new Gap.Blazor.ToolStripSeparator();
         mnuCreateOrderReception = new Gap.Blazor.ToolStripMenuItem();
         mnuOrderReceptionsApproval = new Gap.Blazor.ToolStripMenuItem();
         mnuMainInventory = new Gap.Blazor.ToolStripMenuItem();
         mnuAddStockManually = new Gap.Blazor.ToolStripMenuItem();
         mnuAdjustStockManually = new Gap.Blazor.ToolStripMenuItem();
         mnuAccounts = new Gap.Blazor.ToolStripMenuItem();
         mnuProducts = new Gap.Blazor.ToolStripMenuItem();
         mnuSecurity = new Gap.Blazor.ToolStripMenuItem();
         mnuHelp = new Gap.Blazor.ToolStripMenuItem();
         mnuAbout = new Gap.Blazor.ToolStripMenuItem();
         sbStatusBar = new Gap.Blazor.StatusStrip();
         sbStatusBar_Panels_Panel1 = new Gap.Blazor.ToolStripStatusLabel();
         sbStatusBar_Panels_Panel2 = new Gap.Blazor.ToolStripStatusLabel();
         sbStatusBar_Panels_Panel3 = new Gap.Blazor.ToolStripStatusLabel();
         sbStatusBar.SuspendLayout();
         SuspendLayout();
         // 
         // MainMenu1
         // 
         MainMenu1.Items.AddRange(new Gap.Blazor.ToolStripItem[] { mnuFile, mnuOrders, mnuMainInventory, mnuAccounts, mnuHelp });
         // 
         // mnuFile
         // 
         mnuFile.Available = true;
         mnuFile.Checked = false;
         mnuFile.Enabled = true;
         mnuFile.MergeAction = Gap.Blazor.MergeAction.Remove;
         mnuFile.Name = "mnuFile";
         mnuFile.Text = "&File";
         mnuFile.DropDownItems.AddRange(new Gap.Blazor.ToolStripItem[] { mnuCustomer, mnuProviders, mnuExit });
         // 
         // mnuCustomer
         // 
         mnuCustomer.Available = true;
         mnuCustomer.Checked = false;
         mnuCustomer.Enabled = true;
         mnuCustomer.Name = "mnuCustomer";
         mnuCustomer.Text = "&Manage Customers";
         mnuCustomer.ClickAsync += new AsyncEventHandler(mnuCustomer_Click);
         // 
         // mnuProviders
         // 
         mnuProviders.Available = true;
         mnuProviders.Checked = false;
         mnuProviders.Enabled = true;
         mnuProviders.Name = "mnuProviders";
         mnuProviders.Text = "Manage Su&ppliers ";
         mnuProviders.ClickAsync += new AsyncEventHandler(mnuProviders_Click);
         // 
         // mnuExit
         // 
         mnuExit.Available = true;
         mnuExit.Checked = false;
         mnuExit.Enabled = true;
         mnuExit.Name = "mnuExit";
         mnuExit.Text = "&Exit";
         mnuExit.Click += new System.EventHandler(mnuExit_Click);
         // 
         // mnuOrders
         // 
         mnuOrders.Available = true;
         mnuOrders.Checked = false;
         mnuOrders.Enabled = true;
         mnuOrders.MergeAction = Gap.Blazor.MergeAction.Remove;
         mnuOrders.Name = "mnuOrders";
         mnuOrders.Text = "&Orders";
         mnuOrders.DropDownItems.AddRange(new Gap.Blazor.ToolStripItem[] { mnuCreateOrderRequest, mnuOrderRequestsApproval, lExit2, mnuCreateOrderReception, mnuOrderReceptionsApproval });
         // 
         // mnuCreateOrderRequest
         // 
         mnuCreateOrderRequest.Available = true;
         mnuCreateOrderRequest.Checked = false;
         mnuCreateOrderRequest.Enabled = true;
         mnuCreateOrderRequest.Name = "mnuCreateOrderRequest";
         mnuCreateOrderRequest.Text = "Create Order";
         mnuCreateOrderRequest.Click += new System.EventHandler(mnuCreateOrderRequest_Click);
         // 
         // mnuOrderRequestsApproval
         // 
         mnuOrderRequestsApproval.Available = true;
         mnuOrderRequestsApproval.Checked = false;
         mnuOrderRequestsApproval.Enabled = true;
         mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval";
         mnuOrderRequestsApproval.Text = "Create Invoice";
         mnuOrderRequestsApproval.Click += new System.EventHandler(mnuOrderRequestsApproval_Click);
         // 
         // lExit2
         // 
         lExit2.Properties().AllowDrop = true;
         lExit2.Available = true;
         lExit2.Enabled = true;
         lExit2.Name = "lExit2";
         // 
         // mnuCreateOrderReception
         // 
         mnuCreateOrderReception.Available = true;
         mnuCreateOrderReception.Checked = false;
         mnuCreateOrderReception.Enabled = true;
         mnuCreateOrderReception.Name = "mnuCreateOrderReception";
         mnuCreateOrderReception.Text = "Add Stock Order";
         mnuCreateOrderReception.Click += new System.EventHandler(mnuCreateOrderReception_Click);
         // 
         // mnuOrderReceptionsApproval
         // 
         mnuOrderReceptionsApproval.Available = true;
         mnuOrderReceptionsApproval.Checked = false;
         mnuOrderReceptionsApproval.Enabled = true;
         mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval";
         mnuOrderReceptionsApproval.Text = "Add Stock to Inventory";
         mnuOrderReceptionsApproval.Click += new System.EventHandler(mnuOrderReceptionsApproval_Click);
         // 
         // mnuMainInventory
         // 
         mnuMainInventory.Available = true;
         mnuMainInventory.Checked = false;
         mnuMainInventory.Enabled = true;
         mnuMainInventory.MergeAction = Gap.Blazor.MergeAction.Remove;
         mnuMainInventory.Name = "mnuMainInventory";
         mnuMainInventory.Text = "&Inventory";
         mnuMainInventory.DropDownItems.AddRange(new Gap.Blazor.ToolStripItem[] { mnuAddStockManually, mnuAdjustStockManually });
         // 
         // mnuAddStockManually
         // 
         mnuAddStockManually.Available = true;
         mnuAddStockManually.Checked = false;
         mnuAddStockManually.Enabled = true;
         mnuAddStockManually.Name = "mnuAddStockManually";
         mnuAddStockManually.Text = "Inventory Update";
         mnuAddStockManually.Click += new System.EventHandler(mnuAddStockManually_Click);
         // 
         // mnuAdjustStockManually
         // 
         mnuAdjustStockManually.Available = true;
         mnuAdjustStockManually.Checked = false;
         mnuAdjustStockManually.Enabled = true;
         mnuAdjustStockManually.Name = "mnuAdjustStockManually";
         mnuAdjustStockManually.Text = "Inventory Adjust";
         mnuAdjustStockManually.Click += new System.EventHandler(mnuAdjustStockManually_Click);
         // 
         // mnuAccounts
         // 
         mnuAccounts.Available = true;
         mnuAccounts.Checked = false;
         mnuAccounts.Enabled = true;
         mnuAccounts.MergeAction = Gap.Blazor.MergeAction.Remove;
         mnuAccounts.Name = "mnuAccounts";
         mnuAccounts.Text = "&Maintenance";
         mnuAccounts.DropDownItems.AddRange(new Gap.Blazor.ToolStripItem[] { mnuProducts, mnuSecurity });
         // 
         // mnuProducts
         // 
         mnuProducts.Available = true;
         mnuProducts.Checked = false;
         mnuProducts.Enabled = true;
         mnuProducts.Name = "mnuProducts";
         mnuProducts.Text = "Manage Products";
         mnuProducts.ClickAsync += new AsyncEventHandler(mnuProducts_Click);
         // 
         // mnuSecurity
         // 
         mnuSecurity.Available = true;
         mnuSecurity.Checked = false;
         mnuSecurity.Enabled = true;
         mnuSecurity.Name = "mnuSecurity";
         mnuSecurity.Text = "Manage Users";
         mnuSecurity.Click += new System.EventHandler(mnuSecurity_Click);
         // 
         // mnuHelp
         // 
         mnuHelp.Available = true;
         mnuHelp.Checked = false;
         mnuHelp.Enabled = true;
         mnuHelp.MergeAction = Gap.Blazor.MergeAction.Remove;
         mnuHelp.Name = "mnuHelp";
         mnuHelp.Text = "&Help";
         mnuHelp.DropDownItems.AddRange(new Gap.Blazor.ToolStripItem[] { mnuAbout });
         // 
         // mnuAbout
         // 
         mnuAbout.Available = true;
         mnuAbout.Checked = false;
         mnuAbout.Enabled = true;
         mnuAbout.Name = "mnuAbout";
         mnuAbout.Text = "&About";
         mnuAbout.ClickAsync += new AsyncEventHandler(mnuAbout_Click);
         // 
         // sbStatusBar
         // 
         sbStatusBar.AllowDrop = true;
         sbStatusBar.Properties().BackColor = Gap.Blazor.SystemColors.Control;
         sbStatusBar.Dock = Gap.Blazor.DockStyle.Bottom;
         sbStatusBar.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         sbStatusBar.Location = new System.Drawing.Point(0, 683);
         sbStatusBar.Name = "sbStatusBar";
         sbStatusBar.Properties().ShowItemToolTips = true;
         sbStatusBar.Size = new System.Drawing.Size(1113, 25);
         sbStatusBar.TabIndex = 0;
         sbStatusBar.Items.AddRange(new Gap.Blazor.ToolStripItem[] { sbStatusBar_Panels_Panel1 });
         sbStatusBar.Items.AddRange(new Gap.Blazor.ToolStripItem[] { sbStatusBar_Panels_Panel2 });
         sbStatusBar.Items.AddRange(new Gap.Blazor.ToolStripItem[] { sbStatusBar_Panels_Panel3 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         sbStatusBar_Panels_Panel1.BorderSides = (Gap.Blazor.ToolStripStatusLabelBorderSides)(Gap.Blazor.ToolStripStatusLabelBorderSides.Left | Gap.Blazor.ToolStripStatusLabelBorderSides.Top | Gap.Blazor.ToolStripStatusLabelBorderSides.Right | Gap.Blazor.ToolStripStatusLabelBorderSides.Bottom);
         sbStatusBar_Panels_Panel1.BorderStyle = Gap.Blazor.Border3DStyle.SunkenOuter;
         sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         sbStatusBar_Panels_Panel1.Margin = new Gap.Blazor.Padding(0);
         sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(901, 25);
         sbStatusBar_Panels_Panel1.Spring = true;
         sbStatusBar_Panels_Panel1.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         sbStatusBar_Panels_Panel1.TextImageRelation = Gap.Blazor.TextImageRelation.ImageBeforeText;
         // 
         // sbStatusBar_Panels_Panel2
         // 
         sbStatusBar_Panels_Panel2.AutoSize = false;
         sbStatusBar_Panels_Panel2.BorderSides = (Gap.Blazor.ToolStripStatusLabelBorderSides)(Gap.Blazor.ToolStripStatusLabelBorderSides.Left | Gap.Blazor.ToolStripStatusLabelBorderSides.Top | Gap.Blazor.ToolStripStatusLabelBorderSides.Right | Gap.Blazor.ToolStripStatusLabelBorderSides.Bottom);
         sbStatusBar_Panels_Panel2.BorderStyle = Gap.Blazor.Border3DStyle.SunkenOuter;
         sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
         sbStatusBar_Panels_Panel2.Margin = new Gap.Blazor.Padding(0);
         sbStatusBar_Panels_Panel2.Size = new System.Drawing.Size(96, 25);
         sbStatusBar_Panels_Panel2.Text = "1:25 PM";
         sbStatusBar_Panels_Panel2.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         sbStatusBar_Panels_Panel2.TextImageRelation = Gap.Blazor.TextImageRelation.ImageBeforeText;
         // 
         // sbStatusBar_Panels_Panel3
         // 
         sbStatusBar_Panels_Panel3.AutoSize = false;
         sbStatusBar_Panels_Panel3.BorderSides = (Gap.Blazor.ToolStripStatusLabelBorderSides)(Gap.Blazor.ToolStripStatusLabelBorderSides.Left | Gap.Blazor.ToolStripStatusLabelBorderSides.Top | Gap.Blazor.ToolStripStatusLabelBorderSides.Right | Gap.Blazor.ToolStripStatusLabelBorderSides.Bottom);
         sbStatusBar_Panels_Panel3.BorderStyle = Gap.Blazor.Border3DStyle.SunkenOuter;
         sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
         sbStatusBar_Panels_Panel3.Margin = new Gap.Blazor.Padding(0);
         sbStatusBar_Panels_Panel3.Size = new System.Drawing.Size(96, 25);
         sbStatusBar_Panels_Panel3.Text = "2/21/2018";
         sbStatusBar_Panels_Panel3.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         sbStatusBar_Panels_Panel3.TextImageRelation = Gap.Blazor.TextImageRelation.ImageBeforeText;
         AllowDrop = true;
         BackColor = Gap.Blazor.SystemColors.AppWorkspace;
         ClientSize = new System.Drawing.Size(1113, 708);
         Controls.Add(sbStatusBar);
         Controls.Add(MainMenu1);
         Enabled = true;
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         IsMdiContainer = true;
         this.Properties().Location = new System.Drawing.Point(11, 54);
         Name = "frmMain";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         Text = "Sales Agent";
         WindowState = Gap.Blazor.FormWindowState.Maximized;
         Activated += new System.EventHandler(frmMain_Activated);
         sbStatusBar.ResumeLayout(false);
         ResumeLayout(false);
      }
#endregion

   }

}