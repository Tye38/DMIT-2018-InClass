<Query Kind="Expression">
  <Connection>
    <ID>dcd0a3d8-e67d-47ec-9672-17e8f2bf2ef6</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//Linq Practice

from tables in Reservations
where tables.ReservationDate.Year == 2014 &&
	tables.ReservationDate.Month == 5 &&
	tables.ReservationDate.Day == 25 &&
	tables.ReservationStatus == 'C'
//orderby descending tables.ReservationStatus.Time
select tables

