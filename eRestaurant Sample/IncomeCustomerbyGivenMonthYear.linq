<Query Kind="Statements">
  <Connection>
    <ID>51ae4b6f-7ffc-4890-a7e5-e35fb162dd7a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Get the following form the Bills table for the given month/year:
// BillDate, ID, #people served , total amount billed
// Then, display the total income for the month and the number of customers served

// 0) Set up info that might be passed in to my BLL
var month =DateTime.Today.Month -1;
var year = DateTime.Today.Year;

// 1) Get the data for the month/year with a sum of each Bill's BillItems
var billsInMonth = 	from item in Bills
					where item.PaidStatus // only the bills that were/was paid
							&& item.BillDate.Month == month
							&& item.BillDate.Year  == year
					orderby item.BillDate
					select new 
					{
						BillDate = item.BillDate,
						BillId = item.BillID,
						NumberOfCustomers = item.NumberInParty,
						TotalAmount = item.BillItems.Sum(bi => bi.Quantity * bi.SalePrice)
					};
					
//billsInMonth.Dump();

//Temp: some var for formatting
var monthName = DateTime.Today.AddMonths(-1).ToString("MMM");
var title = string.Format("Total income for {0} {1}", monthName,year);
//Temp: Perform some quick aggregates to check my query
billsInMonth.Sum(tm => tm.TotalAmount).ToString("C").Dump(title, true);

billsInMonth.Sum(tm => tm.NumberOfCustomers).Dump("Patrons Served", true);

// 2) Build the report from the billsInMonth date
var report = 	from item in billsInMonth
				group item by item.BillDate.Day into dailySummary
				select new 
				{
					Day = dailySummary.Key,
					DailyCustomers = dailySummary.Sum(grp => grp.NumberOfCustomers),
					Income = dailySummary.Sum(grp => grp.TotalAmount)
				};
report.OrderBy(r => r.Day).Dump("Daily Income");


