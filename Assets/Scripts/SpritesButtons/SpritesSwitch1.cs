using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SpritesSwitch1 : MonoBehaviour
{
    public GameManager gm;
    public InteractableButton ib;

    public Sprite upOn;
    public Sprite downOn;
    public Sprite neutral;

    public Sprite buttonDisabled;
    

    // Update is called once per frame
    void Update()
    {
        // Sprites Switches

        if (gm.lightsValue3 == 5)
        {
            gameObject.GetComponent<Image>().sprite = upOn;
        }

        if (gm.lightsValue3 == 6)
        {
            gameObject.GetComponent<Image>().sprite = downOn;
        }

        if (gm.lightsValue3 == 0)
        {
            gameObject.GetComponent<Image>().sprite = neutral;
        }


        if (ib.enabledButton == false)
        {
            gameObject.GetComponent<Image>().sprite = buttonDisabled;
        }
       
    }
}
