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

        SpellBook();                                                                        //calls the SpellBook function to initialise the Dictionary when the program starts
    }
    // Start is called before the first frame update
    void Start()
    {
        playAgain.SetActive(false);                                                                 //disables the Play Again button
        timerRunning = true;                                                                        //sets the timer to start running
        SpellRandomiser();                                                                          //Calls the Spell Randomiser function to randomise spells
    }

    // Update is called once per frame
    void Update()
    {
        Timer();                                                                                    //starts the timer for the game

        if(remainingTime <= 0)
        {
            GameObject.DestroyImmediate(invokerHero);                                               //when timer hits zero destroys the Player Object
            playAgain.SetActive(true);                                                              //when timer hits zero enables the play again button
        }

        points.text = invokerHero.GetComponent<SpellCast>().rightspellcastCounter.ToString();       //Updates the points for the UI by referencing the correct spells cast by the player from the Game Manager
        spellsCast.text = invokerHero.GetComponent<SpellCast>().spellCastCounter.ToString();        //Updates the total number of spells cast by the player from the the Game Manager
        
    }

    void Timer()
    {
        if(timerRunning)
        {
            if(remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;                                                    //reduces the timer variable by Time.deltaTIme
            }
            else 
            {
                remainingTime = 0;                                                                  //sets the timer to zero so that it doesn't go to negative values
                timerRunning = false;
            }
        }
        DisplayTime(remainingTime);                                                                 //function to update and display time to the player through the UI
    }

    void DisplayTime(float displayTime)
    {
        displayTime += 1;                                                                           //to create the placebo for the player that they're starting on dot instead of losing a few milliseconds
        float minutes = Mathf.FloorToInt(displayTime/60);                                           //to calculate the minutes
        float seconds = Mathf.FloorToInt(displayTime%60);                                           //to calculate the seconds

        timerInfo.text = string.Format("{0:00} : {1:00}", minutes, seconds);                        //Time:Seconds formatting for the timer
    }

    void SpellBook()                                                                                //function to add information to the Dictionary Spell Book
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

    public void SpellRandomiser()                                                                   //Randomiser function to randomise the spells given to the player
    {
        spellRandomiser = Random.Range(1,10);                                                       //randomises the key value of the dictionary to access spells between from 1 - 10 with both min and max values included
        trySpell.text = spellBook[spellRandomiser];                                                 //updates the spell which the player should attempt to cast
    }
}
