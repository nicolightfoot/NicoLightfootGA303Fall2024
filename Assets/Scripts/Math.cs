using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour
{
    public int odysseus = 586189;
    public int penelope = 89476;
    public int circe = 826045;
    public int agamemnon = 953505;

    public long chainchomp = 9363381;
    public long boo = 318797453;
    public long goomba = 986552102;
    public long koopa = 39718005;

    public float air = 19.72629f;
    public float water = 90.35421f;
    public float earth = 7.89950f;
    public float fire = 5.18018f;

    public double war = 6.7004795382689;
    public double plague = 8.1308455948410;
    public double famine = 7.9069626829752;
    public double death = 2.5325641037225;



    // Start is called before the first frame update
    void Start()

    {
        Debug.Log("The starting number for addition is " + odysseus);
        odysseus = odysseus + penelope;
        Debug.Log("Added " + penelope + " to starting number, making the total " + odysseus);
        odysseus = odysseus + circe;
        Debug.Log("Added " + circe + " to the total, making the new total " + odysseus);
        odysseus = odysseus + agamemnon;
        Debug.Log("Added " + odysseus + " to the total, making the final addition total" + odysseus);

        Debug.Log("The starting number for subtraction is " + chainchomp);
        chainchomp = chainchomp - boo;
        Debug.Log("Subtracted " + boo + " from starting number, making the new total " +  chainchomp);
        chainchomp = chainchomp - goomba;
        Debug.Log("Subtracted " + goomba + " from the total, making the new total " + chainchomp);
        chainchomp = chainchomp - koopa;
        Debug.Log("Subtracted " + koopa + " from the total, making the final subtraction total " + chainchomp);

        Debug.Log("The starting number for multiplication is " + air);
        air = air * water;
        Debug.Log("Multiplied the starting number by " + water + " making the new total " + air);
        air = air * earth;
        Debug.Log("Multiplied the total by " + earth + " making the new total " + air);
        air = air * fire;
        Debug.Log("Multiplied the total by " + fire + " making the final multiplication total " + air);

        Debug.Log("The starting number for division is " + war);
        war = war / plague;
        Debug.Log("Divided the starting number by " + plague + " making the new total " + war);
        war = war / famine;
        Debug.Log("Divided the total by " + famine + " making the new total " + war);
        war = war / death;
        Debug.Log("Divided the total by " + death + " making the final division total " + war);
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
