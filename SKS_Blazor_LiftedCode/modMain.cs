using System;
using Mobilize.Web.Extensions;

namespace SKS
{

   internal static class modMain
   {

      public static bool CurrentUserAdmin
      {
         get
         {
            StaticService.InitializeData<bool>($"{typeof(modMain).FullName}.CurrentUserAdmin", false);
            return StaticService.Get<bool>($"{typeof(modMain).FullName}.CurrentUserAdmin");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.CurrentUserAdmin", value);
         }
      }

      public static string UserFullname
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.UserFullname", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.UserFullname");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.UserFullname", value);
         }
      }

      public static string UserLevel
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.UserLevel", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.UserLevel");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.UserLevel", value);
         }
      }

      public static string UserId
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.UserId", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.UserId");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.UserId", value);
         }
      }

      public static string ConnectionString
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.ConnectionString", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.ConnectionString");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.ConnectionString", value);
         }
      }

      public static int DetectionType
      {
         get
         {
            StaticService.InitializeData<int>($"{typeof(modMain).FullName}.DetectionType", 0);
            return StaticService.Get<int>($"{typeof(modMain).FullName}.DetectionType");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.DetectionType", value);
         }
      }

      public static double n
      {
         get
         {
            StaticService.InitializeData<double>($"{typeof(modMain).FullName}.n", 0);
            return StaticService.Get<double>($"{typeof(modMain).FullName}.n");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.n", value);
         }
      }

      public static int i
      {
         get
         {
            StaticService.InitializeData<int>($"{typeof(modMain).FullName}.i", 0);
            return StaticService.Get<int>($"{typeof(modMain).FullName}.i");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.i", value);
         }
      }

      public static string s
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.s", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.s");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.s", value);
         }
      }

      public static System.DateTime d
      {
         get
         {
            StaticService.InitializeData<System.DateTime>($"{typeof(modMain).FullName}.d", DateTime.FromOADate(0));
            return StaticService.Get<System.DateTime>($"{typeof(modMain).FullName}.d");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.d", value);
         }
      }

      public static string msg
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.msg", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.msg");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.msg", value);
         }
      }

      public static string ImgName
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.ImgName", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.ImgName");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.ImgName", value);
         }
      }

      public static string ImgSrc
      {
         get
         {
            StaticService.InitializeData<string>($"{typeof(modMain).FullName}.ImgSrc", "");
            return StaticService.Get<string>($"{typeof(modMain).FullName}.ImgSrc");
         }
         set
         {
            StaticService.Set($"{typeof(modMain).FullName}.ImgSrc", value);
         }
      }

      //UPGRADE_WARNING: (1047) Application will terminate when Sub Main() finishes. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1047
      [STAThread]
      public static void Main()
      {
         Stub._System.Windows.Forms.Application.EnableVisualStyles();
         Stub._System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
         ConnectionString = "DRIVER=SQLite3 ODBC Driver; Database=Orders.db; LongNames=0; Timeout=1000; NoTXN=0; SyncPragma=NORMAL; StepAPI=0;";
         modConnection.OpenConnection();
         CurrentUserAdmin = true;
         UserFullname = "Allan Cantillo";
         UserLevel = "Administrator";
         UserId = "acantillo";
         frmMain.DefInstance.Show();
      }

      internal static void LogStatus(string message, Gap.Blazor.Form frm = null)
      {
         Gap.Blazor.StatusStrip sb = null;
         sb = null;
         ((Gap.Blazor.ToolStripStatusLabel)frmMain.DefInstance.sbStatusBar.Items[0]).Text = message;
         if ( frm != null )
         {
            if ( frm == frmAdjustStockManual.DefInstance )
            {
               sb = frmAdjustStockManual.DefInstance.sbStatusBar;
            }
            else if ( frm == frmActionOrderReception.DefInstance )
            {
               sb = frmActionOrderReception.DefInstance.sbStatusBar;
            }
            else if ( frm == frmActionOrderRequest.DefInstance )
            {
               sb = frmActionOrderRequest.DefInstance.sbStatusBar;
            }
            else if ( frm == frmAddStockManual.DefInstance )
            {
               sb = frmAddStockManual.DefInstance.sbStatusBar;
            }
            else if ( frm == frmReceptionApproval.DefInstance )
            {
               sb = frmReceptionApproval.DefInstance.sbStatusBar;
            }
            else if ( frm == frmOrderReception.DefInstance )
            {
               sb = frmOrderReception.DefInstance.sbStatusBar;
            }
            else if ( frm == frmOrderRequest.DefInstance )
            {
               sb = frmOrderRequest.DefInstance.sbStatusBar;
            }
            else if ( frm == frmRequestApproval.DefInstance )
            {
               sb = frmRequestApproval.DefInstance.sbStatusBar;
            }
            if ( sb != null )
            {
               if ( ((Gap.Blazor.ToolStripStatusLabel)sb.Items[0]) != null )
               {
                  ((Gap.Blazor.ToolStripStatusLabel)sb.Items[0]).Text = message;
               }
            }
         }
      }

      internal static void ClearLogStatus(Gap.Blazor.Form frm = null) => LogStatus("", frm);

   }

}