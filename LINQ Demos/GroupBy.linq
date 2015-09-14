<Query Kind="Expression">
  <Connection>
    <ID>b849f098-0328-439e-ab38-a0e4e51fec11</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Grouping Sample
from food in Items
group food by food.MenuCategoryID