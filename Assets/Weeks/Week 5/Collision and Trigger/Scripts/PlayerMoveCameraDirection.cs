using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveCameraDirection : MonoBehaviour
{
    [Range(1,10)] [SerializeField] private float speed;
    [Range(1,10)] [SerializeField] private float angularSpeed;
    [SerializeField] private Transform pivoteY;
    [SerializeField] private Transform player_GPX;

    private float targetAngle;
    

 

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }
    void Rotate()
    {
        //Smooth way
        player_GPX.rotation = Quaternion.Lerp(a:player_GPX.rotation, 
                                              b:Quaternion.Euler(0, targetAngle, 0), 
                                              t:angularSpeed * Time.deltaTime);
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
             Move(pivoteY.forward);
            CalculateTargetAngle(pivoteY.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(-pivoteY.right);
            CalculateTargetAngle(-pivoteY.right);

        }
        if (Input.GetKey(KeyCode.D))
        {
           Move(pivoteY.right);
            CalculateTargetAngle(pivoteY.right);

        }
        if (Input.GetKey(KeyCode.S))
        {
          Move(-pivoteY.forward);
           CalculateTargetAngle(-pivoteY.forward);

        }
    }

    void Move(Vector3 direction)
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    void CalculateTargetAngle(Vector3 direction)
    {
        
        targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

        //Direct way
      //  player_GPX.rotation = Quaternion.Euler(0,targetAngle,0);
    }
}
