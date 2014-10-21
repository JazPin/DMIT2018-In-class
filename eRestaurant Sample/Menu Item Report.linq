<Query Kind="Expression">
  <Connection>
    <ID>51ae4b6f-7ffc-4890-a7e5-e35fb162dd7a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// This query is for pulling out data to be used in a 
// Details report. The query gets all the menu itmes 
// and their caegories , sorting them by the menu item description 
// and then by the menu item description.

from cat in Items
orderby cat.MenuCategory.Description, cat.Description
select new 
{
	CategoryDescription = cat.MenuCategory.Description,
	ItemDescription = cat.Description,
	Price = cat.CurrentPrice,
	Calories = cat.Calories,
	Comment = cat.Comment
}