using UnityEngine;

class SumOfNumbers : MonoBehaviour
{
    [SerializeField] long number;
    [SerializeField] long sum;

    void OnValidate()
    {
        sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
    }
}
