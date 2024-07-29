using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppjogodomilhao.Models
{
    internal class pergunta
    {
        public int id { get; set; }
        public string Enunciado { get; set; }

        public List<alternativa> alternativas { get; set; }
    }
}
