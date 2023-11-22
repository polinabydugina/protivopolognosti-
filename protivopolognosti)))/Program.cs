using System.Diagnostics.Metrics;

while (true)
{
    int n = Convert.ToInt32(Console.ReadLine());

    if (n >= 1 && n <= 100)
    {
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {


            int a = Convert.ToInt32(Console.ReadLine());
            if (a < -100 || a > 100)
            {
                Console.WriteLine("Введенное число не должно по модулю превосходить 100.");
                i--;
            }
            else
            {
                nums[i] = a;
            }


        }
        Console.Clear();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($" {nums[i]}");
        }

        iskatel(nums);
        void iskatel(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[i] == -d[j])
                    {
                        Console.Write(i);
                        Console.Write(j);
                        return;


                    }
                }
            }
        }
    }

    else
    {
        Console.WriteLine("Количество элементов массива не должно превышать 100");
    }
    break;

}



