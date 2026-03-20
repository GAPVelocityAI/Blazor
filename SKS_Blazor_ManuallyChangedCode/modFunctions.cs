using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;
using Gap.Blazor;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.Web.Extensions;

namespace SKS
{

   internal static class modFunctions
   {

      internal static void AppendAND(ref string filter)
      {
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(filter) )
         {
            filter = $"{filter} AND ";
         }
      }

      internal static bool AddToCollection(OrderedDictionary col, string Item)
      {
         bool result = false;
         if ( !Exists(col, Item) )
         {
            col.Add(Item, Item);
            result = true;
         }
         return result;
      }

      internal static bool Exists(OrderedDictionary col, string Index)
      {
         object o = null;
         try
         {
            //UPGRADE_WARNING: (1068) col() of type Variant is being forced to Scalar. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1068
            o = col[Index];
         }
         catch
         {
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         return !Object.Equals(o, null);
      }

      internal static double DoubleValue(string strValue)
      {
         if ( Strings.Len(strValue) != 0 )
         {
            return Double.Parse(strValue);
         }
         else
         {
            return 0;
         }
      }

      internal static bool ValidateTextBoxDouble(Gap.Blazor.TextBox txBox, Gap.Blazor.Form parentForm)
      {
         bool result = false;
         try
         {
            DoubleValue(txBox.Text);
            return true;
         }
         catch
         {
            modMain.LogStatus("The value inserted is not valid", parentForm);
            txBox.Text = "";
            txBox.Focus();
            result = false;
         }
         return result;
      }

      internal static bool ValidateTextDouble(string text, Gap.Blazor.Form parentForm)
      {
         bool result = false;
         try
         {
            DoubleValue(text);
            return true;
         }
         catch
         {
            modMain.LogStatus("The value inserted is not valid", parentForm);
            result = false;
         }
         return result;
      }

      internal static void SelectAll(Gap.Blazor.TextBox txtBox)
      {
         txtBox.SelectionStart = 0;
         txtBox.SelectionLength = Strings.Len(txtBox.Text);
      }

      internal static int UpCase(int KeyAscii) => Strings.Asc(Strings.Chr(KeyAscii).ToString().ToUpper()[0]);

      //'''''''''''''''''''''''''''''''''
      //'' Combobox related functions '''
      //'''''''''''''''''''''''''''''''''
      internal static void LoadCombo(string Table, Gap.Blazor.ComboBox combo, string field, string valueField = "")
      {
         modConnection.ExecuteSql($"Select * From {Table}");
         combo.Items.Clear();
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(valueField) )
         {
            while ( !modConnection.rs.EOF )
            {
               combo.AddItem(Convert.ToString(modConnection.rs[field]));
               combo.SetItemData(combo.GetNewIndex(), Convert.ToInt32(modConnection.rs[valueField]));
               modConnection.rs.MoveNext();
            }
         }
         else
         {
            while ( !modConnection.rs.EOF )
            {
               combo.AddItem(Convert.ToString(modConnection.rs[field]));
               modConnection.rs.MoveNext();
            }
         }
      //If strDefault <> Empty Then
      // combo = strDefault
      //End If
      }

