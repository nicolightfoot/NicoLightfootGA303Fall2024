using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLights : MonoBehaviour
{
    private Light lightSource;

    private bool isLightOn = false; 
    

    // Start is called before the first frame update
    void Start()
    {
        lightSource = GetComponent<Light>();
        lightSource.enabled = isLightOn;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LightSwitch()
    {
        isLightOn = !isLightOn;
        lightSource.enabled = isLightOn;
    }

    public void ColorSwitchOdd()
    {
        if (isLightOn == true)
        {
            lightSource.color = Color.magenta;
        }
    }

    public void ColorSwitchEven()
    {
        if (isLightOn == true)
        {
            lightSource.color = Color.cyan;
        }
    }
}
