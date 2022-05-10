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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        QuasWexExort();                                                                     //function to check for spell input and cast spells
        // Debug.Log("You cast " + spellCastCounter + " spell(s)");
    }

    private void QuasWexExort()
    {
        if(Spell.Count < 3)                                                                //checks the lenght of the list and if it is less than 3 it adds an item of type Keycode
        {
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
            if(Input.GetKeyDown(KeyCode.Q))
            {
                inputKey = KeyCode.Q;
                QuasWexExortSwitch();
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
        if(Input.GetKeyDown(KeyCode.R))
        {
            invokeSpell();
        }
    }

    private void QuasWexExortSwitch()                                                       //moves the 3rd item in the list to the 2nd, the 2nd to the 1st and new input to the 3rd
    {
        Spell[0] = Spell[1];                                                                //stores the item in the 2nd in the 1st
        Spell[1] = Spell[2];                                                                //stores the item in the 3rd in the 2nd
        Spell[2] = inputKey;                                                                //stores the new input in the 3rd
    }

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
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Cold Snap";

                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 1)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(coldSnap, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 210:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Ghost Walk";
                
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 2)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(ghostWalk, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 201:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Ice Wall";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 3)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(iceWall, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 030:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast EMP";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 4)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(emp, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 120:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Tornado";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 5)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(tornado, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 021:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Alacrity";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 6)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(alacrity, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 003:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Sun Strike";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 7)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(sunStrike, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 102:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Forge Spirit";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 8)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(forgeSpirit, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 012:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Chaos Meteor";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 9)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(chaosMeteor, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            case 111:
                gameManagerRef.GetComponent<GameManager>().spellCast.text = "You cast Deafening Blast";
                if(gameManagerRef.GetComponent<GameManager>().spellRandomiser == 10)
                {
                    rightspellcastCounter++;
                    audioSource.PlayOneShot(deafeningBlast, 0.5f);
                    Debug.Log("Spell Count " + rightspellcastCounter);
                    gameManagerRef.GetComponent<GameManager>().SpellRandomiser();
                }
                spellCounter = new Vector3(0, 0, 0);                                                    //resets the spell counter to 0 after spell is cast
                Debug.Log("You cast " + spellCastCounter + " spell(s)");
                break;
            
        }

    }
}
