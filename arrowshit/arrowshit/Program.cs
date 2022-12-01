

ConsoleKeyInfo cki;
cki = Console.ReadKey();

if (cki.Key == ConsoleKey.RightArrow)
{
    Console.Write("fug");

}
Console.ReadKey();

float[] a = new float[5];
for (int i = 0; i < a.Length; i++)
{

    a[i] = float.Parse(Console.ReadLine());
}
Array.Sort(a);
foreach (float s in a)
    Console.Write("{0} ", s);

