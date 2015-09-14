<Query Kind="Expression">
  <Connection>
    <ID>a5979967-cf39-4356-b0d4-f4ff2c88bd6d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from data in Waiters 
where data.ReleaseDate == null
select data