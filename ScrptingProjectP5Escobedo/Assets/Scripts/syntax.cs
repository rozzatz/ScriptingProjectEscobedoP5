using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //this line is there to tell me the x position of my object

        /*hi there!
         * this is two lines
         * */
        Debug.Log(transform.position.y);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
