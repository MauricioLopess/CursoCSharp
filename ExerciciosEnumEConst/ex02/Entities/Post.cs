using System;
using System.Text;
using System.Collections.Generic;

namespace ExerciciosEnumEConst.ex02.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

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
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sBuild = new StringBuilder();
            sBuild.AppendLine(Title);
            sBuild.AppendLine($"{Likes} likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sBuild.AppendLine($"{Content}\nComments:\n");
            foreach (Comment comment in Comments)
            {
                sBuild.AppendLine(comment.Text);
            }
            return sBuild.ToString();
        }
    }
}
