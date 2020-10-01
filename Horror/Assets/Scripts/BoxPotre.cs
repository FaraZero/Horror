using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPotre : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseBox()
    {
        player.GetComponentInChildren<Potre>().AddPotre();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
