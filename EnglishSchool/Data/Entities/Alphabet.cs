using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Alphabet
    {
        //public char letter { get; set; }
        //public string rusSound { get; set; }
        //public string transcription { get; set; }
        //public string word { get; set; }
        public static List<char> ABC = new List<char>
                                {'A','B','C','D','F','E','G',
                                 'H','I','J','K','L','M','N',
                                 'O','P','Q','R','S','T','U',
                                 'V','W','X','Y','Z'};

        public static List<string> rusSounds = new List<string>
                                   {"Эй","Би","Си","Ди","И","Эф",
                                    "Джи","Эйч","Ай","Джей","Кей",
                                    "Эль","Эм","Эн","О","Пи","Кью",
                                    "Ар","Эс","Ти","Ю","Ви","Дабль Ю",
                                    "Экс","Уай","Зет"};
        public static List<string> transcriptions = new List<string>
                                   {"[ei]","[bi:]","[si:]","[di:]","[i:]","[ef]",
                                    "[dji:]","[eits]","[ai]","[djei]","[kei]",
                                    "[el]","[em]","[en]","[ou]","[pi:]","[kju:]",
                                    "[a:]","[es]","[ti:]","[ju:]","[vi:]","['d^bl ju:]",
                                    "[eks]","[wai]","[zed]"};
        public static List<string> words = new List<string>
                                   {"apple","ballon","cake","doll","elephant","frog",
                                    "goat","house","ice cream","jam","key",
                                    "lemon","mouse","nose","orange","puppy","queen",
                                    "rose","rabbit","tiger","umbrella","violin","watch",
                                    "xylophone","yacht","zebra"};
    }
}
