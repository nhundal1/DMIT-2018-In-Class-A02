<Query Kind="Expression">
  <Connection>
    <ID>94a0d1ed-2791-4f25-b6bd-b63833b8a9ce</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Anonymous Types 2.linq

from person in Waiters
where person.ReleaseDate == null   // People still employed
select new
{
Name = person.FirstName + " " + person.LastName,
Phone = person.Phone,
DaysEmployed =(DateTime.Today - person.HireDate). Days
}


