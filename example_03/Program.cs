

int ElementInStroka(string strarray, char strcount)
{
    int count = 1;
    foreach (var element in strarray)
        if (strcount == element)
            count++;
    return count;
}

Console.WriteLine("Input text :");
string text = Console.ReadLine();
Console.WriteLine("enter the characters you want to analyze :");
string searchsymboltext = Console.ReadLine();

foreach (var element in searchsymboltext)
{
    int countelement = ElementInStroka(text, element);
    int lengthtext = text.Length;
    Console.WriteLine((double)countelement / lengthtext);
    Console.WriteLine($"символ {element} встречается {ElementInStroka(text, element)} раз."
    + $" Частота {(double)countelement / lengthtext}%");
}
Console.WriteLine(text.Length);


