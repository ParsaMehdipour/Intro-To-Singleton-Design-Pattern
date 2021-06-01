using System.Collections.Generic;

namespace Singleton_Design
{
    public class TableSevers
    {
        private static readonly TableSevers _severs = new TableSevers();

        private List<string> Waiters = new List<string>();
        private int _nextServer = 0;

        public TableSevers()
        {
            Waiters.Add("Parsa");
            Waiters.Add("Mark");
            Waiters.Add("Bob");
            Waiters.Add("Sue");
        }

        public static TableSevers GetTableServers()
        {
            return _severs;
        }

        public string GetNextWaiter()
        {
            var output = Waiters[_nextServer];

            _nextServer += 1;

            if (_nextServer >= Waiters.Count)
                _nextServer = 0;

            return output;
        }
    }
}
