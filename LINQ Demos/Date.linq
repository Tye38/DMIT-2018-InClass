<Query Kind="Expression">
  <Connection>
    <ID>dcd0a3d8-e67d-47ec-9672-17e8f2bf2ef6</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from info in Bills
where info.BillDate.Year == 2014 && 
	info.BillDate.Month == 5 &&
	info.BillDate.Day == 25//== new DateTime(2014, 5, 25)
select info 