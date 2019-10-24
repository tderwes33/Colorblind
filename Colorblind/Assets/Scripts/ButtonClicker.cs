using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    private GameObject buttonObjects;
    private ButtonActivate buttonActive;
    private string buttonName;
    // Start is called before the first frame update
    void Start()
    {
        buttonObjects = GameObject.Find("HiddenObjects");
        buttonActive = buttonObjects.GetComponent<ButtonActivate>();
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log("ray is " + ray);
        if(Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(hit.transform.tag == "Button")
                {
                   Debug.Log("Hit" + hit.transform.gameObject.name);
                   buttonName = hit.transform.gameObject.name;

                   buttonActive.Activate(buttonName);
                }
                
                
            }
        }
    }

}
