namespace Konu03Operatorler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Konu 03 Operatörler");
			Console.WriteLine("1-Aritmetik Operatörler");
			int sayi1 = 3;
			int sayi2 = 4;
			int sayi3 = 5;
			Console.WriteLine();
			Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");//string tırnağınının önüne $işareti koyarak ("string tırnağına bitişik olacak) string interpolasyonu yapıyoruz.
																					   //string interpolasyonu değişkenlerin değerlerini bir string deki yer tutucularla değiştiren yapıdır (+ ile işlem uzunluğundan kaçınırız)
			Console.WriteLine("1234" + sayi3);//string ile int arasında + işlemi yapıldığında int string'e dönüştürülür ve string olarak birleştirilir.
			Console.WriteLine();

			Console.WriteLine("Hesaplama İşlemleri:");
			Console.WriteLine("sayi1+sayi2: " + (sayi1 + sayi2));
			Console.WriteLine("sayi1-sayi2: " + (sayi1 - sayi2));
			Console.WriteLine("sayi1*sayi2: " + (sayi1 * sayi2));
			Console.WriteLine("sayi1/sayi2: " + (sayi1 / sayi2));
			Console.WriteLine("sayi1%sayi2: " + (sayi1 % sayi2));
			Console.WriteLine();

			Console.WriteLine("Artırım ve Azaltım Operatörleri");
			sayi2++; //bir değişkendeki değeri 1 artırmak için
			Console.WriteLine("sayi2: " + sayi2);
			sayi2--; // bir değişkendeki değeri eksiltmek için
			Console.WriteLine("sayi2: " + sayi2);
			Console.WriteLine();

			Console.WriteLine("Atama Operatörleri");
			Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
			Console.WriteLine("sayi1 += sayi2: " + (sayi1 += sayi2));
			Console.WriteLine("sayi1 -= sayi2: " + (sayi1 -= sayi2));
			Console.WriteLine("sayi1 *= sayi2: " + (sayi1 *= sayi2));
			Console.WriteLine("sayi1 /= sayi2: " + (sayi1 /= sayi2));
			Console.WriteLine("sayi1 %= sayi2: " + (sayi1 %= sayi2));
			Console.WriteLine();

			Console.WriteLine("İlişkisel Oparatörler"); //birden fazla değeri karşılaştırıp aralarındaki ilişkiyi öğrenmek için kullanılır.
			Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
			Console.WriteLine("sayi 1 sayi 2 ye eşit mi?" + (sayi1 == sayi2));
			Console.WriteLine("sayi 1 sayi 2 ye eşit değil mi?" + (sayi1 != sayi2));
			Console.WriteLine("sayi 1 sayi 2 den büyük mü?" + (sayi1 > sayi2));
			Console.WriteLine("sayi 1 sayi 2 den küçük mü?" + (sayi1 < sayi2));
			Console.WriteLine("sayi 1 sayi 2 den küçük mü vaya sayılar eşit mi?" + (sayi1 <= sayi2));
			Console.WriteLine("sayi 1 sayi 2 den büyük mü vaya sayılar eşit mi?" + (sayi1 >= sayi2));
			Console.WriteLine();

			Console.WriteLine("Ternary Oparatörü");// eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısayolu olarak kullanılır (o mu bu mu şeklinde).
			Console.WriteLine("Ternary: " + ((sayi1 == sayi2) ? //(eşit mi değil mi?)
			$"sayi 1 ({sayi1}) sayı 2 ({sayi2}) ye eşit" : $"sayı 1 ({sayi1}) sayı 2 ({sayi2}) ye eşit değil")); //( : işareti hangi sonuç doğruysa onun çıktısını aldırır)
			Console.WriteLine();

			Console.WriteLine("Mantıksal Operatörler");
			Console.WriteLine("And & Operatörü");
			Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
			Console.WriteLine("sayı 1 sayı 2 ye eşit mi?" + (sayi1 == sayi2));
			Console.WriteLine("sayı 1 sayı 2 den büyük mü?" + (sayi1 > sayi2));
			sayi1 = 4; //sayi1 değerini 4 olarak atıyoruz ki karşılaştırma işlemi true olsun
			Console.WriteLine("sayı 1 sayı 2 ye eşit mi? ve sayı 1 sayı 2 den küçük mü?" + ((sayi1 == sayi2) && (sayi1 < sayi2))); // iki değerinde true sonucu vermesi lazım 1 tanesi false olması durumunda sonuç false olur.
			Console.WriteLine();

			Console.WriteLine("Veya || Operatörü");
			Console.WriteLine("sayı 1 sayı 2 ye eşit mi? veya sayı 1 sayı 2 den küçük mü?" + ((sayi1 == sayi2) || (sayi1 < sayi2))); // sadece bir değerin true olması yeterli sonuç true olur.
		}
	}
}