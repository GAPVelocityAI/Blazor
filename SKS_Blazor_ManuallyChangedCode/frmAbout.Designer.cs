using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAbout
   {

#region "Upgrade Support "
      private static frmAbout m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmAbout>($"{typeof(frmAbout).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmAbout).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmAbout).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmAbout).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmAbout DefInstance
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
      public static frmAbout CreateInstance()
      {
         frmAbout theInstance = new frmAbout();
         theInstance.Form_Load();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "picIcon", "cmdOK", "_Line1_1", "lblDescription", "lblTitle", "_Line1_0", "lblVersion", "lblDisclaimer", "Line1", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.PictureBox picIcon { get; set; }

      public Gap.Blazor.Button cmdOK { get; set; }

      public Gap.Blazor.Label _Line1_1 { get; set; }

      public Gap.Blazor.Label lblDescription { get; set; }

      public Gap.Blazor.Label lblTitle { get; set; }

      public Gap.Blazor.Label _Line1_0 { get; set; }

      public Gap.Blazor.Label lblVersion { get; set; }

      public Gap.Blazor.Label lblDisclaimer { get; set; }

      public Gap.Blazor.Label[] Line1 = new Gap.Blazor.Label[2];

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         picIcon = new Gap.Blazor.PictureBox();
         cmdOK = new Gap.Blazor.Button();
         _Line1_1 = new Gap.Blazor.Label();
         lblDescription = new Gap.Blazor.Label();
         lblTitle = new Gap.Blazor.Label();
         _Line1_0 = new Gap.Blazor.Label();
         lblVersion = new Gap.Blazor.Label();
         lblDisclaimer = new Gap.Blazor.Label();
         SuspendLayout();
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // picIcon
         // 
         picIcon.AllowDrop = true;
         picIcon.BackColor = Gap.Blazor.SystemColors.Control;
         picIcon.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         picIcon.Properties().CausesValidation = true;
         picIcon.Dock = Gap.Blazor.DockStyle.None;
         picIcon.Enabled = true;
         picIcon.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         picIcon.Image = (System.Drawing.Image)resources.GetObject("picIcon.Image");
         picIcon.Location = new System.Drawing.Point(16, 16);
         picIcon.Name = "picIcon";
         picIcon.Size = new System.Drawing.Size(36, 36);
         picIcon.SizeMode = Gap.Blazor.PictureBoxSizeMode.AutoSize;
         picIcon.Properties().TabIndex = 1;
         picIcon.Properties().TabStop = true;
         picIcon.Visible = true;
         // 
         // cmdOK
         // 
         cmdOK.AllowDrop = true;
         cmdOK.BackColor = Gap.Blazor.SystemColors.Control;
         cmdOK.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdOK.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdOK.Location = new System.Drawing.Point(272, 208);
         cmdOK.Name = "cmdOK";
         cmdOK.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdOK.Size = new System.Drawing.Size(108, 23);
         cmdOK.TabIndex = 0;
         cmdOK.Text = "OK";
         cmdOK.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdOK.UseVisualStyleBackColor = false;
         cmdOK.Click += new System.EventHandler(cmdOk_Click);
         // 
         // _Line1_1
         // 
         _Line1_1.AllowDrop = true;
         _Line1_1.BackColor = System.Drawing.Color.Gray;
         _Line1_1.BorderStyle = Gap.Blazor.BorderStyle.FixedSingle;
         _Line1_1.Enabled = false;
         _Line1_1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Line1_1.Location = new System.Drawing.Point(5, 147);
         _Line1_1.Name = "_Line1_1";
         _Line1_1.Size = new System.Drawing.Size(294, 1);
         _Line1_1.Visible = true;
         // 
         // lblDescription
         // 
         lblDescription.AllowDrop = true;
         lblDescription.AutoSize = true;
         lblDescription.BackColor = Gap.Blazor.SystemColors.Control;
         lblDescription.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblDescription.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblDescription.ForeColor = System.Drawing.Color.Black;
         lblDescription.Location = new System.Drawing.Point(164, 80);
         lblDescription.MinimumSize = new System.Drawing.Size(199, 13);
         lblDescription.Name = "lblDescription";
         lblDescription.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblDescription.Size = new System.Drawing.Size(199, 13);
         lblDescription.TabIndex = 2;
         lblDescription.Text = "Order Processing Software by Mobilize.net";
         // 
         // lblTitle
         // 
         lblTitle.AllowDrop = true;
         lblTitle.AutoSize = true;
         lblTitle.BackColor = Gap.Blazor.SystemColors.Control;
         lblTitle.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblTitle.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblTitle.ForeColor = System.Drawing.Color.Black;
         lblTitle.Location = new System.Drawing.Point(163, 24);
         lblTitle.MinimumSize = new System.Drawing.Size(122, 13);
         lblTitle.Name = "lblTitle";
         lblTitle.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblTitle.Size = new System.Drawing.Size(122, 13);
         lblTitle.TabIndex = 4;
         lblTitle.Text = "Salmon King Seafood";
         // 
         // _Line1_0
         // 
         _Line1_0.AllowDrop = true;
         _Line1_0.BackColor = System.Drawing.Color.White;
         _Line1_0.Enabled = false;
         _Line1_0.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         _Line1_0.Location = new System.Drawing.Point(6, 148);
         _Line1_0.Name = "_Line1_0";
         _Line1_0.Size = new System.Drawing.Size(293, 1);
         _Line1_0.Visible = true;
         // 
         // lblVersion
         // 
         lblVersion.AllowDrop = true;
         lblVersion.AutoSize = true;
         lblVersion.BackColor = Gap.Blazor.SystemColors.Control;
         lblVersion.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblVersion.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblVersion.ForeColor = Gap.Blazor.SystemColors.ControlText;
         lblVersion.Location = new System.Drawing.Point(163, 56);
         lblVersion.MinimumSize = new System.Drawing.Size(137, 13);
         lblVersion.Name = "lblVersion";
         lblVersion.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblVersion.Size = new System.Drawing.Size(137, 13);
         lblVersion.TabIndex = 5;
         lblVersion.Text = "Version: Mobilize - WebMAP ";
         // 
         // lblDisclaimer
         // 
         lblDisclaimer.AllowDrop = true;
         lblDisclaimer.AutoSize = true;
         lblDisclaimer.BackColor = Gap.Blazor.SystemColors.Control;
         lblDisclaimer.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblDisclaimer.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblDisclaimer.ForeColor = System.Drawing.Color.Black;
         lblDisclaimer.Location = new System.Drawing.Point(17, 175);
         lblDisclaimer.MinimumSize = new System.Drawing.Size(132, 13);
         lblDisclaimer.Name = "lblDisclaimer";
         lblDisclaimer.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblDisclaimer.Size = new System.Drawing.Size(132, 13);
         lblDisclaimer.TabIndex = 3;
         lblDisclaimer.Text = "Copyright 2018 Mobilize.Net";
         AcceptButton = cmdOK;
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         BackColor = Gap.Blazor.SystemColors.Control;
         CancelButton = cmdOK;
         ClientSize = new System.Drawing.Size(394, 237);
         Controls.Add(picIcon);
         Controls.Add(cmdOK);
         Controls.Add(_Line1_1);
         Controls.Add(lblDescription);
         Controls.Add(lblTitle);
         Controls.Add(_Line1_0);
         Controls.Add(lblVersion);
         Controls.Add(lblDisclaimer);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedDialog;
         this.Properties().Location = new System.Drawing.Point(156, 129);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmAbout";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         Text = "About Salmon King Seafood";
         cmdOK.SetStyle(0);
         Activated += new System.EventHandler(frmAbout_Activated);
         Closed += new System.EventHandler(Form_Closed);
         ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents) => InitializeLine1();

      void InitializeLine1()
      {
         Line1 = new Gap.Blazor.Label[2];
         Line1[1] = _Line1_1;
         Line1[0] = _Line1_0;
      }
#endregion

   }

}