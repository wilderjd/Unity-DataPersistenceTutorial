using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartHighScoreText : MonoBehaviour
{

    public Text HighScoreText;

    void Start()
    {
        HighScoreText.text = $"Top Score: {GameControl.control.TopName}: {GameControl.control.HighScore}"; 
        Debug.Log("Trying to print top score");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
