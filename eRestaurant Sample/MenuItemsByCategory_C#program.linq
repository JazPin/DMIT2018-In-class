<Query Kind="Program">
  <Connection>
    <ID>51ae4b6f-7ffc-4890-a7e5-e35fb162dd7a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	var data =  from cat in MenuCategories
				orderby cat.Description
				select new Category() // Anonymous type
				{
					Description = cat.Description,
					MenuItem = from item in cat.Items
								where item.Active
								orderby item.Description
								select new MenuItem()
								{
									Description = item.Description,
									Price = item.CurrentPrice,
									Calories = item.Calories,
									Comment = item.Comment
								}
				};
	data.Dump();
}

// Define other methods and classes here

public class Category{
	public string Description{get; set;}
	public IEnumerable MenuItem {get; set;}
}

public class MenuItem
{
	public string Description{get;set;}
	public decimal Price {get;set;}
	public int? Calories {get;set;}
	public string Comment {get;set;}
}
