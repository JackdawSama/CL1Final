using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    public SpriteRenderer orb1;
    public SpriteRenderer orb2;
    public SpriteRenderer orb3;
    private SpellCast spellcastref;

    // Start is called before the first frame update
    void Start()
    {
        spellcastref = GetComponent<SpellCast>();
        orb1 = GetComponent<SpriteRenderer>();
        orb2 = GetComponent<SpriteRenderer>();
        orb3 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(spellcastref.Spell.Count == 3)
        {
            if(spellcastref.Spell[0] == KeyCode.Q)
            {
                orb1.color = Color.blue;
            }
            else if(spellcastref.Spell[0] == KeyCode.W)
            {
                orb1.color = Color.magenta;
            }
            else if(spellcastref.Spell[0] == KeyCode.E)
            {
                orb1.color = Color.yellow;
            }
            else if(spellcastref.Spell[1] == KeyCode.Q)
            {
                orb2.color = Color.blue;
            }
            else if(spellcastref.Spell[1] == KeyCode.W)
            {
                orb2.color = Color.magenta;
            }
            else if(spellcastref.Spell[1] == KeyCode.E)
            {
                orb2.color = Color.yellow;
            }
            else if(spellcastref.Spell[2] == KeyCode.Q)
            {
                orb3.color = Color.blue;
            }
            else if(spellcastref.Spell[2] == KeyCode.W)
            {
                orb3.color = Color.magenta;
            }
            else if(spellcastref.Spell[2] == KeyCode.E)
            {
                orb3.color = Color.yellow;
            }
        }
    }
}
