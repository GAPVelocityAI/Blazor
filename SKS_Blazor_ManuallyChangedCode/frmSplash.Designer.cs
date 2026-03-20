using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmSplash
   {

#region "Upgrade Support "
      private static frmSplash m_vb6FormDefInstance
      {
         get
         {
            return StaticService.Get<frmSplash>($"{typeof(frmSplash).FullName}.m_vb6FormDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmSplash).FullName}.m_vb6FormDefInstance", value);
         }
      }

      private static bool m_InitializingDefInstance
      {
         get
         {
            return StaticService.Get<bool>($"{typeof(frmSplash).FullName}.m_InitializingDefInstance");
         }
         set
         {
            StaticService.Set($"{typeof(frmSplash).FullName}.m_InitializingDefInstance", value);
         }
      }

      public static frmSplash DefInstance
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
      public static frmSplash CreateInstance()
      {
         frmSplash theInstance = new frmSplash();
         return theInstance;
      }

      private string[] visualControls = new string[] { "components", "ToolTipMain", "Timer1", "Image1" };
      //Required by the Windows Form Designer
      private Gap.Blazor.IContainer components;

      public Gap.Blazor.ToolTip ToolTipMain { get; set; }

      public Gap.Blazor.Timer Timer1 { get; set; }

      public Gap.Blazor.PictureBox Image1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      private void InitializeComponent()
      {
         components = new Gap.Blazor.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
         ToolTipMain = new Gap.Blazor.ToolTip(components);
         Timer1 = new Gap.Blazor.Timer(components);
         Image1 = new Gap.Blazor.PictureBox();
         SuspendLayout();
         // 
         // Timer1
         // 
         Timer1.Enabled = true;
         Timer1.Interval = 3000;
         Timer1.Tick += new System.EventHandler(Timer1_Tick);
         // 
         // Image1
         // 
         Image1.AllowDrop = true;
         Image1.BorderStyle = Gap.Blazor.BorderStyle.None;
         Image1.Enabled = true;
         Image1.Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         Image1.Image = (System.Drawing.Image)resources.GetObject("Image1.Image");
         Image1.Location = new System.Drawing.Point(0, 0);
         Image1.Name = "Image1";
         Image1.Size = new System.Drawing.Size(964, 642);
         Image1.SizeMode = Gap.Blazor.PictureBoxSizeMode.StretchImage;
         Image1.Visible = true;
         AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         BackColor = Gap.Blazor.SystemColors.Control;
         ClientSize = new System.Drawing.Size(943, 613);
         Controls.Add(Image1);
         Font = new Gap.Blazor.Font("Microsoft Sans Serif", 8.25f, Gap.Blazor.FontStyle.Regular, Gap.Blazor.GraphicsUnit.Point, 0);
         FormBorderStyle = Gap.Blazor.FormBorderStyle.FixedDialog;
         KeyPreview = true;
         this.Properties().Location = new System.Drawing.Point(17, 116);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "frmSplash";
         RightToLeft = Gap.Blazor.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         StartPosition = Gap.Blazor.FormStartPosition.CenterScreen;
         Activated += new System.EventHandler(frmSplash_Activated);
         Closed += new System.EventHandler(Form_Closed);
         KeyPress += new Gap.Blazor.KeyPressEventHandler(Form_KeyPress);
         ResumeLayout(false);
      }
#endregion

   }

}