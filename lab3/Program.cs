Console.WriteLine("Enter digit");
byte a = byte.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number");
string N = Console.ReadLine()!;

int n = 0;

for (int i = 0; i < N.Length; i++) {
    if (byte.Parse(N[i].ToString()) == a) {
        n++;
    }
}

Console.WriteLine(n > 0 ? "Number '" + N.ToString() + "' includes digit '" + a.ToString() + "' " + n.ToString() + " times" : "Number '" + N.ToString() + "' doesn't include digit '" + a.ToString() + "'");