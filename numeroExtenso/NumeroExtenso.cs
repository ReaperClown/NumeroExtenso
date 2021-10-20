using System;

public class NumeroExtenso
{
	public static void Main()
	{
		string separador = " e ";

		Console.Write("Digite um número: ");
		Globals.valor = int.Parse(Console.ReadLine());

		if (Globals.valor < 20)
		{
			Console.WriteLine(RetorneValorString(Globals.valor));

			Console.ReadLine();
		}

		if (Globals.valor > 19)
		{
			int len = Globals.valor.ToString().Length;

			if (len == 2)
			{
				int ValorPrimario = int.Parse(Globals.valor.ToString().Substring(0, 1));
				int ValorSecundario = int.Parse(Globals.valor.ToString().Substring(1, 1));
				ValorPrimario = ValorPrimario * 10;
				Console.WriteLine(RetorneValorString(ValorPrimario) + (ValorSecundario > 0 ? separador + RetorneValorString(ValorSecundario) : ""));

				Console.ReadLine();
			}
			else if (len == 3)
			{
				int ValorPrimario = int.Parse(Globals.valor.ToString().Substring(0, 1));
				int ValorSecundario = int.Parse(Globals.valor.ToString().Substring(1, 1));
				int ValorTerciario = int.Parse(Globals.valor.ToString().Substring(2, 1));

				ValorPrimario = ValorPrimario * 100;
				ValorSecundario = ValorSecundario * 10;

				Console.WriteLine("\n" + RetorneValorString(ValorPrimario)
								  + (ValorSecundario > 0 ? separador + RetorneValorString(ValorSecundario) : "")
								  + (ValorTerciario > 0 ? separador + RetorneValorString(ValorTerciario) : ""));

				Console.ReadLine();
			}
			else if (len == 4)
            {
				int ValorPrimario = int.Parse(Globals.valor.ToString().Substring(0, 1));
				int ValorSecundario = int.Parse(Globals.valor.ToString().Substring(1, 1));
				int ValorTerciario = int.Parse(Globals.valor.ToString().Substring(2, 1));
				int ValorQuaternario = int.Parse(Globals.valor.ToString().Substring(3, 1));

				ValorPrimario = ValorPrimario * 1000;
				ValorSecundario = ValorSecundario * 100;
				ValorTerciario = ValorTerciario * 10;

				Console.WriteLine("\n" + RetorneValorString(ValorPrimario)
								  + (ValorSecundario > 0 ? " " + RetorneValorString(ValorSecundario) : "")
								  + (ValorTerciario > 0 ? separador + RetorneValorString(ValorTerciario) : "")
								  + (ValorQuaternario > 0 ? separador + RetorneValorString(ValorQuaternario) : ""));

				Console.ReadLine();
			}
		}
	}

	public static string RetorneValorString(int identificador)
	{
		switch (identificador)
		{
			case 1: return "Um";
			case 2: return "Dois";
			case 3: return "Tres";
			case 4: return "Quatro";
			case 5: return "Cinco";
			case 6: return "Seis";
			case 7: return "Sete";
			case 8: return "Oito";
			case 9: return "Nove";

			case 10: return "Dez";
			case 11: return "Onze";
			case 12: return "Doze";
			case 13: return "Treze";
			case 14: return "Quatorze";
			case 15: return "Quinze";
			case 16: return "Dezesseis";
			case 17: return "Dezessete";
			case 18: return "Dezoito";
			case 19: return "Dezenove";

			case 20: return "Vinte";
			case 30: return "Trinta";
			case 40: return "Quarenta";
			case 50: return "Cinquenta";
			case 60: return "Sessenta";
			case 70: return "Setenta";
			case 80: return "Oitenta";
			case 90: return "Noventa";

			case 100: if(Globals.valor > 100 && Globals.valor <= 199)
					  return "Cento";
					  else
					  return "Cem";
			case 200: return "Duzentos";
			case 300: return "Trezentos";
			case 400: return "Quatrocentos";
			case 500: return "Quinhentos";
			case 600: return "Seicentos";
			case 700: return "Setecentos";
			case 800: return "Oitocentos";
			case 900: return "Novecentos";

			case 1000: return "Mil";
			case 2000: return "Dois Mil";
			case 3000: return "Três Mil";
			case 4000: return "Quatro Mil";
			case 5000: return "Cinco Mil";
			case 6000: return "Seis Mil";
			case 7000: return "Sete Mil";
			case 8000: return "Oito Mil";
			case 9000: return "Nove Mil";

			default: return "Valor inválido";
		}
	}

	public static class Globals
    {
        public static int valor = 0;
    }
}

