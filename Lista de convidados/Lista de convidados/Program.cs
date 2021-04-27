using System;

namespace Lista_de_convidados
{
    class Program
    {
        private static string[] ListadeConvidados =
        {
            "Daniel",  //Array 0
            "Evandro",
            "Matheus",
            "Ale",
            "Teresa",
            "Gabriel",
            "Cleidson",
            "Giuseppe" //Array 7
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado:");
            var nome = Console.ReadLine();

            if (nome == null || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não informado para checar a lista");
            }

            Console.WriteLine("Informe a idade do convidado");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if (idadeInformada == false)

            {
                Console.WriteLine("Idade não informado para seguir o programa");
            }

            bool estaConvidado;
            switch (nome)
            {
                case "Daniel":
                    estaConvidado = true;
                    break;
                case "Evandro":
                    estaConvidado = true;
                    break;
                case "Matheus":
                    estaConvidado = true;
                    break;
                case "Ale":
                    estaConvidado = true;
                    break;
                case "Teresa":
                    estaConvidado = true;
                    break;
                case "Giusappe":
                    estaConvidado = true;
                    break;
                    
                    default:
                    estaConvidado = false;
                    break;
            }

            if(estaConvidado == true && idade >= 18)
            {
                Console.WriteLine("Parabéns seja bem vindo");
            }
            else if (estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos de idade");
            }
        }
    }
}
