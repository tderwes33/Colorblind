using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMod : MonoBehaviour
{
    private Transform hitButton;
    private GameObject hitButtonHighlight;
    private bool enter = false;
    private bool exit = false;

    // Start is called before the first frame update
    void Start()
    {
        hitButton = this.transform;
        hitButtonHighlight = hitButton.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (enter == true)
        {
            print("??????");
            hitButtonHighlight.SetActive(true);
            print(hitButtonHighlight.activeSelf);
        }

        if (exit == true)
        {
            hitButtonHighlight.SetActive(false);
        }
        /*else if(exit >= 1)
        {
            exit += 1;
        }*/
    }

   /* private void OnMouseOver()
    {
        enter = true;
        exit = false;
        Debug.Log("Enter " + hitButtonHighlight + " " + hitButtonHighlight.activeSelf);


    }

    private void OnMouseExit()
    {
        enter = false;
        exit = true;
    }*/

    public void Highlight()
    {
        if (hitButtonHighlight.activeSelf == false)
        {
            hitButtonHighlight.SetActive(true);
        }
        
    }

    public void NoHightlight()
    {
        if (hitButtonHighlight.activeSelf == true)
        {
            hitButtonHighlight.SetActive(false);
        }
    }

}
