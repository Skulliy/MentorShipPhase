using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RotatingEnemy : MonoBehaviour
{
    public void RotateEnemy(float angle)
    {
        transform.Rotate(0, angle, 0);
    }
}
