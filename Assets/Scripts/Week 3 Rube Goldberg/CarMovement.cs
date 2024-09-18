using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public GameObject car;
    public float carSpeed = -500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void carGoesVroom()
    {
        Debug.Log("vroom!");
        car.GetComponent<Rigidbody>().AddForce(car.transform.forward * carSpeed);
    }
}
