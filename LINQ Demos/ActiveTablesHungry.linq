<Query Kind="Expression">
  <Connection>
    <ID>dcd0a3d8-e67d-47ec-9672-17e8f2bf2ef6</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from bill in Bills
where bill.OrderPlaced == null
select bill