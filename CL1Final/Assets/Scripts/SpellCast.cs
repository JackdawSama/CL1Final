using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCast : MonoBehaviour
{
    char[] Spell;

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
        
    }

    private void castSpell()
    {
        Vector3 spellCounter = new Vector3(0, 0, 0);

        if(Input.GetKeyDown(KeyCode.R))
        {
            for(int i = 0; i < Spell.Length; i++)
            {
                if(Spell[i] == 'Q')
                {
                    spellCounter.x += 1; 
                }
                else if(Spell[i] == 'W')
                {
                    spellCounter.y += 1;
                }
                else if(Spell[i] == 'E')
                {
                    spellCounter.z += 1;
                }
            }

            float spellCode = 100 * spellCounter.x + 10 * spellCounter.y + spellCounter.z;

            int code = (int) spellCode;

            switch(code)
            {
                case coldSnap:
                    //triggeranimation?
                    break;
                
            }
        }
    }
}
