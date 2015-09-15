<Query Kind="Expression">
  <Connection>
    <ID>94a0d1ed-2791-4f25-b6bd-b63833b8a9ce</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//lIST ALL THE MENU ITEMS THAT ARE ENTREES
//IN ORDER FROM MOST TO LEAT EXPENSIVE
from food in Items
where food.MenuCategory.Description == "Entree"
orderby food.CurrentPrice descending
select food