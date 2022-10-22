//char[] ruletter = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ш', 'щ', 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е', };
//char[] enletter = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'a', 'e', 'i', 'o', 'u', 'y' };
//void Pangram()
//{
//    Console.WriteLine("Введите предложение");
//    string a = Console.ReadLine();
//    char[] result = a.ToCharArray();
//    bool b = true;
//    foreach (char c in enletter)
//    {
//        if (!result.Contains(c))
//        {
//            b = false;
//            break;
//        }
//    }
//    if (b == true)
//    {
//        Console.WriteLine("Это предложения панграмма");
//    }
//}
//Pangram();

char[] chars = new char[] { 'o', 'i', 'a', 'u', 'e' };
Console.WriteLine("Введите предложение");
string a = Console.ReadLine();
foreach (char c in chars)
{
    bool isupper = char.IsUpper(c);
    if (isupper == false && chars.Contains(c))
    {
        a = a.Replace(c.ToString(), "");
    }
}
Console.WriteLine(a);