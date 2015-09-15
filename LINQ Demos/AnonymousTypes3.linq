<Query Kind="Expression">
  <Connection>
    <ID>09f429eb-20ed-40ca-951e-cd7110428fb4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by food.MenuCategory into foodGroup
select new
{
	CategoryID = foodGroup.Key.MenuCategoryID,
	Category = foodGroup.Key.Description,
	count = foodGroup.Count(),
	MenuItems = foodGroup.ToList()
}
