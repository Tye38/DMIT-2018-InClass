<Query Kind="Expression">
  <Connection>
    <ID>b849f098-0328-439e-ab38-a0e4e51fec11</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// booking is a variable name
from booking in Reservations
where booking.EventCode.Equals("A")
select booking