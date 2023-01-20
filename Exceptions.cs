using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace chemaths
{
    class Exceptions
    {
        public static void PARSE(string eq)
        {
            //обробка ситуації, коли рівняння містить символи не тільки латинської абетки
            if (Regex.IsMatch(eq, @"\p{IsCyrillic}"))
            {
                throw new Exception("alphabet_mistake");
            }

            //обробка ситуації, коли молекула містить пробіли
            Regex regex = new Regex(@"[a-zA-Z]\s[A-Z]");
            if (regex.IsMatch(eq))
            {
                throw new Exception("space_mistake");
            }

            //обробка ситуації, коли рівняння не містить хоча б одного знаку " + "
            if (!eq.Contains(" + "))
            {
                throw new Exception("plus_mistake");
            }

            //обробка ситуації, коли рівняння містить більше або менше 2 сторін, розділених " -> "
            string[] sides = eq.Split(new string[] { " -> " }, StringSplitOptions.None);
            if (sides.Length != 2)
            {
                throw new Exception("sides_mistake");
            }

            //обробка ситуації, коли рівняння не містить пробілів або містить більше, ніж 1 пробіл
            //підряд
            regex = new Regex(@"\s{2,}");
            if (regex.IsMatch(eq) || !eq.Contains(' '))
            {
                throw new Exception("space_mistake");
            }

            PARSE_SIDE(sides[0]);
            PARSE_SIDE(sides[1]);
        }

        public static void PARSE_SIDE(string side)
        {
            //розбиття сторони рівняння на молекули
            string[] separators = { "+" };
            string[] molecules = side.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string molecule in molecules)
            {
                PARSE_MOLECULE(molecule);
            }
        }

        public static void PARSE_MOLECULE(string molecule)
        {
            molecule = molecule.Trim();//прибирання пробілів на початку та на кінці рядка
            //періодична таблиця хімічних елементів
            string periodical_table = "Ac|Ag|Al|Am|Ar|As|At|Au|B|Ba|Be|Bh|Bi|Bk|Br|C|Ca|Cd|Ce|Cf|" +
                                        "Cl|Cm|Co|Cr|Cs|Cu|Ds|Db|Dy|Er|Es|Eu|F|Fe|Fm|Fr|Ga|Gd|Ge|H|" +
                                        "He|Hf|Hg|Ho|Hs|I|In|Ir|K|Kr|La|Li|Lr|Lu|Md|Mg|Mn|Mo|Mt|N|" +
                                        "Na|Nb|Nd|Ne|Ni|No|Np|O|Os|P|Pa|Pb|Pd|Pm|Po|Pr|Pt|Pu|Ra|Rb|" +
                                        "Re|Rf|Rg|Rh|Rn|Ru|S|Sb|Sc|Se|Sg|Si|Sm|Sn|Sr|Ta|Tb|Tc|Te|Th|" +
                                        "Ti|Tl|Tm|U|V|W|Xe|Y|Yb|Zn|Zr";
            string[] atoms = periodical_table.Split('|');
            int counter = 0;
            for (int i = 0; i < molecule.Length; i++)
            {
                //зчитання першого символу
                char c = molecule[i];
                string atom = c.ToString();

                if (Regex.IsMatch(atom, "[A-Z]"))//якщо символ належить до верхнього регістру
                {
                    //перевірка символів після першого верхнього регістру
                    for (int j = i + 1; j < molecule.Length; j++)
                    {
                        //зчитання наступного сиволу
                        char d = molecule[j];
                        string b = d.ToString();

                        if (Regex.IsMatch(b, "[a-z]"))//якщо символ належить до нижнього регістру
                        {
                            atom += b;//створення атома, наприклад "С + u = Cu"
                        }
                        if (Regex.IsMatch(b, "[A-Z]"))//якщо символ належить до верхнього регістру
                        {
                            i = j - 1;//початок обробки з першого циклу
                            break;
                        }
                    }
                    counter = 0;
                }
                foreach (string element in atoms)
                {
                    if (atom == element)//якщо утворений атом існує в періодичній таблиці
                    {
                        counter = 1;
                    }
                }
                if (counter != 1)//якщо утворений атом не існує в періодичній таблиці
                {
                    throw new Exception("atom_mistake");
                }
            }
        }
    }
}
