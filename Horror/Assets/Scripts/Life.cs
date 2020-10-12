using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public float maxLife = 100;
    public float curLife;
    float lifeDrain = 1f;

    public Image lifeUI;

    // Start is called before the first frame update
    void Start()
    {
        curLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (curLife <= 0)
        {
            curLife = 0;
        }
        lifeUI.transform.localScale = new Vector3(
            curLife / maxLife,
            lifeUI.transform.localScale.y,
            lifeUI.transform.localScale.z
            );
        if (curLife <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    public void AddLife()
    {
        curLife = maxLife;
    }
}
