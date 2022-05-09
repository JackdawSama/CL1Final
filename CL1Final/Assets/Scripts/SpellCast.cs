using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellUtil;

public class SpellCast : MonoBehaviour
{
    public List<KeyCode> Spell;
    KeyCode inputKey;
    Vector3 spellCounter = new Vector3(0, 0, 0);

    enum Spellbook                                                                              //enum to store the list of spell combinations available
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

        float spellCode = 100 * spellCounter.x + 10 * spellCounter.y + spellCounter.z;      //converts the counter information into a float
        //Debug.Log(spellCode);
        int code = (int) spellCode;                                                         //converts the float into a integer for Switch statement parsing

        switch(code)
        {
            case 300:
                //ColdSnap
                //spell completed indicator
                Debug.Log("Cold Snap");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 210:
                //GhostWalk
                //spell completed indicator
                Debug.Log("Ghost Walk");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 201:
                //IceWall
                //spell completed indicator
                Debug.Log("Ice Wall");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 030:
                //emp
                //spell completed indicator
                Debug.Log("EMP");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 120:
                //tornado
                //spell completed indicator
                Debug.Log("Tornado");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 021:
                //alacrity
                //spell completed indicator
                Debug.Log("Alacrity");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 003:
                //SunStrike
                //spell completed indicator
                Debug.Log("Sun Strike");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 102:
                //ForgeSpirit
                //spell completed indicator
                Debug.Log("Forge Spirit");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 012:
                //ChaosMeteor
                //spell completed indicator
                Debug.Log("Chaos Meteor");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            case 111:
                //DeafeningBlast
                //spell completed indicator
                Debug.Log("Defeaning Blast");
                spellCounter = new Vector3(0, 0, 0);                                        //resets the spell counter to 0 after spell is cast
                break;
            
        }
    }
}
