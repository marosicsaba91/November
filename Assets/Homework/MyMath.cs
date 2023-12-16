using UnityEngine;

public class MyMath : MonoBehaviour
{
    [SerializeField] int a, b, c;
    [SerializeField] bool isPythagorean;

    [SerializeField] int number;
    [SerializeField] bool isPrime;


    void OnValidate()
    {
        isPythagorean = IsPythagorean(a, b, c);
        isPrime = IsPrime(number);
    }

    float Floor(float n)
    {
        float remainder = n % 1;   // Törtrész
        return n - remainder;
    }

    float Ceiling(float n)
    {
        float remainder = n % 1;   // Törtrész

        if (remainder == 0)
            return n;

        return n + 1 - remainder;
    }

    float Round(float n)
    {
        float remainder = n % 1;
        if (remainder < 0.5f)
            return Floor(n);
        else
            return Ceiling(n);
    }

    bool IsPythagorean(int a, int b, int c)
    {
        int leg1, leg2, hypotenuse;
        if (a > b && a > c)
        {
            hypotenuse = a;
            leg1 = b;
            leg2 = c;
        }
        else if (b > a && b > c)
        {
            hypotenuse = b;
            leg1 = a;
            leg2 = c;
        }
        else
        {
            hypotenuse = c;
            leg1 = a;
            leg2 = b;
        }

        return leg1 * leg1 + leg2 * leg2 == hypotenuse * hypotenuse;
    }

    bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    int LeastCommonMultiple(int n1, int n2)
    {
        int max = Mathf.Max(n1, n2);
        int min = Mathf.Min(n1, n2);

        for (int i = max; i > 0; i += max)
        {
            if (i % min == 0)
            {
                return i;
            }
        }

        return -1;
    }
}
