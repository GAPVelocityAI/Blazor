using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmProducts
   {

#region "Upgrade Support "
      private static frmProducts m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmProducts>($"{typeof(frmProducts).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmProducts).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmProducts).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmProducts).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmProducts DefInstance
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
      public static frmProducts CreateInstance()
      {
         frmProducts theInstance = new frmProducts();
         theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.TextBox _txtField_6 { get; set; }

      public Gap.Blazor.TextBox _txtField_0 { get; set; }

      public Gap.Blazor.TextBox _txtField_5 { get; set; }

      public Gap.Blazor.ComboBox cmbCategory { get; set; }

      public Gap.Blazor.TextBox _txtField_4 { get; set; }

      public Gap.Blazor.TextBox _txtField_3 { get; set; }

      public Gap.Blazor.TextBox _txtField_2 { get; set; }

      public Gap.Blazor.TextBox _txtField_1 { get; set; }

      public Gap.Blazor.CheckBox Check1 { get; set; }

      public Gap.Blazor.TextBox txtCategory { get; set; }

      public Gap.Blazor.Label Label7 { get; set; }

      public Gap.Blazor.Label Label3 { get; set; }

      public Gap.Blazor.Label Label2 { get; set; }

      public Gap.Blazor.Label Label1 { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.Label Label5 { get; set; }

      public Gap.Blazor.Label Label6 { get; set; }

      public Gap.Blazor.Label Label11 { get; set; }

      public Gap.Blazor.Label Label15 { get; set; }

      public Gap.Blazor.GroupBox Frame1 { get; set; }

      public Gap.Blazor.VBUC.ADODataControlHelper dcProducts { get; set; }

      public Gap.Blazor.ImageList ImageList1 { get; set; }

      public Gap.Blazor.ToolStripButton Toolbar1_Buttons_Button1 { get; set; }

      public Gap.Blazor.ToolStripButton Toolbar1_Buttons_Button2 { get; set; }

      public Gap.Blazor.ToolStripButton Toolbar1_Buttons_Button3 { get; set; }

      public Gap.Blazor.ToolStripButton Toolbar1_Buttons_Button4 { get; set; }

      public Gap.Blazor.ToolStripButton Toolbar1_Buttons_Button5 { get; set; }

      public Gap.Blazor.ToolStripButton Toolbar1_Buttons_Button6 { get; set; }

      public Gap.Blazor.ToolStrip Toolbar1 { get; set; }

      public Gap.Blazor.TextBox[] txtField = new Gap.Blazor.TextBox[7];

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         Frame1 = new Gap.Blazor.GroupBox();
         _txtField_6 = new Gap.Blazor.TextBox();
         _txtField_0 = new Gap.Blazor.TextBox();
         _txtField_5 = new Gap.Blazor.TextBox();
         cmbCategory = new Gap.Blazor.ComboBox();
         _txtField_4 = new Gap.Blazor.TextBox();
         _txtField_3 = new Gap.Blazor.TextBox();
         _txtField_2 = new Gap.Blazor.TextBox();
         _txtField_1 = new Gap.Blazor.TextBox();
         Check1 = new Gap.Blazor.CheckBox();
         txtCategory = new Gap.Blazor.TextBox();
         Label7 = new Gap.Blazor.Label();
         Label3 = new Gap.Blazor.Label();
         Label2 = new Gap.Blazor.Label();
         Label1 = new Gap.Blazor.Label();
         Label4 = new Gap.Blazor.Label();
         Label5 = new Gap.Blazor.Label();
         Label6 = new Gap.Blazor.Label();
         Label11 = new Gap.Blazor.Label();
         Label15 = new Gap.Blazor.Label();
         dcProducts = new Gap.Blazor.VBUC.ADODataControlHelper();
         ImageList1 = new Gap.Blazor.ImageList();
         Toolbar1 = new Gap.Blazor.ToolStrip();
         Toolbar1_Buttons_Button1 = new Gap.Blazor.ToolStripButton();
         Toolbar1_Buttons_Button2 = new Gap.Blazor.ToolStripButton();
         Toolbar1_Buttons_Button3 = new Gap.Blazor.ToolStripButton();
         Toolbar1_Buttons_Button4 = new Gap.Blazor.ToolStripButton();
         Toolbar1_Buttons_Button5 = new Gap.Blazor.ToolStripButton();
         Toolbar1_Buttons_Button6 = new Gap.Blazor.ToolStripButton();
         Frame1.SuspendLayout();
         Toolbar1.SuspendLayout();
         SuspendLayout();
         // 
         // Frame1
         // 
         Frame1.AllowDrop = true;
         Frame1.BackColor = Gap.Blazor.SystemColors.Control;
         Frame1.Controls.Add(_txtField_6);
         Frame1.Controls.Add(_txtField_0);
         Frame1.Controls.Add(_txtField_5);
         Frame1.Controls.Add(cmbCategory);
         Frame1.Controls.Add(_txtField_4);
         Frame1.Controls.Add(_txtField_3);
         Frame1.Controls.Add(_txtField_2);
         Frame1.Controls.Add(_txtField_1);
         Frame1.Controls.Add(Check1);
         Frame1.Controls.Add(txtCategory);
         Frame1.Controls.Add(Label7);
         Frame1.Controls.Add(Label3);
         Frame1.Controls.Add(Label2);
         Frame1.Controls.Add(Label1);
         Frame1.Controls.Add(Label4);
         Frame1.Controls.Add(Label5);
         Frame1.Controls.Add(Label6);
         Frame1.Controls.Add(Label11);
         Frame1.Controls.Add(Label15);
         Frame1.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame1.Enabled = true;
         Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame1.Location = new System.Drawing.Point(8, 48);
         Frame1.Name = "Frame1";
         Frame1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame1.Size = new System.Drawing.Size(433, 281);
         Frame1.TabIndex = 9;
         Frame1.Text = "Product information";
         Frame1.Visible = true;
         // 
         // _txtField_6
         // 
         _txtField_6.AcceptsReturn = true;
         _txtField_6.AllowDrop = true;
         _txtField_6.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_6.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_6.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_6.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_6.Location = new System.Drawing.Point(256, 240);
         _txtField_6.MaxLength = 0;
         _txtField_6.Name = "_txtField_6";
         _txtField_6.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_6.Size = new System.Drawing.Size(105, 20);
         _txtField_6.TabIndex = 20;
         // 
         // _txtField_0
         // 
         _txtField_0.AcceptsReturn = true;
         _txtField_0.AllowDrop = true;
         _txtField_0.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_0.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_0.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_0.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_0.Location = new System.Drawing.Point(104, 24);
         _txtField_0.MaxLength = 20;
         _txtField_0.Name = "_txtField_0";
         _txtField_0.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_0.Size = new System.Drawing.Size(113, 20);
         _txtField_0.TabIndex = 0;
         // 
         // _txtField_5
         // 
         _txtField_5.AcceptsReturn = true;
         _txtField_5.AllowDrop = true;
         _txtField_5.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_5.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_5.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_5.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_5.Location = new System.Drawing.Point(104, 240);
         _txtField_5.MaxLength = 0;
         _txtField_5.Name = "_txtField_5";
         _txtField_5.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_5.Size = new System.Drawing.Size(105, 20);
         _txtField_5.TabIndex = 7;
         // 
         // cmbCategory
         // 
         cmbCategory.AllowDrop = true;
         cmbCategory.BackColor = Gap.Blazor.SystemColors.Window;
         cmbCategory.CausesValidation = true;
         cmbCategory.DropDownStyle = Gap.Blazor.ComboBoxStyle.DropDownList;
         cmbCategory.Enabled = true;
         cmbCategory.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmbCategory.ForeColor = Gap.Blazor.SystemColors.WindowText;
         cmbCategory.IntegralHeight = true;
         cmbCategory.Location = new System.Drawing.Point(104, 117);
         cmbCategory.Name = "cmbCategory";
         cmbCategory.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmbCategory.Size = new System.Drawing.Size(121, 21);
         cmbCategory.Sorted = false;
         cmbCategory.TabIndex = 3;
         cmbCategory.TabStop = true;
         cmbCategory.Visible = true;
         cmbCategory.SelectedIndexChanged += new System.EventHandler(cmbCategory_SelectedIndexChanged);
         // 
         // _txtField_4
         // 
         _txtField_4.AcceptsReturn = true;
         _txtField_4.AllowDrop = true;
         _txtField_4.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_4.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_4.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_4.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_4.Location = new System.Drawing.Point(104, 210);
         _txtField_4.MaxLength = 0;
         _txtField_4.Name = "_txtField_4";
         _txtField_4.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_4.Size = new System.Drawing.Size(105, 20);
         _txtField_4.TabIndex = 6;
         // 
         // _txtField_3
         // 
         _txtField_3.AcceptsReturn = true;
         _txtField_3.AllowDrop = true;
         _txtField_3.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_3.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_3.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_3.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_3.Location = new System.Drawing.Point(104, 148);
         _txtField_3.MaxLength = 0;
         _txtField_3.Name = "_txtField_3";
         _txtField_3.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_3.Size = new System.Drawing.Size(121, 20);
         _txtField_3.TabIndex = 4;
         // 
         // _txtField_2
         // 
         _txtField_2.AcceptsReturn = true;
         _txtField_2.AllowDrop = true;
         _txtField_2.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_2.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_2.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_2.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_2.Location = new System.Drawing.Point(104, 88);
         _txtField_2.MaxLength = 255;
         _txtField_2.Name = "_txtField_2";
         _txtField_2.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_2.Size = new System.Drawing.Size(305, 20);
         _txtField_2.TabIndex = 2;
         // 
         // _txtField_1
         // 
         _txtField_1.AcceptsReturn = true;
         _txtField_1.AllowDrop = true;
         _txtField_1.BackColor = Gap.Blazor.SystemColors.Window;
         _txtField_1.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         _txtField_1.Cursor = Gap.Blazor.Cursors.IBeam;
         _txtField_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _txtField_1.ForeColor = Gap.Blazor.SystemColors.WindowText;
         _txtField_1.Location = new System.Drawing.Point(104, 56);
         _txtField_1.MaxLength = 50;
         _txtField_1.Name = "_txtField_1";
         _txtField_1.RightToLeft = Gap.Blazor.RightToLeft.No;
         _txtField_1.Size = new System.Drawing.Size(193, 20);
         _txtField_1.TabIndex = 1;
         // 
         // Check1
         // 
         Check1.AllowDrop = true;
         Check1.Appearance = Gap.Blazor.Appearance.Normal;
         Check1.BackColor = Gap.Blazor.SystemColors.Control;
         Check1.CausesValidation = true;
         Check1.CheckAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         Check1.CheckState = Gap.Blazor.CheckState.Unchecked;
         Check1.Enabled = true;
         Check1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Check1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Check1.Location = new System.Drawing.Point(104, 181);
         Check1.Name = "Check1";
         Check1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Check1.Size = new System.Drawing.Size(25, 17);
         Check1.TabIndex = 5;
         Check1.TabStop = true;
         Check1.Text = "";
         Check1.TextAlign = Gap.Blazor.ContentAlignment.MiddleLeft;
         Check1.Visible = true;
         // 
         // txtCategory
         // 
         txtCategory.AcceptsReturn = true;
         txtCategory.AllowDrop = true;
         txtCategory.BackColor = Gap.Blazor.SystemColors.Window;
         txtCategory.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtCategory.Cursor = Gap.Blazor.Cursors.IBeam;
         txtCategory.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtCategory.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtCategory.Location = new System.Drawing.Point(200, 120);
         txtCategory.MaxLength = 0;
         txtCategory.Name = "txtCategory";
         txtCategory.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtCategory.Size = new System.Drawing.Size(10, 13);
         txtCategory.TabIndex = 16;
         txtCategory.TabStop = false;
         txtCategory.TextChanged += new System.EventHandler(txtCategory_TextChanged);
         // 
         // Label7
         // 
         Label7.AllowDrop = true;
         Label7.BackColor = Gap.Blazor.SystemColors.Control;
         Label7.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label7.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label7.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label7.Location = new System.Drawing.Point(216, 244);
         Label7.MinimumSize = new System.Drawing.Size(57, 17);
         Label7.Name = "Label7";
         Label7.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label7.Size = new System.Drawing.Size(57, 17);
         Label7.TabIndex = 19;
         Label7.Text = "Unit";
         // 
         // Label3
         // 
         Label3.AllowDrop = true;
         Label3.BackColor = Gap.Blazor.SystemColors.Control;
         Label3.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label3.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label3.Location = new System.Drawing.Point(16, 24);
         Label3.MinimumSize = new System.Drawing.Size(89, 17);
         Label3.Name = "Label3";
         Label3.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label3.Size = new System.Drawing.Size(89, 17);
         Label3.TabIndex = 18;
         Label3.Text = "Product ";
         // 
         // Label2
         // 
         Label2.AllowDrop = true;
         Label2.BackColor = Gap.Blazor.SystemColors.Control;
         Label2.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label2.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label2.Location = new System.Drawing.Point(16, 244);
         Label2.MinimumSize = new System.Drawing.Size(81, 17);
         Label2.Name = "Label2";
         Label2.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label2.Size = new System.Drawing.Size(81, 17);
         Label2.TabIndex = 17;
         Label2.Text = "Qty per unit";
         // 
         // Label1
         // 
         Label1.AllowDrop = true;
         Label1.BackColor = Gap.Blazor.SystemColors.Control;
         Label1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label1.Location = new System.Drawing.Point(16, 56);
         Label1.MinimumSize = new System.Drawing.Size(89, 17);
         Label1.Name = "Label1";
         Label1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label1.Size = new System.Drawing.Size(89, 17);
         Label1.TabIndex = 15;
         Label1.Text = "Name";
         // 
         // Label4
         // 
         Label4.AllowDrop = true;
         Label4.BackColor = Gap.Blazor.SystemColors.Control;
         Label4.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label4.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label4.Location = new System.Drawing.Point(16, 87);
         Label4.MinimumSize = new System.Drawing.Size(89, 17);
         Label4.Name = "Label4";
         Label4.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label4.Size = new System.Drawing.Size(89, 17);
         Label4.TabIndex = 14;
         Label4.Text = "Desc";
         // 
         // Label5
         // 
         Label5.AllowDrop = true;
         Label5.BackColor = Gap.Blazor.SystemColors.Control;
         Label5.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label5.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label5.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label5.Location = new System.Drawing.Point(16, 148);
         Label5.MinimumSize = new System.Drawing.Size(89, 17);
         Label5.Name = "Label5";
         Label5.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label5.Size = new System.Drawing.Size(89, 17);
         Label5.TabIndex = 13;
         Label5.Text = "Serial number";
         // 
         // Label6
         // 
         Label6.AllowDrop = true;
         Label6.BackColor = Gap.Blazor.SystemColors.Control;
         Label6.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label6.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label6.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label6.Location = new System.Drawing.Point(16, 210);
         Label6.MinimumSize = new System.Drawing.Size(81, 17);
         Label6.Name = "Label6";
         Label6.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label6.Size = new System.Drawing.Size(81, 17);
         Label6.TabIndex = 12;
         Label6.Text = "Unit price";
         // 
         // Label11
         // 
         Label11.AllowDrop = true;
         Label11.BackColor = Gap.Blazor.SystemColors.Control;
         Label11.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label11.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label11.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label11.Location = new System.Drawing.Point(16, 118);
         Label11.MinimumSize = new System.Drawing.Size(89, 17);
         Label11.Name = "Label11";
         Label11.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label11.Size = new System.Drawing.Size(89, 17);
         Label11.TabIndex = 11;
         Label11.Text = "Category";
         // 
         // Label15
         // 
         Label15.AllowDrop = true;
         Label15.BackColor = Gap.Blazor.SystemColors.Control;
         Label15.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label15.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label15.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Label15.Location = new System.Drawing.Point(16, 179);
         Label15.MinimumSize = new System.Drawing.Size(89, 17);
         Label15.Name = "Label15";
         Label15.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label15.Size = new System.Drawing.Size(89, 17);
         Label15.TabIndex = 10;
         Label15.Text = "Discontinued";
         // 
         // dcProducts
         // 
         dcProducts.AllowDrop = true;
         dcProducts.Properties().BackColor = Gap.Blazor.SystemColors.Window;
         dcProducts.Properties().BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst;
         dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db";
         dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
         dcProducts.Enabled = true;
         dcProducts.Properties().EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
         dcProducts.FactoryName = "Access";
         dcProducts.Properties().Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         dcProducts.Properties().ForeColor = Gap.Blazor.SystemColors.WindowText;
         dcProducts.Location = new System.Drawing.Point(8, 336);
         dcProducts.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
         dcProducts.Name = "dcProducts";
         dcProducts.Password = "";
         dcProducts.QueryTimeout = 30;
         dcProducts.QueryType = System.Data.CommandType.Text;
         dcProducts.RecordSource = "Select * from Products";
         dcProducts.Text = "Products";
         dcProducts.UserName = "";
         dcProducts.Width = 177;
         // 
         // ImageList1
         // 
         ImageList1.ImageSize = new System.Drawing.Size(16, 16);
         ImageList1.ImageStream = new ImageList.ImageListStreamer(ImageList1, "SKS.frmProducts.ImageList1.ImageStream");
         ImageList1.TransparentColor = System.Drawing.Color.White;
         ImageList1.Images.SetKeyName(0, "");
         ImageList1.Images.SetKeyName(1, "");
         ImageList1.Images.SetKeyName(2, "");
         ImageList1.Images.SetKeyName(3, "");
         ImageList1.Images.SetKeyName(4, "");
         ImageList1.Images.SetKeyName(5, "");
         // 
         // Toolbar1
         // 
         Toolbar1.AllowDrop = true;
         Toolbar1.Dock = Gap.Blazor.DockStyle.Top;
         Toolbar1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Toolbar1.ImageList = ImageList1;
         Toolbar1.Location = new System.Drawing.Point(0, 0);
         Toolbar1.Name = "Toolbar1";
         Toolbar1.ShowItemToolTips = true;
         Toolbar1.Size = new System.Drawing.Size(448, 44);
         Toolbar1.TabIndex = 8;
         Toolbar1.Items.Add(Toolbar1_Buttons_Button1);
         Toolbar1.Items.Add(Toolbar1_Buttons_Button2);
         Toolbar1.Items.Add(Toolbar1_Buttons_Button3);
         Toolbar1.Items.Add(Toolbar1_Buttons_Button4);
         Toolbar1.Items.Add(Toolbar1_Buttons_Button5);
         Toolbar1.Items.Add(Toolbar1_Buttons_Button6);
         // 
         // Toolbar1_Buttons_Button1
         // 
         Toolbar1_Buttons_Button1.DisplayStyle = Gap.Blazor.ToolStripItemDisplayStyle.ImageAndText;
         Toolbar1_Buttons_Button1.ImageIndex = 0;
         Toolbar1_Buttons_Button1.ImageScaling = Gap.Blazor.ToolStripItemImageScaling.None;
         Toolbar1_Buttons_Button1.Size = new System.Drawing.Size(44, 39);
         Toolbar1_Buttons_Button1.Text = "Add";
         Toolbar1_Buttons_Button1.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         Toolbar1_Buttons_Button1.Properties().ToolTipText = "Create a new record";
         Toolbar1_Buttons_Button1.ClickAsync += new AsyncEventHandler(Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button2
         // 
         Toolbar1_Buttons_Button2.DisplayStyle = Gap.Blazor.ToolStripItemDisplayStyle.ImageAndText;
         Toolbar1_Buttons_Button2.ImageIndex = 1;
         Toolbar1_Buttons_Button2.ImageScaling = Gap.Blazor.ToolStripItemImageScaling.None;
         Toolbar1_Buttons_Button2.Size = new System.Drawing.Size(44, 39);
         Toolbar1_Buttons_Button2.Text = "Edit";
         Toolbar1_Buttons_Button2.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         Toolbar1_Buttons_Button2.Properties().ToolTipText = "Edit this record";
         Toolbar1_Buttons_Button2.ClickAsync += new AsyncEventHandler(Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button3
         // 
         Toolbar1_Buttons_Button3.DisplayStyle = Gap.Blazor.ToolStripItemDisplayStyle.ImageAndText;
         Toolbar1_Buttons_Button3.ImageIndex = 2;
         Toolbar1_Buttons_Button3.ImageScaling = Gap.Blazor.ToolStripItemImageScaling.None;
         Toolbar1_Buttons_Button3.Size = new System.Drawing.Size(44, 39);
         Toolbar1_Buttons_Button3.Text = "Save";
         Toolbar1_Buttons_Button3.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         Toolbar1_Buttons_Button3.Properties().ToolTipText = "Save the current changes";
         Toolbar1_Buttons_Button3.ClickAsync += new AsyncEventHandler(Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button4
         // 
         Toolbar1_Buttons_Button4.DisplayStyle = Gap.Blazor.ToolStripItemDisplayStyle.ImageAndText;
         Toolbar1_Buttons_Button4.ImageIndex = 3;
         Toolbar1_Buttons_Button4.ImageScaling = Gap.Blazor.ToolStripItemImageScaling.None;
         Toolbar1_Buttons_Button4.Size = new System.Drawing.Size(44, 39);
         Toolbar1_Buttons_Button4.Text = "Delete";
         Toolbar1_Buttons_Button4.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         Toolbar1_Buttons_Button4.Properties().ToolTipText = "Delete the current record";
         Toolbar1_Buttons_Button4.ClickAsync += new AsyncEventHandler(Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button5
         // 
         Toolbar1_Buttons_Button5.DisplayStyle = Gap.Blazor.ToolStripItemDisplayStyle.ImageAndText;
         Toolbar1_Buttons_Button5.ImageIndex = 4;
         Toolbar1_Buttons_Button5.ImageScaling = Gap.Blazor.ToolStripItemImageScaling.None;
         Toolbar1_Buttons_Button5.Size = new System.Drawing.Size(44, 39);
         Toolbar1_Buttons_Button5.Text = "Search";
         Toolbar1_Buttons_Button5.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         Toolbar1_Buttons_Button5.Properties().ToolTipText = "Search for a record";
         Toolbar1_Buttons_Button5.ClickAsync += new AsyncEventHandler(Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button6
         // 
         Toolbar1_Buttons_Button6.DisplayStyle = Gap.Blazor.ToolStripItemDisplayStyle.ImageAndText;
         Toolbar1_Buttons_Button6.ImageIndex = 5;
         Toolbar1_Buttons_Button6.ImageScaling = Gap.Blazor.ToolStripItemImageScaling.None;
         Toolbar1_Buttons_Button6.Size = new System.Drawing.Size(44, 39);
         Toolbar1_Buttons_Button6.Text = "Cancel";
         Toolbar1_Buttons_Button6.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         Toolbar1_Buttons_Button6.Properties().ToolTipText = "Cancel edited changes";
         Toolbar1_Buttons_Button6.ClickAsync += new AsyncEventHandler(Toolbar1_ButtonClick);
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(448, 379);
         Controls.Add(Frame1);
         Controls.Add(dcProducts);
         Controls.Add(Toolbar1);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmProducts";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         Text = "Products";
         Activated += new System.EventHandler(frmProducts_Activated);
         Closed += new System.EventHandler(Form_Closed);
         Frame1.ResumeLayout(false);
         Toolbar1.ResumeLayout(false);
         ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         InitializetxtField();
         VB6_AddADODataBinding();
      }

      void InitializetxtField()
      {
         txtField = new Gap.Blazor.TextBox[7];
         txtField[6] = _txtField_6;
         txtField[0] = _txtField_0;
         txtField[5] = _txtField_5;
         txtField[4] = _txtField_4;
         txtField[3] = _txtField_3;
         txtField[2] = _txtField_2;
         txtField[1] = _txtField_1;
      }
#endregion

#region "Upgrade Support"
      public void VB6_AddADODataBinding()
      {
         dcProducts.Refresh();
         txtCategory.DataBindings.Add("Text", dcProducts, "CategoryID", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         Check1.DataBindings.Add("Checked", dcProducts, "Discontinued", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_1.DataBindings.Add("Text", dcProducts, "ProductName", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_2.DataBindings.Add("Text", dcProducts, "ProductDescription", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_3.DataBindings.Add("Text", dcProducts, "SerialNumber", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_5.DataBindings.Add("Text", dcProducts, "QuantityPerUnit", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_0.DataBindings.Add("Text", dcProducts, "ProductID", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_6.DataBindings.Add("Text", dcProducts, "Unit", false, Gap.Blazor.DataSourceUpdateMode.OnPropertyChanged);
      }
#endregion

   }

}