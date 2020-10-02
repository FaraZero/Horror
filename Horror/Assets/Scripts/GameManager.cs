using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public void AddScore()
    {
        score += 1;
        scoreText.text = "coins - "+ score.ToString();

        if (score >= 30)
        {
            SceneManager.LoadScene("Win");
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
