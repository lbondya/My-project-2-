using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private DoorType Door;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var pc = other.GetComponent<PlayerController>();
            //hc.CurrentHealth -= Damage;
            if (pc.HasKey(Door))
            {
                //Open();
                Destroy(gameObject);
            }
            //Destroy(gameObject); 
        }
    }

    private void Open()
    {

    }
}
