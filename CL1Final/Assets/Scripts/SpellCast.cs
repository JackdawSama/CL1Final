using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCast : MonoBehaviour
{
    public List<KeyCode> Spell;
    KeyCode inputKey;
    Vector3 spellCounter = new Vector3(0, 0, 0);

    enum Spellbook
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
        QuasWexExort();
    }

    private void castSpell()
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

        float spellCode = 100 * spellCounter.x + 10 * spellCounter.y + spellCounter.z;
        Debug.Log(spellCode);
        int code = (int) spellCode;

        switch(code)
        {
            case 300:
                //ColdSnap
                //spell completed indicator
                Debug.Log("Cold Snap");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 210:
                //GhostWalk
                //spell completed indicator
                Debug.Log("Ghost Walk");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 201:
                //IceWall
                //spell completed indicator
                Debug.Log("Ice Wall");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 030:
                //emp
                //spell completed indicator
                Debug.Log("EMP");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 120:
                //tornado
                //spell completed indicator
                Debug.Log("Tornado");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 021:
                //alacrity
                //spell completed indicator
                Debug.Log("Alacrity");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 003:
                //SunStrike
                //spell completed indicator
                Debug.Log("Sun Strike");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 102:
                //ForgeSpirit
                //spell completed indicator
                Debug.Log("Forge Spirit");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 012:
                //ChaosMeteor
                //spell completed indicator
                Debug.Log("Chaos Meteor");
                spellCounter = new Vector3(0, 0, 0);
                break;
            case 111:
                //DeafeningBlast
                //spell completed indicator
                Debug.Log("Defeaning Blast");
                spellCounter = new Vector3(0, 0, 0);
                break;
            
        }
    }

    private void QuasWexExort()
    {
        if(Spell.Count != 3)
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
        else 
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
            castSpell();
        }
    }

    private void QuasWexExortSwitch()
    {
        Spell[0] = Spell[1];
        Spell[1] = Spell[2];
        Spell[2] = inputKey;
    }
}
