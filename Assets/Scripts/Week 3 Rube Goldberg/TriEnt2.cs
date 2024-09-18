using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriEnt2 : MonoBehaviour
{
    public AudioSource winNoise;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.GetComponent<Collider>().gameObject.tag == "noiseBox")
        {
            winNoise.Play();
            Debug.Log("Yippee!");
        }
    }
}
