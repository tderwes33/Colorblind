using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log("ray is " + ray);
        if (Physics.Raycast(ray, out hit, .05f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.tag == "Pickup")
                {
                    Debug.Log("Can Pickup" + hit.transform.gameObject.name);
                    
                    GameObject button = hit.transform.gameObject;

                }


            }
        }
    }
}
