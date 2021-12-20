using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private float DamageAdditional;
    [SerializeField] private float TimeC;

    public float _currentTimeIn;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.tag == "Player")
        {
            var hc = other.GetComponent<HealthController>();
            //hc.CurrentHealth -= Damage;
            //hc.CurrentHealth -= Damage;
            Debug.Log(hc.CurrentHealth);
            //Destroy(gameObject); 


        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && other.tag == "Player")
        {
            _currentTimeIn += Time.deltaTime;
            if (_currentTimeIn >= TimeC)
            {
                var hc = other.GetComponent<HealthController>();
                hc.CurrentHealth -= DamageAdditional;
                Debug.Log(hc.CurrentHealth);
                _currentTimeIn = 0;
                //Destroy(gameObject); 
            }


        }

        
    }

     void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _currentTimeIn += Time.deltaTime;
            if (_currentTimeIn >= TimeC)
            {
                _currentTimeIn = 0;
                //Destroy(gameObject); 
            }


        }

    }
}
