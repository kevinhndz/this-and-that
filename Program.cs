int[] TwoSumValores(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { nums[i], nums[j] };
            }
        }
    }

    return new int[0];
}

int[] numeros = new int[] { 2, 7, 11, 15 };
int objetivo = 9;

int[] pareja = TwoSumValores(numeros, objetivo);

if (pareja.Length == 2)
{
    Console.WriteLine($"Pareja encontrada: {pareja[0]} y {pareja[1]}");
}
else
{
    Console.WriteLine("No se encontró ninguna pareja.");
}