using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;

namespace SKS
{

   public partial class frmLogin
      : Gap.Blazor.Form
   {

      public frmLogin()
      : base()
      {
         this.View = typeof(FrmLoginView);
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
         ReLoadForm(false);
      }

      private void frmLogin_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      public bool LoginSucceeded = false;

      private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
      {
         LoginSucceeded = false;
         this.Close();
      }

      private void cmdOk_Click(Object eventSender, EventArgs eventArgs)
      {
         modConnection.ExecuteSql($"SELECT * FROM Users WHERE username = '{txtUserName.Text}' and password = '{txtPassword.Text}'");
         if ( modConnection.rs.EOF )
         {
            Application.CurrentApplication.ShowSimpleNotification("Invalid 'Username' or 'Password', please try again!", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Exclamation);
            txtUserName.Focus();
            modFunctions.SelectAll(txtUserName);
            return ;
         }
         modMain.UserFullname = Convert.ToString(modConnection.rs["Fullname"]);
         modMain.UserLevel = Convert.ToString(modConnection.rs["Level"]);
         modMain.CurrentUserAdmin = (modMain.UserLevel == "Administrator");
         this.Cursor = Gap.Blazor.Cursors.CursorDefault;
         LoginSucceeded = true;
         modMain.LogStatus($"User : {modMain.UserFullname} logged at {DateTimeHelper.ToString(DateTime.Parse(DateTimeHelper.ToString(DateTime.Now)))},{DateTimeHelper.ToString(DateTime.Now)}");
         this.Close();
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}