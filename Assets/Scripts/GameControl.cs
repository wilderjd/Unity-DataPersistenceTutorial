using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public string playerName;
    private int highScore=0;
    public int HighScore{
        get{
            return highScore;
        }
        set{
            highScore = value;
        }
    }
    private string topName="";
    public string TopName{
        get{
            return topName;
        }
        set{
            topName = value;
        }
    }


    void Awake()
    {
        Load();
        if (control == null){
            DontDestroyOnLoad(gameObject);
            control = this;
            
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    public void setName(string name)
    {
        playerName = name;
    }

    
    public void Save()
    {

        PlayerPrefs.SetInt("highScore", highScore);

        PlayerPrefs.SetString("topName", topName);

        PlayerPrefs.Save();
    }

    public void Load()
    {
        highScore = PlayerPrefs.GetInt("highScore",0);

        topName = PlayerPrefs.GetString("topName","");

    }

    public void UpdateHighScore(int score)
    {
        if (score > highScore)
        {
            topName = playerName;
            highScore = score;
            Save();
        }
    }

    void OnDestroy()
    {
        Save();
    }

}
