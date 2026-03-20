using System;
using System.Collections.Generic;
using UpgradeHelpers.DB.ADO;

namespace SKS
{

   public partial class frmCustomers
      : Gap.Blazor.Form
   {

      public frmCustomers()
      : base()
      {
         this.View = typeof(FrmCustomersView);
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

      private void frmCustomers_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      private bool NewMode = false;
      private bool EditMode = false;
      private bool CancellingMode = false;
      public string CurrentCustomerID = "";
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
            if ( value >= 0 && value <= modFunctions.GetRowsCount(dcCustomers.Recordset) )
            {
               _dataPointerInternal = value;
               VB6_AddADODataBinding();
            }
         }
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs) => CurrentCustomerID = Convert.ToString(dcCustomers.Recordset["CustomerId"]);

      //Private Sub dcCustomers_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //NewMode = False
      //EditMode = False
      //CancellingMode = False
      //End Sub
      //Private Sub dcCustomers_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //CancellingMode = True
      //End Sub
      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
      private void Form_Load() => InitForm();

      public void InitForm()
      {
         dcCustomers.ConnectionString = modMain.ConnectionString;
         NewMode = false;
         EditMode = false;
         CancellingMode = false;
      }

      private async Task Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Gap.Blazor.ToolStripItem Button = (Gap.Blazor.ToolStripItem)eventSender;
         object x = null;
         int newCustomerId = 0;
         switch ( Button.Text )
         {
            case "Add":
               //Add new record 
               NewMode = true;
               BeforeInsert();
               //dcCustomers.Recordset.AddNew();
               break;
            case "Edit":
               //Edit mode 
               EditMode = true;
               break;
            case "Save":
               //Save data 
               if (NewMode)
                    AfterInsert();
               dcCustomers.Recordset.Update();
               dcCustomers.Recordset.Requery(); // SQLite ODBC driver needs to requery the info 

               EditMode = false;
               NewMode = false;
               break;
            case "Delete":
               //Delete record 
               if ( await Gap.Blazor.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Gap.Blazor.MessageBoxButtons.YesNo, Gap.Blazor.MessageBoxIcon.Question) == Gap.Blazor.DialogResult.Yes )
               {
                  dcCustomers.Recordset.Delete();
                  dcCustomers.Recordset.Requery();
                  AfterDelete();
               }
               break;
            case "Search":
               await
                  //Search for records 
                  modFunctions.SearchShow("Customers", "CompanyName", "customer");
               break;
            case "Cancel":
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcCustomers.Recordset.CancelUpdate();
               dcCustomers.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
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
            modFunctions.SynchronizeData(this.DataPointer, dcCustomers.Recordset, eventSender as Control, this.InfoToBind);
         }
      }

      private void BindInfo()
      {
         InfoToBind = new Dictionary<string, Control>()
         {
            {"CompanyName", this._txtField_0},
            {"CompanyOrDepartment", this._txtField_1},
            {"EmailAddress", this._txtField_2},
            {"BillingAddress", this._txtField_3},
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
         dcCustomers.Recordset.MoveFirst();
      }

      private void buttonPrevious_Click(object sender, EventArgs e)
      {
         this.DataPointer--;
         dcCustomers.Recordset.CurrentPosition = this.DataPointer;
      }

      private void buttonNext_Click(object sender, EventArgs e)
      {
         this.DataPointer++;
         dcCustomers.Recordset.CurrentPosition = this.DataPointer;
      }

      private void buttonLast_Click(object sender, EventArgs e)
      {
         this.DataPointer = modFunctions.GetRowsCount(dcCustomers.Recordset);
         dcCustomers.Recordset.MoveLast();
      }

      private void AfterDelete()
      {
         if ( modFunctions.GetRowsCountNormal(dcCustomers.Recordset) == 0 )
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
            new Dictionary<string, string>() { { "CustomerID", new Random().Next(100, 9999).ToString() } });
         modConnection.ExecuteSql(sqlToInsert);
         NewMode = false;
      }

      //Used already in frmSearch
      public void SearchCriteriaProducts(string field, string value)
      {
         modConnection.ExecuteSql($"Select * from Customers where {field} LIKE '{value}%'");
         if ( modConnection.rs.RecordCount == 0 )
         {
            Application.CurrentApplication.ShowSimpleNotification("There are no records with the selected criteria", "Search", Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Information);
         }
         else
         {
            modMain.LogStatus($"There are {modConnection.rs.RecordCount.ToString()} that meet with the selected criteria");
            dcCustomers.Recordset = modConnection.rs;
         }
      }

   }

}