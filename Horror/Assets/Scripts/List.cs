using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public Image mapIcon;

    
    // Start is called before the first frame update
    void Start()
    {
        if (mapIcon != null)
            mapIcon.enabled = false;
    }
    
    public void MapActive()
    {
        if (mapIcon != null)
            mapIcon.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
