using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousedown : MonoBehaviour
{
   private Rigidbody rb;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
       rb.AddForce(-transform.forward * -500); 
        rb.useGravity = true;
    }
}
