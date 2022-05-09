using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        public IEnumerator ColdSnap()
        {
            yield return null;
        }
        public IEnumerator GhostWalk()
        {
            yield return null;
        }
        public IEnumerator IceWall()
        {
            Instantiate(iceWall);
            yield return new WaitForSeconds(3);
            GameObject.Destroy(iceWall, 1);
        }
        public IEnumerator EMP()
        {
            Instantiate(emp);
            yield return new WaitForSeconds(2);
            GameObject.Destroy(emp);
        }
        public IEnumerator Tornado()
        {
            Instantiate(tornado);
            yield return new WaitForSeconds(3);
            GameObject.Destroy(tornado);
        }
        public IEnumerator Alacrity()
        {
            yield return null;
        }
        public IEnumerator SunStrike()
        {
            Instantiate(sunStrike);
            yield return new WaitForSeconds(1.5f);
            GameObject.Destroy(sunStrike);
        }
        public IEnumerator ForgeSpirit()
        {
            Instantiate(forgeSpirit);
            yield return new WaitForSeconds(5);
            GameObject.Destroy(forgeSpirit);
        }

        public IEnumerator ChaosMeteor()
        {
            Instantiate(chaosMeteor);
            yield return new WaitForSeconds(3);
            GameObject.Destroy(chaosMeteor);
        }

        public IEnumerator DeafeningBlast()
        {
            Instantiate(deafeningBlast);
            yield return new WaitForSeconds(3);
            GameObject.Destroy(deafeningBlast);
        }

    }
}
