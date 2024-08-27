using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharWord : MonoBehaviour
{
    public char letter1 = 'r';
    public char letter2 = 'o';
    public char letter3 = 'm';
    public char letter4 = 'e';

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(letter1.ToString() + letter2.ToString() + 
            letter3.ToString() + letter4.ToString() + letter2.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
