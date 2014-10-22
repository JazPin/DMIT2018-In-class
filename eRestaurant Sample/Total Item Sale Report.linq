<Query Kind="Statements">
  <Connection>
    <ID>1de21bbc-1a66-44db-98db-b4477358aee3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

var results = 	from info in BillItems
				orderby info.Item.MenuCategory.Description, info.Item.Description
				select new
				{
					CategoryDescription = info.Item.MenuCategory.Description,
					ItemDescription = info.Item.Description,
					Quantity = info.Quantity,
					Price = info.SalePrice,
					Cost = info.UnitCost
				};
results.Dump();