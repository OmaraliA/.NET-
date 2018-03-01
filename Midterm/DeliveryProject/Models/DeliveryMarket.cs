using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using DataLibrary.Models;
using DataLibrary;

namespace DeliveryProject.Models { 
    public class DeliveryMarket {
 
        public List<Order> GetOrder(){
            var getList = new Prog();
            var list = getList.ReadOrder();
            return list;
        }

        public List<Road> GetRoad(){
            var getList = new Prog();
            var list = getList.ReadRoad();
            return list;
        }
        
        public List<Category> GetCategory(){
            var getList = new Prog();
            var list = getList.ReadCategory();
            return list;
        }

        public List<Record> GetRecord(){
            var getList = new Prog();
            var roadList = getList.ReadRoad();
            var orderList = getList.ReadOrder();
            var caregoryList = getList.ReadCategory();

            var model = new List<Record>();

            var order = roadList  
                                .Join(orderList,
                                    road => road.Id,
                                    order => order.MarketId,
                                    (market, product) => new 
                                    {
                                        market,
                                        product
                                    })
                                .ToList();
            var join = marketList  
                    .Join(productList,
                        markets => markets.Id,
                        products => products.MarketId,
                        (markets, products) => new 
                        {
                            markets,
                            products
                        })
                    .ToList();           
            var newJoin = join
                    .Where(x => x.markets.Name.Equals(value))
                    .Select( x => 
                    new {
                        name = x.products.Name, 
                        price = x.products.Price,
                        amount = x.products.Amount
                    }).ToList();


            var sortPrice = marketProduct
                            .Where(x => x.market.Name.Equals(value))
                            .Sum(x=>x.product.Price);

            foreach (var item in newJoin)  {     
            model.Add(new Sum { 
                    name = item.name, 
                    price = (item.price).ToString(), 
                });
            }
          
            model.Add(new Sum {
                    sum = sortPrice.ToString()  
                });
            return model;
        }
    }
}