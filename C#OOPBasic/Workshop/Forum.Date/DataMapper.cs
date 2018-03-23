using Forum.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Forum.Date
{
    class DataMapper
    {
        private const string DATA_PATH = "../data/";
        private const string CONFIG_PATH = "config.ini";

        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv";

        private static readonly Dictionary<string, string> config;

        static DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);
        }

        public static void EnsureConfigFile(string configPath)
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, DEFAULT_CONFIG);
            }
        }

        public static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath);

            var contents = ReadLines(configPath);

            var config = contents
                .Select(l => l.Split('='))
                .ToDictionary(t => t[0], t => DATA_PATH + t[1]);

            return config;
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);

            var lines = File.ReadAllLines(path);
            return lines;
        }

        private static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }


        public static List<Category> LoadCategories()
        {
            List<Category> categories = new List<Category>();

            var lines = ReadLines(config["categories"]);

            foreach (var line in lines)
            {
                var splitLine = line.Split(";");

                var postIds = splitLine[2]
                    .Split(',')
                    .Select(int.Parse)
                    .ToList();

                Category category = new Category(int.Parse(splitLine[0]), splitLine[1], postIds);
                categories.Add(category);
            }

            return categories;
        }

        public static void SaveCategories(List<Category> categories)
        {
            List<string> lines = new List<string>();

            foreach (var category in categories)
            {
                const string categoryFormat = "{0};{1};{2}";
                string line = string.Format(categoryFormat, category.Id, category.Name,
                    string.Join(",", category.PostIds));

                lines.Add(line);
            }

            WriteLines(config["categories"], lines.ToArray());
        }

        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();

            var lines = ReadLines(config["users"]);

            foreach (var line in lines)
            {
                var splitLine = line.Split(";");

                var postIds = splitLine[3]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var user = new User(int.Parse(splitLine[0]), splitLine[1],splitLine[2], postIds);
                users.Add(user);
            }

            return users;
        }

        public static void SaveUsers(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (var user in users)
            {
                const string userFormat = "{0};{1};{2};{3}";
                string line = string.Format(userFormat, user.Id, user.Username, user.Password,
                    string.Join(",", user.PostIds));

                lines.Add(line);
            }

            WriteLines(config["users"], lines.ToArray());
        }


        public static List<Post> Loadposts()
        {
            List<Post> posts = new List<Post>();

            var lines = ReadLines(config["posts"]);

            foreach (var line in lines)
            {
                var splitLine = line.Split(";");

                var replyIds = splitLine[5]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var post = new Post(int.Parse(splitLine[0]), splitLine[1], splitLine[2],int.Parse(splitLine[3]), int.Parse(splitLine[4]), replyIds);
                posts.Add(post);
            }

            return posts;
        }

        public static void Saveposts(List<Post> posts)
        {
            List<string> lines = new List<string>();

            foreach (var post in posts)
            {
                const string postFormat = "{0};{1};{2};{3};{4};{5}";
                string line = string.Format(postFormat, post.Id, post.Title, post.Content, post.CategotyId,post.AuthorId,
                    string.Join(",", post.ReplyIds));

                lines.Add(line);
            }

            WriteLines(config["posts"], lines.ToArray());
        }


        public static List<Reply> LoadReply()
        {
            List<Reply> replies = new List<Reply>();

            var lines = ReadLines(config["replies"]);

            foreach (var line in lines)
            {
                var splitLine = line.Split(";");

                var reply = new Reply(int.Parse(splitLine[0]), splitLine[1], int.Parse(splitLine[2]),
                    int.Parse(splitLine[3]));
                replies.Add(reply);
            }

            return replies;
        }

        public static void SaveReplies(List<Reply> replies)
        {
            List<string> lines = new List<string>();

            foreach (var reply in replies)
            {
                const string replyFormat = "{0};{1};{2};{3}";
                string line = string.Format(replyFormat, reply.Id, reply.Content, reply.AuthorId, reply.PostId);
     
                lines.Add(line);
            }

            WriteLines(config["replies"], lines.ToArray());
        }


    }
}
