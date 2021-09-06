using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementFirstPerson : MonoBehaviour
{
    [Range(1, 100)] [SerializeField] private float angularSpeedX;
    [Range(1, 100)] [SerializeField] private float angularSpeedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionY = Vector3.up * Input.GetAxis("Mouse X");
        Vector3 directionX = -Vector3.right * Input.GetAxis("Mouse Y");

        if (directionX.magnitude > 0 && directionY.magnitude > 0)
        {
            this.transform.Rotate(angularSpeedY * Time.deltaTime * directionY);
            this.transform.Rotate(angularSpeedX * Time.deltaTime * directionX);
        }

        

    }
}
