using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        temp_NamalDataContext Namal_S = new temp_NamalDataContext();
      //  StoreDataContext Namal_S = new StoreDataContext();

        
       
        #region login
        public string get_pass(String id)
        {
            string password1 = (from aa in Namal_S.Login_Details
                                where aa.Username == id
                                select aa.Password).SingleOrDefault();

            return password1;
        }
        #endregion login
        #region Supplier
        public String InsertSupplierDetails(Suppliers_tbl SupplierInfo)
        {
            String message;
            Suppliers_tbl sD = new Suppliers_tbl();
            sD.Supplier_Id = SupplierInfo.Supplier_Id;
            sD.Supplier_Name = SupplierInfo.Supplier_Name;
            sD.Phone_No = SupplierInfo.Phone_No;

            try
            {
                Namal_S.Suppliers_tbls.InsertOnSubmit(sD);
                Namal_S.SubmitChanges();
                message = "Details inserted successfully";
            }
            catch (Exception ex)
            {
                message = "Details not inserted successfully";
            }
            return message;
        }

        public string UpdateSupplierDetails(Suppliers_tbl SupplierInfo)
        {
            String message;
            //****
            Suppliers_tbl modify_supplier = Namal_S.Suppliers_tbls.FirstOrDefault(a => a.Supplier_Id.Equals(SupplierInfo.Supplier_Id));
            modify_supplier.Supplier_Name = SupplierInfo.Supplier_Name;
            modify_supplier.Phone_No = SupplierInfo.Phone_No;
            try
            {
                Namal_S.SubmitChanges();
                message = "Details Modified successfully";
            }
            catch
            {
                message = "Details not Modified successfully";
            }
            return message;
        }

        public string DeleteSupplierDetails(int Supplier_ID)
        {
            String message;
            Suppliers_tbl Delete_supplier = Namal_S.Suppliers_tbls.FirstOrDefault(a => a.Supplier_Id.Equals(Supplier_ID));
            try
            {
                Namal_S.Suppliers_tbls.DeleteOnSubmit(Delete_supplier);
                Namal_S.SubmitChanges();
                message = "Details Deleted successfully";
            }
            catch
            {
                message = "Details not Deleted successfully";
            }
            return message;
        }

        public int nextSupplierID()
        {
            var nSupplierID = (from a in Namal_S.Suppliers_tbls
                               select a.Supplier_Id).Max();
            return Convert.ToInt32(nSupplierID) + 1;
        }

        public String SupplierDetails(int id)
        {
            var Supplier = (from a in Namal_S.Suppliers_tbls
                            where a.Supplier_Id == id
                            select a).FirstOrDefault();
            return "Supplier ID:" + Supplier.Supplier_Id+ "\nSupplier Name:" + Supplier.Supplier_Name+ "\nTelephone:" + Supplier.Phone_No;
        }

        #endregion Supplier
        #region Item

        public String InsertItemDetails(Item_tbl ItemInfo)
        {
            String message;
            Item_tbl iD = new Item_tbl();
            iD.Item_Id = ItemInfo.Item_Id;
            iD.Item_Name = ItemInfo.Item_Name;
            iD.Item_Description = ItemInfo.Item_Description;
            iD.Supplier_Id = ItemInfo.Supplier_Id;

            try
            {
                Namal_S.Item_tbls.InsertOnSubmit(iD);
               Namal_S.SubmitChanges();
                message = "Details inserted successfully";
            }
            catch (Exception ex)
            {
                message = "Details not inserted successfully";
            }
            return message;

        }

        public string UpdateItemDetails(Item_tbl ItemInfo)
        {
            String message;
            Item_tbl modify_item = Namal_S.Item_tbls.FirstOrDefault(a => a.Item_Id.Equals(ItemInfo.Item_Id));
            modify_item.Item_Name = ItemInfo.Item_Name;
            modify_item.Item_Description = ItemInfo.Item_Description;
            modify_item.Supplier_Id = ItemInfo.Supplier_Id;

            try
            {
                Namal_S.SubmitChanges();
                message = "Details Modified successfully";
            }
            catch
            {
                message = "Details not Modified successfully";
            }
            return message;
        }

        public string DeleteItemDetails(int item_ID)
        {
            String message;
            Item_tbl Delete_item = Namal_S.Item_tbls.FirstOrDefault(a => a.Item_Id.Equals(item_ID));
            try
            {
                Namal_S.Item_tbls.DeleteOnSubmit(Delete_item);
                Namal_S.SubmitChanges();
                message = "Details Deleted successfully";
            }
            catch
            {
                message = "Details not Deleted successfully";
            }
            return message;
        }

        public int nextItemID()
        {
            var nItemID = (from a in Namal_S.Item_tbls
                           select a.Item_Id).Max();
            return Convert.ToInt32(nItemID) + 1;
        }

        public String ItemDetails(int id)
        {
            var Item = (from a in Namal_S.Item_tbls
                        where a.Item_Id == id
                        select a).FirstOrDefault();
            return "item ID:" + Item.Item_Id + "\nItem Name:" + Item.Item_Name + "\nSupplier_Id:" + Item.Supplier_Id + "\nItemDescription:" + Item.Item_Description;
        }
        public List<Item_tbl> ItemDetailsByItmID(String id)
        {
            List<Item_tbl> itemDe = new List<Item_tbl>();
            var Item = from a in Namal_S.Item_tbls
                       select a;
            foreach (var item in Item)
            {
                if (item.Item_Id.ToString().StartsWith(id))
                {
                    itemDe.Add(new Item_tbl() { Item_Id = item.Item_Id, Item_Name = item.Item_Name });
                }

            }
            return itemDe;
        }

        public List<Item_tbl> ItemDetailsByItmName(String Name)
        {
            List<Item_tbl> itemDe = new List<Item_tbl>();
            var Item = from a in Namal_S.Item_tbls
                       select a;
            foreach (var item in Item)
            {
                if (item.Item_Name.StartsWith(Name))
                {
                    itemDe.Add(new Item_tbl() { Item_Id = item.Item_Id, Item_Name = item.Item_Name });
                }
            }
            return itemDe;
        }

        #endregion Item
        #region StockLevel

        public string InsertStockDetails(Stock_tbl StockInfo)
        {
            String message;
            Stock_tbl sl = new Stock_tbl();
            sl.Stock_Id = StockInfo.Stock_Id;
            sl.Item_Id = StockInfo.Item_Id;
            sl.Current_Stock_Level = StockInfo.Current_Stock_Level;
            sl.Reorder_Limit = StockInfo.Reorder_Limit;


            sl.Current_Stock_Level = StockInfo.Current_Stock_Level;

            try
            {
                Namal_S.Stock_tbls.InsertOnSubmit(sl);
                Namal_S.SubmitChanges();
                message = "Details inserted Successfully";
            }
            catch
            {
                message = "Details not inserted Successfully";
            }

            return message;

        }

        public string UpdateStockDetails(Stock_tbl StockInfo)
        {
            String message;
            Stock_tbl modify_stock = Namal_S.Stock_tbls.FirstOrDefault(a => a.Stock_Id.Equals(StockInfo.Stock_Id));
            modify_stock.Item_Id = StockInfo.Item_Id;
            modify_stock.Reorder_Limit = StockInfo.Reorder_Limit;
            modify_stock.Current_Stock_Level += StockInfo.Current_Stock_Level;
            try
            {
                Namal_S.SubmitChanges();
                message = "Details Modified successfully";
            }
            catch
            {
                message = "Details not Modified successfully";
            }
            return message;
        }

        public string DeleteStockDetails(int Stock_id)
        {
            String message;
            Stock_tbl Delete_stock = Namal_S.Stock_tbls.FirstOrDefault(a => a.Item_Id.Equals(Stock_id));
            try
            {
                Namal_S.Stock_tbls.DeleteOnSubmit(Delete_stock);
                Namal_S.SubmitChanges();
                message = "Details Deleted successfully";
            }
            catch
            {
                message = "Details not Deleted successfully";
            }
            return message;
        }

        public String StockDetails(int id)
        {
            var Stock = (from a in Namal_S.Stock_tbls
                         where a.Stock_Id == id
                         select a).FirstOrDefault();
            return "Stock ID:" + Stock.Stock_Id + "\nItem Id:" + Stock.Item_Id + "\nCurrent_Stock_Level:" + Stock.Current_Stock_Level + "\nReorder_Limit:" + Stock.Reorder_Limit;
        }

        #endregion StockLevel



        /************************************************
       *   File Name=Payment Mangement Service1				
       *   Developed by K.C.Briyatris						
       ************************************************/

        public List<Payment_tbl> get_all_List()
        {
            var p = (from vals in Namal_S.Payment_tbls select vals).ToList<Payment_tbl>();
            return p;
        }

        public List<Payment_tbl> get_Payment_Id(int P_Id)
        {

            var i = (from vals in Namal_S.Payment_tbls where vals.Payment_Invoice_Id == P_Id select vals).ToList<Payment_tbl>();
            return i;
        }

        


        public void Add_Payment(int P_Id,DateTime date,float Amount, int Supplier_Id)
        {

            try {
                Payment_tbl new_payment = new Payment_tbl();


                new_payment.Payment_Invoice_Id = P_Id;
                new_payment.Payment_Date = date.Date;
                new_payment.Amount = Amount;
                new_payment.Supplier_Id = Supplier_Id;

                Namal_S.Payment_tbls.InsertOnSubmit(new_payment);

                Namal_S.SubmitChanges();
               
            }
            catch(Exception e)
            {
                
            }
                

          
        }

        public List<string> Search_Payments(int P_id)
        {
            var v = (from p in Namal_S.Payment_tbls
                     where p.Payment_Invoice_Id == P_id
                     select p);

            List<string> list = new List<string>();

            foreach (var i in v)
            {
                list.Add(i.Amount.ToString());
                list.Add(i.Payment_Date.ToString());
            }

            return list;

        }

        public List<Payment_tbl> GetAllPayments()
        {
            var v = (from p in Namal_S.Payment_tbls
                     select p).ToList<Payment_tbl>();

            return v;
        }


        public List<Payment_Report> GetPaymentReport()
        {
            var rv = (from rp in Namal_S.Payment_Reports
                      select rp).ToList<Payment_Report>();

            return rv;
        }





        public void DeletePayment(int P_id)
        {

            try
            {
                var v = (from p in Namal_S.Payment_tbls
                         where p.Payment_Invoice_Id == P_id
                         select p).SingleOrDefault();

            }
            catch (Exception ex)
            {
               
            }

        }




        

        //public void Delete_Payment(int P_Id, DateTime date,float Amount, int Supplier_Id)
        //{


        //        //Payment_tbl Current_payment = new Payment_tbl();


        //        //Current_payment.Payment_Invoice_Id = P_Id;
        //        //Current_payment.Payment_Date = date.Date; //date.Date
        //        //Current_payment.Amount = Amount;
        //        //Current_payment.Supplier_Id = Supplier_Id;
        //        //Namal_S.Payment_tbls.DeleteOnSubmit(Current_payment);

        //        //Namal_S.SubmitChanges();


        //}







    }

}
    
