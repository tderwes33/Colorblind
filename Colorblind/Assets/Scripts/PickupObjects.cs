using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    GameObject tutorialArea;
    FindKey keyTracker;
    // Start is called before the first frame update
    void Start()
    {
        tutorialArea = GameObject.Find("Room1");
        keyTracker = tutorialArea.GetComponent<FindKey>();
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log("ray is " + ray);
        if (Physics.Raycast(ray, out hit, 1))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.tag == "Pickup")
                {
                    Debug.Log("Can Pickup" + hit.transform.gameObject.name);
                    
                    GameObject item = hit.transform.gameObject;
                    item.SetActive(false);
                    keyTracker.keyName(item.name);

                } else if(hit.transform.tag == "Interactable")
                {
                    GameObject door = hit.transform.gameObject;
                    if(door.name == "redDoor" && keyTracker.gotRed() == true)
                    {
                        Debug.Log("Open red door");
                    } else if(door.name == "greenDoor" && keyTracker.gotGreen() == true)
                    {
                        Debug.Log("Open green door");
                    }
                }


            }
        }
    }
}
