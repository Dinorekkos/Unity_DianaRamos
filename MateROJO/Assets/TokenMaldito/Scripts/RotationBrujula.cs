using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBrujula: MonoBehaviour
{
    
    TokenObject tokenScript = new TokenObject();
    Token1 token1Script = new Token1();

    public float angle;

    public GameObject posCentral;
    public GameObject pivote;
    private Vector3 posTemp;

    Vector3 inicialPos;
    public enum AXISB{X,Y,Z}
    public AXISB axis;
   

     private void Awake() 
    {
        inicialPos = pivote.transform.position;  
    }


    void Rotate(AXISB _axis)
    {
        Vector3 pos = pivote.transform.position;
        
        float x = pos.x;
        float y = pos.y;
        float z = pos.z;

        switch (_axis)
        {
            case AXISB.X:
                DoPosTem();
                y = (pos.y * Mathf.Cos(angle)) - (pos.z * Mathf.Sin(angle));
                z = (pos.y * Mathf.Sin(angle)) + (pos.z * Mathf.Cos(angle));
                Debug.Log(pivote.transform.position);
                ReturnRotate();
            break;

            case AXISB.Y:
                DoPosTem();
                z = (pos.z * Mathf.Cos(angle)) - (pos.x * Mathf.Sin(angle));
                x = (pos.z * Mathf.Sin(angle)) + (pos.x * Mathf.Cos(angle));
                Debug.Log(pivote.transform.position);
                ReturnRotate();
            break;

            case AXISB.Z:
                DoPosTem();
                x = (pos.x * Mathf.Cos(angle)) - (pos.y * Mathf.Sin(angle));
                y = (pos.x * Mathf.Sin(angle)) + (pos.y * Mathf.Cos(angle));
                Debug.Log(pivote.transform.position);
                ReturnRotate();
            break;
            }
        pivote.transform.position  = new Vector3(x,y,z);
    }

/* public Vector3(float x, float y, float z)
 {  
     x = pos.x;
     y = pos.y;
     z = pos.z;

 }
 */




    void Update()
    {
        //Formula
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            axis = AXISB.X;
            Rotate(axis);
            
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            axis = AXISB.Y;
            Rotate(axis);
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            
            axis = AXISB.Z;
            Rotate(axis);
            
        } 
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            pivote.transform.position = inicialPos;
            
        }   
    }

    void DoPosTem()
    {
        posTemp = posCentral.transform.position;
        pivote.transform.position = new Vector3(0,0,0);
        
    }
    void ReturnRotate()
    {
        posCentral.transform.position = posTemp;
    }


    /*void RotateBothObJjects()
    {
        Vector3[] newPosTokenObject = tokenScript.meshFilter.mesh.vertices;
        Vector3[] newPosToken1 = token1Script.meshFilter.mesh.vertices;


    }*/




}
