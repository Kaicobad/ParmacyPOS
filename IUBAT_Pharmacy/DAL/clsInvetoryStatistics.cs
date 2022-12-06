using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsInvetoryStatistics : clsMyBase
    {
        public System.Data.DataSet SelectInventorys(string extra = "")
        {
            MyCommand = MyCommandBuilder(@"SELECT prc.*,sld.*,prc.PurchaseQuantity-sld.SellQuantity as ProductLeft
                                            FROM (
                                                select p.name as PurchaseProduct, sum(prc.Qty) as PurchaseQuantity from PurchaseDetails as prc 
	                                            left join product as p on prc.ProductId = p.id
	                                            group by p.Name
                                            ) prc
                                            JOIN (
                                                select p.name as SellProduct, sum(sld.Qty) as SellQuantity from SaleDetails as sld 
	                                            left join product as p on sld.ProductId = p.id 
	                                            group by p.Name 
                                            ) sld 
                                            on sld.SellProduct = prc.PurchaseProduct ");


            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
    }
}
