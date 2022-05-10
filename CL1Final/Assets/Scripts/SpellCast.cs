using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellUtil;

public class SpellCast : MonoBehaviour
{
    public List<KeyCode> Spell;
    KeyCode inputKey;
    Vector3 spellCounter = new Vector3(0, 0, 0);
    public int spellCastCounter = 0;
    public int rightspellcastCounter = 0;

    public GameObject gameManagerRef;

    public AudioSource audioSource;
    public AudioClip coldSnap;
    public AudioClip ghostWalk;
    public AudioClip iceWall;
    public AudioClip emp;
    public AudioClip tornado;
    public AudioClip alacrity;
    public AudioClip sunStrike;
    public AudioClip forgeSpirit;
    public AudioClip chaosMeteor;
    public AudioClip deafeningBlast;

    enum SpellBook                                                                              //enum to store the list of spell combinations available
    {
        coldSnap = 300,
        ghostWalk = 210,
        iceWall = 201,
        emp = 030,
        tornado = 120,
        alacrity = 021,
        sunStrike = 003,
        forgeSpirit = 102,
        chaosMeteor = 012,
        deafeningBlast = 111
    }

    // Update is called once per frame
    void Update()
    {
        QuasWexExort();                                                                     //function to check for spell input and cast spells
    }

    private void QuasWexExort()
    {
        if(Spell.Count < 3)                                                                //checks the lenght of the list and if it is less than 3 it adds an item of type Keycode
        {
            //if Q, W or E is pressed an element is added to the list
            if(Input.GetKeyDown(KeyCode.Q))
            {
                Spell.Add(KeyCode.Q);
            }
            else if(Input.GetKeyDown(KeyCode.W))
            {
                Spell.Add(KeyCode.W);
            }
            else if(Input.GetKeyDown(KeyCode.E))
            {
                Spell.Add(KeyCode.E);
            }
        }
        else                                                                                //if the list hits 3 then instead of adding more to the list it alters the list treating the list as a queue
        {
            //checks if the key pressed is either Q,W or E and captures the input from the player and alters the list
            if(Input.GetKeyDown(KeyCode.Q))
            {
                inputKey = KeyCode.Q;                                                       //captures the input from the player and stores it in a variable
                QuasWexExortSwitch();                                                       //the function QuasWexExortSwitch treats the list like a queue by popping the first element of the list and moving the 2nd to the 1st, the 3rd to the 2nd and adds the new input to the 3rd
            }
            else if(Input.GetKeyDown(KeyCode.W))
            {
                inputKey = KeyCode.W;
                QuasWexExortSwitch();
            }
            else if(Input.GetKeyDown(KeyCode.E))
            {
                inputKey = KeyCode.E;
                QuasWexExortSwitch();
            }
        }
        if(Input.GetKeyDown(KeyCode.R))                                                     //checks if R has been pressed by the player
        {
            invokeSpell();                                                                  //if R has been pressed by the player, the function invokeSpell is called
        }
    }

    private void QuasWexExortSwitch()                                                       //moves the 3rd item in the list to the 2nd, the 2nd to the 1st and new input to the 3rd
    {
        Spell[0] = Spell[1];                                                                //stores the item in the 2nd in the 1st
        Spell[1] = Spell[2];                                                                //stores the item in the 3rd in the 2nd
        Spell[2] = inputKey;                                                                //stores the new input in the 3rd
    }

    //Understanding how the invokeSpell's parsing works
    //The keys Q,W and E have a total of 10 combinations which are treated as the spells.
    //For each spell there are multiple permutations possible, i.e in the case of Deafening Blast(Q,W,E), the possible permutations are QWE, QEW, EQW, EWQ, WEQ and WQE.
    //using an if-elseif statement for each permutaion within a spell would lead to if-elseif statements exceeding 25. This would make the running of the program slower as parsing if-elseif statements are slow.
    //By parsing the list and having a counter variable to count each time the key(Q,W or E) appears it is easy to reduce the total number of if-else statements used.     
    private void invokeSpell()                                                              //function to parse through the list and register the key combination in the list when a spell is cast
    {
        for(int i = 0; i < Spell.Count; i++)
        {
            if(Spell[i] == KeyCode.Q)
            {
                spellCounter.x += 1; 
            }
            else if(Spell[i] == KeyCode.W)
            {
                spellCounter.y += 1;
            }
            else if(Spell[i] == KeyCode.E)
            {
                spellCounter.z += 1;
            }
        }

        float spellCode = 100 * spellCounter.x + 10 * spellCounter.y + spellCounter.z;                  //converts the counter information into a float
        int spellParse = (int) spellCode;                                                               //converts the float into a integer for Switch statement parsing

        spellCastCounter++;

        switch(spellParse)
        {
            case 300:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Cold Snap";       //updates the spell that has been cast

                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 1)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(coldSnap, 0.5f);                                            //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 210:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Ghost Walk";      //updates the spell that has been cast
                
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 2)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(ghostWalk, 0.5f);                                           //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 201:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Ice Wall";        //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 3)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(iceWall, 0.5f);                                             //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 030:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast EMP";             //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 4)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(emp, 0.5f);                                                 //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 120:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Tornado";         //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 5)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(tornado, 0.5f);                                             //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 021:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Alacrity";        //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 6)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(alacrity, 0.5f);                                            //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 003:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Sun Strike";      //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 7)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(sunStrike, 0.5f);                                           //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 102:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Forge Spirit";    //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 8)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(forgeSpirit, 0.5f);                                         //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 012:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Chaos Meteor";    //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 9)                     //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(chaosMeteor, 0.5f);                                         //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            case 111:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Deafening Blast"; //updates the spell that has been cast
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 10)                    //checks if the right spell has been cast
                {
                    rightspellcastCounter++;                                                            //increments the counter to track player points
                    audioSource.PlayOneShot(deafeningBlast, 0.5f);                                      //plays audio for player feedback
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();                       //access the randomiser in the Game Manager to give the player the next spell to cast
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                break;
            
        }

    }
}
