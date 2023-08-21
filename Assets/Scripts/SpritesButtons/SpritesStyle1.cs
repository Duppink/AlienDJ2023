using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SpritesStyle1 : MonoBehaviour
{
    public GameManager gm;
    public InteractableButton ib;
    public Sprite styleOn;
    public Sprite styleOff;
    public Sprite buttonDisabled;

    
    void Update()
    {
        if (gm.style1 == true)
        {
            gameObject.GetComponent<Image>().sprite = styleOn;
            //gameObject.GetComponent<SpriteRenderer>().sprite = styleOn;
        }

        if (gm.style1 == false)
        {
            gameObject.GetComponent<Image>().sprite = styleOff;
            //gameObject.GetComponent<SpriteRenderer>().sprite = styleOff;
        }
        
        if (ib.enabledButton == false)
        {
            gameObject.GetComponent<Image>().sprite = buttonDisabled;
            //gameObject.GetComponent<SpriteRenderer>().sprite = buttonDisabled;
        }

    }
}
