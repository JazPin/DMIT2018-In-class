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

