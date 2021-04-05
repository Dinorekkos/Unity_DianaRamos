using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubikCreator : MonoBehaviour
{
    
    CubeCreator cubeCreatorScript;
    
    [SerializeField] GameObject rubikCube;
    [SerializeField] GameObject cubeRed;
    [SerializeField] GameObject cubeBlue;
    [SerializeField] GameObject cubeGreen;

    [SerializeField] GameObject[] cubesArray;

    void Start()
    {
        for (int z = 0; z < 3; z++)
        {
            for (int y = 0; y < 3; y++)
            {  
                 cubeCreatorScript = new CubeCreator();
                 Instantiate(cubeRed);
                 cubeRed.transform.position = new Vector3(0,y,z);
                
                for (int columBlue = 0; columBlue < 1; columBlue++)
                {
                    cubeCreatorScript = new CubeCreator();
                    Instantiate(cubeBlue);
                    cubeBlue.transform.position = new Vector3(1,y,z);
                } 
                for (int columGreen = 0; columGreen < 1; columGreen++)
                {
                    cubeCreatorScript = new CubeCreator();
                    Instantiate(cubeGreen);
                    cubeGreen.transform.position = new Vector3(-1,y,z);
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
