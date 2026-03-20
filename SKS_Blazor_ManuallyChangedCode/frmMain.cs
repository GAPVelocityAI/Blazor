using System;

namespace SKS
{

   public partial class frmMain
      : Gap.Blazor.Form
   {

      public frmMain()
      : base()
      {
         this.View = typeof(FrmMainView);
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

      private void frmMain_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
      private async Task MDIForm_Load()
      {
         await frmSplash.DefInstance.ShowDialog();
         frmOrderRequest.DefInstance.Show();
      }

      public async Task mnuAbout_Click(Object eventSender, EventArgs eventArgs) => await frmAbout.DefInstance.ShowDialog(this);

      public void mnuAddStockManually_Click(Object eventSender, EventArgs eventArgs) => frmAddStockManual.DefInstance.Show();

      public void mnuAdjustStockManually_Click(Object eventSender, EventArgs eventArgs) => frmAdjustStockManual.DefInstance.Show();

      public void mnuCreateOrderReception_Click(Object eventSender, EventArgs eventArgs) => frmOrderReception.DefInstance.Show();

      public void mnuCreateOrderRequest_Click(Object eventSender, EventArgs eventArgs) => frmOrderRequest.DefInstance.Show();

      public async Task mnuCustomer_Click(Object eventSender, EventArgs eventArgs)
      {
         await frmCustomers.DefInstance.ShowDialog();
         frmCustomers.DefInstance.InitForm();
      }

      public void mnuExit_Click(Object eventSender, EventArgs eventArgs) => this.Close();

      public void mnuOrderReceptionsApproval_Click(Object eventSender, EventArgs eventArgs) => frmReceptionApproval.DefInstance.Show();

      public void mnuOrderRequestsApproval_Click(Object eventSender, EventArgs eventArgs) => frmRequestApproval.DefInstance.Show();

      public async Task mnuProducts_Click(Object eventSender, EventArgs eventArgs) => await frmProducts.DefInstance.ShowDialog();

      public async Task mnuProviders_Click(Object eventSender, EventArgs eventArgs) => await frmProviders.DefInstance.ShowDialog();

      public void mnuSecurity_Click(Object eventSender, EventArgs eventArgs) => frmUsersManage.DefInstance.Show();

   }

}