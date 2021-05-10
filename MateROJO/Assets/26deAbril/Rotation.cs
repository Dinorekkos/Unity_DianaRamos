using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public enum AXIS{X,Y,Z}
    public AXIS axis;

    public enum MATRIZ{X,Y,Z}
    public MATRIZ matriz;
    Vector3 inicialPos;

    private float [,] xMatrix;
    private float [,] yMatrix;
    private float [,] zMatrix;
    
   

    [SerializeField] GameObject cube;
    [SerializeField] int angle;
    [SerializeField] int delta;

    private void Start()     
    {
         inicialPos = cube.transform.position;

           xMatrix = new float[4,4]
        {
            {1,0,0,0},
            {0,Mathf.Cos(angle), Mathf.Sin(-(angle)),0},
            {0,Mathf.Sin(angle),Mathf.Cos(angle),0},
            {0,0,0,1}

        };
           yMatrix = new float [4,4]
        {
            {Mathf.Cos(angle),0,Mathf.Sin(angle),0},
            {0,1,0,0},
            {-Mathf.Sin(angle),0,Mathf.Cos(angle),0},
            {0,0,0,1}
        };
          zMatrix= new float[4,4] 
        {
            {Mathf.Cos(angle),-Mathf.Sin(angle),0,0},
            {Mathf.Sin(angle),Mathf.Cos(angle),0,0},
            {0,0,1,0},
            {0,0,0,1}
        }; 

        
    }

    void Update () 
    {
        //Formula
        if (Input.GetKeyDown(KeyCode.A))
        {
            axis = AXIS.X;
            RotateFormula(axis);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            axis = AXIS.Y;
            RotateFormula(axis);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            axis = AXIS.Z;
            RotateFormula(axis);
        } 


        //Matrices
        if(Input.GetKeyDown(KeyCode.Z))
        {
            
            matriz = MATRIZ.X;
            RotateMatrix(matriz);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            matriz = MATRIZ.Y;
            RotateMatrix(matriz);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            matriz = MATRIZ.Z;
            RotateMatrix(matriz);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            cube.transform.position = inicialPos;
        }

            
    }

    void RotateFormula(AXIS _axis)
    {
        Vector3 pos = cube.transform.position;
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;

        switch (_axis)
        {
            case AXIS.X:
                y = (pos.y * Mathf.Cos(angle)) - (pos.z * Mathf.Sin(angle));
                z = (pos.y * Mathf.Sin(angle)) + (pos.z * Mathf.Cos(angle));
                Debug.Log(cube.transform.position);
            break;

            case AXIS.Y:
                z = (pos.z * Mathf.Cos(angle)) - (pos.x * Mathf.Sin(angle));
                x = (pos.z * Mathf.Sin(angle)) + (pos.x * Mathf.Cos(angle));

            break;
            
            case AXIS.Z:
                x = (pos.x * Mathf.Cos(angle)) - (pos.y * Mathf.Sin(angle));
                y = (pos.x * Mathf.Sin(angle)) + (pos.y * Mathf.Cos(angle));

            break;
        }
        cube.transform.position = new Vector3(x,y,z);
    }


    void RotateMatrix(MATRIZ _matriz)
    {
        Vector3 pos = cube.transform.position;
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;
        
        switch (_matriz)
        {
            case MATRIZ.X:
            
                y = (pos.y * xMatrix[1,1]) + (pos.z * xMatrix[2,1]);
                z = (pos.y * xMatrix[1,2]) + (pos.z * xMatrix[2,2]);
            
            break;
            case MATRIZ.Y:
            
                z = (pos.z * yMatrix[0,0]) + (pos.x * yMatrix[2,0]);
                x = (pos.z * yMatrix[0,2]) + (pos.x * yMatrix[2,2]);
            
            break;
            case MATRIZ.Z:
            
                x = (pos.x * zMatrix[0,0]) + (pos.y * zMatrix[1,0]);
                y = (pos.x * zMatrix[0,1]) + (pos.y * zMatrix[1,1]);
            
            break;
        }

         cube.transform.position = new Vector3(x,y,z);
    }






     
}