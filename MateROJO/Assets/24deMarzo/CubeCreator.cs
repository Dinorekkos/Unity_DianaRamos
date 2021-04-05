using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
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
        meshRenderer.material =  material;
        meshFilter.mesh = mesh;


            
             vertex = new []
            {
                new Vector3(0,0,0), //0 
                new Vector3(0,1,0), //1 
                new Vector3(1,0,0), //2
                new Vector3(1,1,0), //3
                new Vector3(0,1,1), //4
                new Vector3(1,1,1), //5
                new Vector3(1,0,1), //6
                new Vector3(0,0,1), //7
    
            };
        
         meshFilter.mesh.vertices = vertex;
            triangles = new[]
            {
                //cara Frontal
                0,1,2,
                3,2,1,
                //cara Superior
                5,1,4,
                3,1,5,
                //cara Lateral Derecha
                5,2,3,
                6,2,5,
                //cara Inferior
                0,6,7,
                6,0,2,
                //cara Lateral Izquierda
                0,7,1, 
                4,1,7,
                //cara Trasera
                6,5,7,
                4,7,5

            };
            meshFilter.mesh.triangles = triangles;
    }
  
}
