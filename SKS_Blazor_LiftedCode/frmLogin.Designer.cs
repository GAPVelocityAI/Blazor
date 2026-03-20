using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmLogin
   {

#region "Upgrade Support "
      private static frmLogin m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmLogin>($"{typeof(frmLogin).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmLogin).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmLogin).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmLogin).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmLogin DefInstance
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
      public static frmLogin CreateInstance()
      {
         frmLogin theInstance = new frmLogin();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "txtUserName", "cmdCancel", "txtPassword", "cmdOK", "_lblLabels_0", "_lblLabels_1", "lblLabels", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.TextBox txtUserName { get; set; }

      public Gap.Blazor.Button cmdCancel { get; set; }

      public Gap.Blazor.TextBox txtPassword { get; set; }

      public Gap.Blazor.Button cmdOK { get; set; }

      public Gap.Blazor.Label _lblLabels_0 { get; set; }

      public Gap.Blazor.Label _lblLabels_1 { get; set; }

      public Gap.Blazor.Label[] lblLabels = new Gap.Blazor.Label[2];

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         txtUserName = new Gap.Blazor.TextBox();
         cmdCancel = new Gap.Blazor.Button();
         txtPassword = new Gap.Blazor.TextBox();
         cmdOK = new Gap.Blazor.Button();
         _lblLabels_0 = new Gap.Blazor.Label();
         _lblLabels_1 = new Gap.Blazor.Label();
         SuspendLayout();
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // txtUserName
         // 
         txtUserName.AcceptsReturn = true;
         txtUserName.AllowDrop = true;
         txtUserName.BackColor = Gap.Blazor.SystemColors.Window;
         txtUserName.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtUserName.Cursor = Gap.Blazor.Cursors.IBeam;
         txtUserName.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtUserName.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtUserName.Location = new System.Drawing.Point(118, 25);
         txtUserName.MaxLength = 0;
         txtUserName.Name = "txtUserName";
         txtUserName.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtUserName.Size = new System.Drawing.Size(155, 23);
         txtUserName.TabIndex = 1;
         // 
         // cmdCancel
         // 
         cmdCancel.AllowDrop = true;
         cmdCancel.BackColor = Gap.Blazor.SystemColors.Control;
         cmdCancel.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdCancel.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdCancel.Location = new System.Drawing.Point(196, 100);
         cmdCancel.Name = "cmdCancel";
         cmdCancel.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdCancel.Size = new System.Drawing.Size(76, 26);
         cmdCancel.TabIndex = 5;
         cmdCancel.Text = "Cancel";
         cmdCancel.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdCancel.UseVisualStyleBackColor = false;
         cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
         // 
         // txtPassword
         // 
         txtPassword.AcceptsReturn = true;
         txtPassword.AllowDrop = true;
         txtPassword.BackColor = Gap.Blazor.SystemColors.Window;
         txtPassword.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtPassword.Cursor = Gap.Blazor.Cursors.IBeam;
         txtPassword.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtPassword.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtPassword.Properties().ImeMode = Stub._System.Windows.Forms.ImeMode.Disable;
         txtPassword.Location = new System.Drawing.Point(118, 51);
         txtPassword.MaxLength = 0;
         txtPassword.Name = "txtPassword";
         txtPassword.PasswordChar = (char)42;
         txtPassword.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtPassword.Size = new System.Drawing.Size(155, 23);
         txtPassword.TabIndex = 3;
         // 
         // cmdOK
         // 
         cmdOK.AllowDrop = true;
         cmdOK.BackColor = Gap.Blazor.SystemColors.Control;
         cmdOK.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdOK.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdOK.Location = new System.Drawing.Point(89, 100);
         cmdOK.Name = "cmdOK";
         cmdOK.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdOK.Size = new System.Drawing.Size(76, 26);
         cmdOK.TabIndex = 4;
         cmdOK.Text = "OK";
         cmdOK.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdOK.UseVisualStyleBackColor = false;
         cmdOK.Click += new System.EventHandler(cmdOk_Click);
         // 
         // _lblLabels_0
         // 
         _lblLabels_0.AllowDrop = true;
         _lblLabels_0.BackColor = Gap.Blazor.SystemColors.Control;
         _lblLabels_0.BorderStyle = Gap.Blazor.BorderStyle.None;
         _lblLabels_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _lblLabels_0.ForeColor = Gap.Blazor.SystemColors.ControlText;
         _lblLabels_0.Location = new System.Drawing.Point(39, 26);
         _lblLabels_0.MinimumSize = new System.Drawing.Size(72, 18);
         _lblLabels_0.Name = "_lblLabels_0";
         _lblLabels_0.RightToLeft = Gap.Blazor.RightToLeft.No;
         _lblLabels_0.Size = new System.Drawing.Size(72, 18);
         _lblLabels_0.TabIndex = 0;
         _lblLabels_0.Text = "&User Name:";
         // 
         // _lblLabels_1
         // 
         _lblLabels_1.AllowDrop = true;
         _lblLabels_1.BackColor = Gap.Blazor.SystemColors.Control;
         _lblLabels_1.BorderStyle = Gap.Blazor.BorderStyle.None;
         _lblLabels_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _lblLabels_1.ForeColor = Gap.Blazor.SystemColors.ControlText;
         _lblLabels_1.Location = new System.Drawing.Point(39, 52);
         _lblLabels_1.MinimumSize = new System.Drawing.Size(72, 18);
         _lblLabels_1.Name = "_lblLabels_1";
         _lblLabels_1.RightToLeft = Gap.Blazor.RightToLeft.No;
         _lblLabels_1.Size = new System.Drawing.Size(72, 18);
         _lblLabels_1.TabIndex = 2;
         _lblLabels_1.Text = "&Password:";
         AcceptButton = cmdOK;
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         BackColor = Gap.Blazor.SystemColors.Control;
         CancelButton = cmdCancel;
         ClientSize = new System.Drawing.Size(289, 137);
         Controls.Add(txtUserName);
         Controls.Add(cmdCancel);
         Controls.Add(txtPassword);
         Controls.Add(cmdOK);
         Controls.Add(_lblLabels_0);
         Controls.Add(_lblLabels_1);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedSingle;
         Icon = (System.Drawing.Icon)resources.GetObject("frmLogin.Icon");
         this.Properties().Location = new System.Drawing.Point(189, 232);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmLogin";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         StartPosition = Gap.Blazor.FormStartPosition.CenterScreen;
         Text = "Login";
         cmdCancel.SetStyle(0);
         cmdOK.SetStyle(0);
         Activated += new System.EventHandler(frmLogin_Activated);
         Closed += new System.EventHandler(Form_Closed);
         ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents) => InitializelblLabels();

      void InitializelblLabels()
      {
         lblLabels = new Gap.Blazor.Label[2];
         lblLabels[0] = _lblLabels_0;
         lblLabels[1] = _lblLabels_1;
      }
#endregion

   }

}