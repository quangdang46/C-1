using System;

public class Class1
{
	public Class1()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		int nam, thang;
        Console.WriteLine("Moi ban nhap thang:");
		thang = int.Parse(Console.ReadLine());
        switch (thang)
        {
			case 1: case 3: case 5: case 7: case 8: case 10:
			case 12:
                Console.WriteLine("Thang co 31 ngay!!");
				break;
			case 4: case 6: case 9:
			case 11:
                Console.WriteLine("Thang co 30 ngay!!");
				break;
			case 2:
                Console.WriteLine("Moi ban nhap nam:");
				nam = int.Parse(Console.ReadLine());
				if((nam%4==0 && nam%100!=0) || nam % 400 == 0)
                {
                    Console.WriteLine("Thang co 29 ngay!!");
                }
                else
                {
                    Console.WriteLine("Thang co 28 ngay!!!");
                }
				break;
			default:
                Console.WriteLine("Thang khong hop le!!");
				break;
		}
	}
}
