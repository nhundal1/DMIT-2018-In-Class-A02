<Query Kind="Expression">
  <Connection>
    <ID>94a0d1ed-2791-4f25-b6bd-b63833b8a9ce</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cat in MenuCategories
orderby cat.Description
select new
{
  Description = cat.Description,
  MenuItems = from item in cat.Items
              where item.Active
			  orderby item.Description
			  select  new
	         {
			 
			    Description = item.Description,
				Price = item.CurrentPrice,
				Calories = item.Calories,
				Comment = item.Comment
				
			}
}