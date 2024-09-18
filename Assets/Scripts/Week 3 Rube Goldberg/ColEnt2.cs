using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColEnt2 : MonoBehaviour
{
    public CarMovement carMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if(otherObject.collider.gameObject.tag == "button01")
        {
            Debug.Log("*button noise*");

            carMovementScript.carGoesVroom();
        }
        
    }
}
