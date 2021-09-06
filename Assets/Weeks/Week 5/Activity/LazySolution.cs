using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazySolution : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cylinder;
    
    

    string FarObjectCube()
    {
        Vector3 cubePosition = cube.transform.position;
        Vector3 spherePosition = sphere.transform.position;
        Vector3 cylinderPosition = cylinder.transform.position;

        float c1 = Vector3.Distance(cubePosition, spherePosition);
        float c2 = Vector3.Distance(cubePosition, cylinderPosition);

        if (c1 > c2)
        {
            return "sphere";
        }
        else
        {
            return "cylinder";
        }
    }

    string FarObjectCylinder()
    {
        Vector3 cubePosition = cube.transform.position;
        Vector3 spherePosition = sphere.transform.position;
        Vector3 cylinderPosition = cylinder.transform.position;

        float c1 = Vector3.Distance(cylinderPosition, cubePosition);
        float c2 = Vector3.Distance(cylinderPosition, spherePosition);

        if (c1 > c2)
        {
            return "cube";
        }
        else
        {
            return "sphere";
        }
    }

    string FarObjectSphere()
    {
        Vector3 cubePosition = cube.transform.position;
        Vector3 spherePosition = sphere.transform.position;
        Vector3 cylinderPosition = cylinder.transform.position;

        float c1 = Vector3.Distance(spherePosition, cubePosition);
        float c2 = Vector3.Distance(spherePosition, cylinderPosition);

        if (c1 > c2)
        {
            return "cube";
        }
        else
        {
            return "cylinder";
        }
    }
    void OnDrawGizmos()
    {
        string farObejctCube = FarObjectCube();
        string farObejctCylinder = FarObjectCylinder();
        string farObejctSphere = FarObjectSphere();

        if (farObejctCube == farObejctCylinder)
        {
            //print("La esfera es la mas lejana");
            sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            cylinder.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
        else if (farObejctCube == farObejctSphere)
        {
            //print("La esfera es la mas lejana");
            cylinder.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

            sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
        else
        {
            cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

            sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            cylinder.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }

        



    }

    

    
}
