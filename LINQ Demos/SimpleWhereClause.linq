<Query Kind="Expression">
  <Connection>
    <ID>b849f098-0328-439e-ab38-a0e4e51fec11</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from row in Tables
where row.Capacity > 3
select row