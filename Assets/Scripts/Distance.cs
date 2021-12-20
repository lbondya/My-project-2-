using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private Transform O1;
    [SerializeField] private Transform O2;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float Speed;

    private GameObject _bulletGO;
    private float d=0;
    // Start is called before the first frame update
    void Start()
    {
        _bulletGO = Instantiate(bullet, O1.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        /*var distance = Vector3.Distance(O1.position, O2.position);
        //var distance = (O2.position - O1.position).magnitude;
        var dotProduct = Vector3.Dot(O1.position, O2.position);
        // векторное произведение
        var cross = Vector3.Cross(O1.position, O2.position);*/

        var direction = O2.position - O1.position;

        //O1.position += Vector3.up; 
        //_bulletGO.transform.Translate(O1.forward * Time.deltaTime * Speed);


        //transform.forward

        //O1.Translate(Vector3.up * Speed); // Vector3.up - вектор с единичным значением по оси У

        //_bulletGO.transform.position = Vector3.MoveTowards(_bulletGO.transform.position, O2.position, Speed * Time.deltaTime);4
        d += 0.02f;
        _bulletGO.transform.position = Vector3.Lerp(O1.position, O2.position, d);

    }
}
