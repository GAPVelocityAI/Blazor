using System;

namespace SKS
{

   public partial class frmSplash
      : Gap.Blazor.Form
   {

      public frmSplash()
      : base()
      {
         this.View = typeof(FrmSplashView);
         if ( m_vb6FormDefInstance is null )
         {
            if ( m_InitializingDefInstance )
            {
               m_vb6FormDefInstance = this;
            }
            else
            {
               try
               {
                  //For the start-up form, the first instance created is the default instance.
                  if ( !(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType() )
                  {
                     m_vb6FormDefInstance = this;
                  }
               }
               catch
               {
               }
            }
         }
         //This call is required by the Windows Form Designer.
         InitializeComponent();
      }

      private void frmSplash_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      private void Form_KeyPress(Object eventSender, Gap.Blazor.KeyPressEventArgs eventArgs)
      {
         int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
         try
         {
            this.Close();
         }
         finally
         {
            if ( KeyAscii == 0 )
            {
               eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
         }
      }

      //UPGRADE_NOTE: (7001) The following declaration (Frame1_Click) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
      //private void Frame1_Click() => this.Close();
      //
      private void Timer1_Tick(Object eventSender, EventArgs eventArgs) => this.Close();

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}