using System;

namespace ControlFlowCondLoops.Task3RefactorLoop
{
    internal static class RefactorLoop
    {
        private const int MaxNumber = 100;

        internal static void RunLoop(int[] arrayToSearch, int expectedValue)
        {
            var expectedValueIsFound = false;
            for (var i = 0; i < MaxNumber; i++)
            {
                Console.WriteLine(arrayToSearch[i]);

                expectedValueIsFound = CheckIfConditionsAreMet(i, expectedValue, arrayToSearch[i]);
                if (expectedValueIsFound)
                {
                    break;
                }
            }

            if (expectedValueIsFound)
            {
                Console.WriteLine("Value found.");
            }
        }

        internal static void Main()
        {
        }

        private static bool CheckIfConditionsAreMet(int index, int expectedValue, int arrayValue)
        {
            bool conditionsAreMet = index % 10 == 0 && arrayValue == expectedValue;

            return conditionsAreMet;
        }
    }
}
