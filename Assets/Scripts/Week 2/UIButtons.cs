using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    public Button splatbutton;
    public AudioSource splat;
    public Image lancer;
    

    // Start is called before the first frame update
    void Start()
    {
        splatbutton.onClick.AddListener(ButtonClick);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ButtonClick()
    {
        Debug.Log("Splat!");
        splat.Play();
        lancer.rectTransform.Rotate(new Vector3 (0f,180f,0f));
    }

    
}
