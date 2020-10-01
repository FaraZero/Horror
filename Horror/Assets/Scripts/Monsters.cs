using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Monsters : MonoBehaviour
{
    NavMeshAgent navigator;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        navigator = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        navigator.destination = player.transform.position;
    }
}
