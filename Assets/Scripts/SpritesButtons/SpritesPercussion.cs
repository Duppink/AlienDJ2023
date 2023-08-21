using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class SpritesPercussion : MonoBehaviour
{
    public GameManager gm;

    /*public Sprite perc1;
    public Sprite perc2;
    public Sprite perc3;
    public Sprite perc4;*/

    public Sprite percOn;
    public Sprite percOff;
    public InteractableButton ib;
    public Button p1;
    public Button p2;
    public Button p3;
    public Button p4;

    // Update is called once per frame
    void Update()
    {
        // Sprites Percussion

        if (gm.percussionSelected == 4)
        {
            p4.GetComponent<Image>().sprite = percOn;
        }

        else
        {
            p4.GetComponent<Image>().sprite = percOff;
        }

        if (gm.percussionSelected == 3)
        {
            p3.GetComponent<Image>().sprite = percOn;
        }

        else
        {
            p3.GetComponent<Image>().sprite = percOff;
        }

        if (gm.percussionSelected == 2)
        {
            p2.GetComponent<Image>().sprite = percOn;
        }

        else
        {
            p2.GetComponent<Image>().sprite = percOff;
        }

        if (gm.percussionSelected == 1)
        {
            p1.GetComponent<Image>().sprite = percOn;
        }

        else
        {
            p1.GetComponent<Image>().sprite = percOff;
        }

        

        

        


        /* if (gm.percussionSelected == 1)
         {
             gameObject.GetComponent<SpriteRenderer>().sprite = perc1;
         }

         if (gm.percussionSelected == 2)
         {
             gameObject.GetComponent<SpriteRenderer>().sprite = perc2;
         }

         if (gm.percussionSelected == 3)
         {
             gameObject.GetComponent<SpriteRenderer>().sprite = perc3;
         }

         if (gm.percussionSelected == 4)
         {
             gameObject.GetComponent<SpriteRenderer>().sprite = perc4;
         }*/
    }


}
