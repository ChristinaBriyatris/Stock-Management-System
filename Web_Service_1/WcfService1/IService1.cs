using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

 /************************************************
*   File Name=Payment Mangement Iservice1				
*   Developed by K.C.Briyatris						
************************************************/

        [OperationContract]
        List<Payment_tbl> get_all_List();

        [OperationContract]
        List<Payment_tbl> get_Payment_Id(int P_Id);


        [OperationContract]
        void Add_Payment(int P_Id, DateTime date, float Amount, int Supplier_Id);
       

        //[OperationContract]
        //void DeletePayment(int P_Id);

        [OperationContract]
        List<string> Search_Payments(int P_id);

        [OperationContract]
        void DeletePayment(int P_id);

        [OperationContract]
        List<Payment_tbl> GetAllPayments();

        [OperationContract]
        List<Payment_Report> GetPaymentReport();

 /************************************************
 *   File Name= Othre Interfaces Iservice1				
 *   Developed by P.M.Lishani Nuwanthika						
 ************************************************/

        [OperationContract]
        string get_pass(String id);
        #region supplier
        [OperationContract]
        string InsertSupplierDetails(Suppliers_tbl SupplierInfo);

        [OperationContract]
        string UpdateSupplierDetails(Suppliers_tbl SupplierInfo);

        [OperationContract]
        string DeleteSupplierDetails(int Supplier_ID);

        [OperationContract]
        int nextSupplierID();

        [OperationContract]
        String SupplierDetails(int id);
        #endregion supplier

        #region Item
        [OperationContract]
        string InsertItemDetails(Item_tbl ItemInfo);

        [OperationContract]
        string UpdateItemDetails(Item_tbl ItemInfo);

        [OperationContract]
        string DeleteItemDetails(int item_Id);

        [OperationContract]
        int nextItemID();

        [OperationContract]
        String ItemDetails(int id);

        [OperationContract]
        List<Item_tbl> ItemDetailsByItmID(String id);

        [OperationContract]
        List<Item_tbl> ItemDetailsByItmName(String Name);
        #endregion Item

        #region Stock

        [OperationContract]
        string InsertStockDetails(Stock_tbl StockInfo);

        [OperationContract]
        string UpdateStockDetails(Stock_tbl StockInfo);

        [OperationContract]
        string DeleteStockDetails(int Stock_Id);

        [OperationContract]
        String StockDetails(int id);

        #endregion Stock
    }
        public class Supplier_Details
        {

            int Supplier_Id;
            string Supplier_Name = string.Empty;
            int SupplierTele;

            [DataMember]
            public int Suppliers_Id
            {
                get { return Supplier_Id; }
                set { Supplier_Id = value; }
            }

            [DataMember]
            public string Supplier_name
            {
                get { return Supplier_Name; }
                set { Supplier_Name = value; }
            }

            [DataMember]
            public int Supplier_tele
            {
                get { return SupplierTele; }
                set { SupplierTele = value; }

            }
        }
        public class ItemTable
        {
            int itemID;
            String itemName = string.Empty;
            String SupplierId = string.Empty;
            String itemDescription = string.Empty;


            [DataMember]
            public int ItemID
            {
                get { return itemID; }
                set { itemID = value; }
            }

            [DataMember]
            public String ItemName
            {
                get { return itemName; }
                set { itemName = value; }
            }

            [DataMember]
            public String supplier
            {
                get { return SupplierId; }
                set { SupplierId = value; }
            }

            [DataMember]
            public String ItemDescription
            {
                get { return itemDescription; }
                set { itemDescription = value; }
            }
  }


        public class StockDetails
        {
            int Stock_Id;
            string Item_Id;
            int Current_Stock_Level;
            int Reorder_Limit;

            [DataMember]
            public int Itemid
            {
                get { return Stock_Id; }
                set { Stock_Id = value; }
            }
            [DataMember]
            public string ItemName
            {
                get { return Item_Id; }
                set { Item_Id = value; }
            }
            [DataMember]
            public int CurrentStockLevel
            {
                get { return Current_Stock_Level; }
                set { Current_Stock_Level = value; }
            }

            [DataMember]
            public int ReorderLimit
            {
                get { return Reorder_Limit; }
                set { Reorder_Limit = value; }
            }
        }
        public class itemD
        {
            public int itemID { get; set; }
            public String itemName { get; set; }
        }


    }

