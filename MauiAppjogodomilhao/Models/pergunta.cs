﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppjogodomilhao.Models
{
    public class pergunta
    {
        public int Id { get; set; }
        public string Enunciado { get; set; }

        public List<alternativa> Alternativas { get; set; }
    }
}
