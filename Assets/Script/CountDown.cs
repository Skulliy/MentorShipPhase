using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{

    [SerializeField] private GameObject character1;
    [SerializeField] private GameObject character2;
    [SerializeField] private Transform[] commands1;
    [SerializeField] private Transform[] commands2;
    [SerializeField] private RotatingEnemy Enemy;
    [SerializeField] private Transform[] patrollRoute;
    [SerializeField] private PatrollingEnemy PatrollingEnemy;
    private int index = 0;
    private int routeIndex = 0;
    private bool forwardPatrol = true;
    private void Awake()
    {
        StartCountDown();
        Enemy = GetComponent<RotatingEnemy>();
        PatrollingEnemy = GetComponent<PatrollingEnemy>();
    }

    public void StartCountDown()
    {
        InvokeRepeating("Execute", 0, 2.0f);
    }

    private void Execute()
    {
        if (index < patrollRoute.Length && forwardPatrol)
        {
            PatrollingEnemy.Move(patrollRoute[routeIndex].position);
            routeIndex++;
        }
        else
        {
            PatrollingEnemy.Move(patrollRoute[routeIndex].position);
            routeIndex--;
            if (routeIndex <= 0)
            {
                forwardPatrol = true;
            }
            else
            {
                forwardPatrol = false;
            }
        }
        if (index < commands1.Length)
        {
            if (commands1[index] != null || commands1[index].position != new Vector3(0, 0, 0))
            {
                character1.GetComponent<CharacterController>().MoveCharacter(commands1[index].position);
            }
            if (commands2[index] != null || commands2[index].position != new Vector3(0, 0, 0))
            {
                character2.GetComponent<CharacterController>().MoveCharacter(commands2[index].position);
            }
            index++;
            Enemy.RotateEnemy(60);
        }
        else CancelInvoke("Execute");
    }

  
}
