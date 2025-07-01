// 4 tane sayıdan en büyük olanı ekrana yazdıran program.

using System.ComponentModel.Design;

int sayi1, sayi2, sayi3, sayi4, buyuk;

Console.WriteLine("1.sayıyı giriniz.");
sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("2.sayıyı giriniz.");
sayi2 = int.Parse(Console.ReadLine());
Console.WriteLine("3.sayıyı  giriniz.");
sayi3 = int.Parse(Console.ReadLine());
Console.WriteLine("4.sayıyı giriniz");
sayi4 = int.Parse(Console.ReadLine());


//1.yöntem
if (sayi1 > sayi2)
{
    if (sayi3 > sayi4)
    {
        if (sayi1 > sayi3)
            buyuk = sayi1;
        else
            buyuk = sayi3;
    }
    else
        if (sayi1 > sayi4)
    {
        buyuk = sayi1;
    }
    else
        buyuk = sayi4;
}
else
    if (sayi3 > sayi4)
{
    if (sayi2 > sayi3)
        buyuk = sayi2;
    else
        buyuk = sayi3;
    
}
else
    if (sayi2 > sayi4)
    buyuk=sayi2;
else buyuk = sayi4;

Console.WriteLine("büyük sayı "+buyuk);



//2.yöntem

buyuk=Math.Max(sayi1,sayi2);
buyuk = Math.Max(buyuk, sayi3);
buyuk = Math.Max(buyuk,sayi4);
Console.WriteLine("en büyük sayı "+buyuk);