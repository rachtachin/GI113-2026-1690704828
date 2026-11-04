// GI113 Computer Programming
// Lab 08: Array Statistics (Week 12)
// Name: Rachta Chingthonkom
using UnityEngine;

public class Lab08 : MonoBehaviour
{
    [SerializeField] int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };

    int sum;
    float average;
    int maximum;
    int minimum;

    void Start()
    {
        // Step 2: Print all numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Number " + (i + 1) + ": " + numbers[i]);
        }

        // Step 3: Sum and Average
        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        average = (float)sum / numbers.Length;
        Debug.Log("Sum: " + sum);
        Debug.Log("Average: " + average);

        // Step 4: Maximum and Minimum
        maximum = numbers[0];
        minimum = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }

            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }

        Debug.Log("Maximum: " + maximum);
        Debug.Log("Minimum: " + minimum);

        // Step 5: Sort Numbers
        System.Array.Sort(numbers);

        foreach (int n in numbers)
        {
            Debug.Log("Sorted: " + n);
        }
    }
}
