using System;

namespace ListaDuplaObjeto
{
    class ListaDupla
    {
        public ListaDupla() 
        {
            info = 0;
            next = prior = null;
        }

        
        public void Insere(int n, ref ListaDupla START, ref ListaDupla END)
        {
            this.info = n;
            if (START == null)
                START = END = this;
            else
            {
                END.next = this;
                this.prior = END;
                END = this;
            }
        }

        
        public static bool Remover(int valor, ref ListaDupla START, ref ListaDupla END)
        {
            
            ListaDupla atual = START;
            while (atual != null && atual.info != valor)
                atual = atual.next;

           
            if (atual == null)
                return false;

            
            if (atual.prior != null)
                atual.prior.next = atual.next;
            else 
                START = atual.next;

            
            if (atual.next != null)
                atual.next.prior = atual.prior;
            else 
                END = atual.prior;

           
            atual.next = atual.prior = null;

            return true;
        }

        private int info;
        ListaDupla next;
        ListaDupla prior;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaDupla START, END, ld;
            START = END = null;
            int n, escolha;

            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Insere um elemento na Lista Dupla");
                Console.WriteLine("(2) - Remove um elemento da Lista Dupla");
                Console.WriteLine("(3) - Consulta um elemento da Lista Dupla");
                Console.WriteLine("(4) - Imprime a Lista Dupla esquerda->direita");
                Console.WriteLine("(5) - Imprime a Lista Dupla direita->esquerda");
                Console.WriteLine("(6) - Ordena a Lista Dupla");
                Console.WriteLine("(7) - Para SAIR");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1: 
                        Console.Clear();
                        ld = new ListaDupla();
                        Console.Write("Entre com um numero : ");
                        n = int.Parse(Console.ReadLine());
                        ld.Insere(n, ref START, ref END);
                        break;

                    case 2: 
                        Console.Clear();
                        Console.Write("Digite o número a ser removido: ");
                        n = int.Parse(Console.ReadLine());
                        if (ListaDupla.Remover(n, ref START, ref END))
                            Console.WriteLine("Número removido com sucesso!");
                        else
                            Console.WriteLine("Número não encontrado na lista.");
                        Console.ReadKey();
                        break;
                }
            } while (escolha != 7);
        }
    }
}