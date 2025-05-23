﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace TransferObject
{
    public class Order
    {
        public int id { get; set; }
        public DateTime createdDate { get; set; }
        public float counterfeit { get; set; }
        public float change { get; set; }
        
        public float totalPrice { get; set; }

        public string paymentMethod { get; set; }
        public string couponID { get; set; }



        public int accountID { get; set; }
        //if item[?] == order.ID
        public List<Item> Items { get; set; }
        public Order() { }
        public Order( float totalPrice,float counterfeit, string paymentMethod,string couponID, int accountID,List<Item>items=null)
        {
            this.id = id;
            //this.createdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.counterfeit = counterfeit;
            this.totalPrice = totalPrice;
            this.paymentMethod = paymentMethod;
            this.couponID = couponID;
            this.change = UpdateChange();
            this.accountID = accountID;
            this.Items = new List<Item>(); // Khởi tạo danh sách Items
            //if (items == null) return;
            //foreach(Item item in items)
            //{
            //    if (item.orderID == id)
            //    {
            //        Items.Add(item);
            //    }
            //}
        }
        private float UpdateChange()
        {
             change = counterfeit - totalPrice;
            return change;  
        }

    }
}
