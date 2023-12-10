using UnityEngine;

public class ValueSwitch : MonoBehaviour
{
    [SerializeField] string a, b;

    void Start()
    {
        var temp = a;
        a = b;
        b = temp;
    }
}
