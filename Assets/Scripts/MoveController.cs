using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

[SerializeField] private Vector3 _direction;
[SerializeField] private float Speed = 3;
    [SerializeField] private float rotationSpeed = 180;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
        Vector3 rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);

        //Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
       

       _direction.x = Input.GetAxis("Horizontal");
   _direction.z = Input.GetAxis("Vertical");
    //Debug.Log(_direction);
}

void FixedUpdate()
{
    transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed; 
}
}
