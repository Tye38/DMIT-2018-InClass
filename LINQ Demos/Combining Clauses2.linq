<Query Kind="Expression">
  <Connection>
    <ID>09f429eb-20ed-40ca-951e-cd7110428fb4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Entree's ordered from most to least expensive
from food in Items
orderby food.CurrentPrice descending
where food.MenuCategory.Description == "Entree"
 || food.MenuCategory.Description == "Beverage"
group food by food.MenuCategoryID into result
select result