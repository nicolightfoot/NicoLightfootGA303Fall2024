using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLights : MonoBehaviour
{
    public Light lightSource;

   

    private bool isLightColor = false;

    public Color originalColor;
    public Color colorChange1;
    public Color colorChange2;

    

    // Start is called before the first frame update
    void Start()
    {
        lightSource = GetComponent<Light>();
        lightSource.color = Color.white;

        originalColor = Color.white;
        colorChange1 = Color.magenta;
        colorChange2 = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LightSwitch()
    {
        
        lightSource.enabled = !lightSource.enabled;
    }

    public void ColorSwitchOdd()
    {
        if (lightSource.enabled == true)
        {
            if (isLightColor == false)
            {
                lightSource.color = colorChange1;
                isLightColor = true;
                Debug.Log("Toggled magenta color on!");
            }

            else if (isLightColor == true)
            {
                lightSource.color = originalColor;
                isLightColor = false;
                Debug.Log("Toggled magenta color off!");
            }
        }
        
    }

    public void ColorSwitchEven()
    {
        if (lightSource.enabled == true)
        {
            if (isLightColor == false)
            {
                lightSource.color = colorChange2;
                isLightColor = true;
                Debug.Log("Toggled cyan color on!");
            }

            else if (isLightColor == true)
            {
                lightSource.color = originalColor;
                isLightColor = false;
                Debug.Log("Toggled cyan color off!");
            }
        }

    }

    
}
