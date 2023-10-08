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
    public GameObject drawing17;
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
    private float timer17;
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
    public float timerControllerOfVignett;


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

        //Fade In Drawingtext04
        if (timer4 < 1 && drawing04.activeInHierarchy)
        {
            timer4 += 1 * Time.deltaTime;
            drawing04.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer4);
        }

        //Fade In Drawingtext05
        if (timer5 < 1 && drawing05.activeInHierarchy)
        {
            timer5 += 1 * Time.deltaTime;
            drawing05.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer5);
        }

        //Fade In Drawingtext06
        if (timer6 < 1 && drawing06.activeInHierarchy)
        {
            timer6 += 1 * Time.deltaTime;
            drawing06.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer6);
        }

        //Fade In Drawingtext07
        if (timer7 < 1 && drawing07.activeInHierarchy)
        {
            timer7 += 1 * Time.deltaTime;
            drawing07.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer7);
        }

        //Fade In Drawingtext08
        if (timer8 < 1 && drawing08.activeInHierarchy)
        {
            timer8 += 1 * Time.deltaTime;
            drawing08.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer8);
        }

        //Fade In Drawingtext09
        if (timer9 < 1 && drawing09.activeInHierarchy)
        {
            timer9 += 1 * Time.deltaTime;
            drawing09.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer9);
        }

        //Fade In Drawingtext10
        if (timer10 < 1 && drawing10.activeInHierarchy)
        {
            timer10 += 1 * Time.deltaTime;
            drawing10.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer10);
        }

        //Fade In Drawingtext11
        if (timer11 < 1 && drawing11.activeInHierarchy)
        {
            timer11 += 1 * Time.deltaTime;
            drawing11.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer11);
        }

        //Fade In Drawingtext12
        if (timer12 < 1 && drawing12.activeInHierarchy)
        {
            timer12 += 1 * Time.deltaTime;
            drawing12.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer12);
        }

        //Fade In Drawingtext13
        if (timer13 < 1 && drawing13.activeInHierarchy)
        {
            timer13 += 1 * Time.deltaTime;
            drawing13.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer13);
        }

        //Fade In Drawingtext14
        if (timer14 < 1 && drawing14.activeInHierarchy)
        {
            timer14 += 1 * Time.deltaTime;
            drawing14.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer14);
        }

        //Fade In Drawingtext15
        if (timer15 < 1 && drawing15.activeInHierarchy)
        {
            timer15 += 1 * Time.deltaTime;
            drawing15.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer15);
        }

        //Fade In Drawingtext16
        if (timer16 < 1 && drawing16.activeInHierarchy)
        {
            timer16 += 1 * Time.deltaTime;
            drawing16.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer16);
        }

        //Fade In Drawingtext17
        if (timer17 < 1 && drawing17.activeInHierarchy)
        {
            timer17 += 1 * Time.deltaTime;
            drawing17.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer17);
        }

        //Fade In Drawingtext18
        if (timer18 < 1 && drawing18.activeInHierarchy)
        {
            timer18 += 1 * Time.deltaTime;
            drawing18.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer18);
        }

        //Fade In Drawingtext19
        if (timer19 < 1 && drawing19.activeInHierarchy)
        {
            timer19 += 1 * Time.deltaTime;
            drawing19.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer19);
        }

        //Fade In Drawingtext20
        if (timer20 < 1 && drawing20.activeInHierarchy)
        {
            timer20 += 1 * Time.deltaTime;
            drawing20.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer20);
        }

        //Fade In Drawingtext21
        if (timer21 < 1 && drawing21.activeInHierarchy)
        {
            timer21 += 1 * Time.deltaTime;
            drawing21.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer21);
        }

        //Fade In Drawingtext22
        if (timer22 < 1 && drawing22.activeInHierarchy)
        {
            timer22 += 1 * Time.deltaTime;
            drawing22.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer22);
        }

        //Fade In Drawingtext23
        if (timer23 < 1 && drawing23.activeInHierarchy)
        {
            timer23 += 1 * Time.deltaTime;
            drawing23.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer23);
        }

        //Fade In Drawingtext24
        if (timer24 < 1 && drawing24.activeInHierarchy)
        {
            timer24 += 1 * Time.deltaTime;
            drawing24.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer24);
        }

        //Fade In Drawingtext25
        if (timer25 < 1 && drawing25.activeInHierarchy)
        {
            timer25 += 1 * Time.deltaTime;
            drawing25.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer25);
        }

        //Fade In Drawingtext26
        if (timer26 < 1 && drawing26.activeInHierarchy)
        {
            timer26 += 1 * Time.deltaTime;
            drawing26.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer26);
        }

        //Fade In Drawingtext27
        if (timer27 < 1 && drawing27.activeInHierarchy)
        {
            timer27 += 1 * Time.deltaTime;
            drawing27.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer27);
        }

        //Fade In Drawingtext28
        if (timer28 < 1 && drawing28.activeInHierarchy)
        {
            timer28 += 1 * Time.deltaTime;
            drawing28.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer28);
        }

        //Fade In Drawingtext29
        if (timer29 < 1 && drawing29.activeInHierarchy)
        {
            timer29 += 1 * Time.deltaTime;
            drawing29.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer29);
        }

        //Fade In Drawingtext30
        if (timer30 < 1 && drawing30.activeInHierarchy)
        {
            timer30 += 1 * Time.deltaTime;
            drawing30.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer30);
        }

        //Fade In Drawingtext31
        if (timer31 < 1 && drawing31.activeInHierarchy)
        {
            timer31 += 1 * Time.deltaTime;
            drawing31.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer31);
        }

        //Fade In Drawingtext32
        if (timer32 < 1 && drawing32.activeInHierarchy)
        {
            timer32 += 1 * Time.deltaTime;
            drawing32.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer32);
        }

        //Fade In Drawingtext33
        if (timer33 < 1 && drawing33.activeInHierarchy)
        {
            timer33 += 1 * Time.deltaTime;
            drawing33.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, timer33);
        }

        if (timerControllerOfVignett >= 0)
        {
            timerControllerOfVignett += 1 * Time.deltaTime;
        }

        if (timerControllerOfVignett >= 0)
        {
            ChangeDrawing();
        }
        

    }


    public void ChangeDrawing ()
    {
    
        if ((currentDrawings == 0) && (timerControllerOfVignett >= 0))
        {              
            drawing01.SetActive(true);            
            currentDrawings = 1;
            return;
        }
        
        if((currentDrawings == 1) && (timerControllerOfVignett >= 1))        
        {
            drawing02.SetActive(true);
            currentDrawings = 1.5f;
            return;
        }

        if ((currentDrawings == 1.5) && (timerControllerOfVignett >= 2))
        {
            drawingtext01.SetActive(true);
            currentDrawings = 2;
            return;
        }

        if ((currentDrawings == 2) && (timerControllerOfVignett >= 3))
        {
            drawing03.SetActive(true);
            currentDrawings = 3;
            return;
        }

        if ((currentDrawings == 3) && (timerControllerOfVignett >= 4))
        {
            drawing04.SetActive(true);
            currentDrawings = 4;
            return;
        }

        if ((currentDrawings == 4) && (timerControllerOfVignett >= 5))
        {
            drawing05.SetActive(true);
            currentDrawings = 5;
            return;
        }

        if ((currentDrawings == 5) && (timerControllerOfVignett >= 6)) 
        {
            drawing06.SetActive(true);
            currentDrawings = 6;
            return;
        }

        if ((currentDrawings == 6) && (timerControllerOfVignett >= 7))
        {
            drawing07.SetActive(true);
            currentDrawings = 7;
            return;
        }

        if ((currentDrawings == 7) && (timerControllerOfVignett >= 8))
        {
            drawing08.SetActive(true);
            currentDrawings = 8;
            return;
        }

        if ((currentDrawings == 8) && (timerControllerOfVignett >= 9))
        {
            drawing09.SetActive(true);
            currentDrawings = 9;
            return;
        }

        if ((currentDrawings == 9) && (timerControllerOfVignett >= 10))
        {
            drawing10.SetActive(true);
            currentDrawings = 10;
            return;
        }

        if ((currentDrawings == 10) && (timerControllerOfVignett >= 11))
        {
            drawing11.SetActive(true);
            currentDrawings = 11;
            return;
        }

        if ((currentDrawings == 11) && (timerControllerOfVignett >= 12))
        {
            drawing12.SetActive(true);
            currentDrawings = 12;
            return;
        }

        if ((currentDrawings == 12) && (timerControllerOfVignett >= 13))
        {
            drawing13.SetActive(true);
            currentDrawings = 13;
            return;
        }

        if ((currentDrawings == 13) && (timerControllerOfVignett >= 14))
        {
            drawing14.SetActive(true);
            currentDrawings = 14;
            return;
        }

        if ((currentDrawings == 14) && (timerControllerOfVignett >= 15))
        {
            drawing15.SetActive(true);
            currentDrawings = 15;
            return;
        }

        if ((currentDrawings == 15) && (timerControllerOfVignett >= 16))
        {
            drawing16.SetActive(true);
            currentDrawings = 16;
            return;
        }

        if ((currentDrawings == 16) && (timerControllerOfVignett >= 17))
        {
            drawing17.SetActive(true);
            currentDrawings = 17;
            return;
        }

        if ((currentDrawings == 17) && (timerControllerOfVignett >= 17))
        {
            drawing18.SetActive(true);
            currentDrawings = 18;
            return;
        }

        if ((currentDrawings == 18) && (timerControllerOfVignett >= 18))
        {
            drawing19.SetActive(true);
            currentDrawings = 19;
            return;
        }

        if ((currentDrawings == 19) && (timerControllerOfVignett >= 19))
        {
            drawing20.SetActive(true);
            currentDrawings = 20;
            return;
        }

        if ((currentDrawings == 20) && (timerControllerOfVignett >= 20))
        {
            drawing21.SetActive(true);
            currentDrawings = 21;
            return;
        }

        if ((currentDrawings == 21) && (timerControllerOfVignett >= 21))
        {
            drawing22.SetActive(true);
            currentDrawings = 22;
            return;
        }

        if ((currentDrawings == 22) && (timerControllerOfVignett >= 22))
        {
            drawing23.SetActive(true);
            currentDrawings = 23;
            return;
        }

        if ((currentDrawings == 23) && (timerControllerOfVignett >= 23))
        {
            drawing24.SetActive(true);
            currentDrawings = 24;
            return;
        }

        if ((currentDrawings == 24) && (timerControllerOfVignett >= 24))
        {
            drawing25.SetActive(true);
            currentDrawings = 25;
            return;
        }

        if ((currentDrawings == 25) && (timerControllerOfVignett >= 25))
        {
            drawing26.SetActive(true);
            currentDrawings = 26;
            return;
        }

        if ((currentDrawings == 26) && (timerControllerOfVignett >= 26))
        {
            drawing27.SetActive(true);
            currentDrawings = 27;
            return;
        }

        if ((currentDrawings == 27) && (timerControllerOfVignett >= 27))
        {
            drawing28.SetActive(true);
            currentDrawings = 28;
            return;
        }

        if ((currentDrawings == 28) && (timerControllerOfVignett >= 28))
        {
            drawing29.SetActive(true);
            currentDrawings = 29;
            return;
        }

        if ((currentDrawings == 29) && (timerControllerOfVignett >= 29))
        {
            drawing30.SetActive(true);
            currentDrawings = 30;
            return;
        }

        if ((currentDrawings == 30) && (timerControllerOfVignett >= 30))
        {
            drawing31.SetActive(true);
            currentDrawings = 31;
            return;
        }

        if ((currentDrawings == 31) && (timerControllerOfVignett >= 31))
        {
            drawing32.SetActive(true);
            currentDrawings = 32;
            return;
        }

        if ((currentDrawings == 32) && (timerControllerOfVignett >= 32))
        {
            drawing33.SetActive(true);
            currentDrawings = 33;
            return;
        }

        if ((currentDrawings == 33) && (timerControllerOfVignett >= 35))
        {
            gsm.GoToBriefing();
            return;
        }

    }

       
            
       
    
}
