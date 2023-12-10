using UnityEngine;

class MinMax : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int min, max;
    [Space]
    [SerializeField] int x = 77;
    [SerializeField] string parity;


    void OnValidate()
    {
        min = a < b ? a : b;
        max = a > b ? a : b;

        parity = x % 2 == 0 ? "PÁROS" : "PÁRATLAN";
    }
}
