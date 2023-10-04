using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class IntroductionController : MonoBehaviour
{
    public float currentPage;
    public float currentDrawings;
    public GameSceneManager gsm;
    
    [Header("Drawings")]
    public GameObject drawing01;
    public GameObject drawing02;
    public GameObject drawingtext01;
    public GameObject drawing03;
    public GameObject drawing04;
    public GameObject drawing05;
    public GameObject drawing06;
    public GameObject drawing07;
    public GameObject drawing08;
    public GameObject drawing09;
    public GameObject drawing10;
    public GameObject drawing11;
    public GameObject drawing12;
    public GameObject drawing13;
    public GameObject drawing14;
    public GameObject drawing15;
    public GameObject drawing16;
    //public GameObject drawing17;
    public GameObject drawing18;
    public GameObject drawing19;
    public GameObject drawing20;
    public GameObject drawing21;
    public GameObject drawing22;
    public GameObject drawing23;
    public GameObject drawing24;
    public GameObject drawing25;
    public GameObject drawing26;
    public GameObject drawing27;
    public GameObject drawing28;
    public GameObject drawing29;
    public GameObject drawing30;
    public GameObject drawing31;
    public GameObject drawing32;
    public GameObject drawing33;

    /*
    [Header("Texts")]
    public GameObject introText01;
    public GameObject introText02;
    public GameObject introText03;
    public GameObject introText04;
    public GameObject introText05;
    public GameObject introText06;
    public GameObject introText07;
    public GameObject introText08;
    public GameObject introText09;
    public GameObject introText10;
    public GameObject introText11;
    public GameObject introText12;
    public GameObject introText13;
    public GameObject introText14;
    public GameObject introText15;
    public GameObject introText16;

    */

    private float timer1;
    private float timer2;
    private float timerDrawingtext01;
    private float timer3;
    private float timer4;
    private float timer5;        
    private float timer6;
    private float timer7;
    private float timer8;
    private float timer9;
    private float timer10;
    private float timer11;
    private float timer12;
    private float timer13;
    private float timer14;
    private float timer15;
    private float timer16;
    //private float timer17;
    private float timer18;
    private float timer19;
    private float timer20;
    private float timer21;
    private float timer22;
    private float timer23;
    private float timer24;
    private float timer25;
    private float timer26;
    private float timer27;
    private float timer28;
    private float timer29;
    private float timer30;
    private float timer31;
    private float timer32;
    private float timer33;


    private void Update()
    {
        //Fade In Drawing01
        if (timer1 < 1 && drawing01.activeInHierarchy)
        {
            timer1 += 1 * Time.deltaTime;
            drawing01.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer1);
            
        }

        //Fade In Drawing02
        if (timer2 < 1 && drawing02.activeInHierarchy)
        {
            timer2 += 1 * Time.deltaTime;
            drawing02.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer2);

        }

        //Fade In Drawingtext01
        if (timerDrawingtext01 < 1 && drawingtext01.activeInHierarchy)
        {
            timerDrawingtext01 += 1 * Time.deltaTime;
            drawingtext01.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timerDrawingtext01);

        }

        //Fade In Drawingtext03
        if (timer3 < 1 && drawing03.activeInHierarchy)
        {
            timer3 += 1 * Time.deltaTime;
            drawing03.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer3);

        }




    }


    public void ChangeDrawing ()
    {
    
        if(currentDrawings == 0)
        {              
            drawing01.SetActive(true);            
            currentDrawings = 1;
            return;
        }
        if(currentDrawings == 1)
        {
            drawing02.SetActive(true);
            currentDrawings = 1.5f;
            return;
        }
        
        if(currentDrawings == 1.5f)
        {
            drawingtext01.SetActive(true);
            currentDrawings = 2;
            return;
        }

        if(currentDrawings == 2)
        {
            drawing03.SetActive(true);
            currentDrawings = 3;
            return;
        }
        if(currentDrawings == 3)
        {
            drawing04.SetActive(true);
            currentDrawings = 4;
            return;
        }
        if(currentDrawings == 4)
        {
            drawing05.SetActive(true);
            currentDrawings = 5;
            return;
        }
        if(currentDrawings == 5)
        {
            drawing06.SetActive(true);
            currentDrawings = 6;
            return;
        }
        if(currentDrawings == 6)
        {
            drawing07.SetActive(true);
            currentDrawings = 7;
            return;
        }
        if(currentDrawings == 7)
        {
            drawing08.SetActive(true);
            currentDrawings = 8;
            return;
        }
        if(currentDrawings == 8)
        {
            drawing09.SetActive(true);
            currentDrawings = 9;
            return;
        }
        if(currentDrawings == 9)
        {
            drawing10.SetActive(true);
            currentDrawings = 10;
            return;
        }
        if(currentDrawings == 10)
        {
            drawing11.SetActive(true);
            currentDrawings = 11;
            return;
        }
        if(currentDrawings == 11)
        {
            drawing12.SetActive(true);
            currentDrawings = 12;
            return;
        }
        if(currentDrawings == 12)
        {
            drawing13.SetActive(true);
            currentDrawings = 13;
            return;
        }
        if(currentDrawings == 13)
        {
            drawing14.SetActive(true);
            currentDrawings = 14;
            return;
        }
        if(currentDrawings == 14)
        {
            drawing15.SetActive(true);
            currentDrawings = 15;
            return;
        }
        if(currentDrawings == 15)
        {
            drawing16.SetActive(true);
            currentDrawings = 17;
            return;
        }
        /*if(currentDrawings == 16)
        {
            drawing17.SetActive(true);
            currentDrawings = 17;
            return;
        }*/
        if(currentDrawings == 17)
        {
            drawing18.SetActive(true);
            currentDrawings = 18;
            return;
        }
        if(currentDrawings == 18)
        {
            drawing19.SetActive(true);
            currentDrawings = 19;
            return;
        }
        if(currentDrawings == 19)
        {
            drawing20.SetActive(true);
            currentDrawings = 20;
            return;
        }
        if(currentDrawings == 20)
        {
            drawing21.SetActive(true);
            currentDrawings = 21;
            return;
        }
        if(currentDrawings == 21)
        {
            drawing22.SetActive(true);
            currentDrawings = 22;
            return;
        }
        if(currentDrawings == 22)
        {
            drawing23.SetActive(true);
            currentDrawings = 23;
            return;
        }
        if(currentDrawings == 23)
        {
            drawing24.SetActive(true);
            currentDrawings = 24;
            return;
        }
        if(currentDrawings == 24)
        {
            drawing25.SetActive(true);
            currentDrawings = 25;
            return;
        }
        if(currentDrawings == 25)
        {
            drawing26.SetActive(true);
            currentDrawings = 26;
            return;
        }
        if(currentDrawings == 26)
        {
            drawing27.SetActive(true);
            currentDrawings = 27;
            return;
        }
        if(currentDrawings == 27)
        {
            drawing28.SetActive(true);
            currentDrawings = 28;
            return;
        }
        if(currentDrawings == 28)
        {
            drawing29.SetActive(true);
            currentDrawings = 29;
            return;
        }
        if(currentDrawings == 29)
        {
            drawing30.SetActive(true);
            currentDrawings = 30;
            return;
        }
        if(currentDrawings == 30)
        {
            drawing31.SetActive(true);
            currentDrawings = 31;
            return;
        }
        if(currentDrawings == 31)
        {
            drawing32.SetActive(true);
            currentDrawings = 32;
            return;
        }
        if(currentDrawings == 32)
        {
            drawing33.SetActive(true);
            currentDrawings = 33;
            return;
        }
        if(currentDrawings == 33)
        {
            gsm.GoToBriefing();
            return;
        }

    }

       
            
       
    
}
