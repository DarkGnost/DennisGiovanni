using system;
using datar;
using ruang;

namespace HelloProgram
{
	class program
	{
		static void main(string[] args)
		{
			BangunDatar kelasku=new BangunDatar();
			
			console.WriteLine("Kelasmu berada di X TKJ 1"+kelasku.tampilan()+"/n");
			
			kelasku.luas_persegi();
			kelasku.luas_segitiga();
			kelasku.luas_lingkaran();
			
			BangunRuang kelasku1=new BangunRuang();
			
			kelasku.volume_balok();
			kelasku.volume_kubus();
		}
	}
}