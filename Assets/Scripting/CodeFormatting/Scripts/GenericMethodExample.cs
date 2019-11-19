using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericMethodExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Evaluate("Hello World");
        Evaluate(10);
    }

    // Update is called once per frame
    private void Evaluate<T>(T suppliedValue)
    {
        Debug.LogFormat("The type of {0} is {l}", suppliedValue, typeof(T));
    }
}
