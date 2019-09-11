using system;

namespace BangunRuang
{
	class BangunRuang
	{
		public void volume_balok()
		{
		int panjang, lebar, tinggi, volume;
		
		console.WriteLine("panjang balok adalah=");
		panjang= convert.ToInt32(console.ReadLine());
		
		console.WriteLine("lebar balok adalah=");
		lebar= convert.ToInt32(console.ReadLine());
		
		console.WriteLine("tinggi balok adalah=");
		tinggi= convert.ToInt32(console.ReadLine());
		
		volume= panjang * lebar * tinggi;
		
		console.WriteLine("volume balok adalah="+volume+"/n");
	}
		public void volume_kubus()
		{
			int sisi, volume;
			
			console.WriteLine("sisi kubus adalah=");
			sisi= convert.ToInt32(console.ReadLine());
			
			volume= sisi * sisi * sisi;
			
			console.WriteLine("volume kubus adalah="+volume+"/n");
		}
	}
}
