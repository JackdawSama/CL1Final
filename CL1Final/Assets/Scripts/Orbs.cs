using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    public GameObject orb1;
    public GameObject orb2;
    public GameObject orb3;
    private SpellCast spellcastref;

    public Sprite quas;
    public Sprite wex;
    public Sprite exort;

    // Start is called before the first frame update
    void Start()
    {
        spellcastref = GetComponent<SpellCast>();
    }

    // Update is called once per frame
    void Update()
    {
        if(spellcastref.Spell.Count <= 3)
        {
            if(spellcastref.Spell[0] == KeyCode.Q)
            {
                orb1.GetComponent<SpriteRenderer>().sprite = quas;
            }
            else if(spellcastref.Spell[0] == KeyCode.W)
            {
                orb1.GetComponent<SpriteRenderer>().sprite = wex;
            }
            else if(spellcastref.Spell[0] == KeyCode.E)
            {
                orb1.GetComponent<SpriteRenderer>().sprite = exort;
            }
            if(spellcastref.Spell[1] == KeyCode.Q)
            {
                orb2.GetComponent<SpriteRenderer>().sprite = quas;
            }
            else if(spellcastref.Spell[1] == KeyCode.W)
            {
                orb2.GetComponent<SpriteRenderer>().sprite = wex;
            }
            else if(spellcastref.Spell[1] == KeyCode.E)
            {
                orb2.GetComponent<SpriteRenderer>().sprite = exort;
            }
            if(spellcastref.Spell[2] == KeyCode.Q)
            {
                orb3.GetComponent<SpriteRenderer>().sprite = quas;
            }
            else if(spellcastref.Spell[2] == KeyCode.W)
            {
                orb3.GetComponent<SpriteRenderer>().sprite = wex;
            }
            else if(spellcastref.Spell[2] == KeyCode.E)
            {
                orb3.GetComponent<SpriteRenderer>().sprite = exort;
            }
        }
    }
}
