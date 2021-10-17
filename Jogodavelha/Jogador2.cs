using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    class Jogador2 : Jogadores
    {
        public override void Escolha()
        {
            bool escolheuRepetido = false;
            do
            {
                Funcionalidades.Placar();
                Funcionalidades.Tabuleiro();

                Console.WriteLine($"{Program.player2.nome}, Escolha qual posição deseja ocupar (olhe para o início do jogo): ");
                try
                {
                    int opcaoEscolhida = int.Parse(Console.ReadLine()) - 1;
                    if (position[opcaoEscolhida] == " ")
                    {
                        position[opcaoEscolhida] = "O";
                        escolheuRepetido = false;
                    }
                    else
                    {
                        Console.WriteLine("Ops..... lugar já escolhido rsrs..\nTente novamente:");
                        escolheuRepetido = true;
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    escolheuRepetido = true;
                    Console.WriteLine("Opção inválida. Aperte enter..");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (escolheuRepetido == true);

            Console.Clear();
        }

        public override void Verificar()
        {

            if (position[0] == position[1] && position[1] == position[2] && position[1] == "O" || position[3] == position[4] && position[4] == position[5] && position[4] == "O" || position[6] == position[7] && position[7] == position[8] && position[7] == "O" || position[0] == position[3] && position[3] == position[6] && position[3] == "O" || position[1] == position[4] && position[4] == position[7] && position[4] == "O" || position[2] == position[5] && position[5] == position[8] && position[5] == "O" || position[0] == position[4] && position[4] == position[8] && position[4] == "O" || position[2] == position[4] && position[4] == position[6] && position[4] == "O")
            {
                Funcionalidades.Placar();
                Funcionalidades.Tabuleiro();

                Console.WriteLine($"{Program.player2.nome} Ganhou o jogo!!!!!!! Pressione Enter");
                Program.player2.vitorias++;
                Program.fimPartida = true;

                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Program.fimPartida = false;
            }

            Funcionalidades.VerificarEmpate();

        }
    }
}
