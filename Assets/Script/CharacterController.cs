using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5.0f;
    public void MoveCharacter(Vector3 direction)
    {
        transform.position = direction + new Vector3(0,2,0);
    }
}
