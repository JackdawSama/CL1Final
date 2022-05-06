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
            }
            else if(Input.GetKeyDown(KeyCode.W))
            {
                inputKey = KeyCode.W;
            }
            else if(Input.GetKeyDown(KeyCode.E))
            {
                inputKey = KeyCode.E;
            }
        }

        

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
        int code = (int) spellCode;

        switch(code)
        {
            case 300:
                //ColdSnap
                break;
            case 210:
                //GhostWalk
                break;
            case 201:
                //IceWall
                break;
            case 030:
                //emp
                break;
            case 120:
                //tornado
                break;
            case 021:
                //alacrity
                break;
            case 003:
                //SunStrike
                break;
            case 102:
                //ForgeSpirit
                break;
            case 012:
                //ChaosMeteor
                break;
            case 111:
                //DeafeningBlast
                break;
            
        }
    }
}
