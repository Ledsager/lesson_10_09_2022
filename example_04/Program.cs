/* Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о 
существовании нетривиального статистического распределения отдельных символов и их 
последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью 
до замены символов будет сохраняться в процессе шифрования и дешифрования.
*/

int ElementInStroka(string strarray, char strcount)
{
    int count = 0;
    foreach (var element in strarray)
        if (strcount == element)
            count++;
    return count;
}

Console.WriteLine("Input text :");
string text = Console.ReadLine();
string searchsymboltext = string.Empty;

foreach (var element in text)
{
    int z = searchsymboltext.Length;
    int index = searchsymboltext.IndexOf(element);
    if (index == -1)
        searchsymboltext = searchsymboltext + element;
}
Console.WriteLine();

foreach (var element in searchsymboltext)
{
    int countelement = ElementInStroka(text, element);
    int lengthtext = text.Length;
    Console.WriteLine($"символ {element} встречается {ElementInStroka(text, element)} раз."
    + $" Частота {(double)countelement / lengthtext}%");
}
