using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform trAxisX;
    [SerializeField] private Transform trAxisY;
    [Range(1,100)] [SerializeField] private float angularSpeedX;
    [Range(1,100)] [SerializeField] private float angularSpeedY;


    // Update is called once per frame
    void Update()
    {

        Vector3 directionY = Vector3.up * Input.GetAxis("Mouse X");
        Vector3 directionX = Vector3.right * Input.GetAxis("Mouse Y");

    

        trAxisY.Rotate(angularSpeedY * Time.deltaTime * directionY);
        trAxisX.Rotate(angularSpeedX * Time.deltaTime * directionX);



    }

}
