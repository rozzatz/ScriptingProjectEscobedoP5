using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;
    void Start()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("ive washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
