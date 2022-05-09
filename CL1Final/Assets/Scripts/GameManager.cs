using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager FindInstance()                                                //singleton declaration
    {
        return instance;
    }

    public float remainingTime = 10;
    public bool timerRunning = false;
    public Text timerInfo;

    void Awake()
    {
        if (instance != null && instance != this)                                           //checking for a single instance of the Game Manager
        {
            Destroy(this);
        }
        else if (instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if(timerRunning)
        {
            if(remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else 
            {
                remainingTime = 0;
                timerRunning = false;
            }
        }
        DisplayTime(remainingTime);
    }

    void DisplayTime(float displayTime)
    {
        displayTime += 1;
        float minutes = Mathf.FloorToInt(displayTime/60);
        float seconds = Mathf.FloorToInt(displayTime%60);

        timerInfo.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
