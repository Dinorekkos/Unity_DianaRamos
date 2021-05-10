 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Material material;
    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;
    Vector3 [] vertex;
    int [] triangles;
    Vector3 posTemp;

    public float angle;
   


    void Start()
    {
       
        CreateBrujula();
    }   
    void Update()
    {
       
        TransformBrujula();
        
        
    }

    void CreateBrujula()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        meshFilter.mesh = mesh;

        vertex = new[]
        {
            //Primera Cara
              //1
                new Vector3(0,0,0), // A-0
                new Vector3(-0.77f,-6.39f,0), //D-1
                new Vector3(1,-6.32f,0), //E-2
                //2
                new Vector3(0,0,0), // A-3
                new Vector3(1,-6.32f,0), //E-4
                new Vector3(2.82f,-5.75f,0), //F-5
                //3
                new Vector3(0,0,0), // A-6
                new Vector3(2.82f,-5.75f,0), //F-7
                new Vector3(4.37f,-4.65f,0), //G-8
                //4
                new Vector3(0,0,0), // A-9
                new Vector3(4.37f,-4.65f,0), // G-10
                new Vector3(5.5f,-3.13f,0), //H-11
                //5
                new Vector3(0,0,0), // A-12
                new Vector3(5.5f,-3.13f,0), //H-13
                new Vector3(6.11f,-1.32f,0), //I-14
                //6
                new Vector3(0,0,0), // A-15
                new Vector3(6.11f,-1.32f,0), //I-16
                new Vector3(6.13f,0.58f,0), //J-17
                //7
                new Vector3(0,0,0), // A-18
                new Vector3(6.13f,0.58f,0), //J-19
                new Vector3(5.56f,2.39f,0), //K-20
                //8
                new Vector3(0,0,0), // A-21
                new Vector3(5.56f,2.39f,0), //K-22
                new Vector3(4.46f,3.95f,0), //L-23
                //9
                new Vector3(0,0,0), // A-24
                new Vector3(4.46f,3.95f,0), //L-25
                new Vector3(2.94f,5.08f,0), //M-26
                //10
                new Vector3(0,0,0), // A-27
                new Vector3(2.94f,5.08f,0), //M-28
                new Vector3(1.14f,5.69f,0), //N-29
                //11
                new Vector3(0,0,0), // A-30
                new Vector3(1.14f,5.69f,0), //N-31
                new Vector3(-0.77f,5.71f,0), //O-32
                //12
                new Vector3(0,0,0), // A-33
                new Vector3(-0.77f,5.71f,0), //O-34
                new Vector3(-2.58f,5.14f,0), //P-35
                //13
                new Vector3(0,0,0), // A-36
                new Vector3(-2.58f,5.14f,0), //P-37
                new Vector3(-4.13f,4.04f,0), // Q-38
                //14
                new Vector3(0,0,0), // A-39
                new Vector3(-4.13f,4.04f,0), // Q-40
                new Vector3(-5.27f,2.52f,0), // R-41
                //15
                new Vector3(0,0,0), // A-42
                new Vector3(-5.27f,2.52f,0), // R-43
                new Vector3(-5.88f,0.71f,0), // S-44
                //16
                new Vector3(0,0,0), // A-45
                new Vector3(-5.88f,0.71f,0), // S-46
                new Vector3(-5.9f,-1.19f,0), // T-47
                //17
                new Vector3(0,0,0), // A-48
                new Vector3(-5.9f,-1.19f,0), // T-49
                new Vector3(-5.33f,-3,0), // U-50
                //18
                new Vector3(0,0,0), // A-51
                new Vector3(-5.33f,-3,0), // U-52
                new Vector3(-4.23f,-4.56f,0), // V-53
                //19
                new Vector3(0,0,0), // A-54
                new Vector3(-4.23f,-4.56f,0), // V-55
                new Vector3(-2.7f,-5.69f,0), // W-56
                //20
                new Vector3(0,0,0), // A-57
                new Vector3(-2.7f,-5.69f,0), // W-58
                new Vector3(-0.77f,-6.39f,0), //D-59 

        };
        meshFilter.mesh.vertices = vertex;
        
        int [] triangles = 
        {
           //Primera Cara
            0,1,2, //1
            3,4,5, //2
            6,7,8, //3
            9,10,11, //4
            12,13,14,//5
            15,16,17,//6
            18,19,20,//7
            21,22,23,//8
            24,25,26,//9
            27,28,29,//10
            30,31,32,//11
            33,34,35,//12
            36,37,38,//13
            39,40,41,//14
            42,43,44,//15
            45,46,47,//16
            48,49,50,//17
            51,52,53,//18
            54,55,56,//19
            57,58,59,//20
        };
  
         meshFilter.mesh.triangles = triangles;
    }

    void TransformBrujula()
    {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            meshFilter.mesh = mesh;

            posTemp = this.transform.position;
            this.transform.position = new Vector3 (0,0,0);

    

        for(int i = 0; i< vertex.Length; i++)
         {
             if(Input.GetKeyDown(KeyCode.R))
             vertex[i] = RotateX(vertex[i].x,vertex[i].y,vertex[i].z);
             if(Input.GetKeyDown(KeyCode.Y))
             vertex[i] = RotateY(vertex[i].x,vertex[i].y,vertex[i].z);
             if(Input.GetKeyDown(KeyCode.Z))
              vertex[i] = RotateZ(vertex[i].x,vertex[i].y,vertex[i].z);


         }


        meshFilter.mesh.vertices = vertex;

        int [] triangles = 
        {
           //Primera Cara
            0,1,2, //1
            3,4,5, //2
            6,7,8, //3
            9,10,11, //4
            12,13,14,//5
            15,16,17,//6
            18,19,20,//7
            21,22,23,//8
            24,25,26,//9
            27,28,29,//10
            30,31,32,//11
            33,34,35,//12
            36,37,38,//13
            39,40,41,//14
            42,43,44,//15
            45,46,47,//16
            48,49,50,//17
            51,52,53,//18
            54,55,56,//19
            57,58,59,//20
        };
  
         meshFilter.mesh.triangles = triangles;
         this.transform.position =  posTemp;
    }


    Vector3 RotateX(float x,float y, float z)
    {
        Vector3 pos = new Vector3(x,y,z);
        float yPrima = (pos.y * Mathf.Cos(angle)) - (pos.z * Mathf.Sin(angle));
        float zPrima = (pos.y * Mathf.Sin(angle)) + (pos.z * Mathf.Cos(angle));
       
        return new Vector3(pos.x,yPrima,zPrima);
    }

    Vector3 RotateY(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x,y,z);
        float zPrima = (pos.z * Mathf.Cos(angle)) - (pos.x * Mathf.Sin(angle));
        float xPrima = (pos.z * Mathf.Sin(angle)) + (pos.x * Mathf.Cos(angle));

        return new Vector3(xPrima, pos.y,zPrima);
    }
    Vector3 RotateZ(float x, float y, float z)
    {  
        Vector3 pos = new Vector3(x,y,z);
        float xPrima = (pos.x * Mathf.Cos(angle)) - (pos.y * Mathf.Sin(angle));
        float yPrima = (pos.x * Mathf.Sin(angle)) + (pos.y * Mathf.Cos(angle));

        return new Vector3(xPrima,yPrima,pos.z);

    }

}

