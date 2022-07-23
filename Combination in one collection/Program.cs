namespace Combination_in_one_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = CreateArray();
            int[] array2 = CreateArray();
            List<int> combinationList = new List<int>();

            AddNumber(array1, combinationList);
            AddNumber(array2, combinationList);

            WriteArray(array1, "Массив 1:");
            WriteArray(array2, "Массив 2:");
            WriteList(combinationList, "Объединенная коллекция List без повторных значений:");

            HashSet<int> addNumber2 = AddNumber2(array1, array2);
            WriteList(combinationList, "Объединенная коллекция HashSet без повторных значений:");

            AddNumber3(array1, combinationList);
            AddNumber3(array2, combinationList);
            WriteList(combinationList, "Объединенная коллекция List без повторных значений ()another way with Contain Method):");
        }

        static void AddNumber3(int[] array, List<int> combinationList)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!combinationList.Contains(array[i]))
                {
                    combinationList.Add(i);
                }
            }
        }

        static HashSet<int> AddNumber2(int[] array1, int[] array2)
        {
            HashSet<int> numbers1 = new HashSet<int>(array1);
            HashSet<int> numbers2 = new HashSet<int>(array2);
            numbers1.UnionWith(numbers2);
            return numbers1;
        }

        static void AddNumber(int[] array, List<int> combinationList)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool noRepeats = true;

                for (int j = 0; j < combinationList.Count; j++)
                {
                    if (array[i] == combinationList[j])
                    {
                        noRepeats = false;
                    }
                }

                if (noRepeats)
                {
                    combinationList.Add(array[i]);
                }
            }
        }

        static void WriteList(List<int> list, string text)
        {
            Console.WriteLine(text);

            foreach (var number in list)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        static void WriteArray(int[] array, string text)
        {
            Console.WriteLine(text);

            foreach (var number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }
        
        static void WriteHashSet(HashSet<int> array, string text)
        {
            Console.WriteLine(text);

            foreach (var number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        static int[] CreateArray()
        {
            Random random = new Random();
            int minArrayLenght = 3;
            int maxArrayLenght = 10;
            int minValue = 0;
            int maxValue = 10;
            int arrayLenght = random.Next(minArrayLenght, maxArrayLenght);
            int[] tempArray = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                tempArray[i] = random.Next(minValue, maxValue);
            }

            return tempArray;
        }
    }
}