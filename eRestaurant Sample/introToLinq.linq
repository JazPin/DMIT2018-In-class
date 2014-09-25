<Query Kind="Statements">
  <Connection>
    <ID>51ae4b6f-7ffc-4890-a7e5-e35fb162dd7a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// C# Expression
//from row in Tables
//where row.Capacity > 3
//select row;

/* Example 1: Querying data from eRestaurant */
var result = 	from row in Tables
				where row.Capacity > 3
				select row;
				
// Following line won't work in ur VS project.....				
result.Dump(); // the .Dump() method is an extension mehtod in LinqPad it's not in .NET


/* Example 2: Querying simple array of strings */
string[] names = {"Dan", "Don", "Sam", "Dwayne", "Laural", "Steve"};
names.Dump();

var shortList = from person in names
				where person.StartsWith("D")
				select person;
shortList.Dump();				

/* Example 3: Querying Find the most recent Bill and its total */
// Get All Bills that have been placed
var allBills =  from item in Bills
				where item.OrderPlaced.HasValue
				select new 	//declaring an "annonymous type" on-the-fly
				{ 			// using an init list to set the properties
					BillDate = item.BillDate,
					IsReady = item.OrderReady
				};

allBills.Count().Dump(); // show the count of items
allBills.Take(5).Dump(); // show the first 5 bills




