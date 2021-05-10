using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour
{
    [SerializeField] private GameObject brujulaGO;
    [SerializeField] private Vector3 delta;
    private Vector3 posInicial;
  
    void Start()
    {
        posInicial = brujulaGO.transform.position;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            brujulaGO.transform.position = Formula(brujulaGO.transform.position, delta);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            brujulaGO.transform.position = posInicial;
        }
    }
    
    public Vector3 Formula (Vector3 brujulaPos,Vector3 deltaVar)
    {
        float xPrima = (brujulaPos.x * 1) + (1 * deltaVar.x);
        float yPrima = (brujulaPos.y * 1) + (1 * deltaVar.y);
        float zPrima = (brujulaPos.z * 1) + (1 * deltaVar.z);
        return new Vector3 (xPrima,yPrima,zPrima);

    }


}
