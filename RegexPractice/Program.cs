using System.Text.RegularExpressions;

//string[] strings = new string[6] { "1XxXDREO", "64FGH5", "22DFssG3", "4FGJ", "ODB3", "66XXFO" };
string[] strings = new string[14] {
	"+48 571 123445", "0780 555 666", "0048 609 123456",
	"0048-609-222-345", "+48-501-123-456", "0 508 123456",
	"608 123 456", "608123678", "607-123-799", "613332200",
	"61 222 22 22", "333ccc333", "sss333 444", "2323333"
};

//string wzor = "^(1|6)[A-z]";
//string wzor = "^[0-9]{2}[A-z]*[0-9]{1}$";
//string wzor = @"^[0-9]{2}(|[^A-z])[0-9]{3}$";

string wzor = @"^(\+|[0-9])[^A-z]";

Regex wyrazenie = new Regex(wzor);

for (int i = 0; i < strings.Length; i++)
{
	if (wyrazenie.IsMatch(strings[i]))
	{
		//strings[i] = strings[i].Replace("O", "0");
		Console.WriteLine($"{i + 1}: {strings[i]}");
	}
}