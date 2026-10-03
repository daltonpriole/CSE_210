using System;
using System.Collections.Generic;

    public class Gratidao : Atividades
    {
        private List<string> _gatilhos;
        private Random _random;

        public Gratidao()
        {
            _nome = "Gratidão";
            _descricao = "Esta atividade ajudará você a focar nas coisas boas do seu dia, cultivando um sentimento de apreciação por pequenos e grandes momentos.";
            _random = new Random();

            _gatilhos = new List<string>
            {
                "Pense em algo simples que aconteceu hoje e te fez sorrir.",
                "Pense em uma pessoa que tornou sua vida melhor recentemente.",
                "Pense em um desafio recente que te trouxe algum aprendizado.",
                "Pense em um privilégio ou conforto que você tem na sua rotina e costuma esquecer."
            };
        }

        public override void Executar()
        {
            // Sorteia um gatilho de gratidão
            string gatilhoEscolhido = _gatilhos[_random.Next(_gatilhos.Count)];
            
            Console.WriteLine("\nFeche os olhos por alguns instantes e reflita sobre o seguinte gatilho:");
            Console.WriteLine($"\n--- {gatilhoEscolhido} ---");
            Console.Write("\nMantenha esse pensamento em mente: ");
            
            // Usa metade do tempo total da atividade para o usuário apenas refletir com o spinner
            int tempoReflexao = _duracao / 2;
            if (tempoReflexao < 3) tempoReflexao = 3; // Garante um tempo mínimo
            ExibirProgresso(tempoReflexao);
            Console.WriteLine("\n\nAgora que você se conectou com esse sentimento...");
            
            // Pede para o usuário registrar o seu agradecimento
            Console.WriteLine("Escreva em uma frase o seu agradecimento sincero de hoje:");
            Console.Write("> ");
            string agradecimento = Console.ReadLine();

            if (!string.IsNullOrEmpty(agradecimento))
            {
                Console.Clear();
                Console.WriteLine("\nSua afirmação positiva do dia foi registrada com sucesso:");
                Console.WriteLine($"\n✨ \"{agradecimento}\" ✨");
                
                // Deixa a mensagem positiva na tela com o spinner rodando pelo tempo restante
                int tempoRestante = _duracao - tempoReflexao;
                if (tempoRestante > 0)
                {
                    ExibirProgresso(tempoRestante);
                }
            }
        }
    }
