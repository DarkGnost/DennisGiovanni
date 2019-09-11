using system;

namespace Datar
{
	class BangunDatar
	{
		public string tampilan()
			{
				return ", Hi Dennis!";
			}
			public void luas_persegi()
				{
					int sisi,luas;
					
					console.WriteLine("sisi persegi adalah=");
					sisi= convert.ToInt32(console.ReadLine());
					
					luas= sisi * sisi;
					Console.WriteLine("Luas persegi adalah="+luas+"/n");
				}
				public void luas_segitiga()
				{
					int alas, tinggi;
					double luas;
					double setengah;
					setengah= 0.5;
					
					console.WriteLine("alas segitiga adalah=");
					alas= convert.ToInt32(console.ReadLine());
					
					console.WriteLine("tinggi segitiga adalah=");
					tinggi= convert.ToInt32(console.ReadLine());
					
					Luas= setengah * alas * tinggi
					
					console.WriteLine("Luas segitiga adalah="+luas+"/n");
				}
					public void luas_lingkaran()
					{
						int r;
						double luas;
						double phi;
						phi= 3.14;
						
						console.WriteLine("Jari-jari lingkaran adalah=");
						r= convert.ToInt32(console.ReadLinle());
						
						Luas= phi * r * r;
						
						console.WriteLine("Luas Lingkaran adalah="+luas+"/n");
						 
					}
	}
}