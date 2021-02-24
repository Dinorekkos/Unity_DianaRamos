using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public enum Operacion { Suma, Resta, Multi, Division}

    [Header("VectorCubo")]
    [SerializeField] private float cubex,cubey,cubez;


    [Header("VectorSphere")]
    [SerializeField] private float sphereX, sphereY, sphereZ;



    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;

    private float resultMagnitud;

    private float xNormalizado, yNormalizado, zNormalizado;

    public float resultadoDistancia;
    

   


    void Start()
    {
        GetMagnitude();
        NormalizeVector();
    }



    void Update()
    {
        KnowDistance();
    }


    void GetMagnitude()
    {


        cubex= ((cube.transform.position.x * cube.transform.position.x ));
        cubey= ((cube.transform.position.y * cube.transform.position.y));
        cubez= ((cube.transform.position.z * cube.transform.position.z));

        resultMagnitud = Mathf.Sqrt(cubex + cubey + cubez);


        Debug.Log( "Cubo: Resultado de magnitud = " + resultMagnitud);
    }


    void NormalizeVector()
    {
        xNormalizado = (cube.transform.position.x / resultMagnitud);
        yNormalizado = (cube.transform.position.y / resultMagnitud);
        zNormalizado = (cube.transform.position.z / resultMagnitud);

        Debug.Log("Cubo: Resultado Normalizado = " + " x="+xNormalizado + " y=" +yNormalizado +" z=" +zNormalizado);

    }


    void KnowDistance()
    {
        float newCubex, newCubey, newcubez;
        
        sphereX = sphere.transform.position.x;
        sphereY = sphere.transform.position.y;
        sphereZ = sphere.transform.position.z;

        newCubex = cube.transform.position.x;
        newCubey = cube.transform.position.y;
        newcubez = cube.transform.position.z;


        resultadoDistancia = (Mathf.Sqrt(sphereX * newCubex) + (sphereY * newcubez) + (sphereZ * newcubez));

        Debug.Log("ResultadoDistancia = " + resultadoDistancia);



    }









}
