<Query Kind="Expression">
  <Connection>
    <ID>94a0d1ed-2791-4f25-b6bd-b63833b8a9ce</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>


//Anonymous Types 1.linq
from food in Items
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new
{
  Desciption = food.Description,
  Price= food.CurrentPrice,
  Calories = food.Calories
  
 }