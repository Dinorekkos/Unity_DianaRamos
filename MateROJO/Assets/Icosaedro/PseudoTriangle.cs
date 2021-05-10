using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PseudoTriangle : MonoBehaviour
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
            //triangulo1
            new Vector3(1,0,0), //A-0
            new Vector3(2,0,0), //B-1
            new Vector3(1.5f,0.87f,0), //F-2
            //triangulo 2
            new Vector3(0.69f,-0.18f,0.93f), //J-3
            new Vector3(0.69f,0.76f,0.58f), //I -4
            new Vector3(1,0,0), //A-5
            //triangulo3
            new Vector3(1,0,0), //A-6
            new Vector3(1.5f,-0.65f,0.58f), //G-7
            new Vector3(0.69f,-0.18f,0.93f), //J-8
            //triangulo4
            new Vector3(1,0,0), //A-9
            new Vector3(0.69f,0.76f,0.58f), //I-10
            new Vector3(1.5f,0.87f,0), //F-11
            //triangulo5
            new Vector3(1,0,0), //A-12
            new Vector3(2,0,0), //B-13
            new Vector3(1.5f,-0.65f,0.58f), //G-14
            //triangulo6
            new Vector3(1.5f,-0.65f,0.58f), //G-15
            new Vector3(1.5f,-0.29f,1.51f),//M -16
            new Vector3(0.69f,-0.18f,0.93f), //J-17
            //triangulo7
            new Vector3(1.5f,-0.65f,0.58f), //G-18
            new Vector3(2.31f,-0.18f,0.93f), //K-19
            new Vector3(1.5f,-0.29f,1.51f),//M -20
            //triangulo8
            new Vector3(2.31f,-0.18f,0.93f), //K-21
            new Vector3(1.5f,-0.65f,0.58f), //L-22
            new Vector3(2,0,0), //B-23
            //triangulo9
            new Vector3(1.5f,-0.29f,1.51f),//M -24
            new Vector3(2.31f,-0.18f,0.93f), //K-25
            new Vector3(2, 0.58f,1.51f), //N-26
             //triangulo10
            new Vector3(2,0,0), //B-27
            new Vector3(2.31f,0.76f,0.58f), //H-28
            new Vector3(2.31f,-0.18f,0.93f), //K-29
            //traignulo11
            new Vector3(2, 0.58f,1.51f), //N-30
            new Vector3(2.31f,-0.18f,0.93f), //K-31
            new Vector3(2.31f,0.76f,0.58f), //H-32
            //triangulo12
            new Vector3(2.31f,0.76f,0.58f), //H-33
            new Vector3(2,0,0), //B-34
            new Vector3(1.5f,0.87f,0), //F-35
            //triangulo13
            new Vector3(2.31f,0.76f,0.58f), //H-36
            new Vector3(1.5f,0.87f,0), //F-37
            new Vector3(1.5f,1.22f,0.93f), //L-38
            //triangulo14
            new Vector3(2.31f,0.76f,0.58f), //H-39
            new Vector3(1.5f,1.22f,0.93f), //L-40
            new Vector3(2, 0.58f,1.51f), //N-41
            //triangulo15
            new Vector3(1.5f,0.87f,0), //F-42
            new Vector3(0.69f,0.76f,0.58f), //I-43
            new Vector3(1.5f,1.22f,0.93f), //L-44
            //triangulo16
            new Vector3(1.5f,1.22f,0.93f), //L-45
            new Vector3(0.69f,0.76f,0.58f), //I-46
            new Vector3(1,0.58f,1.51f), //O-47
            //triangulo17
            new Vector3(1.5f,1.22f,0.93f), //L-48
            new Vector3(1,0.58f,1.51f), //O-49
            new Vector3(2, 0.58f,1.51f), //N-50
            //triangulo18
            new Vector3(1,0.58f,1.51f), //O-51
            new Vector3(0.69f,0.76f,0.58f), //I-52
            new Vector3(0.69f,-0.18f,0.93f), //J-53
            //triangulo19
            new Vector3(1.5f,-0.29f,1.51f),//M-54
            new Vector3(1,0.58f,1.51f), //O-55
            new Vector3(0.69f,-0.18f,0.93f), //J-56
            //triangulo20
            new Vector3(1.5f,-0.29f,1.51f),//M -57
            new Vector3(2, 0.58f,1.51f), //N-58
            new Vector3(1,0.58f,1.51f), //O-59
        };

        meshFilter.mesh.vertices = vertex;

        int[] triangles =
       {
           0,2,1, //1
           3,4,5, //2
           6,7,8, //3
           9,10,11, //4 
           12,13,14, //5
           15,16,17, //6
           18,19,20, //7
           21,22,23, //8
           24,25,26, //9
           27,28,29, //10
           30,31,32, //11
           33,34,35, //12
           36,37,38, //13
           39,40,41, //14
           42,43,44, //15
           45,46,47, //16
           48,49,50,//17
           51,52,53, //18
           54,55,56, //19
           57,58,59 //20
           

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
