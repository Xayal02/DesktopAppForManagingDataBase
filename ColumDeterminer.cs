using System.Text;
using System.Windows.Forms;

namespace ColumnDeterminer
{
    internal static  class ProductList
    {
        public static readonly int idIndex = 0;
        
        public static readonly int keepTimeIndex = 1;
       
        public static readonly int nameIndex = 2;
       
        public static readonly int typeIndex = 3;
        
        public static readonly int notesIndex = 4;
        
        public static readonly int wholesalePriceIndex = 5;
       
        public static readonly int salePriceIndex = 6;
      
        public static readonly int overallIndex = 7;

        public static  int type;


        public static int GetRowIndex(DataGridView dataGridView)
        {
            return dataGridView.SelectedCells[0].RowIndex;
        }
        public static object ColumnValues(DataGridView dataGridView, Columns column)
        {
            if (column == Columns.Id) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[idIndex].Value;

            else if (column == Columns.Name) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[nameIndex].Value;

            else if (column == Columns.ProductType) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[typeIndex].Value;

            else if (column == Columns.WholesalePrice) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[wholesalePriceIndex].Value;
            
            else if (column == Columns.SalePrice) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[salePriceIndex].Value;
            
            else if (column == Columns.KeepTime) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[keepTimeIndex].Value;
            
            else if (column == Columns.AdditionalNotes) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[notesIndex].Value;

            else return default;
        }

        public static int GetTypeValue(DataGridView dataGridView)
        {
            string typeString = ColumnValues(dataGridView, Columns.ProductType).ToString();
            if (typeString == "Dondurulmus") type = 0;
            else if (typeString == "Teze") type = 1;
            else if (typeString == "Kaptit olunmus") type = 2;
            else type = 3;

            return type;
        }

        public static bool IsTypeValueEmpty(DataGridView dataGridView)
        {
            return string.IsNullOrEmpty(dataGridView.Rows[GetRowIndex(dataGridView)].Cells[typeIndex].Value.ToString());
        }

        public enum Columns
        {
            Id,
            Name,
            ProductType,
            WholesalePrice,
            SalePrice,
            KeepTime,
            AdditionalNotes
        }
    }

    public class WarehouseList
    {
        public static readonly int nameIndex = 0;

        public static readonly int typeIndex = 1;

        public static readonly int notesIndex = 2;

        public static readonly int amountIndex = 3;

        public static readonly int measureIndex = 4;

        public static readonly int arriveDateIndex = 5;

        public static readonly int expireDateIndex = 6;

        public static readonly int codeIndex = 7;

        public static int GetRowIndex(DataGridView dataGridView)
        {
            return dataGridView.SelectedCells[0].RowIndex;
        }
        public static object ColumnValues(DataGridView dataGridView, Columns column)
        {
            if (column == Columns.Product)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(dataGridView.Rows[GetRowIndex(dataGridView)].Cells[nameIndex].Value + " | ");
                sb.Append(dataGridView.Rows[GetRowIndex(dataGridView)].Cells[typeIndex].Value + " | ");
                sb.Append(dataGridView.Rows[GetRowIndex(dataGridView)].Cells[notesIndex].Value);

                return sb.ToString();

            }

            else if (column == Columns.Amount) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[amountIndex].Value;

            else if (column == Columns.Measure) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[measureIndex].Value;

            else if (column == Columns.ArrivedDate) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[arriveDateIndex].Value;

            else if (column == Columns.Code) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[codeIndex].Value;

            else return default;
        }

        public enum Columns
        {
            Product,
            Amount,
            Measure,
            ArrivedDate,
            Code

        }
    }
    public static class Staff
    {
        public static readonly int idIndex = 0;
        public static readonly int nameIndex = 1;
        public static readonly int surnameIndex = 2;
        public static readonly int positionIndex = 3;
        public static readonly int numberIndex = 4;

        public static int GetRowIndex(DataGridView dataGridView)
        {
            return dataGridView.SelectedCells[0].RowIndex;

        }
        public static object ColumnValues(DataGridView dataGridView, Columns column)
        {
            if (column == Columns.Id) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[idIndex].Value;
          
            else if (column == Columns.Name) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[nameIndex].Value;

            else if (column == Columns.Surname) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[surnameIndex].Value;

            else if (column == Columns.Position) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[positionIndex].Value;

            else if (column == Columns.Number) return dataGridView.Rows[GetRowIndex(dataGridView)].Cells[numberIndex].Value;

            else return default;
        }

        public enum Columns
        {
            Id,
            Name,
            Surname,
            Position,
            Number
        }

    }
}
