using System; 

class ModifyBit 
{ 
    static void Main() 
    {
    ulong n = ulong.Parse(Console.ReadLine()); 
    byte p = byte.Parse(Console.ReadLine()); 
    ulong v = ulong.Parse(Console.ReadLine());
    n &= ~(1U << p);
    n |= (v << p);
    Console.WriteLine(n);
    }
}
