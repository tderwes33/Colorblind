using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    private GameObject buttonObjects;
    private HiddenObjActivate buttonActive;
    private string buttonName;

    private GameObject[] allOutlines;

    private void Awake()
    {
        allOutlines = GameObject.FindGameObjectsWithTag("Highlight");
    }
    // Start is called before the first frame update
    void Start()
    {
        buttonObjects = GameObject.Find("HiddenObjects");
        buttonActive = buttonObjects.GetComponent<HiddenObjActivate>();
        for (int i = 0; i < allOutlines.Length; i++)
        {
            if (allOutlines[i].gameObject.activeSelf == true)
            {
                allOutlines[i].gameObject.SetActive(false);
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log("ray is " + ray);
        if(Physics.Raycast(ray, out hit))
        {           
            if(hit.transform.tag == "Button")
            {
                //HighlightButton(hit.transform);
                
                    if (Input.GetMouseButtonDown(0))
                    {
                       Debug.Log("Hit" + hit.transform.gameObject.name);
                       buttonName = hit.transform.gameObject.name;
                   
                       buttonActive.Activate(buttonName);
                   }
                
                
            }

           /* if (hit.transform.tag != "Button")
            {
                UnHighlightButton();
            }
            */

        }

    }

    public void HighlightButton(Transform button)
    {
        Transform highlighter = button.GetChild(0);
        if(highlighter.gameObject.activeSelf == false)
        {
            highlighter.gameObject.SetActive(true);
        }

    }

    public void UnHighlightButton()
    {
       for(int i = 0; i < allOutlines.Length; i++)
        {
            if(allOutlines[i].gameObject.activeSelf == true)
            {
                allOutlines[i].gameObject.SetActive(false);
            }
        }
    }
}
