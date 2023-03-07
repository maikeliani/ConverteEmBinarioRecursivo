internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int resto;
        int[] binarios = new int[8];
        int x = 0;

        Console.WriteLine("Informe um numero para o calculo: ");
        numero = int.Parse(Console.ReadLine());

        converteBinario(numero);


        int[] converteBinario(int numero)
        {
            

            if ( (numero == 1)  && (numero % 2 == 0) ||( numero ==0) )
            {
                resto = numero % 2;
                binarios[x] = resto;
                return binarios;
            }
            else
            {
                resto = numero % 2;
                binarios[x] = resto;
                x++;
               
            }

            return  converteBinario(numero / 2);

        }


        for(int i = binarios.Length-1; i >= 0; i--)
        {
            Console.Write($" {binarios[i]}");
        }
    }
}