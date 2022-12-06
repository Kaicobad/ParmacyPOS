using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsPurchaseDetails:clsMyBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DiscountId { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Vat { get; set; }
        public string Number { get; set; }
        public string Subtotal { get; set; }
        public int PurchaseId { get; set; }
        public string p_Name { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DateTime2 { get; set; }
        public string ProductName { get; set; }//added by me
        public int ProductQuantity { get; set; }// added by me



        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into purchaseDetails(productId, DiscountId, qty, rate, vat,PurchaseId,Number,subTotal) values(@productId, @discountId, @qty, @rate, @vat,@purchaseId,@number,@subTotal)");
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@number", Number);
            MyCommand.Parameters.AddWithValue("@purchaseId", PurchaseId);
            MyCommand.Parameters.AddWithValue("@subTotal", Subtotal);


            return ExecuteScaler(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update purchaseDetails set productId = @productId, discountId = discountId, qty = @qty, rate = @rate, vat = @vat where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from purchaseDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, discountId, qty, rate, vat from purchaseDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                ProductId = Convert.ToInt32(MyReader["productId"]);
                DiscountId = Convert.ToInt32(MyReader["discountId"]);
                Qty = Convert.ToInt32(MyReader["qty"]);
                Rate = Convert.ToDouble(MyReader["rate"]);
                Vat = Convert.ToDouble(MyReader["vat"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select( string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select prc.Id, p.name as Product, prc.qty, prc.rate,
                                            prc.vat as Vat, p.Code as Number,prc.subTotal, pr.Id as PuchaseId, 
                                            ds.persentage as discount ,pr.dateTime , em.name as Employee, 
                                            Pr.employeeId as EmployeeId, Prc.DiscountId as DiscountId, prc.ProductId as ProductId
                                            from PurchaseDetails as prc

                                            left join purchase as pr on pr.Id = prc.PurchaseId
                                            left join product as p  on prc.productId = p.id 
                                            left join discount as ds on prc.DiscountId = ds.Id 
                                            left join employee as em on pr.employeeId = em.Id where prc.Id > 0");
                                                                                                                                         

            if (PurchaseId > 0)
            {
                MyCommand.CommandText += " and pr.Id = @purchaseId ";
                MyCommand.Parameters.AddWithValue("@purchaseId", PurchaseId);
            }

            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }

        public System.Data.DataSet SelectProductCount(string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select p.name as Product, sum(prc.Qty) as Quantity from PurchaseDetails as prc 

                                            left join product as p on prc.ProductId = p.id

                                            group by p.Name ");


            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }

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
