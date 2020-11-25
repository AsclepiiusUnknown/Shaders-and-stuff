using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject boxObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempBox = Instantiate(boxObject, transform.position, Quaternion.identity);
            Destroy(tempBox,5);
        }
    }
}