using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodoCruzado : MonoBehaviour
{
    public GameObject cube, sphere;
    public Vector3 a, b;
    private void Update()
     {
      ShowProductoCruzado(a, b);
    }

    public void ShowProductoCruzado(Vector3 a, Vector3 b)
    {
       Debug.Log (ProductoCruzado(a,b));
    }
    public Vector3 ProductoCruzado(Vector3 a, Vector3 b)
   {
       a = new Vector3 (cube.transform.position.x, cube.transform.position.y, cube.transform.position.z);
       b = new Vector3 (sphere.transform.position.x, transform.position.y, transform.position.z);
       
       Vector3 result = new Vector3(0,0,0);
       
       result.x = (a.y * b.z)- (a.z * b.y);
       result.y = (a.z* b.x) - (a.x * b.z);
       result.z = (a.x * b.y) - (a.y * b.x);

       return result;

    

   }



}
