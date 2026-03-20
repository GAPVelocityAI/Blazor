using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmSearch
   {

#region "Upgrade Support "
      private static frmSearch m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmSearch>($"{typeof(frmSearch).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmSearch).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmSearch).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmSearch).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmSearch DefInstance
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
      public static frmSearch CreateInstance()
      {
         frmSearch theInstance = new frmSearch();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "cmdClose", "cmdSearch", "ctrlLiner1", "cboSrchBy", "txtSrchStr", "Label20", "Label19", "Image3", "Label1", "lblSrchBy", "commandButtonHelper1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.Button cmdClose { get; set; }

      public Gap.Blazor.Button cmdSearch { get; set; }

      public Gap.Blazor.PictureBox ctrlLiner1 { get; set; }

      public Gap.Blazor.ComboBox cboSrchBy { get; set; }

      public Gap.Blazor.TextBox txtSrchStr { get; set; }

      public Gap.Blazor.Label Label20 { get; set; }

      public Gap.Blazor.Label Label19 { get; set; }

      public Gap.Blazor.PictureBox Image3 { get; set; }

      public Gap.Blazor.Label Label1 { get; set; }

      public Gap.Blazor.Label lblSrchBy { get; set; }

      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         cmdClose = new Gap.Blazor.Button();
         cmdSearch = new Gap.Blazor.Button();
         ctrlLiner1 = new Gap.Blazor.PictureBox();
         cboSrchBy = new Gap.Blazor.ComboBox();
         txtSrchStr = new Gap.Blazor.TextBox();
         Label20 = new Gap.Blazor.Label();
         Label19 = new Gap.Blazor.Label();
         Image3 = new Gap.Blazor.PictureBox();
         Label1 = new Gap.Blazor.Label();
         lblSrchBy = new Gap.Blazor.Label();
         SuspendLayout();
         commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
         // 
         // cmdClose
         // 
         cmdClose.AllowDrop = true;
         cmdClose.BackColor = Gap.Blazor.SystemColors.Control;
         cmdClose.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdClose.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdClose.Location = new System.Drawing.Point(272, 104);
         cmdClose.Name = "cmdClose";
         cmdClose.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdClose.Size = new System.Drawing.Size(81, 25);
         cmdClose.TabIndex = 8;
         cmdClose.Text = "&Close";
         cmdClose.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdClose.UseVisualStyleBackColor = false;
         cmdClose.Click += new System.EventHandler(cmdClose_Click);
         // 
         // cmdSearch
         // 
         cmdSearch.AllowDrop = true;
         cmdSearch.BackColor = Gap.Blazor.SystemColors.Control;
         cmdSearch.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cmdSearch.ForeColor = Gap.Blazor.SystemColors.ControlText;
         cmdSearch.Location = new System.Drawing.Point(184, 104);
         cmdSearch.Name = "cmdSearch";
         cmdSearch.RightToLeft = Gap.Blazor.RightToLeft.No;
         cmdSearch.Size = new System.Drawing.Size(81, 25);
         cmdSearch.TabIndex = 7;
         cmdSearch.Text = "&Search";
         cmdSearch.TextImageRelation = Gap.Blazor.TextImageRelation.ImageAboveText;
         cmdSearch.UseVisualStyleBackColor = false;
         cmdSearch.Click += new System.EventHandler(cmdSearch_Click);
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
         ctrlLiner1.Size = new System.Drawing.Size(385, 2);
         ctrlLiner1.SizeMode = Gap.Blazor.PictureBoxSizeMode.Normal;
         ctrlLiner1.Properties().TabIndex = 6;
         ctrlLiner1.Properties().TabStop = true;
         ctrlLiner1.Visible = true;
         // 
         // cboSrchBy
         // 
         cboSrchBy.AllowDrop = true;
         cboSrchBy.BackColor = Gap.Blazor.SystemColors.Window;
         cboSrchBy.CausesValidation = true;
         cboSrchBy.DropDownStyle = Gap.Blazor.ComboBoxStyle.DropDownList;
         cboSrchBy.Enabled = true;
         cboSrchBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         cboSrchBy.ForeColor = Gap.Blazor.SystemColors.WindowText;
         cboSrchBy.IntegralHeight = true;
         cboSrchBy.Location = new System.Drawing.Point(208, 144);
         cboSrchBy.Name = "cboSrchBy";
         cboSrchBy.RightToLeft = Gap.Blazor.RightToLeft.No;
         cboSrchBy.Size = new System.Drawing.Size(145, 21);
         cboSrchBy.Sorted = false;
         cboSrchBy.TabIndex = 3;
         cboSrchBy.TabStop = true;
         cboSrchBy.Visible = true;
         cboSrchBy.SelectedIndexChanged += new System.EventHandler(cboSrchBy_SelectedIndexChanged);
         // 
         // txtSrchStr
         // 
         txtSrchStr.AcceptsReturn = true;
         txtSrchStr.AllowDrop = true;
         txtSrchStr.BackColor = Gap.Blazor.SystemColors.Window;
         txtSrchStr.BorderStyle = Gap.Blazor.BorderStyle.Fixed3D;
         txtSrchStr.Cursor = Gap.Blazor.Cursors.IBeam;
         txtSrchStr.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         txtSrchStr.ForeColor = Gap.Blazor.SystemColors.WindowText;
         txtSrchStr.Location = new System.Drawing.Point(136, 72);
         txtSrchStr.MaxLength = 0;
         txtSrchStr.Name = "txtSrchStr";
         txtSrchStr.RightToLeft = Gap.Blazor.RightToLeft.No;
         txtSrchStr.Size = new System.Drawing.Size(217, 19);
         txtSrchStr.TabIndex = 0;
         // 
         // Label20
         // 
         Label20.AllowDrop = true;
         Label20.AutoSize = true;
         Label20.BackColor = System.Drawing.Color.Transparent;
         Label20.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label20.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label20.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         Label20.Location = new System.Drawing.Point(49, 32);
         Label20.MinimumSize = new System.Drawing.Size(119, 13);
         Label20.Name = "Label20";
         Label20.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label20.Size = new System.Drawing.Size(119, 13);
         Label20.TabIndex = 5;
         Label20.Text = "Search for a specific item";
         // 
         // Label19
         // 
         Label19.AllowDrop = true;
         Label19.AutoSize = true;
         Label19.BackColor = System.Drawing.Color.Transparent;
         Label19.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label19.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 9.75f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         Label19.Location = new System.Drawing.Point(49, 8);
         Label19.MinimumSize = new System.Drawing.Size(50, 16);
         Label19.Name = "Label19";
         Label19.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label19.Size = new System.Drawing.Size(50, 16);
         Label19.TabIndex = 4;
         Label19.Text = "Search";
         Label19.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // Image3
         // 
         Image3.AllowDrop = true;
         Image3.BorderStyle = Gap.Blazor.BorderStyle.None;
         Image3.Enabled = true;
         Image3.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Image3.Image = (System.Drawing.Image)resources.GetObject("Image3.Image");
         Image3.Location = new System.Drawing.Point(8, 8);
         Image3.Name = "Image3";
         Image3.Size = new System.Drawing.Size(16, 16);
         Image3.SizeMode = Gap.Blazor.PictureBoxSizeMode.Normal;
         Image3.Visible = true;
         // 
         // Label1
         // 
         Label1.AllowDrop = true;
         Label1.AutoSize = true;
         Label1.BackColor = Gap.Blazor.SystemColors.Control;
         Label1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Label1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         Label1.Location = new System.Drawing.Point(125, 144);
         Label1.MinimumSize = new System.Drawing.Size(62, 13);
         Label1.Name = "Label1";
         Label1.RightToLeft = Gap.Blazor.RightToLeft.No;
         Label1.Size = new System.Drawing.Size(62, 13);
         Label1.TabIndex = 2;
         Label1.Text = "Search by:";
         Label1.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         // 
         // lblSrchBy
         // 
         lblSrchBy.AllowDrop = true;
         lblSrchBy.AutoSize = true;
         lblSrchBy.BackColor = Gap.Blazor.SystemColors.Control;
         lblSrchBy.BorderStyle = Gap.Blazor.BorderStyle.None;
         lblSrchBy.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Bold | Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         lblSrchBy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         lblSrchBy.Location = new System.Drawing.Point(7, 72);
         lblSrchBy.MinimumSize = new System.Drawing.Size(116, 13);
         lblSrchBy.Name = "lblSrchBy";
         lblSrchBy.RightToLeft = Gap.Blazor.RightToLeft.No;
         lblSrchBy.Size = new System.Drawing.Size(116, 13);
         lblSrchBy.TabIndex = 1;
         lblSrchBy.Text = "Field";
         lblSrchBy.TextAlign = Gap.Blazor.ContentAlignment.TopRight;
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(378, 173);
         Controls.Add(cmdClose);
         Controls.Add(cmdSearch);
         Controls.Add(ctrlLiner1);
         Controls.Add(cboSrchBy);
         Controls.Add(txtSrchStr);
         Controls.Add(Label20);
         Controls.Add(Label19);
         Controls.Add(Image3);
         Controls.Add(Label1);
         Controls.Add(lblSrchBy);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedDialog;
         Icon = (System.Drawing.Icon)resources.GetObject("frmSearch.Icon");
         this.Properties().Location = new System.Drawing.Point(486, 322);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmSearch";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         StartPosition = Gap.Blazor.FormStartPosition.CenterScreen;
         Text = "Search";
         cmdClose.SetStyle(0);
         cmdSearch.SetStyle(0);
         Activated += new System.EventHandler(frmSearch_Activated);
         Closed += new System.EventHandler(Form_Closed);
         ResumeLayout(false);
      }
#endregion

   }

}