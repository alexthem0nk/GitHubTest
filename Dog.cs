/* 
	File name: 	Dog.cs
	Purpose:	Class to describe pet dog used for a vet practice
	Author:		Alex Lencucha
	Date:		01-DEC-2022
	Version:	1.1
	Notes:
	
*/

namespace VetPractice
{
	public class Dog : IComparable<Dog>
	{
		public string Name {get; set;}
		public string Type {get; set;}
		public string Sex {get; set;}
		public bool IsDesexed {get; set;}
		
		public Dog (string name, string type, string sex, bool isDesexed)
		{
			Name = name;
			Type = type;
			Sex = sex;
			IsDesexed = isDesexed;
		}
		
		public int CompareTo(Dog otherDog)
		{
			return Name.CompareTo(otherDog.Name);
		}
	
	}

}
