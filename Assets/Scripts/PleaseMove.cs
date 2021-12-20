using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseMove : MonoBehaviour
{
    //public Joystick joystek;
    public float movement_Speed;
    CharacterController charCtrl;
    public static float xMove, zMove;
    //private Vector3 facDir;
    void Awake()
    {
        charCtrl = GetComponent<CharacterController>();
    }
    void Update()
    {
        playerMovmentControler();
        playerRotationControler();
    }
    // Update is called once per frame
    void playerMovmentControler()
    {
        xMove = Input.GetAxis("Horizontal");// + joystek.Horizontal;
        zMove = Input.GetAxis("Vertical");// + joystek.Vertical;
        float gravity = 9.8f;
        Vector3 moveAxis = new Vector3(xMove, -gravity, zMove);
        charCtrl.Move(((moveAxis) * movement_Speed * Time.deltaTime));
    }
    void playerRotationControler()
    {
        if (xMove > 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 2f * Time.deltaTime);
        else if (xMove < 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 2f * Time.deltaTime);
        if (zMove > 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 2f * Time.deltaTime);
        else if (zMove < 0)
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 2f * Time.deltaTime);
    }

}
/*public class PleaseMove : MonoBehaviour
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
}*/