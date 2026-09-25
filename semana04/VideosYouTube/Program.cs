using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá!! Este é o Projeto VideosYouTube.");
        //criando a lista de videos
        List<Video> videos = new List<Video>();

        //Criando video 1
        Video video1 = new Video();
        video1._titulo = "Tutorial de c# aula1";
        video1._autor = "Joao";
        video1._duracao = 250;
        //Criando video 2 
        Video video2 = new Video();
        video2._titulo = "Tutorial de c# aula2";
        video2._autor = "Marcos";
        video2._duracao = 320;
        //Criando video 3 
        Video video3 = new Video();
        video3._titulo = "Tutorial de c# aula3";
        video3._autor = "Paulo";
        video3._duracao = 120;
        
        //Adicionando os videos a Lista de Video "videos"
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

       

        //Criando lista de Comentarios
        List<Comentario> comentarios = new List<Comentario>();
      
  
        //Criando Comentarios Video 1
        Comentario comentario1 = new Comentario();
        comentario1._nome = "Maria";
        comentario1._texto = "muito bom";
       
        Comentario comentario2 = new Comentario();
        comentario2._nome = "Joao";
        comentario2._texto = "Excelente";
        
        Comentario comentario3 = new Comentario();
        comentario3._nome = "Mateus";
        comentario3._texto = "Otimo";
        
       
        //Criando Comentarios Video 2
        Comentario comentario5 = new Comentario();
        comentario5._nome = "Sara";
        comentario5._texto = "Otima Aula";
       
        Comentario comentario6 = new Comentario();
        comentario6._nome = "Julia";
        comentario6._texto = "Excelente";
        
        Comentario comentario7 = new Comentario();
        comentario7._nome = "Jonas";
        comentario7._texto = "Otimo";
        
        
        //Criando Comentarios Video 3
        Comentario comentario9 = new Comentario();
        comentario9._nome = "Helama";
        comentario9._texto = "Um Bom video";
       
        Comentario comentario10 = new Comentario();
        comentario10._nome = "Mormon";
        comentario10._texto = "boa Aula";
        
        Comentario comentario11 = new Comentario();
        comentario11._nome = "Oliver";
        comentario11._texto = "Otimo";
             
        
        //Atribuindo os comentarios a Lista
        comentarios.Add(comentario1);
        comentarios.Add(comentario2);
        comentarios.Add(comentario3);
        
        comentarios.Add(comentario5);
        comentarios.Add(comentario6);
        comentarios.Add(comentario7);
        
        comentarios.Add(comentario9);
        comentarios.Add(comentario10);
        comentarios.Add(comentario11);
        
        
        //Atribuindo a lista de comentarios 1 aou video 1
        video1._comment.Add(comentario1);
        video1._comment.Add(comentario2);
        video1._comment.Add(comentario3);

        video2._comment.Add(comentario5);
        video2._comment.Add(comentario6);
        video2._comment.Add(comentario7);

        video3._comment.Add(comentario9);
        video3._comment.Add(comentario10);
        video3._comment.Add(comentario11);

        //Exibindo resultados no terminal
        foreach (var video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Título: {video._titulo}");
            Console.WriteLine($"Autor: {video._autor}");
            Console.WriteLine($"Duração: {video._duracao} segundos");
            
            // Usando o método NumComment() que você criou na classe Video!
            Console.WriteLine($"Quantidade de Comentários: {video.NumComment()}");
            
            Console.WriteLine("Comentários:");

            // Percorre apenas os comentários do vídeo atual
            foreach (var comentario in video._comment)
            {
                Console.WriteLine($" - {comentario._nome}: {comentario._texto}");
            }
            Console.WriteLine();
        }

    }
}