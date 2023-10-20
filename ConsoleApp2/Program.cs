class Program
{
    static int[] Input()
    {
        Console.Write(" n = ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("a[{ 0}]= ", i);
            a[i] = int.Parse(Console.ReadLine());
        }
        return a;
    }
    static int F(int[] a)
    {
        int k = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] == a[i + 1])
            {
                ++k;
            }
        }
        return k;
    }
    static void Main()
    {
        int[] a = Input();
        Console.WriteLine("k ={ 0} ", F(a));
    }
}