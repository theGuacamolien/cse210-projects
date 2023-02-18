using System;

namespace JournalApp
{
    class Entry
    {
        private string prompt;
        private string response;
        private DateTime date;

        public Entry(string prompt, string response)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = DateTime.Now;
        }

        public Entry(string prompt, string response, DateTime date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }

        public string GetPrompt()
        {
            return prompt;
        }

        public string GetResponse()
        {
            return response;
        }

        public DateTime GetDate()
        {
            return date;
        }
    }
}
