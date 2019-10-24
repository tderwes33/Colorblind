using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    private GameObject hiddenObjs;

    private Transform red1;
    //private Transform red1Child;

    private Transform red2;
    //private Transform red2Child;

    private Transform blue1;
    //private Transform blue1Child;

    private Transform blue2;
    //private Transform blue2Child;


    // Start is called before the first frame update
    void Start()
    {
        hiddenObjs = GameObject.Find("HiddenObjects");

        red1 = hiddenObjs.transform.GetChild(0);
        red2 = hiddenObjs.transform.GetChild(1);
        blue1 = hiddenObjs.transform.GetChild(2);
        blue2 = hiddenObjs.transform.GetChild(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate(string name)
    {
        Debug.Log("Activate");
        if(name == "RedButton1")
        {
            red1.gameObject.SetActive(true);
            //red1Child = red1.transform.GetChild(0);
            //red1Child.gameObject.SetActive(true);
          
        }
        if(name == "RedButton2")
        {
            red2.gameObject.SetActive(true);
            //red2Child = red2.transform.GetChild(0);
            //red2.gameObject.SetActive(true);
        }
        if(name == "BlueButton1")
        {
            blue1.gameObject.SetActive(true);
            //blue1Child = blue1.transform.GetChild(0);
            //blue1.gameObject.SetActive(true);
        }
        if(name == "BlueButton2")
        {
            blue2.gameObject.SetActive(true);
            //blue2Child = blue2.transform.GetChild(0);
            //blue2Child.gameObject.SetActive(true);
        }
    } 

}
