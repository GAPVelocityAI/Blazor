using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmUsersManage
   {

#region "Upgrade Support "
      private static frmUsersManage m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmUsersManage>($"{typeof(frmUsersManage).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmUsersManage).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmUsersManage).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmUsersManage).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmUsersManage DefInstance
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
      public static frmUsersManage CreateInstance()
      {
         frmUsersManage theInstance = new frmUsersManage();
         theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "lstAccounts_ColumnHeader_1_", "lstAccounts_ColumnHeader_2_", "lstAccounts_ColumnHeader_3_", "lstAccounts", "cmdClear", "cmdSave", "ctrlLiner1", "txtFullname", "txtPassword", "txtUsername", "cboLevel", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_3", "lblId", "Frame1", "cmdClose", "cmdEdit", "cmdDelete", "_Label1_4", "Label19", "Label4", "Image1", "Label1", "listViewHelper1", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.ColumnHeader lstAccounts_ColumnHeader_1_ { get; set; }

      public Gap.Blazor.ColumnHeader lstAccounts_ColumnHeader_2_ { get; set; }

      public Gap.Blazor.ColumnHeader lstAccounts_ColumnHeader_3_ { get; set; }

      public Gap.Blazor.ListView lstAccounts { get; set; }

      public Gap.Blazor.Button cmdClear { get; set; }

      public Gap.Blazor.Button cmdSave { get; set; }

      public Gap.Blazor.PictureBox ctrlLiner1 { get; set; }

      public Gap.Blazor.TextBox txtFullname { get; set; }

      public Gap.Blazor.TextBox txtPassword { get; set; }

      public Gap.Blazor.TextBox txtUsername { get; set; }

      public Gap.Blazor.ComboBox cboLevel { get; set; }

      public Gap.Blazor.Label _Label1_2 { get; set; }

      public Gap.Blazor.Label _Label1_0 { get; set; }

      public Gap.Blazor.Label _Label1_1 { get; set; }

      public Gap.Blazor.Label _Label1_3 { get; set; }

      public Gap.Blazor.Label lblId { get; set; }

      public Gap.Blazor.GroupBox Frame1 { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.Button cmdEdit { get; set; }

      public Gap.Blazor.Button cmdDelete { get; set; }

      public Gap.Blazor.Label _Label1_4 { get; set; }

      public Gap.Blazor.Label Label19 { get; set; }

      public Gap.Blazor.Label Label4 { get; set; }

      public Gap.Blazor.PictureBox Image1 { get; set; }

      public Gap.Blazor.Label[] Label1 = new Gap.Blazor.Label[5];

      public Gap.Blazor.ListView listViewHelper1 { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      //[System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManage));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         lstAccounts = new Gap.Blazor.ListView();
         lstAccounts_ColumnHeader_1_ = new Gap.Blazor.ColumnHeader();
         lstAccounts_ColumnHeader_2_ = new Gap.Blazor.ColumnHeader();
         lstAccounts_ColumnHeader_3_ = new Gap.Blazor.ColumnHeader();
         cmdClear = new Gap.Blazor.Button();
         cmdSave = new Gap.Blazor.Button();
         ctrlLiner1 = new Gap.Blazor.PictureBox();
         Frame1 = new Gap.Blazor.GroupBox();
         txtFullname = new Gap.Blazor.TextBox();
         txtPassword = new Gap.Blazor.TextBox();
         txtUsername = new Gap.Blazor.TextBox();
         cboLevel = new Gap.Blazor.ComboBox();
         _Label1_2 = new Gap.Blazor.Label();
         _Label1_0 = new Gap.Blazor.Label();
         _Label1_1 = new Gap.Blazor.Label();
         _Label1_3 = new Gap.Blazor.Label();
         lblId = new Gap.Blazor.Label();
         cmdClose = new Gap.Blazor.Button();
         cmdEdit = new Gap.Blazor.Button();
         cmdDelete = new Gap.Blazor.Button();
         _Label1_4 = new Gap.Blazor.Label();
         Label19 = new Gap.Blazor.Label();
         Label4 = new Gap.Blazor.Label();
         Image1 = new Gap.Blazor.PictureBox();
         lstAccounts.SuspendLayout();
         Frame1.SuspendLayout();
         SuspendLayout();
         listViewHelper1 = new Gap.Blazor.ListView(components);
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // lstAccounts
         // 
         lstAccounts.AllowDrop = true;
         lstAccounts.BackColor = Gap.Blazor.SystemColors.Window;
         lstAccounts.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         lstAccounts.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lstAccounts.ForeColor = Gap.Blazor.SystemColors.WindowText;
         lstAccounts.FullRowSelect = true;
         lstAccounts.HideSelection = true;
         lstAccounts.LabelEdit = true;
         lstAccounts.Location = new System.Drawing.Point(0, 264);
         lstAccounts.MultiSelect = false;
         lstAccounts.Name = "lstAccounts";
         lstAccounts.Size = new System.Drawing.Size(337, 113);
         lstAccounts.TabIndex = 7;
         lstAccounts.View = Gap.Blazor.ListViewMode.Details;
         lstAccounts.Columns.Add(lstAccounts_ColumnHeader_1_);
         lstAccounts.Columns.Add(lstAccounts_ColumnHeader_2_);
         lstAccounts.Columns.Add(lstAccounts_ColumnHeader_3_);
         lstAccounts.DoubleClick += new System.EventHandler(lstAccounts_DoubleClick);
         // 
         // lstAccounts_ColumnHeader_1_
         // 
         lstAccounts_ColumnHeader_1_.Text = "UserId";
         lstAccounts_ColumnHeader_1_.Width = 97;
         // 
         // lstAccounts_ColumnHeader_2_
         // 
         lstAccounts_ColumnHeader_2_.Text = "Name";
         lstAccounts_ColumnHeader_2_.Width = 97;
         // 
         // lstAccounts_ColumnHeader_3_
         // 
         lstAccounts_ColumnHeader_3_.Text = "Level";
         lstAccounts_ColumnHeader_3_.Width = 97;
         // 
         // cmdClear
         // 
         cmdClear.AllowDrop = true;
         cmdClear.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClear.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClear.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClear.Location = new System.Drawing.Point(168, 232);
         cmdClear.Name = "cmdClear";
         cmdClear.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClear.Size = new System.Drawing.Size(81, 25);
         cmdClear.TabIndex = 5;
         cmdClear.Text = "&New";
         cmdClear.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClear.UseVisualStyleBackColor = false;
         cmdClear.Click += new System.EventHandler(cmdClear_Click);
         // 
         // cmdSave
         // 
         cmdSave.AllowDrop = true;
         cmdSave.BackColor = Gap.Blazor.SystemColors.Control;
         cmdSave.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdSave.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdSave.Location = new System.Drawing.Point(80, 232);
         cmdSave.Name = "cmdSave";
         cmdSave.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdSave.Size = new System.Drawing.Size(81, 25);
         cmdSave.TabIndex = 4;
         cmdSave.Text = "&Save";
         cmdSave.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdSave.UseVisualStyleBackColor = false;
         cmdSave.Click += new System.EventHandler(cmdSave_Click);
         // 
         // ctrlLiner1
         // 
         ctrlLiner1.AllowDrop = true;
         ctrlLiner1.BackColor = Gap.Blazor.SystemColors.Control;
         ctrlLiner1.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         ctrlLiner1.Properties().CausesValidation = true;
         ctrlLiner1.Dock = Gap.Blazor.DockStyle.None;
         ctrlLiner1.Enabled = true;
         ctrlLiner1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         ctrlLiner1.Location = new System.Drawing.Point(0, 56);
         ctrlLiner1.Name = "ctrlLiner1";
         ctrlLiner1.Size = new System.Drawing.Size(313, 2);
         ctrlLiner1.SizeMode = Gap.Blazor.PictureBoxSizeMode.Normal;
         ctrlLiner1.Properties().TabIndex = 15;
         ctrlLiner1.Properties().TabStop = true;
         ctrlLiner1.Visible = true;
         // 
         // Frame1
         // 
         Frame1.AllowDrop = true;
         Frame1.BackColor = Gap.Blazor.SystemColors.Control;
         Frame1.Controls.Add(txtFullname);
         Frame1.Controls.Add(txtPassword);
         Frame1.Controls.Add(txtUsername);
         Frame1.Controls.Add(cboLevel);
         Frame1.Controls.Add(_Label1_2);
         Frame1.Controls.Add(_Label1_0);
         Frame1.Controls.Add(_Label1_1);
         Frame1.Controls.Add(_Label1_3);
         Frame1.Controls.Add(lblId);
         Frame1.Cursor = Gap.Blazor.Cursors.CursorDefault;
         Frame1.Enabled = true;
         Frame1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Frame1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         Frame1.Location = new System.Drawing.Point(8, 64);
         Frame1.Name = "Frame1";
         Frame1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Frame1.Size = new System.Drawing.Size(329, 153);
         Frame1.TabIndex = 10;
         Frame1.Text = "User information";
         Frame1.Visible = true;
         // 
         // txtFullname
         // 
         txtFullname.AcceptsReturn = true;
         txtFullname.AllowDrop = true;
         txtFullname.BackColor = Gap.Blazor.SystemColors.Window;
         txtFullname.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtFullname.Cursor = Gap.Blazor.Cursors.IBeam;
         txtFullname.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtFullname.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtFullname.Properties().ImeMode = Stub._System.Windows.Forms.ImeMode.Disable;
         txtFullname.Location = new System.Drawing.Point(120, 88);
         txtFullname.MaxLength = 50;
         txtFullname.Name = "txtFullname";
         txtFullname.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtFullname.Size = new System.Drawing.Size(193, 19);
         txtFullname.TabIndex = 2;
         txtFullname.Enter += new System.EventHandler(txtFullname_Enter);
         // 
         // txtPassword
         // 
         txtPassword.AcceptsReturn = true;
         txtPassword.AllowDrop = true;
         txtPassword.BackColor = Gap.Blazor.SystemColors.Window;
         txtPassword.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtPassword.Cursor = Gap.Blazor.Cursors.IBeam;
         txtPassword.Font = new Gap.Blazor.Font("Wingdings", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 2);
         txtPassword.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtPassword.Properties().ImeMode = Stub._System.Windows.Forms.ImeMode.Disable;
         txtPassword.Location = new System.Drawing.Point(120, 56);
         txtPassword.MaxLength = 50;
         txtPassword.Name = "txtPassword";
         txtPassword.PasswordChar = (char)108;
         txtPassword.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtPassword.Size = new System.Drawing.Size(193, 19);
         txtPassword.TabIndex = 1;
         txtPassword.Enter += new System.EventHandler(txtPassword_Enter);
         // 
         // txtUsername
         // 
         txtUsername.AcceptsReturn = true;
         txtUsername.AllowDrop = true;
         txtUsername.BackColor = Gap.Blazor.SystemColors.Window;
         txtUsername.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtUsername.Cursor = Gap.Blazor.Cursors.IBeam;
         txtUsername.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtUsername.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtUsername.Location = new System.Drawing.Point(120, 24);
         txtUsername.MaxLength = 50;
         txtUsername.Name = "txtUsername";
         txtUsername.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtUsername.Size = new System.Drawing.Size(193, 19);
         txtUsername.TabIndex = 0;
         txtUsername.Enter += new System.EventHandler(txtUsername_Enter);
         // 
         // cboLevel
         // 
         cboLevel.AllowDrop = true;
         cboLevel.BackColor = Gap.Blazor.SystemColors.Window;
         cboLevel.CausesValidation = true;
         cboLevel.DropDownStyle = Gap.Blazor.ComboBoxStyle.DropDownList;
         cboLevel.Enabled = true;
         cboLevel.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cboLevel.ForeColor = Gap.Blazor.SystemColors.WindowText;
         cboLevel.IntegralHeight = true;
         cboLevel.Location = new System.Drawing.Point(120, 120);
         cboLevel.Name = "cboLevel";
         cboLevel.RightToLeft = Gap.Blazor.RightToLeft.No;
         cboLevel.Size = new System.Drawing.Size(193, 21);
         cboLevel.Sorted = false;
         cboLevel.TabIndex = 3;
         cboLevel.TabStop = true;
         cboLevel.Visible = true;
         // 
         // _Label1_2
         // 
         _Label1_2.AllowDrop = true;
         _Label1_2.AutoSize = true;
         _Label1_2.BackColor = Gap.Blazor.SystemColors.Control;
         _Label1_2.BorderStyle = Gap.Blazor.BorderStyle.None;
         _Label1_2.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Label1_2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         _Label1_2.Location = new System.Drawing.Point(16, 88);
         _Label1_2.MinimumSize = new System.Drawing.Size(68, 13);
         _Label1_2.Name = "_Label1_2";
         _Label1_2.RightToLeft = Gap.Blazor.RightToLeft.No;
         _Label1_2.Size = new System.Drawing.Size(68, 13);
         _Label1_2.TabIndex = 16;
         _Label1_2.Text = "Full name: *";
         // 
         // _Label1_0
         // 
         _Label1_0.AllowDrop = true;
         _Label1_0.AutoSize = true;
         _Label1_0.BackColor = Gap.Blazor.SystemColors.Control;
         _Label1_0.BorderStyle = Gap.Blazor.BorderStyle.None;
         _Label1_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Label1_0.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         _Label1_0.Location = new System.Drawing.Point(16, 32);
         _Label1_0.MinimumSize = new System.Drawing.Size(70, 13);
         _Label1_0.Name = "_Label1_0";
         _Label1_0.RightToLeft = Gap.Blazor.RightToLeft.No;
         _Label1_0.Size = new System.Drawing.Size(70, 13);
         _Label1_0.TabIndex = 14;
         _Label1_0.Text = "Username: *";
         // 
         // _Label1_1
         // 
         _Label1_1.AllowDrop = true;
         _Label1_1.AutoSize = true;
         _Label1_1.BackColor = Gap.Blazor.SystemColors.Control;
         _Label1_1.BorderStyle = Gap.Blazor.BorderStyle.None;
         _Label1_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Label1_1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         _Label1_1.Location = new System.Drawing.Point(16, 56);
         _Label1_1.MinimumSize = new System.Drawing.Size(96, 13);
         _Label1_1.Name = "_Label1_1";
         _Label1_1.RightToLeft = Gap.Blazor.RightToLeft.No;
         _Label1_1.Size = new System.Drawing.Size(96, 13);
         _Label1_1.TabIndex = 13;
         _Label1_1.Text = "New password: *";
         // 
         // _Label1_3
         // 
         _Label1_3.AllowDrop = true;
         _Label1_3.AutoSize = true;
         _Label1_3.BackColor = Gap.Blazor.SystemColors.Control;
         _Label1_3.BorderStyle = Gap.Blazor.BorderStyle.None;
         _Label1_3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Label1_3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         _Label1_3.Location = new System.Drawing.Point(16, 120);
         _Label1_3.MinimumSize = new System.Drawing.Size(71, 13);
         _Label1_3.Name = "_Label1_3";
         _Label1_3.RightToLeft = Gap.Blazor.RightToLeft.No;
         _Label1_3.Size = new System.Drawing.Size(71, 13);
         _Label1_3.TabIndex = 12;
         _Label1_3.Text = "User level: *";
         // 
         // lblId
         // 
         lblId.AllowDrop = true;
         lblId.AutoSize = true;
         lblId.BackColor = Gap.Blazor.SystemColors.Control;
         lblId.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblId.Font = new Gap.Blazor.Font("Tahoma", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         lblId.Location = new System.Drawing.Point(128, 24);
         lblId.MinimumSize = new System.Drawing.Size(3, 13);
         lblId.Name = "lblId";
         lblId.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblId.Size = new System.Drawing.Size(3, 13);
         lblId.TabIndex = 11;
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(256, 232);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(81, 25);
         cmdClose.TabIndex = 6;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // cmdEdit
         // 
         cmdEdit.AllowDrop = true;
         cmdEdit.BackColor = Gap.Blazor.SystemColors.Control;
         cmdEdit.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdEdit.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdEdit.Location = new System.Drawing.Point(168, 384);
         cmdEdit.Name = "cmdEdit";
         cmdEdit.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdEdit.Size = new System.Drawing.Size(81, 25);
         cmdEdit.TabIndex = 8;
         cmdEdit.Text = "&Edit";
         cmdEdit.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdEdit.UseVisualStyleBackColor = false;
         cmdEdit.Click += new System.EventHandler(cmdEdit_Click);
         // 
         // cmdDelete
         // 
         cmdDelete.AllowDrop = true;
         cmdDelete.BackColor = Gap.Blazor.SystemColors.Control;
         cmdDelete.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdDelete.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdDelete.Location = new System.Drawing.Point(256, 384);
         cmdDelete.Name = "cmdDelete";
         cmdDelete.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdDelete.Size = new System.Drawing.Size(81, 25);
         cmdDelete.TabIndex = 9;
         cmdDelete.Text = "&Delete";
         cmdDelete.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdDelete.UseVisualStyleBackColor = false;
         cmdDelete.ClickAsync += new AsyncEventHandler(cmdDelete_Click);
         // 
         // _Label1_4
         // 
         _Label1_4.AllowDrop = true;
         _Label1_4.AutoSize = true;
         _Label1_4.BackColor = Gap.Blazor.SystemColors.Control;
         _Label1_4.BorderStyle = Gap.Blazor.BorderStyle.None;
         _Label1_4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Label1_4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         _Label1_4.Location = new System.Drawing.Point(8, 392);
         _Label1_4.MinimumSize = new System.Drawing.Size(95, 13);
         _Label1_4.Name = "_Label1_4";
         _Label1_4.RightToLeft = Gap.Blazor.RightToLeft.No;
         _Label1_4.Size = new System.Drawing.Size(95, 13);
         _Label1_4.TabIndex = 19;
         _Label1_4.Text = "* Required fields";
         // 
         // Label19
         // 
         Label19.AllowDrop = true;
         Label19.AutoSize = true;
         Label19.BackColor = System.Drawing.Color.Transparent;
         Label19.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label19.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 9.75f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         Label19.Location = new System.Drawing.Point(48, 8);
         Label19.MinimumSize = new System.Drawing.Size(34, 16);
         Label19.Name = "Label19";
         Label19.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label19.Size = new System.Drawing.Size(34, 16);
         Label19.TabIndex = 18;
         Label19.Text = "User";
         Label19.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // Label4
         // 
         Label4.AllowDrop = true;
         Label4.AutoSize = true;
         Label4.BackColor = System.Drawing.Color.Transparent;
         Label4.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label4.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         Label4.Location = new System.Drawing.Point(48, 32);
         Label4.MinimumSize = new System.Drawing.Size(176, 13);
         Label4.Name = "Label4";
         Label4.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label4.Size = new System.Drawing.Size(176, 13);
         Label4.TabIndex = 17;
         Label4.Text = "Set user information and access level";
         // 
         // Image1
         // 
         Image1.AllowDrop = true;
         Image1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Image1.Cursor = new Gap.Blazor.Cursor((new System.Drawing.Bitmap((System.Drawing.Image)resources.GetObject("Image1.Cursor"))).GetHicon());
         Image1.Enabled = true;
         Image1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Image1.Image = (System.Drawing.Image)resources.GetObject("Image1.Image");
         Image1.Location = new System.Drawing.Point(8, 8);
         Image1.Name = "Image1";
         Image1.Size = new System.Drawing.Size(32, 32);
         Image1.SizeMode = Gap.Blazor.PictureBoxSizeMode.StretchImage;
         Image1.Visible = true;
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         AutoScroll = true;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(341, 414);
         Controls.Add(lstAccounts);
         Controls.Add(cmdClear);
         Controls.Add(cmdSave);
         Controls.Add(ctrlLiner1);
         Controls.Add(Frame1);
         Controls.Add(cmdClose);
         Controls.Add(cmdEdit);
         Controls.Add(cmdDelete);
         Controls.Add(_Label1_4);
         Controls.Add(Label19);
         Controls.Add(Label4);
         Controls.Add(Image1);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         Icon = (System.Drawing.Icon)resources.GetObject("frmUsersManage.Icon");
         this.Properties().Location = new System.Drawing.Point(327, 144);
         MaximizeBox = false;
         MinimizeBox = true;
         Name = "frmUsersManage";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         StartPosition = Gap.Blazor.FormStartPosition.Manual;
         Text = "Users Management";
         cmdClear.SetStyle(0);
         cmdSave.SetStyle(0);
         cmdClose.SetStyle(0);
         cmdEdit.SetStyle(0);
         cmdDelete.SetStyle(0);
         ToolTipMain.SetToolTip(Image1, "View warnings");
         Activated += new System.EventHandler(frmUsersManage_Activated);
         Closed += new System.EventHandler(Form_Closed);
         listViewHelper1.SetCorrectEventsBehavior(lstAccounts, true);
         lstAccounts.ResumeLayout(false);
         Frame1.ResumeLayout(false);
         ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         InitializeLabel1();
      }

      void InitializeLabel1()
      {
         Label1 = new Gap.Blazor.Label[5];
         Label1[2] = _Label1_2;
         Label1[0] = _Label1_0;
         Label1[1] = _Label1_1;
         Label1[3] = _Label1_3;
         Label1[4] = _Label1_4;
      }
#endregion

   }

}