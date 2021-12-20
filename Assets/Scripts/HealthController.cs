using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
   

        [SerializeField] private float MaxHealthPoints;
        //[Range(0, 1f)] private float Range;
        [HideInInspector] public float CurrentHealth;

        // Start is called before the first frame update
        void Start()
        {
            CurrentHealth = MaxHealthPoints;
        /*if (gameObject.TryGetComponent<MoveController>(out var c))
        {
            //c.
        }*/
        }

        // Update is called once per frame
        void Update()
        {
            if (CurrentHealth <= 0)
            {
                Debug.Log("Player is dead");
            Time.timeScale = 0; 
                return;
            }
        }
}

