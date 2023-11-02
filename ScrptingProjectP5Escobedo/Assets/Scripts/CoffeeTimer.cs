using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffeetimer : MonoBehaviour
{
    float coffeeTempature = 85.0f;
    float hotlimitTempature = 70.0f;
    float coldlimitTempature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
            TempatureTest();

        coffeeTempature -= Time.deltaTime * 5f;

    }


    void TempatureTest()

    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTempature > hotlimitTempature)
        {
            //... Do this.
            print("coffee is too hot");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTempature < coldlimitTempature)
        {
            //... do this.
            print("coffee is too cold");
        }
        // if it is neither of those...
        else
        {
            // ... do this
            print("coffee is just right.");
        }
    }
}
