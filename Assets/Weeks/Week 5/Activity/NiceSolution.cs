using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiceSolution : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cylinder;

    private void OnDrawGizmos()
    {
        Vector3 cubePosition = cube.transform.position;
        Vector3 spherePosition = sphere.transform.position;
        Vector3 cylinderPosition = cylinder.transform.position;

        float l1 = Vector3.Distance(cubePosition, spherePosition);
        float l2 = Vector3.Distance(cubePosition, cylinderPosition);
        float l3 = Vector3.Distance(spherePosition, cylinderPosition);

        float minimumNumber = FindMinimumNumber(l1, l2, l3);
        if (minimumNumber == l1)
        {
            SetMaterial(cylinder, Color.red);

            SetMaterial(cube, Color.green);
            SetMaterial(sphere, Color.green);

        }
        else if(minimumNumber == l2)
        {
            SetMaterial(sphere, Color.red);

            SetMaterial(cube, Color.green);
            SetMaterial(cylinder, Color.green);
        }
        else 
        {
            SetMaterial(cube, Color.red);

            SetMaterial(cylinder, Color.green);
            SetMaterial(sphere, Color.green); ;
        }
    }

     void SetMaterial(GameObject go, Color color)
    {
        go.GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    float  FindMinimumNumber(float a,float b, float c)
    {
        if (a < b && a < c)
        {
            return a;

        }
        else if (b < a && b < c)
        {
            return b;
        }
        return c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
