<Query Kind="Program" />

void Main()
{
	var students = Names();
	//students.Dump();
	var LastInitial_S = from person in students
						where person.Contains(" S")
						select person;
	LastInitial_S.Dump("People whose last name starts with 'S' ");
}

//Define other methods and classes here

public List<string> Names()
{
	List<string> data = new List<string>();
	data.Add("Bob S");
	data.Add("Dan");
	data.Add("Don");
	data.Add("Jill");
	
	return data;
}