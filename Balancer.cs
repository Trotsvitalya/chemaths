using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chemaths
{
    class Balancer
    {
        public static string eq;
        public static string final;
        public static void runs()
        {
            //получаем список всех элементов и химических веществ
            ArrayList elements = AllUniqueElements(eq); //Приклад: H
            ArrayList chemicals = AllUniqueChemicals(eq);//Приклад: H2O

            //получить матрицу для всех химических веществ, кроме последнего и матрица для последней химической вещества
            Matrix A = PopulateChemMatrix((string[])chemicals.ToArray(typeof(string)), (string[])elements.ToArray(typeof(string)), eq);
            Matrix B = PopulateEquivalentMatrix((string[])chemicals.ToArray(typeof(string)), (string[])elements.ToArray(typeof(string)));

            //рассчитуем коэффициенты
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

            coefficients = MakeAllPositive(coefficients); //все коэффициенты должны быть положительными

            coefficients = ReduceSet(coefficients); //сводит все числа к наименьшим значениям

            final = FillCoefficients(coefficients, eq); //добавляет коэффициенты к химическим веществам


        }
        public static double[] ReduceSet(double[] dArr)
        {
            for (int i = 0; i < dArr.Length; i++)
            {
                double currentD = dArr[i];
                for (int j = 0; j < dArr.Length; j++)
                {
                    double checkD = dArr[j];
                    double greatestCommon = GCD(currentD, checkD);//
                    if (DividesAll(greatestCommon, dArr))
                    {
                        DivideAll(greatestCommon, dArr);
                    }
                }
            }
            return dArr;
        }

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

        public static double GCD(double a, double b)//наибольший общий делитель
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

        //возвращает строку с коэффициентами уравнения, добавленными для балансировки уравнения
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
        //возвращает массив всех уникальных хим.веществ
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

        //принимает разделенное, но не проанализированное уравнение и возвращает массив всех уникальных элементов
        public static ArrayList AllUniqueElements(string unsplit)
        {

            string[] unparsed = unsplit.Split(' ');

            ArrayList allUniqueElements = new ArrayList();
            //этот цикл будет проходить через каждый токен в уравнении
            for (int i = 0; i < unparsed.Length; i++)
            {
                string chemical = unparsed[i];

                if (chemical != "+" && chemical != "->")
                {
                    //разбивать его на элементы
                    for (int j = 0; j < chemical.Length; j++)
                    {

                        if (IsNumeric(chemical[j]) && RestAreNumeric(j, chemical))
                        {
                            break;
                        }

                        //пропустить числа и выполнить создание элемента только в том случае, если мы найдем новый в верхнем регистре
                        while (IsNumeric(chemical[j]) && j < chemical.Length - 1)
                        {
                            j++;
                        }

                        string element = chemical[j] + "";//создать элемент

                        if (j < chemical.Length - 1)
                        {
                            int nextLetterSwitch;
                            char nextChar = chemical[j + 1];
                            //(число, верхний регистр, строчная буква)
                            if (IsNumeric(nextChar))
                            {
                                nextLetterSwitch = 1;
                            }
                            else if (IsUpperCase(nextChar))
                            {
                                nextLetterSwitch = 2;
                            }
                            else
                            {
                                nextLetterSwitch = 3;
                            }

                            switch (nextLetterSwitch)
                            {
                                case 1: //Случай, когда следующий символ - это число
                                    if (!ListContains(allUniqueElements, element))
                                    {
                                        allUniqueElements.Add(element);

                                    }

                                    break;
                                case 2: //Случай, когда следующий символ - это заглавная буква
                                    if (!ListContains(allUniqueElements, element))
                                    {
                                        allUniqueElements.Add(element);

                                    }

                                    break;
                                case 3: //Случай, когда следующий символ - это строчная буква
                                    element += nextChar;
                                    j++;
                                    if (!ListContains(allUniqueElements, element))
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

        //заполняет химическую матрицу количеством каждого элемента, содержащегося в каждом химическом веществе
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
                        /*получает символ после элемента, который указывает количество атомов, 
            если это начало следующего элемента, то этот элемент появляется только один раз в химическом*/
                        if (chemical == element)
                        {
                            A.SetEntry(i, j, 1);
                        }
                        else
                        {
                            int endOfAtom = FindLastIndex(chemical, element) + 1;
                            char num = '\0';
                            //если атом только один и он последний элемент в химической формуле, то он выйдет за пределы индекса,
                            if (endOfAtom != chemical.Length)
                            {
                                num = chemical[endOfAtom];

                                if (IsUpperCase(num))
                                {
                                    //следующий символ является заглавной буквой, поэтому предыдущий элемент появляется только один раз
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

                                    while (endOfAtom < chemical.Length && IsNumeric(chemical[endOfAtom]))
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

        public static Matrix PopulateEquivalentMatrix(string[] chemicals, string[] elmts)
        {
            Matrix A = new Matrix(elmts.Length, 1);

            string chemical = chemicals[chemicals.Length - 1];

            for (int i = 0; i < elmts.Length; i++)
            {
                string element = elmts[i];


                if (chemical.Contains(element))
                {
                    //получает символ после элемента, который указывает количество атомов, если это начало следующего элемента, то этот элемент появляется только один раз в химическом

                    if (chemical == element)
                    {
                        A.SetEntry(i, 0, 1);
                    }
                    else
                    {
                        int endOfAtom = FindLastIndex(chemical, element) + 1;
                        char num = '\0';
                        //если атом только один и является последним элементом в химической формуле, то он выйдет за пределы индекса 
                        if (endOfAtom != chemical.Length)
                        {
                            num = chemical[endOfAtom];

                            if (IsUpperCase(num))
                            {
                                //следующий символ является заглавной буквой, поэтому предыдущий элемент появляется только один раз


                                A.SetEntry(i, 0, 1);

                            }
                            else
                            {
                                //символ является числом и поэтому должен быть преобразован
                                int numInt = ToInt(num);

                                endOfAtom++;
                                //
                                while (endOfAtom < chemical.Length && IsNumeric(chemical[endOfAtom]))
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

        public static double[] MakeAllPositive(double[] dArr)
        {
            for (int i = 0; i < dArr.Length; i++)
            {
                dArr[i] = Math.Abs(dArr[i]);
            }
            return dArr;
        }

        //ищет в строке подстроку и возвращает последний индекс подстроки
        public static int FindLastIndex(string str, string subStr)
        {
            //если они равны, то вернуть на единицу меньше, чем длина
            if (str == subStr)
            {
                return str.Length - 1;
            }

            //конкретный случай, когда substr представляет собой только один символ, тогда он может перебирать каждый символ в хим.
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


        //проверяет, содержится ли строка в списке строк
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
        //Проверяет, является ли символ заглавной буквой английского алфавита
        public static Boolean IsUpperCase(char c)
        {
            return ((c >= 65) && (c <= 90));
        }
        //проверяет, является ли символ числом
        public static Boolean IsNumeric(char c)
        {
            return ((c >= 48) && (c <= 57));
        }
        //преобразует символ в число
        public static int ToInt(char c)
        {
            return c - 48;
        }

        public static int AppendNum(int i, char c)
        {
            if (IsNumeric(c))
            {
                return (i * 10) + ToInt(c);
            }
            else
            {
                return -1;
            }
        }

    }
}
