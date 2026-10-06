int start = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();

while (start > 0)
{
	numbers.Add(start % 2);
	start = start / 2;
}

for (int i = numbers.Count - 1; i >= 0; i--)
{
	Console.Write(numbers[i]);
}

Console.ReadLine(); 