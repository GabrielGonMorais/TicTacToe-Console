using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    class Jogador1 : Jogadores
    {

        public override void Escolha()
        {
            bool escolheuRepetido = false;

            do
            {
                Program.Placar();
                Program.Tabuleiro();

                Console.WriteLine($"{Program.player1.nome}, Escolha qual posição deseja ocupar (olhe para o início do jogo): ");
                int opcaoEscolhida = int.Parse(Console.ReadLine()) - 1;
                if (position[opcaoEscolhida] == " ")
                {
                    position[opcaoEscolhida] = "X";
                    escolheuRepetido = false;
                }
                else
                {
                    Console.WriteLine("Ops..... lugar já escolhido rsrs..\nTente novamente:");
                    escolheuRepetido = true;
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (escolheuRepetido == true);

            Console.Clear();
        }

        public override void Verificar()
        {           

            if (position[0] == position[1] && position[1] == position[2] && position[1] == "X" || position[3] == position[4] && position[4] == position[5] && position[4] == "X" || position[6] == position[7] && position[7] == position[8] && position[7] == "X" || position[0] == position[3] && position[3] == position[6] && position[3] == "X" || position[1] == position[4] && position[4] == position[7] && position[4] == "X" || position[2] == position[5] && position[5] == position[8] && position[5] == "X" || position[0] == position[4] && position[4] == position[8] && position[4] == "X" || position[2] == position[4] && position[4] == position[6] && position[4] == "X")
            {
                Program.Placar();
                Program.Tabuleiro();

                Console.WriteLine($"{Program.player1.nome} Ganhou o jogo!!!!!!! Pressione Enter");
                Program.player1.vitorias++;
                Program.fimPartida = true;

                Console.ReadLine();
                Console.Clear();
            }            
            else
            {
                Program.fimPartida = false;
            }

            Program.VerificarEmpate();

        }
    }
}
