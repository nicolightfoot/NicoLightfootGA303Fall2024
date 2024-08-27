using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DatatypePractice : MonoBehaviour
{
    public int num1; //int is 4 bytes
    public int num2;

    public long num3; //long is 8 bytes

    public uint num4; //int is 4 bytes, only positive range
    public ulong num5; //int is 8 bytes, only positive range

    //DECIMALS
    public float num6 = 3.14f; //stores decimal numbers up to 6-7 digits
    public double num7 = 3.14159265f;

    //TRUE OR FALSE
    public bool isProgrammingHard = true;


    //DATA SIZES
    //1 byte = 8 bits;
    //1024 bytes = 1 kilobyte
    //1024 kilobytes = 1 megabyte
    //1024 megabyte = 1 gigabyte
    //1024 gigabyte = 1 terabyte

    //300Mbps This is not 300 Mbps - this is 300 Megabits per second


    //TEXT VARIABLES
    public char charizard = 'a';
    public char blastoise = 'b';
    public char venasaur = 'c';

    public string monsters = "Pokemon are cool, but so is Undertale" +
        " and I just wanted to say that";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The starting number for num1 is: " + num1);
        num1 = num1 + 1;
        Debug.Log("The end number for num1 afer adding 1 is: " + num1);
        Debug.Log(monsters);
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log
    }
}
