using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherScript : MonoBehaviour
{
     void Start()
    {
      SomeScript mycLASS = new SomeScript();

        mycLASS.Add(1, 2);
        mycLASS.Add("hello","world");

    }
}
