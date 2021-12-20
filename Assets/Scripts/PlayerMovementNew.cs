using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovementNew : MonoBehaviour
{
    public CharacterController _controller;
    public float _speed = 10;
    public float _rotationSpeed = 180;

    private Vector3 rotation;

    public void Update()
    {
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        _controller.Move(move * _speed);
        this.transform.Rotate(this.rotation);
    }
}



/*public class PlayerMovementNew : MonoBehaviour
{
    public float Speed = 10;
     Rigidbody m_Rigidbody;
    private Vector3 _direction;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        Debug.Log(_direction);
    }

    void FixedUpdate()
    {
        transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed;
    }
}*/

