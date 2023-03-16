class calculator
{
	static void main(string[] args)
	{int a = 10;
	int b = 6;
	
	Console.WriteLane("hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a,b));
	Console.WriteLane("hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a,b));
	
	Console.WriteLane("\nTekan sembarang key untuk keluar");
	Console.ReadKey;
	}
	
	static int Penambahan(int a. int b)
	{
		return a+b;
	}
	static int pengurangan (int a, int b)
	{
		return a-b;
	}