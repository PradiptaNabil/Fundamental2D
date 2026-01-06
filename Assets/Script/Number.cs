using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    int Number1 = 10;
    int Number2 = 7;
    
    void Start()
    {
        int Number3 = Number1;
        Number1 = Number2;
        Number2 = Number1;

        Debug.Log(Number1);
        Debug.Log(Number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
