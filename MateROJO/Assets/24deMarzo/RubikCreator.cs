using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubikCreator : MonoBehaviour
{

    
    [SerializeField] GameObject rubikCube;
    [SerializeField] GameObject cubeRed;
    [SerializeField] GameObject[] cubesArray;

    void Start()
    {
        for (int z = 0; z < 3; z++)
        {
            for (int y = 0; y < 3; y++)
            {  
                for (int x = 0; x < 3; x++)
                {
                    Instantiate(cubeRed);
                    cubeRed.transform.position = new Vector3(x,y,z);
                }   
            }
        }

        FindCubes();
    }

    void FindCubes()
    {
        cubesArray = GameObject.FindGameObjectsWithTag("newCube");
        for(int i = 0; i < cubesArray.Length; i++)
        {
            cubesArray[i].gameObject.transform.parent = rubikCube.transform;
        }
        
    }


}
