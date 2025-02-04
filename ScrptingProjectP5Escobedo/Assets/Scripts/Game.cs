using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    void Start()
    {
        PropPlayer myPlayer = new PropPlayer();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}