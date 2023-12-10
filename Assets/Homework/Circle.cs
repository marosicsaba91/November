using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [Space]
    [SerializeField] float circumference;
    [SerializeField] float area;

    void OnValidate()
    {
        const float pi = Mathf.PI;
        circumference = 2 * radius * pi;
        area = radius * radius * pi;
        // area = Mathf.Pow(radius, 2) * pi;
    }
}
