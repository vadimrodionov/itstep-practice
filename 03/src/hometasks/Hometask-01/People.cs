using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace UdincevBogdan.Hometask_01
{
    interface IWorker
    {
        public string Name { get; }
    }
    public class Team
    {
        public Team(List<Worker> w)
        {
            WS = w;
        }
        public Team(List<Worker> w, TeamLeader tl)
        {
            WS = w;
            TL = tl;
        }

        public TeamLeader TL { get; set; }
        public List<Worker> WS { get; set; }
        public string W { get { return Worker._Name; } }
        public List<string> report = new List<string>();
    }
    public class Worker : IWorker
    {
        public Worker(string name)
        {
            Name = name;
            _Name = Name;
        }

        public string Name { get; set; }
        public static string _Name { get; set; }
        string IWorker.Name => Name;
    }
    public class TeamLeader : IWorker
    {
        public TeamLeader(string name)
        {
            Name = name;
        }

        public static string Name { get; set; }
        string IWorker.Name => Name;
    }
}