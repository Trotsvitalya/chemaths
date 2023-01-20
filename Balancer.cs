using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace chemaths
{
    class Balancer
    {
        public static string eq;
        public static string final;
        public static string cof;

        public static void runs()
        {
            ExceptionHandlingBalancer.PARSE(eq); //обробка виключних ситуацій

            //отримуємо список усіх елементів та хімічних речовин
            ArrayList elements = AllUniqueElements(eq); //Приклад: H
            ArrayList chemicals = AllUniqueChemicals(eq);//Приклад: H2O

            //отримати матрицю для всіх хімічних речовин, крім останнього і матриця для останньої хімічної речовини
            Matrix A = SymbolBalancer.PopulateChemMatrix((string[])chemicals.ToArray(typeof(string)), (string[])elements.ToArray(typeof(string)), eq);
            Matrix B = SymbolBalancer.PopulateEquivalentMatrix((string[])chemicals.ToArray(typeof(string)), (string[])elements.ToArray(typeof(string)));

            //розрахуємо коефіцієнти
            Matrix C = (A.GetInverse().Multiply(B)).Multiply(A.GetDeterminant());

            double[] coefficients = new double[C.GetColumn(0).Length];
            Array.Copy(C.GetColumn(0), coefficients, C.GetColumn(0).Length);

            double last = coefficients[coefficients.Length - 1];
            if (coefficients.Length == ((string[])chemicals.ToArray(typeof(string))).Length)
            {
                if (last != A.GetDeterminant())
                {
                    coefficients[coefficients.Length - 1] = A.GetDeterminant();
                }
            }
            else
            {
                ArrayList c = new ArrayList(C.GetColumn(0));
                c.Add(A.GetDeterminant());
                coefficients = (double[])c.ToArray(typeof(double));
            }

            coefficients = RatioBalancer.MakeAllPositive(coefficients); //всі коефіцієнти мають бути позитивними

            coefficients = RatioBalancer.ReduceSet(coefficients); //зводить усі числа до найменших значень

            final = RatioBalancer.FillCoefficients(coefficients, eq); //додає коефіцієнти до хімічних речовин
            cof = string.Join("", coefficients);
        }

        public static Boolean IsProduct(string chem, string eq)
        {
            string[] eqSplit = eq.Split(' ');

            int indexYield = -1;
            int indexChem = -1;
            for (int i = 0; i < eqSplit.Length; i++)
            {
                if (eqSplit[i] == "->")
                {
                    indexYield = i;
                    break;
                }
            }

            for (int i = 0; i < eqSplit.Length; i++)
            {
                if (eqSplit[i] == chem)
                {
                    indexChem = i;
                    break;
                }
            }

            return indexChem > indexYield;
        }
        
        //повертає масив усіх унікальних хімічних речовин
        public static ArrayList AllUniqueChemicals(string unsplit)
        {
            string[] unparsed = unsplit.Split(' ');

            ArrayList allUniqueChemicals = new ArrayList();
            foreach (string s in unparsed)
            {
                if (!(allUniqueChemicals.Contains(s) || s == "+" || s == "->"))
                {
                    allUniqueChemicals.Add(s);
                }
            }

            return allUniqueChemicals;
        }

        //приймає розділене, але не проаналізоване рівняння та повертає масив усіх унікальних елементів
        public static ArrayList AllUniqueElements(string unsplit)
        {

            string[] unparsed = unsplit.Split(' ');

            ArrayList allUniqueElements = new ArrayList();
            //цей цикл проходитиме через кожен токен у рівнянні
            for (int i = 0; i < unparsed.Length; i++)
            {
                string chemical = unparsed[i];

                if (chemical != "+" && chemical != "->")
                {
                    //розбивати його на елементи
                    for (int j = 0; j < chemical.Length; j++)
                    {

                        if (CheckBalancer.IsNumeric(chemical[j]) && CheckBalancer.RestAreNumeric(j, chemical))
                        {
                            break;
                        }

                        //пропустити числа та виконати створення елемента тільки в тому випадку, якщо ми знайдемо новий у верхньому регістрі
                        while (CheckBalancer.IsNumeric(chemical[j]) && j < chemical.Length - 1)
                        {
                            j++;
                        }

                        string element = chemical[j] + "";//створити елемент

                        if (j < chemical.Length - 1)
                        {
                            int nextLetterSwitch;
                            char nextChar = chemical[j + 1];
                            //(число, верхній регістр, мала літера)
                            if (CheckBalancer.IsNumeric(nextChar))
                            {
                                nextLetterSwitch = 1;
                            }
                            else if (CheckBalancer.IsUpperCase(nextChar))
                            {
                                nextLetterSwitch = 2;
                            }
                            else
                            {
                                nextLetterSwitch = 3;
                            }

                            switch (nextLetterSwitch)
                            {
                                case 1: //Випадок, коли наступний символ - це число
                                    if (!CheckBalancer.ListContains(allUniqueElements, element))
                                    {
                                        allUniqueElements.Add(element);

                                    }

                                    break;
                                case 2: //Випадок, коли наступний символ - це велика літера
                                    if (!CheckBalancer.ListContains(allUniqueElements, element))
                                    {
                                        allUniqueElements.Add(element);

                                    }

                                    break;
                                case 3: //Випадок, коли наступний символ - це мала буква
                                    element += nextChar;
                                    j++;
                                    if (!CheckBalancer.ListContains(allUniqueElements, element))
                                    {
                                        allUniqueElements.Add(element);

                                    }

                                    break;
                                default:
                                    break;

                            }
                        }
                    }
                }
            }

            return allUniqueElements;
        }

        //перетворює символ на число
        public static int ToInt(char c)
        {
            return c - 48;
        }

        public static int AppendNum(int i, char c)
        {
            if (CheckBalancer.IsNumeric(c))
            {
                return (i * 10) + ToInt(c);
            }
            else
            {
                return -1;
            }
        }

    }

    //клас з перевірками
    class CheckBalancer : Balancer 
    {
        //перевіряє, чи міститься рядок у списку рядків
        public static Boolean ListContains(ArrayList AL, String s)
        {
            foreach (object o in AL)
            {
                string ss = (string)o;

                if ((ss == s))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean RestAreNumeric(int j, string s)
        {
            for (int i = j; i < s.Length; i++)
            {
                if (!IsNumeric(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
        
        //перевіряє, чи є символ великою літерою англійського алфавіту
        public static Boolean IsUpperCase(char c)
        {
            return ((c >= 65) && (c <= 90));
        }
        
        //перевіряє, чи є символ числом
        public static Boolean IsNumeric(char c)
        {
            return ((c >= 48) && (c <= 57));
        }

        //шукає у рядку підрядок і повертає останній індекс підрядка
        public static int FindLastIndex(string str, string subStr)
        {
            //якщо вони рівні, то повернути на одиницю менше, ніж довжина
            if (str == subStr)
            {
                return str.Length - 1;
            }

            //конкретний випадок, коли substr є лише один символ, тоді він може перебирати кожен символ в хім.
            if (subStr.Length == 1)
            {
                char c = subStr[0];
                for (int i = 0; i < str.Length; i++)
                {
                    if (c == str[i])
                    {
                        return i;
                    }
                }
            }

            for (int i = 0; i < str.Length - subStr.Length + 1; i++)
            {
                string checkString = str.Substring(i, subStr.Length);

                if (checkString == subStr)
                {
                    return i + subStr.Length - 1;
                }
            }
            return -1;
        }
    }

    //клас з розрахунками
    class CalculateBalancer : Balancer
    {
        public static Boolean DividesAll(double div, double[] dArr)
        {
            foreach (double d in dArr)
            {
                if (d % div != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static double[] DivideAll(double div, double[] dArr)
        {
            for (int i = 0; i < dArr.Length; i++)
            {
                dArr[i] = (dArr[i] / div);
            }
            return dArr;
        }

        public static double GCD(double a, double b)//найбільший спільний дільник
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }
    }
    
    //клас з розрахунками коефіціентів
    class RatioBalancer : Balancer
    {
        public static double[] ReduceSet(double[] dArr)
        {
            for (int i = 0; i < dArr.Length; i++)
            {
                double currentD = dArr[i];
                for (int j = 0; j < dArr.Length; j++)
                {
                    double checkD = dArr[j];
                    double greatestCommon = CalculateBalancer.GCD(currentD, checkD);//
                    if (CalculateBalancer.DividesAll(greatestCommon, dArr))
                    {
                        CalculateBalancer.DivideAll(greatestCommon, dArr);
                    }
                }
            }
            return dArr;
        }

        //повертає рядок з коефіцієнтами рівняння, доданими для балансування рівняння
        public static string FillCoefficients(double[] coef, string eq)
        {
            string[] eqParse = eq.Split(' ');

            string balance = "";

            int indexCoef = 0;
            int indexEq = 0;
            while (indexCoef < coef.Length)
            {
                int caseNum = 0;
                if (eqParse[indexEq] == "->" || eqParse[indexEq] == "+")
                {
                    caseNum = 1;
                }
                else
                {
                    caseNum = 2;
                }

                switch (caseNum)
                {
                    case 1:
                        balance += " " + eqParse[indexEq] + " ";
                        indexEq++;
                        break;
                    case 2:
                        balance += "(" + coef[indexCoef] + ")" + eqParse[indexEq];
                        indexCoef++;
                        indexEq++;
                        break;
                    default:
                        break;
                }
            }

            return balance;
        }
        
        public static double[] MakeAllPositive(double[] dArr)
        {
            for (int i = 0; i < dArr.Length; i++)
            {
                dArr[i] = Math.Abs(dArr[i]);
            }
            return dArr;
        }
    }

    //клас з розрахунками елементів
    class SymbolBalancer : Balancer
    {
        public static Matrix PopulateEquivalentMatrix(string[] chemicals, string[] elmts)
        {
            Matrix A = new Matrix(elmts.Length, 1);

            string chemical = chemicals[chemicals.Length - 1];

            for (int i = 0; i < elmts.Length; i++)
            {
                string element = elmts[i];


                if (chemical.Contains(element))
                {
                    //отримує символ після елемента, який вказує кількість атомів, якщо це початок наступного елемента, то цей елемент з'являється лише один раз у хімічному

                    if (chemical == element)
                    {
                        A.SetEntry(i, 0, 1);
                    }
                    else
                    {
                        int endOfAtom = CheckBalancer.FindLastIndex(chemical, element) + 1;
                        char num = '\0';
                        //якщо атом лише один і є останнім елементом у хімічній формулі, то він вийде за межі індексу
                        if (endOfAtom != chemical.Length)
                        {
                            num = chemical[endOfAtom];

                            if (CheckBalancer.IsUpperCase(num))
                            {
                                //наступний символ є великою літерою, тому попередній елемент з'являється лише один раз


                                A.SetEntry(i, 0, 1);

                            }
                            else
                            {
                                //символ є числом і тому має бути перетворений
                                int numInt = ToInt(num);

                                endOfAtom++;
                                //
                                while (endOfAtom < chemical.Length && CheckBalancer.IsNumeric(chemical[endOfAtom]))
                                {
                                    numInt = AppendNum(numInt, chemical[endOfAtom]);
                                    endOfAtom++;
                                }


                                A.SetEntry(i, 0, numInt);
                            }
                        }
                        else
                        {

                            A.SetEntry(i, 0, 1);

                        }
                    }
                }
                else
                {
                    A.SetEntry(i, 0, 0);
                }
            }

            return A;
        }

        //заповнює хімічну матрицю кількістю кожного елемента, що міститься в кожній хімічній речовині
        public static Matrix PopulateChemMatrix(string[] chems, string[] elmts, string eq)
        {
            Matrix A = new Matrix(elmts.Length, chems.Length - 1);

            for (int i = 0; i < A.Entries.GetLength(0); i++)
            {
                string element = elmts[i];

                for (int j = 0; j < A.Entries.GetLength(1); j++)
                {
                    string chemical = chems[j];

                    if (chemical.Contains(element))
                    {
                        /*отримує символ після елемента, який вказує кількість атомів,
                        якщо це початок наступного елемента, то цей елемент з'являється лише один раз у хімічному*/
                        if (chemical == element)
                        {
                            A.SetEntry(i, j, 1);
                        }
                        else
                        {
                            int endOfAtom = CheckBalancer.FindLastIndex(chemical, element) + 1;
                            char num = '\0';
                            //якщо атом тільки один і він останній елемент у хімічній формулі, то він вийде за межі індексу,
                            if (endOfAtom != chemical.Length)
                            {
                                num = chemical[endOfAtom];

                                if (CheckBalancer.IsUpperCase(num))
                                {
                                    //наступний символ є великою літерою, тому попередній елемент з'являється лише один раз
                                    if (IsProduct(chemical, eq))
                                    {
                                        A.SetEntry(i, j, -1);
                                    }
                                    else
                                    {
                                        A.SetEntry(i, j, 1);
                                    }
                                }
                                else
                                {

                                    int numInt = ToInt(num);

                                    endOfAtom++;

                                    while (endOfAtom < chemical.Length && CheckBalancer.IsNumeric(chemical[endOfAtom]))
                                    {
                                        numInt = AppendNum(numInt, chemical[endOfAtom]);
                                        endOfAtom++;
                                    }

                                    if (IsProduct(chemical, eq))
                                    {
                                        numInt *= -1;
                                    }

                                    A.SetEntry(i, j, numInt);
                                }
                            }
                            else
                            {
                                if (IsProduct(chemical, eq))
                                {
                                    A.SetEntry(i, j, -1);
                                }
                                else
                                {
                                    A.SetEntry(i, j, 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        A.SetEntry(i, j, 0);
                    }
                }
            }

            A.ConvertToSquare(1);

            return A;
        }
    }

    //клас з обробкою виключних ситуацій
    class ExceptionHandlingBalancer : Balancer
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