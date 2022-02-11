using System.Text;
using System.Globalization;


namespace Atividade9.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } 
        public int Likes { get; set; }  
        public List<Comment> comments { get; set; } = new List<Comment>();  

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment); //função vai para minha lista de comentários (comments) e adiciona comentários pelo parâmetro comment 
        }

        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);   //função vai para minha lista de comentários (comments) e remove comentários pelo parâmetro comment 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); //StringBuider é usado para 
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (Comment c in comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();   

        }
    }
}
