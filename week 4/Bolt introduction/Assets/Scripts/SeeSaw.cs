using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeSaw : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 _angularSpeed;
    [SerializeField] private int _maxSlope;
    [SerializeField] bool invertir=true;
    [SerializeField] int tolerancia=15;

    
    void Start()
    {
        _angularSpeed.z = Random.Range(10, 20);
        _maxSlope = Random.Range(10, 30);
    }

    // Update is called once per frame
    void Update()
    {
        


        if (this.transform.rotation.eulerAngles.z > _maxSlope && this.transform.rotation.eulerAngles.z < (_maxSlope + tolerancia))
        {
            invertir = false;
           

        }
        else if (this.transform.rotation.eulerAngles.z < (360- _maxSlope ) && this.transform.rotation.eulerAngles.z > (360 - _maxSlope)- tolerancia)
        {
            invertir = true;
          
        }

        int symbolo = (invertir) ? 1 : -1;
         
        this.transform.Rotate(symbolo*_angularSpeed * Time.deltaTime);

       
    }
}
