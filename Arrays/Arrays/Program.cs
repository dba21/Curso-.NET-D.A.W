// See https://aka.ms/new-console-template for more information

int [] vs = new int [3];
inserirValores(vs);

int [] vs1 = {3, 5, 4};
maximo(vs1);
/*
int [] vs2 = {15, 5, 8};
int [] vs3 = {9, 10, 11};
//int [] vs4 = { 9, 10, 11 };
compara(vs2, vs3);
*/

int[] lista1 = { 21, 15, 9, 30 };
int[] lista2 = { 8, 15, 17, 30 };

compara(lista1, lista2);


void inserirValores(int[] valores)
{
    Console.WriteLine("Insira três valores para obter a média.\n");
    int soma = 0;

    for (int i = 0; i < valores.Length; i++)
    {
        valores[i] = int.Parse(Console.ReadLine());
        soma = soma + valores[i];
    }

    Console.WriteLine("A média é: " + soma / valores.Length + "\n");

}


static void maximo(int[] valores)
{
    Console.WriteLine("O número máximo da lista é:");
    int max = 0;

    for (int i = 0; i < valores.Length; i++)
    {
        if (valores[i] >= max)
        {
            max = valores[i];
        }
    }

    Console.WriteLine( max + "\n");
}


static void compara(int[] lista1, int[] lista2)
{

    if (lista1.Length < lista2.Length)
    {
        Console.WriteLine("\nListas diferentes");
    }
    else
    {
        Console.WriteLine("Os números das listas diferentes são:\n");
        for (int i = 0; i < lista1.Length; i++)
        {
            if (lista1[i] != lista2[i])
            {
                Console.WriteLine("Elemento " + lista1[i] + " diferente (!=) " + lista2[i]);
            }
        }

    }
}

