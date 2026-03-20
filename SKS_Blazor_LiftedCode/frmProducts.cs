using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;

namespace SKS
{

   public partial class frmProducts
      : Gap.Blazor.Form
   {

      public frmProducts()
      : base()
      {
         this.View = typeof(FrmProductsView);
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

      private void frmProducts_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      private bool NewMode = false;
      private bool EditMode = false;
      private bool CancellingMode = false;
      public string CurrentProductID = "";

      //SKS Demo TODO: Go the the designer and change the data binding of _txtField_4 like this:
      //_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2");
      private void cmbCategory_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
      {
         if ( cmbCategory.Items.Count == 0 || cmbCategory.SelectedIndex == -1 )
         {
            return ;
         }
         txtCategory.Text = cmbCategory.GetItemData(cmbCategory.SelectedIndex).ToString();
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs) => CurrentProductID = Convert.ToString(dcProducts.Recordset["ProductId"]);

      private void txtCategory_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         if ( cmbCategory.Items.Count == 0 )
         {
            modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( String.IsNullOrEmpty(txtCategory.Text) )
         {
            cmbCategory.SelectedIndex = -1;
            return ;
         }
         int Index = -1;
         int tempForEndVar = cmbCategory.Items.Count;
         for ( modMain.i = 0; modMain.i <= tempForEndVar; modMain.i++ )
         {
            if ( cmbCategory.GetItemData(modMain.i) == StringsHelper.ToDoubleSafe(txtCategory.Text) )
            {
               Index = modMain.i;
               break;
            }
         }
         cmbCategory.SelectedIndex = modMain.i;
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
      private void Form_Load()
      {
         txtCategory.Height = 0;
         txtCategory.Width = 0;
         dcProducts.ConnectionString = modMain.ConnectionString;
         NewMode = false;
         EditMode = false;
         CancellingMode = false;
         if ( cmbCategory.Items.Count == 0 )
         {
            modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
         }
      }

      private async Task Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Gap.Blazor.ToolStripItem Button = (Gap.Blazor.ToolStripItem)eventSender;
         object x = null;
         //SKS Demo TODO: dcProducts.SetFocus()
         switch ( Button.Text )
         {
            case "Add":
               //Add new record 
               NewMode = true;
               dcProducts.Recordset.AddNew();
               dcProducts.Recordset["UnitsInStock"] = 0;
               dcProducts.Recordset["UnitsOnOrder"] = 0;
               dcProducts.Recordset["Discontinued"] = 0;
               break;
            case "Edit":
               //Edit mode 
               EditMode = true;
               //dcProducts.Recordset.EditMode = 
               break;
            case "Save":
               //Save data 
               dcProducts.Recordset.Update();
               dcProducts.Recordset.Requery(); // SQLite ODBC driver needs to requery the info 

               EditMode = false;
               NewMode = false;
               break;
            case "Delete":
               //Delete record 
               if ( await Gap.Blazor.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Gap.Blazor.MessageBoxButtons.YesNo, Gap.Blazor.MessageBoxIcon.Question) == Gap.Blazor.DialogResult.Yes )
               {
                  dcProducts.Recordset.Delete();
                  dcProducts.Recordset.Requery();
               }
               break;
            case "Search":
               await
                  //Search for records 
                  modFunctions.SearchShow("Products", "ProductName", "product");
               break;
            case "Cancel":
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcProducts.Recordset.CancelUpdate();
               dcProducts.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
      }

   }

}