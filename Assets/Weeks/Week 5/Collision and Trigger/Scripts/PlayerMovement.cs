using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed;


    // Update is called once per frame
    void Update()
    {
        MoveCool();
        //MoveBoring();
    }

    void MoveCool()
    {
        Vector3 direction = new Vector3(0, 0, 0);

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (direction.magnitude >= 0.1f)
        { 
            Move(direction);
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
        this.transform.position += direction * speed * Time.deltaTime;
    }
}
