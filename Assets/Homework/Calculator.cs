using UnityEngine;

class Calculator : MonoBehaviour
{
    [SerializeField] float a, b;
    [Space]
    [SerializeField] float sum;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float rate;

    void OnValidate()
    {
        sum = a + b;
        difference = a - b;
        product = a * b;
        rate = a / b;
    }
}
