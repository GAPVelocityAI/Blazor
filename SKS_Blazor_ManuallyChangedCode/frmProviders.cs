using System;
using System.Collections.Generic;
using UpgradeHelpers.DB.ADO;

namespace SKS
{

   public partial class frmProviders
      : Gap.Blazor.Form
   {

      public frmProviders()
      : base()
      {
         this.View = typeof(FrmProvidersView);
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
         BindInfo();
         ReLoadForm(false);
      }

      private void frmProviders_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      private bool NewMode = false;
      private bool EditMode = false;
      private bool CancellingMode = false;
      public int CurrentProviderID = 0;
      private int _dataPointerInternal;
      private Dictionary<string, Control> InfoToBind { get; set; }

      private int DataPointer
      {
         get
         {
            return this._dataPointerInternal;
         }
         set
         {
            if ( value >= 0 && value <= modFunctions.GetRowsCount(dcProviders.Recordset) )
            {
               _dataPointerInternal = value;
               VB6_AddADODataBinding();
            }
         }
      }

      //Private Sub adcProviders_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //NewMode = False
      //EditMode = False
      //CancellingMode = False
      //End Sub
      //Private Sub dcProviders_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //CancellingMode = True
      //End Sub
      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
      private void Form_Load()
      {
         dcProviders.ConnectionString = modMain.ConnectionString;
         NewMode = false;
         EditMode = false;
         CancellingMode = false;
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs) => CurrentProviderID = Convert.ToInt32(dcProviders.Recordset["ProviderId"]);

      private async Task Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Gap.Blazor.ToolStripItem Button = (Gap.Blazor.ToolStripItem)eventSender;
         object x = null;
         //SKS Demo TODO: dcProviders.SetFocus()
         switch ( Button.Text )
         {
            case "Add":
               //Add new record 
               NewMode = true;
               BeforeInsert();
               //dcProviders.Recordset.AddNew();
               break;
            case "Edit":
               //Edit mode 
               EditMode = true;
               break;
            case "Save":
               Save();
               break;
            case "Delete":
               //Delete record 
               if ( await Gap.Blazor.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Gap.Blazor.MessageBoxButtons.YesNo, Gap.Blazor.MessageBoxIcon.Question) == Gap.Blazor.DialogResult.Yes )
               {
                  dcProviders.Recordset.Delete();
                  dcProviders.Recordset.Requery();
                  AfterDelete();
               }
               break;
            case "Search":
               await
                  //Search for records 
                  modFunctions.SearchShow("Providers", "ProviderName", "Provider");
               break;
            case "Cancel":
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcProviders.Recordset.CancelUpdate();
               dcProviders.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
      }

      private void Save()
      {
         //Save data
         if ( modFunctions.TextBoxEmpty(txtField[0]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[1]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[2]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[4]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[5]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[6]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[7]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[7]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[10]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[11]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[12]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[14]) )
         {
            return ;
         }
         dcProviders.Recordset.Update();
         dcProviders.Recordset.Requery();
         EditMode = false;
         NewMode = false;
      }

      private void txtField_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         if ( NewMode == true )
         {
            return;
         }

         if ( !CancellingMode )
         {
            EditMode = true;
         }

         if ( EditMode )
         {
            modFunctions.SynchronizeData(this.DataPointer, dcProviders.Recordset, eventSender as Control, this.InfoToBind);
         }
      }

      private void BindInfo()
      {
         InfoToBind = new Dictionary<string, Control>()
         {
            {"ProviderName", this._txtField_0},
            {"PaymentTerms", this._txtField_1},
            {"EmailAddress", this._txtField_2},
            {"PostalCode", this._txtField_4},
            {"City", this._txtField_5},
            {"StateOrProvince", this._txtField_6},
            {"Country/Region", this._txtField_7},
            {"PhoneNumber", this._txtField_8},
            {"Extension", this._txtField_9},
            {"FaxNumber", this._txtField_10},
            {"ContactTitle", this._txtField_11},
            {"ContactFirstName", this._txtField_12},
            {"ContactLastName", this._txtField_13},
            {"Notes", this._txtField_14},
         };
      }

      private void buttonFirst_Click(object sender, EventArgs e)
      {
         this.DataPointer = 0;
         dcProviders.Recordset.MoveFirst();
      }

      private void buttonPrevious_Click(object sender, EventArgs e)
      {
         this.DataPointer--;
         dcProviders.Recordset.CurrentPosition = this.DataPointer;
      }

      private void buttonNext_Click(object sender, EventArgs e)
      {
         this.DataPointer++;
         dcProviders.Recordset.CurrentPosition = this.DataPointer;
      }

      private void buttonLast_Click(object sender, EventArgs e)
      {
         this.DataPointer = modFunctions.GetRowsCount(dcProviders.Recordset);
         dcProviders.Recordset.MoveLast();
      }

      private void AfterDelete()
      {
         if ( modFunctions.GetRowsCountNormal(dcProviders.Recordset) == 0 )
         {
            modFunctions.EmptyControls(this.InfoToBind);
         }
         else
         {
            buttonFirst_Click(null, null);
         }
      }

      private void BeforeInsert()
      {
         modFunctions.EmptyControls(this.InfoToBind);
      }

      private void AfterInsert()
      {
         string sqlToInsert = modFunctions.QueryToInsert(this.InfoToBind, this.labelTable.Text,
            new Dictionary<string, string>() { { "ProviderID", new Random().Next(100, 9999).ToString() } });
         modConnection.ExecuteSql(sqlToInsert);
         NewMode = false;
      }

   }

}