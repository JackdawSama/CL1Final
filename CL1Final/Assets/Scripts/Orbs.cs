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
        if(spellcastref.Spell.Count <= 3)                                       //checks if the size of the queue is less than 3
        {
            if(spellcastref.Spell[0] == KeyCode.Q)                              //checks if Q has been pressed
            {
                orb1.GetComponent<SpriteRenderer>().sprite = quas;              //in case of Q being true it switches the sprite to Quas for Orb 1
            }
            else if(spellcastref.Spell[0] == KeyCode.W)                         //checks if W has been pressed
            {
                orb1.GetComponent<SpriteRenderer>().sprite = wex;               //in case of W being true it switches the sprite to Wex for Orb 1
            }
            else if(spellcastref.Spell[0] == KeyCode.E)                         //checks if E has been pressed
            {
                orb1.GetComponent<SpriteRenderer>().sprite = exort;             //in case of E being true it switches the sprite to Exort for Orb 1
            }
            if(spellcastref.Spell[1] == KeyCode.Q)                              //checks if Q has been pressed
            {
                orb2.GetComponent<SpriteRenderer>().sprite = quas;              //in case of Q being true it switches the sprite to Quas for Orb 2
            }
            else if(spellcastref.Spell[1] == KeyCode.W)                         //checks if W has been pressed
            {
                orb2.GetComponent<SpriteRenderer>().sprite = wex;               //in case of W being true it switches the sprite to Wex for Orb 2
            }
            else if(spellcastref.Spell[1] == KeyCode.E)                         //checks if E has been pressed
            {
                orb2.GetComponent<SpriteRenderer>().sprite = exort;             //in case of E being true it switches the sprite to Wex for Orb 2
            }
            if(spellcastref.Spell[2] == KeyCode.Q)                              //checks if Q has been pressed
            {
                orb3.GetComponent<SpriteRenderer>().sprite = quas;              //in case of Q being true it switches the sprite to Quas for Orb 3
            }
            else if(spellcastref.Spell[2] == KeyCode.W)                         //checks if W has been pressed
            {
                orb3.GetComponent<SpriteRenderer>().sprite = wex;               //in case of W being true it switches the sprite to Wex for Orb 3
            }
            else if(spellcastref.Spell[2] == KeyCode.E)                         //checks if E has been pressed
            {
                orb3.GetComponent<SpriteRenderer>().sprite = exort;             //in case of E being true it switches the sprite to Exort for Orb 3
            }
        }
    }
}
