<Query Kind="Expression">
  <Connection>
    <ID>51ae4b6f-7ffc-4890-a7e5-e35fb162dd7a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from cat in MenuCategories
orderby cat.Description
select new  // Anonymous type
{
	Description = cat.Description,
	MenuItems = from item in cat.Items
				where item.Active
				orderby item.Description
				select new 
				{
					Description = item.Description,
					Price = item.CurrentPrice,
					Calories = item.Calories,
					Comment = item.Comment
				}
}