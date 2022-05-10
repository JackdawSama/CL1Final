using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Text trySpell;
    public Text spellCast;
    public int spellRandomiser;
    float spellAccuracy;

    public Text points;
    public Text spellsCast;

    public GameObject invokerHero;
    public GameObject playAgain;

    Dictionary<int, string> spellBook = new Dictionary<int, string>();

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

        SpellBook();
    }
    // Start is called before the first frame update
    void Start()
    {
        playAgain.SetActive(false);                                                      //
        timerRunning = true;
        SpellRandomiser();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();

        if(remainingTime <= 0)
        {
            GameObject.DestroyImmediate(invokerHero);
            playAgain.SetActive(true);
        }

        points.text = invokerHero.GetComponent<SpellCast>().rightspellcastCounter.ToString();
        spellsCast.text = invokerHero.GetComponent<SpellCast>().spellCastCounter.ToString();
        
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

    void SpellBook()
    {
        spellBook.Add(1, "Cold Snap");
        spellBook.Add(2, "Ghost Walk");
        spellBook.Add(3, "Ice Wall");
        spellBook.Add(4, "EMP");
        spellBook.Add(5, "Tornado");
        spellBook.Add(6, "Alacrity");
        spellBook.Add(7, "Sun Strike");
        spellBook.Add(8, "Forge Spirit");
        spellBook.Add(9, "Chaos Meteor");
        spellBook.Add(10, "Deafening Blast");
    }

    public void SpellRandomiser()
    {
        spellRandomiser = Random.Range(1,10);
        trySpell.text = spellBook[spellRandomiser];
    }
}
