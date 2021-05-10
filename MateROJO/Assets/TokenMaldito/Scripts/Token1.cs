using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token1 : MonoBehaviour
{
   
    public Material material;
    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;
    Vector3 [] vertex;
    int [] triangles;
    public float angle;
    Vector3 posTemp;
    void Start()
    {
        CreateBrujula();
    }
    private void Update()
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
        Vector2[] uvs =
        {
            //1
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.417f,0.934f),//d9
            new Vector2(0.557f,0.937f),//e9
            //2
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.557f,0.937f),//e9
            new Vector2(0.692f,0.900f),//f9  ----0.704f,0.909f---- 0.701f,0.903f
            //3
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.692f,0.900f),//f9 
            new Vector2(0.81f,0.822f),//g9
             //4
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.81f,0.822f),//g9
            new Vector2(0.896f,0.714f),//h9
            //5
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.896f,0.714f),//h9
            new Vector2(0.942f,0.580f),//i9
            //6
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.942f,0.580f),//i9
            new Vector2(0.951f,0.437f),//j9
            //7
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.951f,0.437f),//j9
            new Vector2(0.911f,0.301f),//k9
            //8
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.911f,0.301f),//k9
            new Vector2(0.84f,0.186f),//l9
            //9
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.84f,0.186f),//l9
            new Vector2(0.722f,0.099f),//m9
            //10
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.722f,0.099f),//m9
            new Vector2(0.594f,0.046f),//n9
             //11
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.594f,0.046f),//n9
            new Vector2(0.454f,0.040f),//o9
             //12
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.454f,0.040f),//o9
            new Vector2(0.317f,0.077f),//p99
             //13
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.317f,0.077f),//p9
            new Vector2(0.201f,0.155f),//q9
            //14
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.201f,0.155f),//q9
            new Vector2(0.112f,0.267f),//r9
            //15
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.112f,0.267f),//r9
            new Vector2(0.064f,0.400f),//s9
            //16
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.064f,0.400f),//s9
            new Vector2(0.05f,0.543f),//t9
            //17
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.05f,0.543f),//t9
            new Vector2(0.09f,0.68f),//u9
            //18
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.09f,0.68f),//u9
            new Vector2(0.173f,0.798f),//v9
            //19
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.173f,0.798f),//v9
            new Vector2(0.285f,0.885f),//w9
            
            //20
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.285f,0.885f),//w9
            new Vector2(0.417f,0.934f),//d9
            
        };
         meshFilter.mesh.triangles = triangles;
         meshFilter.mesh.uv = uvs;   
    }


void TransformBrujula()
{
     Mesh mesh = GetComponent<MeshFilter>().mesh;
     meshFilter.mesh = mesh;
    posTemp = this.transform.position;
    this.transform.position = new Vector3 (0,0,0);

    

    for(int i = 0; i< vertex.Length; i++)
    {
             if(Input.GetKeyDown(KeyCode.X))
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
        Vector2[] uvs =
        {
            //1
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.417f,0.934f),//d9
            new Vector2(0.557f,0.937f),//e9
            //2
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.557f,0.937f),//e9
            new Vector2(0.692f,0.900f),//f9  ----0.704f,0.909f---- 0.701f,0.903f
            //3
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.692f,0.900f),//f9 
            new Vector2(0.81f,0.822f),//g9
             //4
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.81f,0.822f),//g9
            new Vector2(0.896f,0.714f),//h9
            //5
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.896f,0.714f),//h9
            new Vector2(0.942f,0.580f),//i9
            //6
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.942f,0.580f),//i9
            new Vector2(0.951f,0.437f),//j9
            //7
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.951f,0.437f),//j9
            new Vector2(0.911f,0.301f),//k9
            //8
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.911f,0.301f),//k9
            new Vector2(0.84f,0.186f),//l9
            //9
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.84f,0.186f),//l9
            new Vector2(0.722f,0.099f),//m9
            //10
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.722f,0.099f),//m9
            new Vector2(0.594f,0.046f),//n9
             //11
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.594f,0.046f),//n9
            new Vector2(0.454f,0.040f),//o9
             //12
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.454f,0.040f),//o9
            new Vector2(0.317f,0.077f),//p99
             //13
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.317f,0.077f),//p9
            new Vector2(0.201f,0.155f),//q9
            //14
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.201f,0.155f),//q9
            new Vector2(0.112f,0.267f),//r9
            //15
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.112f,0.267f),//r9
            new Vector2(0.064f,0.400f),//s9
            //16
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.064f,0.400f),//s9
            new Vector2(0.05f,0.543f),//t9
            //17
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.05f,0.543f),//t9
            new Vector2(0.09f,0.68f),//u9
            //18
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.09f,0.68f),//u9
            new Vector2(0.173f,0.798f),//v9
            //19
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.173f,0.798f),//v9
            new Vector2(0.285f,0.885f),//w9
            
            //20
            new Vector2(0.503f,0.509f),//a0
            new Vector2(0.285f,0.885f),//w9
            new Vector2(0.417f,0.934f),//d9
            
        };
         meshFilter.mesh.triangles = triangles;
         meshFilter.mesh.uv = uvs;   
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
