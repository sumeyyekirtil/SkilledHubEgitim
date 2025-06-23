using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Konu14InterfacesArayuzler
{
	internal class KategoriDBIslemleri : IVeritabaniIslemleri
	{
		public void Add(string name)
		{
			Console.WriteLine(name + "kategorisi eklendi");
		}

		public void Delete(int id)
		{
			Console.WriteLine("Delete");
		}

		public void GetAll()
		{
			Console.WriteLine();
		}

		public void Update(int id)
		{
			Console.WriteLine("Update");
		}
	}
}
