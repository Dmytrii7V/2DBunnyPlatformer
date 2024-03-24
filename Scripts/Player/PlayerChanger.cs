//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerChanger : MonoBehaviour
//{
//    public GameObject bunny;
//    public GameObject pinkguy;
//    public GameObject maskguy;


//    private Vector3 charPosition;
//    private Vector3 charOutside;

//    private int charInt = 1;

//    private SpriteRenderer bunnyRen, pinkguyRen, maskguyRen;

//    //private readonly string charSelected = "charSelected";

//    void Awake()
//    {
//        charPosition = bunny.transform.position;
//        charOutside = pinkguy.transform.position;

//        bunnyRen = bunny.GetComponent<SpriteRenderer>();
//        pinkguyRen = pinkguy.GetComponent<SpriteRenderer>();
//        maskguyRen = maskguy.GetComponent<SpriteRenderer>();

//    }

//    public void Next()
//    {
//        switch (charInt)
//        {
//            case 1:
//                //PlayerPerfs.SetInt(charSelected, 1);
//                bunnyRen.enabled = false;
//                bunny.transform.position = charOutside;
//                pinkguy.transform.position = charPosition;
//                pinkguyRen.enabled = true;
//                charInt++;
//                break;
//            case 2:
//                //PlayerPerfs.SetInt(charSelected, 2);
//                pinkguyRen.enabled = false;
//                pinkguy.transform.position = charOutside;
//                maskguy.transform.position = charPosition;
//                maskguyRen.enabled = true;
//                charInt++;
//                break;
//            case 3:
//                //playerperfs.setint(charselected, 3);
//                maskguyRen.enabled = false;
//                maskguy.transform.position = charOutside;
//                bunny.transform.position = charPosition;
//                bunnyRen.enabled = true;
//                charInt++;
//                Loop();
//                break;
//            default:
//                    Loop();
//                break;
//        }


//    }

//    public void Previous()
//    {
//        switch (charInt)
//        {
//            case 1:
//                //PlayerPerfs.SetInt(charSelected, 2);
//                bunnyRen.enabled = false;
//                bunny.transform.position = charOutside;
//                maskguy.transform.position = charPosition;
//                maskguyRen.enabled = true;
//                charInt--;
//                Loop();
//                break;
//            case 2:
//                //PlayerPerfs.SetInt(charSelected, 3);
//                pinkguyRen.enabled = false;
//                pinkguy.transform.position = charOutside;
//                bunny.transform.position = charPosition;
//                bunnyRen.enabled = true;
//                charInt--;
//                break;
//            case 3:
//                //PlayerPerfs.SetInt(charSelected, 1);
//                maskguyRen.enabled = false;
//                maskguy.transform.position = charOutside;
//                pinkguy.transform.position = charPosition;
//                pinkguyRen.enabled = true;
//                charInt--;
//                break;
//            default:
//                Loop();
//                break;
//        }


//    }

//    public void Loop() 
//    {

//        if (charInt >= 3)
//        {
//            charInt = 1;
//        }
//        else
//        {
//            charInt = 3;
//        }
    
    
//    }

//}
