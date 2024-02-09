// pick & show random entry from set array 
string[] snacks = { "chipsek", "chocolates", "burgs", "yogurt", "tea" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"On today's menu: {snacks[randomIndex]}");