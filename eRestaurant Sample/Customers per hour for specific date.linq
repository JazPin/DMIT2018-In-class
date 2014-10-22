<Query Kind="Expression">
  <Connection>
    <ID>1de21bbc-1a66-44db-98db-b4477358aee3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from info in Bills
where info.BillDate.Year == 2014
		&& info.BillDate.Month == 9
		&& info.BillDate.Day == 15
group info by info.BillDate.Hour into infoGroup
select new
{
	Hour = infoGroup.Key,
	CustomerBillCount = infoGroup.Count(),
	CustomersCount = infoGroup.Sum(x => x.NumberInParty)
}