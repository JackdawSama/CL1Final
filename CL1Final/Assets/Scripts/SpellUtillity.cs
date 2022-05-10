using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///!!!***IMPORTANT NOTE***!!!

///The Spell Utility script is not being used but has been built for future functionality.
namespace SpellUtil
{
    public class SpellUtillity : MonoBehaviour
    {
        public GameObject iceWall;
        public GameObject emp;
        public GameObject tornado;
        public GameObject sunStrike;
        public GameObject forgeSpirit;
        public GameObject chaosMeteor;
        public GameObject deafeningBlast;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public static IEnumerator ColdSnap()
        {
            yield return null;
        }
        public static IEnumerator GhostWalk()
        {
            yield return null;
        }
        public static IEnumerator IceWall()
        {
            //Instantiate(iceWall);
            yield return null;
            //GameObject.Destroy(iceWall, 1);
        }
        public static IEnumerator EMP()
        {
            //Instantiate(emp);
            yield return null;
            //GameObject.Destroy(emp);
        }
        public static IEnumerator Tornado()
        {
            //Instantiate(tornado);
            yield return null;
            //GameObject.Destroy(tornado);
        }
        public static IEnumerator Alacrity()
        {
            yield return null;
        }
        public static IEnumerator SunStrike()
        {
            //Instantiate(sunStrike);
            yield return null;
            //GameObject.Destroy(sunStrike);
        }
        public static IEnumerator ForgeSpirit()
        {
            //Instantiate(forgeSpirit);
            yield return null;
            //GameObject.Destroy(forgeSpirit);
        }

        public static IEnumerator ChaosMeteor()
        {
            //Instantiate(chaosMeteor);
            yield return null;
            //GameObject.Destroy(chaosMeteor);
        }

        public static IEnumerator DeafeningBlast()
        {
            //Instantiate(deafeningBlast);
            yield return null;
            //GameObject.Destroy(deafeningBlast);
        }

    }
}
