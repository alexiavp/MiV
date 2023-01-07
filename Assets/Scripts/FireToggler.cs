using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireToggler : MonoBehaviour
{
    // Public variable that stores the state of the fire
    public bool isOn = true;

    // Function that is called when the player clicks on the fire particle
    public void ToggleFire()
    {
        // Set the value of isOn to the opposite of its current value
        isOn = !isOn;
    }

    void Update()
    {
        // Check the value of isOn
        if (isOn)
        {
            // If isOn is true, make the fire particle visible
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            // If isOn is false, make the fire particle invisible
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}

