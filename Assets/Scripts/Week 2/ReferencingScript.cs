using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferencingScript : MonoBehaviour
{
    public UICounters otherScript;
    

    // Start is called before the first frame update
    
    void Start()
    {
        SetUICountersVariables();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            otherScript.moodlighting.color = Color.green;
            Debug.Log("Green light!");
        }    
          
        if (Input.GetKeyDown(KeyCode.T))
        {
            otherScript.movement.Translate(Vector3.forward);
            Debug.Log("Moved forward");
        }
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            otherScript.noises.Play();
            Debug.Log("Playing tunes");
        }
    }

    void SetUICountersVariables()
    {
        otherScript.counter01++;

       
      
    }
}
