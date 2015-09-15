<Query Kind="Expression">
  <Connection>
    <ID>94a0d1ed-2791-4f25-b6bd-b63833b8a9ce</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by new {food. MenuCategoryID, food.CurrentPrice}
//No need for select clause if all you want is grouping