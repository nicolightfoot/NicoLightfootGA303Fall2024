using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4 : MonoBehaviour
{
    public List<AllLights> lights = new List<AllLights>();

    public int currentLight = 0;

    public AudioSource mettaton1;
    public AudioSource mettaton2;
    private bool hasPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(lights.Count);
        mettaton1.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ToggleCurrentLight();
            
            if (hasPlayed == false)
            {
              mettaton2.Play();
              hasPlayed = true;
            }
            
            

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

        if (Input.GetKeyDown(KeyCode.Y))
        {
            LightsOff();
        }


        
    }

    public void ToggleCurrentLight()
    {
        lights[currentLight].LightSwitch();
        Debug.Log("Toggled this light");
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
        if (currentLight % 2 == 1)
        {
            lights[currentLight].ColorSwitchOdd();

        }

        if (currentLight % 2 == 0)
        {
            lights[currentLight].ColorSwitchEven();

          
        }
    }


    public void LightsOff()
    {
        foreach (AllLights allLight in lights)
        {
            if (allLight.lightSource.enabled == true)
            {
                allLight.lightSource.enabled = false;
                Debug.Log("Nighty-night!");
            }
        }
    }
}
