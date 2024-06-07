using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    public void MoveForward()
    {
        this.transform.position += this.transform.forward;
    }

    public void RotateLeft()
    {
        this.transform.Rotate(Vector3.up * 90);
    }
}
