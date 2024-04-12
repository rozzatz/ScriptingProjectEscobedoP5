using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Lumin;

public class UsingOthereComponents : MonoBehaviour
{
    public GameObject otherGameObject;




    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    // Start is called before the first frame update
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Start()
    {
        boxCol.size = new Vector3(3,3, 3);
        Debug.Log("the players' score is " + anotherScript.playerScore);
        Debug.Log("the player has died " + yetAnotherScript.numberOfPlayerDeaths + " times" );
    }
}
