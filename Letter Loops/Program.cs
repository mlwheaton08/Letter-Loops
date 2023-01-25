//Expected inputs/outputs:
//abcd A-Bb-Ccc-Dddd
//RqaEzty	R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy
//cwAt	C-Ww-Aaa-Tttt

Console.Write("Please a string of letters: ");
string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
	for (int j = 0; j <= i; j++)
	{
		if (j == 0)
		{
			string letter = input[i].ToString();
			Console.Write(letter.ToUpper());
		}
		else
		{
            string letter = input[i].ToString();
            Console.Write(letter.ToLower());
        }
	}
	if (i != input.Length - 1)
	{
		Console.Write("-");
	}
}