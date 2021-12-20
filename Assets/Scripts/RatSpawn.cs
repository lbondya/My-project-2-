using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawn : MonoBehaviour
{
  
        public int Number;
        public Transform Position;
        public GameObject Rat;

        void Start()
        {
            var g01 = Instantiate(Rat, Position.position, Quaternion.identity);
        }
    }

