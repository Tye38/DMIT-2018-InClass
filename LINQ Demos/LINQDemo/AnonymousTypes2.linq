<Query Kind="Expression">
  <Connection>
    <ID>09f429eb-20ed-40ca-951e-cd7110428fb4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from person in Waiters
where person.ReleaseDate == null
select new
{
	Name = person.FirstName + " " + person.LastName,
	Phone = person.Phone,
	DaysEmployed = (DateTime.Today - person.HireDate).Days
}