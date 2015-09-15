<Query Kind="Program">
  <Connection>
    <ID>94a0d1ed-2791-4f25-b6bd-b63833b8a9ce</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
  var students = Names();
  //students.Dump();
  var lastInitial_S = from person in students
                       where person.Contains(" S")
					   select person;
  lastInitial_S.Dump("People whose last name starts with 'S'");					   

}

// Define other methods and classes here
public List<string> Names()
{
 
    List<string>data =new List<string>();
    data.Add("Bob Saunders");
    data.Add("Dan Gilleland");
	data.Add("Don Welch");
	data.Add("Jill Saunders");
	data.Add("Bill Smith");
	
	return data;
}