using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    public SpriteRenderer quas;
    public SpriteRenderer wex;
    public SpriteRenderer exort;
    private SpellCast spellcastref;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spellcastref.Spell[0] == KeyCode.Q)
        {
            quas.color = Color.blue;
        }
        if(spellcastref.Spell[1] == KeyCode.W)
        {
            wex.color = Color.magenta;
        }
        if(spellcastref.Spell[2] == KeyCode.E)
        {
            exort.color = Color.yellow;
        }
    }
}
