using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour
{
    public int odysseus = 586189890;
    public int penelope = 89476847;
    public int circe = 826045614;
    public int agamemnon = 953505428;
    // Start is called before the first frame update
    void Start()

    {
        Debug.Log("The starting number is " + odysseus);
        odysseus = odysseus + penelope;
        Debug.Log("Added " + penelope + " to starting number, making the total " + odysseus);
        odysseus = odysseus + circe;
        Debug.Log("Added " + circe + " to the total, making the new total " + odysseus);
        odysseus = odysseus + agamemnon;
        Debug.Log("Added " + odysseus + " to the total, making the end total " + odysseus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
