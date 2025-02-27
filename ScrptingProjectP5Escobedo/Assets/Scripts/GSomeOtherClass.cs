using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSomeOtherClass : MonoBehaviour
{
    void Start()
    {
        GSomeClass myClass = new GSomeClass();

     
        myClass.GenericMethod<int>(5);
    }
}
