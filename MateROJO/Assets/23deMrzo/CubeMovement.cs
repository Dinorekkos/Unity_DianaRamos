using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
   // [SerializeField] private float posX, posY,posZ;

    [SerializeField] private GameObject cube;
    [SerializeField] private Vector3 moveCube;
    
    
    public void MovementCube()
    {
        cube.transform.position = MultiplicarVector(cube.transform.position,moveCube);
        //cube.transform.position = new Vector3(cube.transform.position.x + posX, cube.transform.position.y + posY, cube.transform.position.z + posZ);
      

    }

    public Vector3 MultiplicarVector(Vector3 cubePosition, Vector3 delta)
    {
        float x = (cubePosition.x * 1) + (cubePosition.y * 0) + (cubePosition.z *0) + (1 * delta.x);
        float y = (cubePosition.x * 0) + (cubePosition.y * 1) + (cubePosition.z * 0) + (1 * delta.y);
        float z = (cubePosition.x * 0) + (cubePosition.y * 0) + (cubePosition.z * 1) + (1 * delta.z);

        return new Vector3 (x,y,z);

    }
}
