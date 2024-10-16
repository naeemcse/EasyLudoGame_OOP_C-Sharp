for(int i = 0 ;i<100;i++)
Console.Write("#");
Console.WriteLine();

for (int i = 0; i < 100; i++)
{
    if(i<50 || i==99)
    Console.Write("#");
else 
   if(i%5==0)
       Console.Write("|");
   else
   {
       
        Console.Write(" ");
   }
   
    
} 

Console.WriteLine();

for(int i = 0 ;i<100;i++)
    Console.Write("#");