using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApp.Models
{
    class Tweet
    {
        private static int CURRENT_ID;


        public string Tag { get; private set; }
        public string From { get; private set; }
        public string To { get; private set; }
        public string Body { get; private set; }
        public string Id { get; private set; }

        public Tweet(string tag, string from, string to, string body)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = $"{CURRENT_ID}";
            CURRENT_ID++;
        }

        public Tweet(string tag, string from, string to, string body, string id)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = id;
        }

        public override string ToString()
        {
            string result = "";

            result += $"ID: {Id}\n";
            result += $"From: {From}\n";
            result += $"To: {To}\n";

            result += "Body: ";

            if (this.Body.Length > 40)
            {
                result += Body.Substring(40);
            }

            else
            {
                result += Body;
            }

            result += "\n";

            result += $"Tag: {Tag}\n";

            return result;
        }

        public static Tweet Parse(string line)
        {
            string[] elements = line.Split(new char[] { '\t' });

            if (elements.Length == 4)
            {
                Tweet newTweet = new Tweet(elements[0], elements[1], elements[2], elements[3]);
                return newTweet;
            }

            else if (elements.Length == 5)
            {
                Tweet newTweet = new Tweet(elements[0], elements[1], elements[2], elements[3], elements[4]);
                return newTweet;
            }

            return null;
        }
    }
}
