using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float rotSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
    }
}
