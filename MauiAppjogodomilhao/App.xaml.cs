using Java.Nio.Channels;
using MauiAppjogodomilhao.Models;

namespace MauiAppjogodomilhao
{
    public partial class App : Application
    {
        List<pergunta> perguntas_faceis=new() 
        {
            new pergunta
            {

                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de  gelo?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "PLASMA"},
                    new alternativa {correta = false, Descricao = "GASOSO"},
                    new alternativa {correta = true, Descricao = "SÓLIDO"},
                    new alternativa {correta = false, Descricao = "LÍQUIDO"},
                }

            },

             new pergunta
            {

                Id = 2,
                Enunciado = "Quem é a namorada do Mickey?",

                Alternativas=new()
                {
                    new alternativa {correta = true, Descricao = "MINNIE"},
                    new alternativa {correta = false, Descricao = "MARGARIDA"},
                    new alternativa {correta = false, Descricao = "OLÍVIA PALITO"},
                    new alternativa {correta = false, Descricao = "A PEQUENA SEREIA"},
                }

            },

              new pergunta
            {

                Id = 3,
                Enunciado = "Qual é o nome do personagem do folclore brasileiro que tem uma perna só?",

                Alternativas=new()
                {
                    new alternativa {correta = true, Descricao = "SACI-PERERÊ"},
                    new alternativa {correta = false, Descricao = "CUCA"},
                    new alternativa {correta = false, Descricao = "BOITATÁ"},
                    new alternativa {correta = false, Descricao = "NEGRIMHO DO PASTOREIO"},
                }

            },

               new pergunta
            {

                Id = 4,
                Enunciado = "Fidel Cxastro nasceu em qual país?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "JAMAICA"},
                    new alternativa {correta = false, Descricao = "MÉXICO"},
                    new alternativa {correta = false, Descricao = "EL SALVADOR"},
                    new alternativa {correta = true, Descricao = "CUBA"},
                }

            },

                new pergunta
            {

                Id = 5,
                Enunciado = "Qual é o zodiaco que nasce no dia do ano-novo?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "VIRGEM"},
                    new alternativa {correta = false, Descricao = "AQUÁRIO"},
                    new alternativa {correta = true, Descricao = "CAPRICÓRNIO"},
                    new alternativa {correta = false, Descricao = "ARIES"},
                }

            },
                 new pergunta
            {

                Id = 6,
                Enunciado = "Quantas folhas tem um trevo da sorte?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "CINCO"},
                    new alternativa {correta = false, Descricao = "QUATRO"},
                    new alternativa {correta = true, Descricao = "TRÊS"},
                    new alternativa {correta = false, Descricao = "SEIS"},
                }

            },
                  new pergunta
            {

                Id = 7,
                Enunciado = "o violoncelo é conhecido como um instrumento de:?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = ""},
                    new alternativa {correta = false, Descricao = ""},
                    new alternativa {correta = false, Descricao = ""},
                    new alternativa {correta = false, Descricao = ""},
                }

            },
                   new pergunta
            {

                Id = 8,
                Enunciado = "Qual é o zodiaco que nasce no dia do ano-novo?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "VIRGEM"},
                    new alternativa {correta = false, Descricao = "AQUÁRIO"},
                    new alternativa {correta = true, Descricao = "CAPRICÓRNIO"},
                    new alternativa {correta = false, Descricao = "ARIES"},
                }

            },
                    new pergunta
            {

                Id = 9,
                Enunciado = "Qual é o zodiaco que nasce no dia do ano-novo?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "VIRGEM"},
                    new alternativa {correta = false, Descricao = "AQUÁRIO"},
                    new alternativa {correta = true, Descricao = "CAPRICÓRNIO"},
                    new alternativa {correta = false, Descricao = "ARIES"},
                }

            },
                     new pergunta
            {

                Id = 10,
                Enunciado = "Qual é o zodiaco que nasce no dia do ano-novo?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "VIRGEM"},
                    new alternativa {correta = false, Descricao = "AQUÁRIO"},
                    new alternativa {correta = true, Descricao = "CAPRICÓRNIO"},
                    new alternativa {correta = false, Descricao = "ARIES"},
                }

            },


        };
            
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
