using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColEnt1 : MonoBehaviour
{
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
        if (otherObject.collider.gameObject.tag == "domino")
        {
            Debug.Log("Timber!");
        }
    }
}
