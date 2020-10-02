using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColPlay : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddScore();
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
