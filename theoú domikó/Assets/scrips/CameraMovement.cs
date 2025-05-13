using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform targer;


     void Start()
    {
        
    }



     void Update()
    {
         transform.position = new Vector3(targer.transform.position.x, targer.transform.position.y, transform.position.z);
    }
    private void FixedUpdate()
    {

        transform.position = new Vector3(targer.transform.position.x, targer.transform.position.y, transform.position.z);
        //Vector3 Oposition = targer.position + positioncamera;
        //Vector3 Sposition = Vector3.Lerp(transform.position, Oposition, speed * Time.deltaTime);

        //transform.position = Sposition;
    }
}
