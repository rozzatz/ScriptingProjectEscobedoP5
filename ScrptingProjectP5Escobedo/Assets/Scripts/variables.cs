using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
   public int myint = 5;
    // Start is called before the first frame update
    void Start()
    {
        myint = MultiplyByTwo(myint);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
