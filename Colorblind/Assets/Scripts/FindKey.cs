using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindKey : MonoBehaviour
{
    bool redKey = false;
    bool greenKey = false;
    bool blueKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void keyName(string key)
    {
        if(key == "redKey")
        {
            redKey = true;
        } else if(key == "greenKey")
        {
            greenKey = true;
        }
        else
        {
            blueKey = true;
        }
    }

    public bool gotGreen()
    {
        return greenKey;
    }

    public bool gotRed()
    {
       return redKey;
    }

    public bool gotBlue()
    {
        return blueKey;
    }
}
