using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4 : MonoBehaviour
{
    public List<AllLights> lights = new List<AllLights>();

    public int currentLight = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(lights.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ToggleCurrentLight();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            IncreaseLightNumber();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            DecreaseLightNumber();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ToggleAllLights();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleLightColor();
        }
    }

    public void ToggleCurrentLight()
    {
        lights[currentLight].LightSwitch();
    }

    public void IncreaseLightNumber()
    {
        if (currentLight < lights.Count - 1)
        {
            currentLight++;
        }
    }

    public void DecreaseLightNumber()
    {
        if (currentLight > 0)
        {
            currentLight--;
        }
    }

    public void ToggleAllLights()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            lights[i].LightSwitch();

            Debug.Log("Toggled light " + i);
        }

        Debug.Log("Toggled all lights");

    }

    public void ToggleLightColor()
    {
        for (int i = 0; i < lights.Count; i++)
        {
            if (i % 2 == 1)
            {
                lights[i].ColorSwitchOdd();
                Debug.Log("Changed light color at index " + i);
            }

            else if (i % 2 == 0)
            {
                lights[i].ColorSwitchEven();
                Debug.Log("Changed light color at index " + i);

            }
        }
    }

}
