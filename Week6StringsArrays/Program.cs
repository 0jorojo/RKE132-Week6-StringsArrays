// how many words?

string hello = " hello, world? Here I am! ";
//string trimmedString = hello.Trim();

int stringLength = hello.Length;

hello = hello.Trim();

char first = hello[0];
Console.WriteLine(first);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
// hello[0] = 'H'; cant overwrite string with =; needs Replace()

first = hello[0];
Console.WriteLine(first);
Console.WriteLine(hello);

//int wordCount = 1;
//or this can be 0, but logically needs to be +1 of actual space count
//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    { wordCount++; }
//}
//Console.WriteLine($"Word count in {hello}: {wordCount}.");