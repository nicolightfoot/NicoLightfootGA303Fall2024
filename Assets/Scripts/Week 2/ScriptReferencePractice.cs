using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public ComponentFun ourOtherScript;
    

    // Start is called before the first frame update
    void Start()
    {
        SetComponentFunVariables();

        
    }

    private void Update()
    {
        
    }

    void SetComponentFunVariables()
    {
        ourOtherScript.counter++; //This is the same as saying ourOtherScript.counter = ourOtherScript.counter + 1;
        
    }

   
}
