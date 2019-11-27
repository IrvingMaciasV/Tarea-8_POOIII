using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.instance;
    }
    private void FixedUpdate()
    {
        ObjectPooler.instance.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
