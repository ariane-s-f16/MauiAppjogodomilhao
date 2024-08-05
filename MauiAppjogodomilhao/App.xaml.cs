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
                    new alternativa {correta = true, Descricao = "TRÊS"},
                    new alternativa {correta = false, Descricao = "QUATRO"},
                    new alternativa {correta = false, Descricao = "SEIS"},
                }

            },
             new pergunta
            {

                Id = 7,
                Enunciado = "o violoncelo é conhecido como um instrumento de:?",

                Alternativas=new()
                {
                    new alternativa {correta = true, Descricao = "CORDAS"},
                    new alternativa {correta = false, Descricao = "SOPRO"},
                    new alternativa {correta = false, Descricao = "PERCUSSÃO"},
                    new alternativa {correta = false, Descricao = "REPERCUSSÃO"},
                }

            },
             new pergunta
            {

                Id = 8,
                Enunciado = "Com que fruta a branca de neve foi envenenada?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "LARANJA"},
                    new alternativa {correta = false, Descricao = "PERÂ"},
                    new alternativa {correta = false, Descricao = "BANANA"},
                    new alternativa {correta = true, Descricao = "MAÇÃ"},
                }

            },
             new pergunta
            {

                Id = 9,
                Enunciado = "Um adulto sadio tem quantos dentes na boca?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "18"},
                    new alternativa {correta = false, Descricao = "24"},
                    new alternativa {correta = true, Descricao = "32"},
                    new alternativa {correta = false, Descricao = "36"},
                }

            },
             new pergunta
            {

                Id = 10,
                Enunciado = "Quem foi técnico da Seleção brasileira de futebol na Copa de 98?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "SCOLARI"},
                    new alternativa {correta = false, Descricao = "LUXEMBURGO"},
                    new alternativa {correta = true, Descricao = "ZAGALLO"},
                    new alternativa {correta = false, Descricao = "CARPEGIANN"},
                }

            },
             new pergunta
            {

                Id = 11,
                Enunciado = "Cavalo, rainha e torre são peças de qual jogo?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "LUDO"},
                    new alternativa {correta = false, Descricao = "DOMINÓ"},
                    new alternativa {correta = false, Descricao = "DAMA"},
                    new alternativa {correta = false, Descricao = "XADREZ"},
                }

            },
             new pergunta
            {

                Id = 12,
                Enunciado = "Turmalina é uma espécie de quê?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "FLOR"},
                    new alternativa {correta = true, Descricao = "PEDRA"},
                    new alternativa {correta = false, Descricao = "FRUTO"},
                    new alternativa {correta = false, Descricao = "VERDURA"},
                }

            },
             new pergunta
            {

                Id = 13,
                Enunciado = "Quem ocupou o cargo de Ministro da Saúde do Brasil no ano de 2000?",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "PEDRO MALAN"},
                    new alternativa {correta = true, Descricao = "JOSÉ SERRA"},
                    new alternativa {correta = false, Descricao = "DIB JATENE"},
                    new alternativa {correta = false, Descricao = "CIRO GOMES"},
                }

            },
             new pergunta
            {

                Id = 14,
                Enunciado = "Qual foi o nome dado ao movimento liderado por Tiradentes??",

                Alternativas=new()
                {
                    new alternativa {correta = false, Descricao = "REVOLUÇÃO FRANCESA"},
                    new alternativa {correta = false, Descricao = "GUERRA DOS EMBOABAS"},
                    new alternativa {correta = true, Descricao = "INCOFIDÊNCIA MINEIRA"},
                    new alternativa {correta = false, Descricao = "SEGUNDA GUERRA MUNDIAL"},
                }

            },
            new pergunta
            {

                Id = 15,
                Enunciado = "Quando é comemorado o dia da mentira no Brasil?",

                Alternativas=new()
                {
                    new alternativa {correta = true, Descricao = "1 DE ABRIL"},
                    new alternativa {correta = false, Descricao = "7 DE SETEMBRO"},
                    new alternativa {correta = false, Descricao = "26 DE DEZEMBRO"},
                    new alternativa {correta = false, Descricao = "15 DE NOVEMBRO"},
                }

            },
            new pergunta
            {
                Id = 16,
                Enunciado = "Qual é o profissional que conduz o elevador?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CONDUTOR" },
                    new alternativa { correta = false, Descricao = "OPERADOR" },
                    new alternativa { correta = true, Descricao = "ASCENSORISTA" },
                    new alternativa { correta = false, Descricao = "RECEPCIONISTA" },
                }
            },
            new pergunta
            {
                Id = 17,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "HARRISON FORD" },
                    new alternativa { correta = false, Descricao = "GERALD FORD" },
                    new alternativa { correta = true, Descricao = "HENRY FORD" },
                    new alternativa { correta = false, Descricao = "ANNA FORD" },
                }
            },

            new pergunta
            {
                Id = 18,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PRETA" },
                    new alternativa { correta = false, Descricao = "VERMELHA" },
                    new alternativa { correta = false, Descricao = "AZUL" },
                    new alternativa { correta = true, Descricao = "VERDE" },
                }
            },

            new pergunta
            {
                Id = 19,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "200" },
                    new alternativa { correta = true, Descricao = "100" },
                    new alternativa { correta = false, Descricao = "170" },
                    new alternativa { correta = false, Descricao = "220" },
                }
            },

            new pergunta
            {
                Id = 20,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "VENEZA" },
                    new alternativa { correta = false, Descricao = "VITÓRIA" },
                    new alternativa { correta = false, Descricao = "VANCOUVER" },
                    new alternativa { correta = true, Descricao = "VATICANO" },
                }
            },
                new pergunta
            {
                Id = 21,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "CARPINTEIRO" },
                    new alternativa { correta = false, Descricao = "RELOJOEIRO" },
                    new alternativa { correta = false, Descricao = "CONFEITEIRO" },
                    new alternativa { correta = false, Descricao = "BOMBEIRO" },
                }
            },

            new pergunta
            {
                Id = 22,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "MORUMBI" },
                    new alternativa { correta = false, Descricao = "PACAMBU" },
                    new alternativa { correta = true, Descricao = "MARACANÃ" },
                    new alternativa { correta = false, Descricao = "MINEIRÃO" },
                }
            },

            new pergunta
            {
                Id = 23,
                Enunciado = "O que é um oboé?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "VULCÃO" },
                    new alternativa { correta = false, Descricao = "COMIDA" },
                    new alternativa { correta = true, Descricao = "INSTRUMENTO MUSICAL" },
                    new alternativa { correta = false, Descricao = "TRIBO INDÍGENA" },
                }
            },
            new pergunta
            {
            Id = 24,
            Enunciado = "Como é conhecida a ponte que liga Rio de Janeiro a Niterói?",
            Alternativas = new()
            {
                new alternativa { correta = false, Descricao = "GOLDEN GATE" },
                new alternativa { correta = true, Descricao = "RIO-NITERÓI" },
                new alternativa { correta = false, Descricao = "RIO SÃO FRANCISCO" },
                new alternativa { correta = false, Descricao = "BROOKLIN" },
            }
             },

            new pergunta
            {
                Id = 25,
                Enunciado = "Em que ano os portugueses descobriram o Brasil?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "1450" },
                    new alternativa { correta = true, Descricao = "1500" },
                    new alternativa { correta = false, Descricao = "1550" },
                    new alternativa { correta = false, Descricao = "1400" },
                }
            },

            new pergunta
            {
                Id = 26,
                Enunciado = "O que é medido por um termômetro?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "LONGITUDE" },
                    new alternativa { correta = false, Descricao = "UMIDADE" },
                    new alternativa { correta = true, Descricao = "TEMPERATURA" },
                    new alternativa { correta = false, Descricao = "LATITUDE" },
                }
            },

            new pergunta
            {
                Id = 27,
                Enunciado = "O rio Amazonas pertence a qual continente?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "AMERICANO" },
                    new alternativa { correta = false, Descricao = "AFRICANO" },
                    new alternativa { correta = false, Descricao = "EUROPEU" },
                    new alternativa { correta = false, Descricao = "ASIÁTICO" },
                }
            },

            new pergunta
            {
                Id = 28,
                Enunciado = "Quem esculpiu o boneco Pinóquio, no conto de Carlo Lorenzini?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "GEPETO" },
                    new alternativa { correta = false, Descricao = "FADA" },
                    new alternativa { correta = false, Descricao = "BRUXA" },
                    new alternativa { correta = false, Descricao = "GIGANTE" },
                }
            },

            new pergunta
            {
                Id = 29,
                Enunciado = "Qual é a moeda oficial dos Estados Unidos?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ESCUDO" },
                    new alternativa { correta = false, Descricao = "CORAÇÃO" },
                    new alternativa { correta = true, Descricao = "DÓLAR" },
                    new alternativa { correta = false, Descricao = "LIBRA" },
                }
            },

            new pergunta
            {
                Id = 30,
                Enunciado = "Qual foi o placar no final da Copa de 98, quando o Brasil perdeu para a França?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "DOIS A ZERO" },
                    new alternativa { correta = false, Descricao = "TRÊS A ZERO" },
                    new alternativa { correta = false, Descricao = "QUATRO A ZERO" },
                    new alternativa { correta = true, Descricao = "CINCO A ZERO" },
                }
            },
            new pergunta
            {
                Id = 31,
                Enunciado = "Qual é a cidade conhecida como “terra da garoa”?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "RIO DE JANEIRO" },
                    new alternativa { correta = false, Descricao = "PORTO ALEGRE" },
                    new alternativa { correta = false, Descricao = "PIRACICABA" },
                    new alternativa { correta = true, Descricao = "SÃO PAULO" },
                }
            },

            new pergunta
            {
                Id = 32,
                Enunciado = "Qual ator do cinema brasileiro é conhecido por ter unhas enormes?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PENADINHO" },
                    new alternativa { correta = true, Descricao = "ZÉ DO CAIXÃO" },
                    new alternativa { correta = false, Descricao = "ZÉ DO CASARÃO" },
                    new alternativa { correta = false, Descricao = "TONINHO DO DIABO" },
                }
            },

            new pergunta
            {
                Id = 33,
                Enunciado = "Qual dos sete anões usa óculos?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "DUNGA" },
                    new alternativa { correta = false, Descricao = "ZANGADO" },
                    new alternativa { correta = false, Descricao = "DENGOSO" },
                    new alternativa { correta = true, Descricao = "MESTRE" },
                }
            },

            new pergunta
            {
                Id = 34,
                Enunciado = "Quem é o Homem de Aço das histórias em quadrinhos?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "BATMAN" },
                    new alternativa { correta = false, Descricao = "HUCK" },
                    new alternativa { correta = false, Descricao = "HE-MAN" },
                    new alternativa { correta = true, Descricao = "SUPER-HOMEM" },
                }
            },
            new pergunta
            {
                Id = 35,
                Enunciado = "Segundo a Bíblia, quem foi morto por Caim?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ADÃO" },
                    new alternativa { correta = false, Descricao = "ISAAC" },
                    new alternativa { correta = true, Descricao = "ABEL" },
                    new alternativa { correta = false, Descricao = "ABRAÃO" },
                }
            },

            new pergunta
            {
                Id = 36,
                Enunciado = "Qual é o livro dividido em Velho Testamento e Novo Testamento?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "BÍBLIA" },
                    new alternativa { correta = false, Descricao = "ENCICLOPÉDIA" },
                    new alternativa { correta = false, Descricao = "DICIONÁRIO" },
                    new alternativa { correta = false, Descricao = "ATLAS" },
                }
            },

            new pergunta
            {
                Id = 37,
                Enunciado = "Qual objeto é usado como arma pelo Pingüim do Batman?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "GUARDA-CHUVA" },
                    new alternativa { correta = false, Descricao = "CHAPÉU" },
                    new alternativa { correta = false, Descricao = "GALOCHA" },
                    new alternativa { correta = false, Descricao = "CAPA" },
                }
            },
            new pergunta
            {
                Id = 38,
                Enunciado = "Qual é o país de origem do vinho champanhe?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "AMÉRICA" },
                    new alternativa { correta = false, Descricao = "HOLANDA" },
                    new alternativa { correta = true, Descricao = "FRANÇA" },
                    new alternativa { correta = false, Descricao = "SUÉCIA" },
                }
            },

            new pergunta
            {
                Id = 39,
                Enunciado = "Qual destes elementos se forma dentro das ostras?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "DIAMANTE" },
                    new alternativa { correta = true, Descricao = "PÉROLA" },
                    new alternativa { correta = false, Descricao = "RUBI" },
                    new alternativa { correta = false, Descricao = "ESMERALDA" },
                }
            },
            new pergunta
            {
                Id = 40,
                Enunciado = "Capixaba é quem nasce em qual estado brasileiro?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "ESPÍRITO SANTO" },
                    new alternativa { correta = false, Descricao = "RIO GRANDE DO NORTE" },
                    new alternativa { correta = false, Descricao = "SANTA CATARINA" },
                    new alternativa { correta = false, Descricao = "PARANÁ" },
                }
            }

        };
        List<pergunta> perguntas_medias = new()
        {
            new pergunta
            {
                Id = 41,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra??",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "SEIS" },
                    new alternativa { correta = false, Descricao = "OITO" },
                    new alternativa { correta = false, Descricao = "DEZ" },
                    new alternativa { correta = true, Descricao = "DOZE" },
                }
            },
            new pergunta
            {
            Id = 42,
            Enunciado = "O que é gôndola?",
            Alternativas = new()
            {
                new alternativa { correta = true, Descricao = "EMBARCAÇÃO" },
                new alternativa { correta = false, Descricao = "BRINQUEDO" },
                new alternativa { correta = false, Descricao = "MÚSICA" },
                new alternativa { correta = false, Descricao = "SÍMBOLO" },
            }
            },

            new pergunta
            {
                Id = 43,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "JAPÃO" },
                    new alternativa { correta = false, Descricao = "CHINA" },
                    new alternativa { correta = false, Descricao = "ÍNDIA" },
                    new alternativa { correta = false, Descricao = "INDONÉSIA" },
                }
            },

            new pergunta
            {
                Id = 44,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PRIMEIRA DAMA" },
                    new alternativa { correta = false, Descricao = "DONA-PRIMA" },
                    new alternativa { correta = true, Descricao = "PRIMA-DONA" },
                    new alternativa { correta = false, Descricao = "OBRA-PRIMA" },
                }
            },

            new pergunta
            {
                Id = 45,
                Enunciado = "Peroba é uma espécie de?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "INSETO" },
                    new alternativa { correta = true, Descricao = "ÁRVORE" },
                    new alternativa { correta = false, Descricao = "VERME" },
                    new alternativa { correta = false, Descricao = "VERDURA" },
                }
            },

            new pergunta
            {
                Id = 46,
                Enunciado = "O alpinismo é praticado em que lugar?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "MAR" },
                    new alternativa { correta = true, Descricao = "MONTANHA" },
                    new alternativa { correta = false, Descricao = "RIO" },
                    new alternativa { correta = false, Descricao = "PRAIA" },
                }
            },

            new pergunta
            {
                Id = 47,
                Enunciado = "O Coliseu é um monumento histórico de que cidade europeia?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PARIS" },
                    new alternativa { correta = false, Descricao = "COPENHAGUE" },
                    new alternativa { correta = true, Descricao = "ROMA" },
                    new alternativa { correta = false, Descricao = "LONDRES" },
                }
            },

            new pergunta
                {
                    Id = 48,
                    Enunciado = "Qual é o ponto mais alto da Terra?",
                    Alternativas = new()
                    {
                        new alternativa { correta = true, Descricao = "EVEREST" },
                        new alternativa { correta = false, Descricao = "MONTE SINAI" },
                        new alternativa { correta = false, Descricao = "MONTE CASTELO" },
                        new alternativa { correta = false, Descricao = "MONT BLANC" },
                    }
                },

            new pergunta
            {
                Id = 49,
                Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "TÂMISA" },
                    new alternativa { correta = false, Descricao = "SENA" },
                    new alternativa { correta = false, Descricao = "RENO" },
                    new alternativa { correta = false, Descricao = "AUBE" },
                }
            },

            new pergunta
            {
                Id = 50,
                Enunciado = "Qual é a raça do personagem principal do filme 'Beethoven'?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "FILA" },
                    new alternativa { correta = false, Descricao = "PASTOR ALEMÃO" },
                    new alternativa { correta = false, Descricao = "POODLE" },
                    new alternativa { correta = true, Descricao = "SÃO-BERNARDO" },
                }
            },

            new pergunta
            {
                Id = 51,
                Enunciado = "Quem foi eleito presidente da África do Sul em 1994?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "NELSON PIQUET" },
                    new alternativa { correta = true, Descricao = "NELSON MANDELA" },
                    new alternativa { correta = false, Descricao = "NELSON NED" },
                    new alternativa { correta = false, Descricao = "JOHN NELSON" },
                }
            },

            new pergunta
            {
                Id = 52,
                Enunciado = "Qual cantor ficou conhecido como 'O rei da voz'?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ORLANDO SILVA" },
                    new alternativa { correta = false, Descricao = "VICENTE CELESTINO" },
                    new alternativa { correta = false, Descricao = "FRANCISCO ALVES" },
                    new alternativa { correta = true, Descricao = "CARLOS GALHARDO" },
                }
            },

            new pergunta
            {
                Id = 53,
                Enunciado = "Quantos quilates tem o ouro puro?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "18" },
                    new alternativa { correta = false, Descricao = "20" },
                    new alternativa { correta = true, Descricao = "24" },
                    new alternativa { correta = false, Descricao = "30" },
                }
            },

            new pergunta
            {
                Id = 54,
                Enunciado = "Qual é a sigla da Organização das Nações Unidas?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "ONU" },
                    new alternativa { correta = false, Descricao = "FMI" },
                    new alternativa { correta = false, Descricao = "CIA" },
                    new alternativa { correta = false, Descricao = "OTAN" },
                }
            },

            new pergunta
            {
                Id = 55,
                Enunciado = "De quantos em quantos anos aparece o cometa Halley?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "57 ANOS" },
                    new alternativa { correta = false, Descricao = "67 ANOS" },
                    new alternativa { correta = true, Descricao = "76 ANOS" },
                    new alternativa { correta = false, Descricao = "79 ANOS" },
                }
            },

            new pergunta
            {
                Id = 56,
                Enunciado = "Segundo a crença popular, a mula-sem-cabeça é mulher de quem?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "DO COROINHA" },
                    new alternativa { correta = false, Descricao = "DO PADRE" },
                    new alternativa { correta = false, Descricao = "DO SACRISTÃO" },
                    new alternativa { correta = true, Descricao = "DO BISPO" },
                }
            },

            new pergunta
            {
                Id = 57,
                Enunciado = "Que atriz protagonizou o filme 'Titanic'?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CAMERON DIAZ" },
                    new alternativa { correta = true, Descricao = "KATE WINSLET" },
                    new alternativa { correta = false, Descricao = "BRIDGET FONDA" },
                    new alternativa { correta = false, Descricao = "CATHERINE ZETTA JONES" },
                }
            },
            new pergunta
            {
                Id = 58,
                Enunciado = "Como é chamada a doença que causa perda desigual da melanina?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ASTIGMATISMO" },
                    new alternativa { correta = false, Descricao = "TENDINITE" },
                    new alternativa { correta = true, Descricao = "VITILIGO" },
                    new alternativa { correta = false, Descricao = "VITINGA" },
                }
            },

            new pergunta
            {
                Id = 59,
                Enunciado = "Quem realizou a primeira cirurgia de ponte de safena no Brasil?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "DR. ZERBINI" },
                    new alternativa { correta = false, Descricao = "DR. FRITZ" },
                    new alternativa { correta = false, Descricao = "DR. JATENE" },
                    new alternativa { correta = false, Descricao = "DR. CALLIGARI" },
                }
            },

            new pergunta
            {
                Id = 60,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "BILL" },
                    new alternativa { correta = true, Descricao = "CLYDE" },
                    new alternativa { correta = false, Descricao = "JAMES" },
                    new alternativa { correta = false, Descricao = "BUTCH" },
                }
            },

            new pergunta
            {
                Id = 61,
                Enunciado = "Qual é a moeda oficial da Alemanha?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "LIRA" },
                    new alternativa { correta = false, Descricao = "MARCO" },
                    new alternativa { correta = false, Descricao = "FRANCO" },
                    new alternativa { correta = true, Descricao = "LIBRA" },
                }
            },

            new pergunta
            {
                Id = 62,
                Enunciado = "Quem foi o assassino de Lee Harvey Oswald?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "JACK RUBY" },
                    new alternativa { correta = false, Descricao = "JOHN WILKES BOOTH" },
                    new alternativa { correta = false, Descricao = "PAT GARRET" },
                    new alternativa { correta = false, Descricao = "CHARLOTTE CORDAY" },
                }
            },

            new pergunta
            {
                Id = 63,
                Enunciado = "Quem é o parceiro de aventuras de Dom Quixote?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "SANCHO PANÇA" },
                    new alternativa { correta = false, Descricao = "GUILHERME TELL" },
                    new alternativa { correta = false, Descricao = "SIGMUND FREUD" },
                    new alternativa { correta = false, Descricao = "LANCELOT" },
                }
            },

            new pergunta
            {
                Id = 64,
                Enunciado = "Nas histórias do Snoopy, qual é o nome do passarinho?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PIU-PIU" },
                    new alternativa { correta = true, Descricao = "WOODSTOCK" },
                    new alternativa { correta = false, Descricao = "CANARINHO" },
                    new alternativa { correta = false, Descricao = "ROUXINOL" },
                }
            },

            new pergunta
            {
                Id = 65,
                Enunciado = "Que metal avermelhado cria uma camada esverdeada em contato com a umidade?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "FERRO" },
                    new alternativa { correta = true, Descricao = "COBRE" },
                    new alternativa { correta = false, Descricao = "MERCÚRIO" },
                    new alternativa { correta = false, Descricao = "AÇO" },
                }
            },

            new pergunta
            {
                Id = 66,
                Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "PAPIRO" },
                    new alternativa { correta = false, Descricao = "EUCALIPTO" },
                    new alternativa { correta = false, Descricao = "OLIVEIRA" },
                    new alternativa { correta = false, Descricao = "MILHO" },
                }
            },

            new pergunta
            {
                Id = 67,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "ESPANHA" },
                    new alternativa { correta = false, Descricao = "ITÁLIA" },
                    new alternativa { correta = false, Descricao = "FRANÇA" },
                    new alternativa { correta = false, Descricao = "ALEMANHA" },
                }
            },

            new pergunta
            {
                Id = 68,
                Enunciado = "Que humorista, falecido em 1999, foi baterista de Raul Seixas?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "LILICO" },
                    new alternativa { correta = false, Descricao = "RONI CÓCEGAS" },
                    new alternativa { correta = false, Descricao = "GRANDE OTELO" },
                    new alternativa { correta = true, Descricao = "MAZZAROPI" },
                }
            },

            new pergunta
            {
                Id = 69,
                Enunciado = "O que os filatelistas colecionam?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "QUADROS" },
                    new alternativa { correta = false, Descricao = "MOEDAS" },
                    new alternativa { correta = true, Descricao = "SELOS" },
                    new alternativa { correta = false, Descricao = "FIGURINHAS" },
                }
            },

            new pergunta
            {
                Id = 70,
                Enunciado = "Quem pintou o quadro 'La Gioconda', conhecido como 'Mona Lisa'?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "LEONARDO DA VINCI" },
                    new alternativa { correta = false, Descricao = "TICIANO" },
                    new alternativa { correta = false, Descricao = "RAFAEL" },
                    new alternativa { correta = false, Descricao = "MICHELÂNGELO" },
                }
            },
            new pergunta
            {
                Id = 71,
                Enunciado = "Quando começou e terminou a Primeira Guerra Mundial?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "1914-1919" },
                    new alternativa { correta = false, Descricao = "1939-1945" },
                    new alternativa { correta = false, Descricao = "1921-1932" },
                    new alternativa { correta = false, Descricao = "1912-1915" },
                }
            },

            new pergunta
            {
                Id = 72,
                Enunciado = "Qual é a letra do alfabeto que simboliza o número dez em algarismo romano?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "V" },
                    new alternativa { correta = false, Descricao = "D" },
                    new alternativa { correta = false, Descricao = "L" },
                    new alternativa { correta = true, Descricao = "X" },
                }
            },

            new pergunta
            {
                Id = 73,
                Enunciado = "Qual é a história que Francis Ford Coppola dirigiu em três partes?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "TITANIC" },
                    new alternativa { correta = false, Descricao = "SEXTA-FEIRA TREZE" },
                    new alternativa { correta = true, Descricao = "O PODEROSO CHEFÃO" },
                    new alternativa { correta = false, Descricao = "GUERRA NAS ESTRELAS" },
                }
            },

            new pergunta
            {
                Id = 74,
                Enunciado = "Que animais são criados nas pocilgas?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CAMELOS" },
                    new alternativa { correta = false, Descricao = "BÚFALOS" },
                    new alternativa { correta = false, Descricao = "CARNEIROS" },
                    new alternativa { correta = true, Descricao = "PORCOS" },
                }
            },

            new pergunta
            {
                Id = 75,
                Enunciado = "Quem foi o diretor do filme “A lista de Schindler”?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CLINT EASTWOOD" },
                    new alternativa { correta = true, Descricao = "STEVEN SPIELBERG" },
                    new alternativa { correta = false, Descricao = "STANLEY KUBRICK" },
                    new alternativa { correta = false, Descricao = "PEDRO ALMODÓVAR" },
                }
            },

            new pergunta
            {
                Id = 76,
                Enunciado = "Qual é o alimento produzido pela moagem dos grãos de cacau?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PARAFINA" },
                    new alternativa { correta = false, Descricao = "AÇÚCAR" },
                    new alternativa { correta = true, Descricao = "CHOCOLATE" },
                    new alternativa { correta = false, Descricao = "CAFÉ" },
                }
            },

            new pergunta
            {
                Id = 77,
                Enunciado = "Quem introduziu o futebol no Brasil?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PELÉ" },
                    new alternativa { correta = false, Descricao = "JOÃO HAVELANGE" },
                    new alternativa { correta = true, Descricao = "CHARLES MILLER" },
                    new alternativa { correta = false, Descricao = "PAULO MACHADO" },
                }
            },

            new pergunta
            {
                Id = 78,
                Enunciado = "Em que continente se situa o rio Nilo?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "AFRICANO" },
                    new alternativa { correta = false, Descricao = "EUROPEU" },
                    new alternativa { correta = false, Descricao = "AMERICANO" },
                    new alternativa { correta = false, Descricao = "ASIÁTICO" },
                }
            },
            new pergunta
            {
                Id = 79,
                Enunciado = "Qual é a fórmula química da água?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "NACL" },
                    new alternativa { correta = false, Descricao = "H2" },
                    new alternativa { correta = true, Descricao = "H2O" },
                    new alternativa { correta = false, Descricao = "CO2" },
                }
            },

            new pergunta
            {
                Id = 80,
                Enunciado = "Qual era a profissão de Cecília Meirelles?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CANTORA" },
                    new alternativa { correta = true, Descricao = "ESCRITORA" },
                    new alternativa { correta = false, Descricao = "ARQUITETA" },
                    new alternativa { correta = false, Descricao = "PIANISTA" },
                }
            },
            new pergunta
            {
                Id = 81,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "MONSTRO" },
                    new alternativa { correta = false, Descricao = "GORILA" },
                    new alternativa { correta = false, Descricao = "PRÍNCIPE" },
                    new alternativa { correta = true, Descricao = "SAPO" },
                }
            },


        };
        List<pergunta> perguntas_dificeis = new()
        {

            new pergunta
            {
                Id = 81,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "BERLIM" },
                    new alternativa { correta = true, Descricao = "NUREMBERGUE" },
                    new alternativa { correta = false, Descricao = "MUNIQUE" },
                    new alternativa { correta = false, Descricao = "PARIS" },
                }
            },

            new pergunta
            {
                Id = 82,
                Enunciado = "Que ramo da pecuária ocupa-se de bodes e cabras?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ASININO" },
                    new alternativa { correta = true, Descricao = "CAPRINO" },
                    new alternativa { correta = false, Descricao = "BUFALINO" },
                    new alternativa { correta = false, Descricao = "MUAR" },
                }
            },

            new pergunta
            {
                Id = 83,
                Enunciado = "Qual oceano tem o maior volume de água?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ATLÂNTICO" },
                    new alternativa { correta = true, Descricao = "PACÍFICO" },
                    new alternativa { correta = false, Descricao = "ÍNDICO" },
                    new alternativa { correta = false, Descricao = "ÁRTICO" },
                }
            },

            new pergunta
            {
                Id = 84,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "FERNANDO COLLOR" },
                    new alternativa { correta = true, Descricao = "JOÃO FIGUEIREDO" },
                    new alternativa { correta = false, Descricao = "TANCREDO NEVES" },
                    new alternativa { correta = false, Descricao = "JOÃO GOULART" },
                }
            },

            new pergunta
            {
                Id = 85,
                Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "GUERRA FRIA" },
                    new alternativa { correta = false, Descricao = "GUERRA DO VIETNÃ" },
                    new alternativa { correta = false, Descricao = "GUERRA NAS ESTRELAS" },
                    new alternativa { correta = false, Descricao = "GUERRA DA CORÉIA" },
                }
            },

            new pergunta
            {
                Id = 86,
                Enunciado = "O trapézio é um músculo que está situado:",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "NO PESCOÇO" },
                    new alternativa { correta = false, Descricao = "NO OMBRO" },
                    new alternativa { correta = false, Descricao = "NA CABEÇA" },
                    new alternativa { correta = true, Descricao = "NO BRAÇO" },
                }
            },

            new pergunta
            {
                Id = 87,
                Enunciado = "Quem escreveu o livro 'A sangue frio' em 1966?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "TRUMAN CAPOTE" },
                    new alternativa { correta = false, Descricao = "HENRY JAMES" },
                    new alternativa { correta = false, Descricao = "JOHN STEINBECK" },
                    new alternativa { correta = false, Descricao = "TONI MORRISON" },
                }
            },

            new pergunta
            {
                Id = 88,
                Enunciado = "Quem escreveu 'Ulisses' em 1922?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ERNEST HEMINGWAY" },
                    new alternativa { correta = false, Descricao = "MARCEL PROUST" },
                    new alternativa { correta = false, Descricao = "T.S. ELLIOT" },
                    new alternativa { correta = true, Descricao = "JAMES JOYCE" },
                }
            },

            new pergunta
            {
                Id = 89,
                Enunciado = "Qual o símbolo químico do radônio?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "Rr" },
                    new alternativa { correta = false, Descricao = "Rd" },
                    new alternativa { correta = true, Descricao = "Rn" },
                    new alternativa { correta = false, Descricao = "Ro" },
                }
            },

            new pergunta
            {
                Id = 90,
                Enunciado = "O que são meninges?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CÉLULAS" },
                    new alternativa { correta = false, Descricao = "NERVOS" },
                    new alternativa { correta = true, Descricao = "MEMBRANAS" },
                    new alternativa { correta = false, Descricao = "MÚSCULOS" },
                }
            },

            new pergunta
            {
                Id = 91,
                Enunciado = "Qual produto gerou guerras e conflitos no século XX?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ÁLCOOL" },
                    new alternativa { correta = true, Descricao = "PETRÓLEO" },
                    new alternativa { correta = false, Descricao = "OURO" },
                    new alternativa { correta = false, Descricao = "ALUMÍNIO" },
                }
            },

            new pergunta
            {
                Id = 92,
                Enunciado = "Como é chamada a bola de gelo e poeira que orbita em torno do sol?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "COMETA" },
                    new alternativa { correta = false, Descricao = "METEORITO" },
                    new alternativa { correta = false, Descricao = "CAMADA DE OZÔNIO" },
                    new alternativa { correta = false, Descricao = "ESTRELA D’ALVA" },
                }
            },

            new pergunta
            {
                Id = 93,
                Enunciado = "O confucionismo é uma filosofia de qual nacionalidade?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "INDIANA" },
                    new alternativa { correta = false, Descricao = "JAPONESA" },
                    new alternativa { correta = true, Descricao = "CHINESA" },
                    new alternativa { correta = false, Descricao = "COREANA" },
                }
            },

            new pergunta
            {
                Id = 94,
                Enunciado = "Qual a ciência que estuda a distribuição dos animais?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ZOOTERAPIA" },
                    new alternativa { correta = true, Descricao = "ZOOGEOGRAFIA" },
                    new alternativa { correta = false, Descricao = "ZODÍACO" },
                    new alternativa { correta = false, Descricao = "ZOOMETRIA" },
                }
            },

            new pergunta
            {
                Id = 95,
                Enunciado = "A eletrônica é parte de qual ciência?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "FÍSICA" },
                    new alternativa { correta = false, Descricao = "BIOLOGIA" },
                    new alternativa { correta = false, Descricao = "QUÍMICA" },
                    new alternativa { correta = false, Descricao = "BOTÂNICA" },
                }
            },

            new pergunta
            {
                Id = 96,
                Enunciado = "A Bélgica é:",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "UMA REPÚBLICA" },
                    new alternativa { correta = true, Descricao = "UMA MONARQUIA CONSTITUCIONAL" },
                    new alternativa { correta = false, Descricao = "UM EMIRADO" },
                    new alternativa { correta = false, Descricao = "UM PRINCIPADO" },
                }
            },

            new pergunta
            {
                Id = 97,
                Enunciado = "Que parte do corpo humano é infectada pela cólera?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "GARGANTA" },
                    new alternativa { correta = true, Descricao = "INTESTINO" },
                    new alternativa { correta = false, Descricao = "PULMÕES" },
                    new alternativa { correta = false, Descricao = "RINS" },
                }
            },

            new pergunta
            {
                Id = 98,
                Enunciado = "Que figura mitológica é conhecida por sua força extraordinária?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ÁTILA" },
                    new alternativa { correta = false, Descricao = "MINOTAURO" },
                    new alternativa { correta = false, Descricao = "PERSEU" },
                    new alternativa { correta = true, Descricao = "HÉRCULES" },
                }
            },

            new pergunta
            {
                Id = 99,
                Enunciado = "A união do espermatozóide com o óvulo origina uma célula chamada:",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "ZIGOTO" },
                    new alternativa { correta = false, Descricao = "BIGOTO" },
                    new alternativa { correta = false, Descricao = "FETO" },
                    new alternativa { correta = false, Descricao = "GAROTO" },
                }
            },

            new pergunta
            {
                Id = 100,
                Enunciado = "A que país pertence a ilha de Terra Nova?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ESTADOS UNIDOS" },
                    new alternativa { correta = false, Descricao = "DINAMARCA" },
                    new alternativa { correta = true, Descricao = "CANADÁ" },
                    new alternativa { correta = false, Descricao = "FRANÇA" },
                }
            },

            new pergunta
            {
                Id = 101,
                Enunciado = "Em que país você pode gastar rublos?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "HOLANDA" },
                    new alternativa { correta = true, Descricao = "RÚSSIA" },
                    new alternativa { correta = false, Descricao = "ESPANHA" },
                    new alternativa { correta = false, Descricao = "ÁFRICA DO SUL" },
                }
            },

            new pergunta
            {
                Id = 102,
                Enunciado = "Na criação do Estado do Tocantins, que estado teve o território reduzido?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "GOIÁS" },
                    new alternativa { correta = false, Descricao = "MATO GROSSO" },
                    new alternativa { correta = false, Descricao = "PARÁ" },
                    new alternativa { correta = false, Descricao = "MARANHÃO" },
                }
            },

            new pergunta
            {
                Id = 103,
                Enunciado = "De quem é este verso: 'A praça é do povo, como o céu é do condor'?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "TOBIAS BARRETO" },
                    new alternativa { correta = false, Descricao = "DORIVAL CAIMI" },
                    new alternativa { correta = false, Descricao = "MACHADO DE ASSIS" },
                    new alternativa { correta = true, Descricao = "CASTRO ALVES" },
                }
            },

            new pergunta
            {
                Id = 104,
                Enunciado = "Que nome recebe a foz de um rio que se abre para o mar?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "ALAGADO" },
                    new alternativa { correta = false, Descricao = "MANGUEZAL" },
                    new alternativa { correta = false, Descricao = "PÂNTANO" },
                    new alternativa { correta = true, Descricao = "ESTUÁRIO" },
                }
            },

            new pergunta
            {
                Id = 105,
                Enunciado = "'Arábica' e 'robusta' são tipos de quê?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "UVA" },
                    new alternativa { correta = true, Descricao = "CAFÉ" },
                    new alternativa { correta = false, Descricao = "MELÃO" },
                    new alternativa { correta = false, Descricao = "LARANJA" },
                }
            },

            new pergunta
            {
                Id = 106,
                Enunciado = "Em que ano Ayrton Senna venceu o primeiro campeonato de Fórmula 1?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "1987" },
                    new alternativa { correta = false, Descricao = "1990" },
                    new alternativa { correta = false, Descricao = "1985" },
                    new alternativa { correta = true, Descricao = "1988" },
                }
            },

            new pergunta
            {
                Id = 107,
                Enunciado = "Qual é a menor República do mundo?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "MÔNACO" },
                    new alternativa { correta = true, Descricao = "SAN MARINO" },
                    new alternativa { correta = false, Descricao = "NOVA ZELÂNDIA" },
                    new alternativa { correta = false, Descricao = "CHINA" },
                }
            },

            new pergunta
            {
                Id = 108,
                Enunciado = "Que símbolo está desenhado no centro da bandeira Argentina?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "SOL" },
                    new alternativa { correta = false, Descricao = "LUA" },
                    new alternativa { correta = false, Descricao = "ESTRELA" },
                    new alternativa { correta = false, Descricao = "FOICE E MARTELO" },
                }
            },

            new pergunta
            {
                Id = 109,
                Enunciado = "De quem é a frase 'Penso, logo existo'?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PLATÃO" },
                    new alternativa { correta = false, Descricao = "JÚLIO VERNE" },
                    new alternativa { correta = false, Descricao = "ARISTÓTELES" },
                    new alternativa { correta = true, Descricao = "RENÉ DESCARTES" },
                }
            },

            new pergunta
            {
                Id = 110,
                Enunciado = "Quem construiu o primeiro telescópio astronômico completo?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CYRUS MCCORMICK" },
                    new alternativa { correta = false, Descricao = "THOMAS EDISON" },
                    new alternativa { correta = false, Descricao = "MICHELANGELO" },
                    new alternativa { correta = true, Descricao = "GALILEU GALILEI" },
                }
            },

            new pergunta
            {
                Id = 111,
                Enunciado = "Em que parte do nosso corpo está o úmero?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "BRAÇO" },
                    new alternativa { correta = false, Descricao = "PERNA" },
                    new alternativa { correta = false, Descricao = "QUADRIL" },
                    new alternativa { correta = false, Descricao = "COLUNA" },
                }
            },

            new pergunta
            {
                Id = 112,
                Enunciado = "A quem se atribui a frase 'Eu sou o Estado'?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "LUIZ XIV" },
                    new alternativa { correta = false, Descricao = "LUIZ XV" },
                    new alternativa { correta = false, Descricao = "LUIZ XVI" },
                    new alternativa { correta = false, Descricao = "NAPOLEÃO BONAPARTE" },
                }
            },

            new pergunta
            {
                Id = 113,
                Enunciado = "Qual o nome verdadeiro do jogador de futebol conhecido com Zico?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "ARTHUR ANTUNES COIMBRA" },
                    new alternativa { correta = false, Descricao = "ARTHUR ALVES PINTO" },
                    new alternativa { correta = false, Descricao = "ARTHUR DA TÁVOLA" },
                    new alternativa { correta = false, Descricao = "ARTHUR DOS SANTOS" },
                }
            },

            new pergunta
            {
                Id = 114,
                Enunciado = "O que significa deprecar?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "RENEGAR" },
                    new alternativa { correta = false, Descricao = "SUJEITAR" },
                    new alternativa { correta = false, Descricao = "DESMAIAR" },
                    new alternativa { correta = true, Descricao = "PEDIR" },
                }
            },

            new pergunta
            {
                Id = 115,
                Enunciado = "Que cidade foi capital do Império Inca?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "LA PAZ" },
                    new alternativa { correta = false, Descricao = "BUENOS AIRES" },
                    new alternativa { correta = false, Descricao = "BOGOTÁ" },
                    new alternativa { correta = true, Descricao = "CUZCO" },
                }
            },

            new pergunta
            {
                Id = 115,
                Enunciado = "Com que outro nome é conhecido o Cabo Canaveral?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CABO JEFFERSON" },
                    new alternativa { correta = false, Descricao = "CABO LINCOLN" },
                    new alternativa { correta = true, Descricao = "CABO KENNEDY" },
                    new alternativa { correta = false, Descricao = "CABO REAGAN" },
                }
            },

            new pergunta
            {
                Id = 116,
                Enunciado = "Que significa o prefixo exo?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "DENTRO DE" },
                    new alternativa { correta = false, Descricao = "DEBAIXO DE" },
                    new alternativa { correta = true, Descricao = "FORA DE" },
                    new alternativa { correta = false, Descricao = "ATRÁS DE" },
                }
            },

            new pergunta
            {
                Id = 117,
                Enunciado = "Bill Clinton nasceu em que cidade?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "LOS ANGELES" },
                    new alternativa { correta = false, Descricao = "CHICAGO" },
                    new alternativa { correta = true, Descricao = "HOPE" },
                    new alternativa { correta = false, Descricao = "DALLAS" },
                }
            },

            new pergunta
            {
                Id = 118,
                Enunciado = "Qual foi o material utilizado na construção do Partenon de Atenas?",
                Alternativas = new()
                {
                    new alternativa { correta = true, Descricao = "MÁRMORE" },
                    new alternativa { correta = false, Descricao = "GRANITO" },
                    new alternativa { correta = false, Descricao = "GESSO" },
                    new alternativa { correta = false, Descricao = "QUARTZO" },
                }
            },

            new pergunta
            {
                Id = 119,
                Enunciado = "Que trópico atravessa o Saara?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "CAPRICÓRNIO" },
                    new alternativa { correta = false, Descricao = "VIRGEM" },
                    new alternativa { correta = true, Descricao = "CÂNCER" },
                    new alternativa { correta = false, Descricao = "LEÃO" },
                }
            },

            new pergunta
            {
                Id = 120,
                Enunciado = "Quem foi aluno de Platão e tutor de Alexandre, o Grande?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "PITÁGORAS" },
                    new alternativa { correta = false, Descricao = "DIDEROT" },
                    new alternativa { correta = true, Descricao = "ARISTÓTELES" },
                    new alternativa { correta = false, Descricao = "GALILEU GALILEI" },
                }
            },

            new pergunta
            {
                Id = 121,
                Enunciado = "'Guernica' é uma tela de qual pintor?",
                Alternativas = new()
                {
                    new alternativa { correta = false, Descricao = "MONET" },
                    new alternativa { correta = false, Descricao = "RENOIR" },
                    new alternativa { correta = true, Descricao = "PICASSO" },
                    new alternativa { correta = false, Descricao = "LEONARDO DA VINCI" },
                }
            }

        };
          



        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
