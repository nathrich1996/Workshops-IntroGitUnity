using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update() //Change value of x
    {
        IncrementX(2);
    }
    void IncrementX(int n)
    {
        x += n;
    }
}
