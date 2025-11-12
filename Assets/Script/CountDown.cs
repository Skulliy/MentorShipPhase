using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{

    [SerializeField] private GameObject character1;
    [SerializeField] private GameObject character2;
    [SerializeField] private Transform[] commands1;
    [SerializeField] private Transform[] commands2;
    private int index = 0;

    private void Awake()
    {
        StartCountDown();
    }

    public void StartCountDown()
    {
        InvokeRepeating("Execute", 0, 2.0f);
    }

    private void Execute()
    {
        if ( index < commands1.Length)
        {
            if (commands1[index] != null || commands1[index].position != new Vector3(0,0,0))
            {
                character1.GetComponent<CharacterController>().MoveCharacter(commands1[index].position);
            }
            if( commands2[index] != null || commands2[index].position != new Vector3(0,0,0))
            {
                character2.GetComponent<CharacterController>().MoveCharacter(commands2[index].position);
            }
            index++;
        }else CancelInvoke("Execute");
    }

  
}
