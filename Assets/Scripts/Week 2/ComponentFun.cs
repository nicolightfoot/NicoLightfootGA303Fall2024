using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentFun : MonoBehaviour
{
    

    public int counter = 0;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 1) // if the counter variable is equal to 1, we will get dialog that says "Counter is 1!"
        {
            Debug.Log("Counter is 1!");
        }

        CheckInputs();

        //counter = counter + 3; //Increases the current value of counter by 3
        //counter += 3; //Increases the current value of counter by 3 (different syntax!)
        //counter -= 2; //Decreases the current value of counter by 2
        //counter = 0; //Sets the variable to 0.
    }

    void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            counter++;
            Debug.Log("Counter is currently: " + counter);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            counter--;
            Debug.Log("Counter is currently: " + counter);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("This is when the character would move!");
        }
    }
}
