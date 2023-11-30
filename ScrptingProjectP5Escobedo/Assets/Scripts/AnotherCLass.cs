using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherCLass : MonoBehaviour
{
    public int apples;
    public int bananas;


    public int stapler;
    public int sellotape;

    public void Fruitmachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total" + answer);
    }

    
    void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("office supplies total" + answer);
    }
}
