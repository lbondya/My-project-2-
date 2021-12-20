using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private DoorType Door;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var pc = other.GetComponent<PlayerController>();
            //hc.CurrentHealth -= Damage;
            pc.GiveKey(Door);
            //Destroy(gameObject); 


        }


    }
}
