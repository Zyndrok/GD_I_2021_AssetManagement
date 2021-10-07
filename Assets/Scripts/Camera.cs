using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform cubePosition;

    void Update()
    {
        this.transform.position = new Vector3(cubePosition.position.x, 2f, 0f);
    }
}