      internal static bool ComboEmpty(Gap.Blazor.ComboBox combo, object strip = null, int Index = 0)
      {
         bool result = false;
         if ( combo.SelectedIndex == -1 )
         {
            result = true;
            Application.CurrentApplication.ShowSimpleNotification("Please select an option from the list", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Exclamation);
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !Index.Equals(0) )
            {
            //strip.SelectedItem = strip.Tabs(Index)
            }
            combo.Focus();
         }
         else
         {
            result = false;
         }
         return result;
      }

      internal static bool NoRecords(Gap.Blazor.ListView lstView, string Prompt = "")
      {
         if ( lstView.Items.Count == 0 || lstView.FocusedItem == null )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !String.IsNullOrEmpty(Prompt) )
            {
               Application.CurrentApplication.ShowSimpleNotification(Prompt, AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Exclamation);
            }
            return true;
         }
         else
         {
            return false;
         }
      }

      internal static string RcrdId(string Table, string Identifier = "", string FldNo = "")
      {
         int RcrdNo = 0;
         modConnection.ExecuteSql($"Select * from {Table} order by {FldNo} ASC");
         if ( !modConnection.rs.EOF )
         {
            modConnection.rs.MoveLast();
            RcrdNo = Convert.ToInt32(Convert.ToDouble(modConnection.rs[FldNo]) + 1);
         }
         else
         {
            RcrdNo = 1;
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(Identifier) )
         {
            return $"{Identifier}{RcrdNo.ToString()}{DateTime.Today.ToString("MM")}";
         }
         else
         {
            return RcrdNo.ToString();
         }
      }

      //''''''''''''''''''''''''''''''''''''''''
      internal static async Task SearchShow(string Table, string fieldToSearch, string itemToSearch)
      {
         frmSearch.DefInstance.Search(Table, fieldToSearch, itemToSearch);
         await frmSearch.DefInstance.ShowDialog();
      }

      internal static double ValBox(string Prompt, Gap.Blazor.PictureBox Icon, string Title = "", double Default = 0, string Header = "Value Box") =>
      //With frmValue
      //    If Title <> Empty Then
      //       .Caption = Title
      //    Else
      //        .Caption = App.Title
      //    End If
      //    .lblHeader.Caption = StrConv(Header, vbUpperCase)
      //    .imgIcon.Picture = Icon.Picture
      //    .lblPrompt.Caption = Prompt
      //    .Default Val(Default)
      //    .Show vbModal
      //    ValBox = Val(.txtValue.Text)
      //    Unload frmValue
      //End With
      0;

      internal static bool TextBoxEmpty(Gap.Blazor.TextBox stext, object TabObject = null, int TabIndex = 0)
      {
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         bool result = false;
         if ( String.IsNullOrEmpty(stext.Text.Trim()) || stext.Text == "  /  /    " )
         {
            result = true;
            Application.CurrentApplication.ShowSimpleNotification("You need to fill in all required fields", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Exclamation);
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
            if ( !TabIndex.Equals(0) )
            {
            //TabObject.SelectedItem = TabObject.Tabs(TabIndex)
            }
            stext.Focus();
         }
         else
         {
            result = false;
         }
         return result;
      }

      internal static bool TextBoxNumberEmpty(Gap.Blazor.TextBox textbox)
      {
         //if the input is not a numeric then true
         bool result = false;
         if ( !Stub._Microsoft.VisualBasic.Information.IsNumeric(textbox.Text) )
         {
            result = true;
            Application.CurrentApplication.ShowSimpleNotification("The field requires a numeric value.", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Gap.Blazor.MessageBoxButtons.OK, Gap.Blazor.MessageBoxIcon.Exclamation);
            textbox.Focus();
            SelectAll(textbox);
         }
         else
         {
            result = false;
         }
         return result;
      }

      //UPGRADE_NOTE: (7001) The following declaration (SaveDetection) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
      //private void SaveDetection(string Reference, string Title, string Description, string Table)
      //{
      //modConnection.ExecuteSql2($"Select * from {Table}");
      //modConnection.rs2.AddNew();
      //modConnection.rs2["record_no"] = Conversion.Val(RcrdId(Table, "", "record_no"));
      //modConnection.rs2["Reference"] = Reference;
      //modConnection.rs2["war_type"] = Title;
      //modConnection.rs2["Description"] = Description;
      //modConnection.rs2.Update();
      //}
      internal static string ExecErr(string Prompt, string PromptFld = "", string Table = "", string RcrdFld = "", string RcrdStr = "")
      {
         StringBuilder Rcrds = new StringBuilder();
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
         if ( !String.IsNullOrEmpty(Table) )
         {
            modConnection.ExecuteSql($"Select * from {Table} where {RcrdFld} = '{RcrdStr}'");
            while ( !modConnection.rs.EOF )
            {
               Rcrds.Append($"{Convert.ToString(modConnection.rs[PromptFld])}; ");
               modConnection.rs.MoveNext();
            }
            return $"Error: {Prompt}{Environment.NewLine}{Environment.NewLine}" + $"Related Records: {Rcrds.ToString()}";
         }
         else
         {
            return Prompt;
         }
      }

