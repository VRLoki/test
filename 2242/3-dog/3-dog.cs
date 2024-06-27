enum Rating
{
	Good,
	Great,
	Excellent
}

struct Dog
{
	public string name;
	public float age;
	public string owner;
	public Rating rating;
	public Dog(string name, float age, string owner, Rating rating)
	{
		this.name = name;
		this.age = age;
		this.owner = owner;
		this.rating = rating;
	}

	public override string ToString()
	{
		string infoPrinted = $"Dog Name: {this.name}\n";

		infoPrinted += $"Age: {this.age}\n";
		infoPrinted += $"Owner: {this.owner}\n";
		infoPrinted += $"Rating: {this.rating}";

		return infoPrinted;
	}
}
