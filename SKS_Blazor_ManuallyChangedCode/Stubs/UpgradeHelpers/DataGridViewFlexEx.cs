namespace Stub._UpgradeHelpers
{

   public class DataGridViewFlexEx
      : Stub._System.Windows.Forms.DataGridViewEx
   {

      public bool AllowUserToResizeColumns { get; set; }

      public bool AllowUserToResizeRows { get; set; }

      public Gap.Blazor.DataGridViewColumnHeadersHeightSizeMode
      ColumnHeadersHeightSizeMode { get; set; }

      public bool ReadOnly { get; set; }

      public Gap.Blazor.DataGridViewSelectionMode SelectionMode { get; set; }

   }

}