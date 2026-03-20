using Microsoft.VisualBasic;
using System;
using System.Media;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.Web.Extensions;

namespace SKS
{

   public partial class frmAddStockManual
      : Gap.Blazor.Form
   {

      public frmAddStockManual()
      : base()
      {
         this.View = typeof(FrmAddStockManualView);
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

      private void frmAddStockManual_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm != eventSender )
         {
            Gap.Blazor.VBUC.ActivatedForm.LastActivatedForm = (Gap.Blazor.Form)eventSender;
         }
      }

      private bool editingData = false;
      private string currentIdProduct = "";
      private string currentQuantityPerUnit = "";
      private string currentUnit = "";
      private string currentProductName = "";
      private double currentPriceReference = 0;
      private bool codeGeneratedChange = false;
      private double quantity = 0;
      private double stockPrice = 0, unitPrice = 0;

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs) => this.Close();

      private async Task cmdProducts_Click(Object eventSender, EventArgs eventArgs)
      {
         await frmProducts.DefInstance.ShowDialog();
         txtCode.Text = frmProducts.DefInstance.CurrentProductID;
         txtName.Text = "";
         DoSearchProduct();
      }

      private async Task cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
         int newStockId = 0;
         int newManualLogId = 0;
         int newStockLogId = 0;
         editingData = false;
         try
         {
            modConnection.ExecuteSql("Select * from Stocks");
            modConnection.rs.AddNew();
            modConnection.rs["ProductID"] = currentIdProduct;
            modConnection.rs["Stock"] = txtValues[0].Text;
            modConnection.rs["InitialStock"] = txtValues[0].Text;
            modConnection.rs["DateStarted"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["DateModified"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["User"] = modMain.UserId;
            modConnection.rs["UnitPrice"] = txtValues[2].Text;
            modConnection.rs["StockPrice"] = txtValues[1].Text;
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid()");
            newStockId = Convert.ToInt32(modConnection.rs[0]);
            modConnection.ExecuteSql("Select * from ManualStocks");
            modConnection.rs.AddNew();
            modConnection.rs["StockID"] = newStockId;
            modConnection.rs["Quantity"] = txtValues[0].Text;
            modConnection.rs["Price"] = txtValues[1].Text;
            modConnection.rs["User"] = modMain.UserId;
            modConnection.rs["Date"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["Action"] = "ADD";
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid()");
            newManualLogId = Convert.ToInt32(modConnection.rs[0]);
            modConnection.ExecuteSql("Select * from StockLog");
            modConnection.rs.AddNew();
            modConnection.rs["User"] = modMain.UserId;
            modConnection.rs["Date"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["Quantity"] = txtValues[0].Text;
            modConnection.rs["StockPrice"] = txtValues[1].Text;
            modConnection.rs["ProductID"] = currentIdProduct;
            modConnection.rs["StockID"] = newStockId;
            modConnection.rs["DocType"] = "MANUAL";
            modConnection.rs["DocID"] = newManualLogId;
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid()");
            newStockLogId = Convert.ToInt32(modConnection.rs[0]);
            modConnection.ExecuteSql($"Update Products Set UnitsInStock = UnitsInStock + {txtValues[0].Text}" + $" Where ProductId = '& currentIdProduct &'");
            if ( await Gap.Blazor.MessageBox.Show($"Data added successfully{Environment.NewLine}Would you like to add a new stock manually?", "New data", Gap.Blazor.MessageBoxButtons.YesNo, Gap.Blazor.MessageBoxIcon.Question) == Gap.Blazor.DialogResult.Yes )
            {
               ClearFields();
            }
            else
            {
               this.Close();
            }
         }
         catch( System.Exception excep )
         {
            Application.CurrentApplication.ShowSimpleNotification($"An error has occurred adding the data.{Environment.NewLine}Error: ({Stub._Microsoft.VisualBasic.Information.Err().Number.ToString()}) {excep.Message}", "Error", Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Error);
         }
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
      private void Form_Load()
      {
         editingData = false;
         codeGeneratedChange = false;
      }

      private async Task Form_FormClosing(Object eventSender, Gap.Blazor.FormClosingEventArgs eventArgs)
      {
         int Cancel = (eventArgs.Cancel) ? 1 : 0;
         int UnloadMode = (int)eventArgs.CloseReason;
         try
         {
            Gap.Blazor.DialogResult res = (Gap.Blazor.DialogResult)0;
            if ( editingData )
            {
               res = await Gap.Blazor.MessageBox.Show("Do you want to save the edited data?", "Save data", Gap.Blazor.MessageBoxButtons.YesNoCancel, Gap.Blazor.MessageBoxIcon.Question);
               if ( res == Gap.Blazor.DialogResult.Yes )
               {
                  await cmdSave_Click(cmdSave, new EventArgs());
               }
               else if ( res != Gap.Blazor.DialogResult.No )
               {
                  Cancel = -1;
               }
            }
         }
         finally
         {
            eventArgs.Cancel = Cancel != 0;
         }
      }

      private async Task lvProducts_Click(Object eventSender, EventArgs eventArgs) => await RetrieveDataProduct();

      private async Task lvProducts_ItemClick(Gap.Blazor.ListViewItem Item) => await RetrieveDataProduct();

      private void txtCode_TextChanged(Object eventSender, EventArgs eventArgs) => DoSearchProduct();

      //Private Sub txtCode_KeyPress(KeyAscii As Integer)
      //KeyAscii = UpCase(KeyAscii)
      //End Sub
      private async Task txtCode_Leave(Object eventSender, EventArgs eventArgs)
      {
         if ( lvProducts.Items.Count == 1 )
         {
            await RetrieveDataProduct();
         }
      }

      private void txtName_TextChanged(Object eventSender, EventArgs eventArgs) => DoSearchProduct();

      private void DoSearchProduct()
      {
         string filter = "";
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(txtCode.Text) )
         {
            filter = $"ProductId LIKE '%{txtCode.Text}%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(txtName.Text) )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(filter) )
            {
               filter = $"{filter} AND ";
            }
            filter = $"{filter}ProductName LIKE '%{txtName.Text}%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(filter) )
         {
            filter = $"Where {filter}";
         }
         modConnection.ExecuteSql($"Select ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, QuantityPerUnit, Unit from Products {filter}");
         lvProducts.Items.Clear();
         Gap.Blazor.ListViewItem x = null;
         if ( modConnection.rs.RecordCount == 0 )
         {
            modMain.LogStatus("There are no records with the selected criteria", this);
         }
         else
         {
            while ( !modConnection.rs.EOF )
            {
               x = lvProducts.Items.Add(Convert.ToString(modConnection.rs[0]));
               int tempForEndVar = (modConnection.rs.FieldsMetadata.Count - 1);
               for ( modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++ )
               {
                  //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
                  if ( !(modConnection.rs.GetField(modMain.i) is null) )
                  {
                     Gap.Blazor.ListView.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
                  }
               }
               modConnection.rs.MoveNext();
            }
            if ( lvProducts.Items.Count == 1 )
            {
               lvProducts.Items[lvProducts.Items[0].Index].Selected = true;
            //RetrieveDataProduct
            }
         }
      }

      private async Task RetrieveDataProduct()
      {
         if ( editingData )
         {
            if ( await Gap.Blazor.MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", Gap.Blazor.MessageBoxButtons.YesNo, Gap.Blazor.MessageBoxIcon.Question) != Gap.Blazor.DialogResult.Yes )
            {
               return ;
            }
         }
         Gap.Blazor.ListViewItem withVar = null;
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !(lvProducts.FocusedItem is null) )
         {
            withVar = lvProducts.FocusedItem;
            currentIdProduct = lvProducts.FocusedItem.Text;
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(Gap.Blazor.ListView.GetListViewSubItem(withVar, 5).Text) )
            {
               currentQuantityPerUnit = Gap.Blazor.ListView.GetListViewSubItem(withVar, 5).Text;
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(Gap.Blazor.ListView.GetListViewSubItem(withVar, 6).Text) )
            {
               currentUnit = Gap.Blazor.ListView.GetListViewSubItem(withVar, 6).Text;
            }
            currentProductName = Gap.Blazor.ListView.GetListViewSubItem(withVar, 1).Text;
            currentPriceReference = Double.Parse(Gap.Blazor.ListView.GetListViewSubItem(withVar, 2).Text);
            txtProductName.Text = currentProductName;
            txtQuantityPerUnit.Text = currentQuantityPerUnit;
            txtUnit.Text = currentUnit;
            txtValues[0].ReadOnly = false;
            txtValues[1].ReadOnly = false;
            txtValues[2].ReadOnly = false;
            txtValues[0].Text = "1";
            txtValues[1].Text = currentPriceReference.ToString();
            txtValues[2].Text = currentPriceReference.ToString();
            txtValues[0].Focus();
            modFunctions.SelectAll(txtValues[0]);
            editingData = false;
         }
      }

      private async Task txtName_Leave(Object eventSender, EventArgs eventArgs)
      {
         if ( lvProducts.Items.Count == 1 )
         {
            await RetrieveDataProduct();
         }
      }

      private void txtValues_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         int Index = Array.IndexOf(this.txtValues, eventSender);
         if ( !codeGeneratedChange )
         {
            editingData = true;
            codeGeneratedChange = true;
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(txtValues[0].Text) )
            {
               quantity = Double.Parse(txtValues[0].Text);
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(txtValues[1].Text) )
            {
               stockPrice = Double.Parse(txtValues[1].Text);
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(txtValues[2].Text) )
            {
               unitPrice = Double.Parse(txtValues[2].Text);
            }
            switch ( Index )
            {
               case 0:
               case 2:
                  txtValues[1].Text = (unitPrice * quantity).ToString();
                  break;
               case 1:
                  txtValues[2].Text = (stockPrice / quantity).ToString();
                  break;
            }
            lblNewQuantity.Text = $"{StringsHelper.Format(quantity * Double.Parse(currentQuantityPerUnit), "##,###.00")}{currentUnit}";
            codeGeneratedChange = false;
         }
      }

      private void txtValues_Enter(Object eventSender, EventArgs eventArgs)
      {
         int Index = Array.IndexOf(this.txtValues, eventSender);
         modFunctions.SelectAll(txtValues[Index]);
      }

      private void txtValues_KeyPress(Object eventSender, Gap.Blazor.KeyPressEventArgs eventArgs)
      {
         int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
         try
         {
            if ( KeyAscii >= ((int)Gap.Blazor.Keys.D0) && KeyAscii <= ((int)Gap.Blazor.Keys.D9) )
            {
            }
            else if ( KeyAscii == ((int)Gap.Blazor.Keys.Back) || KeyAscii == ((int)Gap.Blazor.Keys.Clear) || KeyAscii == ((int)Gap.Blazor.Keys.Delete) )
            {
            }
            else if ( KeyAscii == ((int)Gap.Blazor.Keys.Left) || KeyAscii == ((int)Gap.Blazor.Keys.Right) || KeyAscii == ((int)Gap.Blazor.Keys.Up) || KeyAscii == ((int)Gap.Blazor.Keys.Down) || KeyAscii == ((int)Gap.Blazor.Keys.Tab) )
            {
            }
            else
            {
               KeyAscii = 0;
               Stub._System.Media.SystemSounds.Beep.Play();
            }
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

      private void ClearFields()
      {
         codeGeneratedChange = true;
         txtValues[0].ReadOnly = true;
         txtValues[1].ReadOnly = true;
         txtValues[2].ReadOnly = true;
         txtValues[0].Text = "";
         txtValues[1].Text = "";
         txtValues[2].Text = "";
         txtCode.Text = "";
         txtName.Text = "";
         txtUnit.Text = "";
         txtProductName.Text = "";
         txtQuantityPerUnit.Text = "";
         lvProducts.Items.Clear();
         txtCode.Focus();
         editingData = false;
         codeGeneratedChange = false;
         lblNewQuantity.Text = "";
         modMain.ClearLogStatus(this);
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}