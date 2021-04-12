using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyTriangle : MonoBehaviour
{
    public Material material;
    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;
    
    Vector3[] vertex;
    int[] triangles;

    void Start()
    {
       meshFilter = gameObject.AddComponent<MeshFilter>();
       meshRenderer = gameObject.AddComponent<MeshRenderer>();
       meshRenderer.material = material;
       Mesh mesh = GetComponent<MeshFilter>().mesh; 
       meshFilter.mesh = mesh;



        vertex = new []
        {
            new Vector3(1,0,0), //A-0
            new Vector3(2,0,0), //B-1
            new Vector3(1.5f,0.87f,0), //F-2
            new Vector3(1.5f,-0.65f,0.58f), //G-3
            new Vector3(2.31f,0.76f,0.58f), //H-4
            new Vector3(0.69f,0.76f,0.58f), //I -5
            new Vector3(0.69f,-0.18f,0.93f), //J-6
            new Vector3(2.31f,-0.18f,0.93f), //K-7
            new Vector3(1.5f,1.22f,0.93f), //L-8
            new Vector3(1.5f,-0.29f,1.51f),//M -9
            new Vector3(2, 0.58f,1.51f), //N-10
            new Vector3(1,0.58f,1.51f), //O-11
        };

        meshFilter.mesh.vertices = vertex;

        int[] triangles =
       {
           0,2,1, //1
           6,5,0, //2
           0,3,6, //3
           0,5,2, //4 
           0,1,3, //5
           3,9,6, //6
           3,7,9, //7
           7,3,1, //8
           9,7,10, //9
           1,4,7, //10
           10,7,4, //11
           4,1,2, //12
           4,2,8, //13
           4,8,10, //14
           2,5,8, //15
           8,5,11, //16
           8,11,10,//17
           11,5,6, //18
           9,11,6, //19
           9,10,11 //20

       };
       
       Vector2[] uvs =
       {
           //triangulo 1 
           new Vector2(0,0),
           new Vector2(0.25f, 0),
           new Vector2(0.125f,0.2f),
           //triangulo 2
           new Vector2(0,0.2f),
           new Vector2(0.25f,0.2f),
           new Vector2(0.125f,0.4f),
           //triangulo 3
           new Vector2(0,0.4f),
           new Vector2(0.25f,0.4f),
           new Vector2(0.125f,0.6f),
           //triangulo 4
           new Vector2(0,0.6f),
           new Vector2(0.25f,0.6f),
           new Vector2(0.125f,0.8f),
           //triangulo 5
           new Vector2(0,0.8f),
           new Vector2(0.25f,0.8f),
           new Vector2(0.125f,1),
           //triangulo 6
           new Vector2(0.25f,0f),
           new Vector2(0.50f,0f),
           new Vector2(0.375f,0.2f),
           //triangulo 7
           new Vector2(0.25f,0.2f),
           new Vector2(0.50f,0.2f),
           new Vector2(0.375f,0.4f),
           //triangulo 8
           new Vector2(0.25f,0.4f),
           new Vector2(0.50f,0.4f),
           new Vector2(0.375f,0.6f),
           //triangulo 9
           new Vector2(0.25f,0.6f),
           new Vector2(0.50f,0.6f),
           new Vector2(0.375f,0.8f),
           //triangulo 10
           new Vector2(0.25f,0.8f),
           new Vector2(0.50f,0.8f),
           new Vector2(0.375f,1),
           //triangulo 11
           new Vector2(0.50f,0),
           new Vector2(0.75f,0),
           new Vector2(0.625f,0.2f),
           //triangulo 12
           new Vector2(0.50f,0.2f),
           new Vector2(0.75f,0.2f),
           new Vector2(0.625f,0.4f),
           //triangulo 13
           new Vector2(0.50f,0.4f),
           new Vector2(0.75f,0.4f),
           new Vector2(0.625f,0.6f),
           //triangulo 14 
           new Vector2(0.50f,0.6f),
           new Vector2(0.75f,0.6f),
           new Vector2(0.625f,0.8f),
           //triangulo 15
           new Vector2(0.50f,0.8f),
           new Vector2(0.75f,0.8f),
           new Vector2(0.625f,1),
           //triangulo 16
           new Vector2(0.75f,0),
           new Vector2(1,0),
           new Vector2(0.875f,0),
           //triangulo 17
           new Vector2(0.75f,0.2f),
           new Vector2(1,0.2f),
           new Vector2(0.875f,0.4f),
           //triangulo 18
           new Vector2(0.75f,0.4f),
           new Vector2(1,0.4f),
           new Vector2(0.875f,0.6f),
           //triangulo 19
           new Vector2(0.75f,0.6f),
           new Vector2(1,0.6f),
           new Vector2(0.875f,0.8f),
           //triangulo 20
           new Vector2(0.75f,0.8f),
           new Vector2(1,0.8f), 
           new Vector2(0.875f,1),          
       };
        
        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;

    }
}