#region Data Synchronization

      internal static void BindValuesToControls(int pointer, ADORecordSetHelper aDORecordSetHelper, Dictionary<string, Control> values)
      {
         int rowCount = GetRowsCountNormal(aDORecordSetHelper);
         var rows = GetRows(aDORecordSetHelper);
         if ( rowCount > 0 && pointer <= rowCount )
         {
            foreach ( var val in values )
            {
               val.Value.Tag = val.Key;
               if ( val.Value is TextBox )
                  (val.Value as TextBox).Text = rows[pointer][val.Key].ToString();
               else if ( val.Value is CheckBox )
                  (val.Value as CheckBox).Checked = Convert.ToBoolean(rows[pointer][val.Key]);
            }
         }
      }

      internal static string QueryToInsert(Dictionary<string, Control> values, string tableName, Dictionary<string, string> additionalValues)
      {
         string queryInsert = "INSERT INTO " + tableName + "(";
         string queryValues = " VALUES(";
         foreach ( var val in values )
         {
            if ( val.Value is TextBox )
            {
               queryInsert += "'" + val.Key + "'";
               queryValues += "'" + (val.Value as TextBox).Text + "'";
            }
            else if ( val.Value is CheckBox )
            {
               queryInsert += "'" + val.Key + "'";
               queryValues += (val.Value as CheckBox).Checked ? "1" : "0";
            }
            else if ( val.Value is ComboBox )
            {
               queryInsert += "'" + val.Key + "'";
               queryValues += "'" + (val.Value as ComboBox).Text + "'";
            }
            queryInsert += ",";
            queryValues += ",";
         }

         foreach ( var val2 in additionalValues )
         {
            queryInsert += "'" + val2.Key + "',";
            queryValues += "'" + val2.Value + "',";
         }

         queryInsert = queryInsert.Substring(0, queryInsert.Length - 1);
         queryValues = queryValues.Substring(0, queryValues.Length - 1);

         queryInsert += ")";
         queryValues += ");";

         return (queryInsert + queryValues);
      }

      internal static void EmptyControls(Dictionary<string, Control> values, string defaultText = "")
      {
         foreach ( var val in values )
         {
            val.Value.Tag = val.Key;
            if ( val.Value is TextBox )
               (val.Value as TextBox).Text = defaultText;
            else if ( val.Value is CheckBox )
               (val.Value as CheckBox).Checked = false;
         }
      }

      internal static void SynchronizeData(int pointer, ADORecordSetHelper aDORecordSetHelper, Control control, Dictionary<string, Control> values)
      {
         int rowCount = GetRowsCount(aDORecordSetHelper);
         var rows = GetRows(aDORecordSetHelper);

         if ( rowCount > 0 && pointer <= rowCount )
         {
            if ( control is TextBox )
               rows[pointer][control.Tag.ToString()] = (control as TextBox).Text;
            else if ( control is CheckBox )
               rows[pointer][control.Tag.ToString()] = (control as CheckBox).Checked;
         }
      }

      internal static int GetRowsCount(ADORecordSetHelper aDORecordSetHelper)
      {
         return aDORecordSetHelper.GetTable().Rows.Count - 1;
      }

      internal static int GetRowsCountNormal(ADORecordSetHelper aDORecordSetHelper)
      {
         return aDORecordSetHelper.GetTable().Rows.Count;
      }

      internal static System.Data.DataRowCollection GetRows(ADORecordSetHelper aDORecordSetHelper)
      {
         return aDORecordSetHelper.GetTable().Rows;
      }

#endregion

   }

}