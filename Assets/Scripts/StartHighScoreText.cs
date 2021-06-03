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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
