namespace Combination_in_one_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = FillArray();
            int[] array2 = FillArray();
            List<int> combinationList = new List<int>();

            AddNumber(array1, combinationList);
            AddNumber(array2, combinationList);

            WriteArray(array1, "Массив 1:");
            WriteArray(array2, "Массив 2:");
            WriteList(combinationList, "Объединенная коллекция без повторных значений:");
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

        static int[] FillArray()
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