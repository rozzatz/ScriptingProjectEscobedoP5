using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifier : MonoBehaviour
{
    public int alpha = 5;

    public int beta = 0;
    public int gamma = 5;


    private AnotherCLass myOtheclass;
   
    void Start()
    {
        alpha = 29;
        myOtheclass = new AnotherCLass();
        myOtheclass.Fruitmachine(alpha, myOtheclass.apples);
    }

    void example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
   
    void Update()
    {
        Debug.Log("alpha is set to: " + alpha);
    }
}
