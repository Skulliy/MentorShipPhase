using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public void Move(Vector3 direction)
    {
        transform.position = direction + new Vector3(0, 2, 0);
    }
}
