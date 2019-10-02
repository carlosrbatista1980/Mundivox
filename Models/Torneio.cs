using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Torneio
    {
        public int Id { get; set; }
        
        public string T1 { get; set; } = "Time A";
        public int T1score { get; set; }
        public string T2 { get; set; } = "Time B";
        public int T2score { get; set; }
        public string T3 { get; set; } = "Time C";
        public int T3score { get; set; }
        public string T4 { get; set; } = "Time D";
        public int T4score { get; set; }

        public string WinnerK1 { get; set; }
        public int WinnerK1score { get; set; }
        public string WinnerK2 { get; set; }
        public int WinnerK2score { get; set; }
        public string WinnerFinal { get; set; }

        public int score { get; set; } = 0;
    }
}