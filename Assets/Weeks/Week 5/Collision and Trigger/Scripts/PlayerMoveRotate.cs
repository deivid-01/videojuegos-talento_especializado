using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveRotate : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed;

    void Update()
    {
        MoveAndRotateCool();
        //MoveBoring();
    }

    void MoveAndRotateCool()
    {
      
        Vector3 direction = new Vector3(x: Input.GetAxis("Horizontal"),
                                        y: 0,
                                        z: Input.GetAxis("Vertical"));

        if (direction.magnitude >= 0.1f)
        {
            Move(direction);
            Rotate(direction);

        }

        
       
    }
    void MoveBoring()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
    }
    void Move(Vector3 direction)
    {
        this.transform.position = this.transform.position + direction * speed * Time.deltaTime;
    }

    void Rotate(Vector3 direction)
    {
        float targetAngle = Mathf.Atan2(direction.x , direction.z)*Mathf.Rad2Deg;
      
        transform.rotation = Quaternion.Euler(0, targetAngle, 0);
       
    }
}
