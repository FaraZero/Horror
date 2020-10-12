using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLife : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseMedBox()
    {
        player.GetComponentInChildren<Life>().AddLife();
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
