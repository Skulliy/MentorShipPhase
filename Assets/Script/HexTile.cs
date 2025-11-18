using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTile : MonoBehaviour
{
    public bool playerOnTile = false;
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnTile = true;

            if (rend != null)
                rend.material.color = Color.green;

            Debug.Log(gameObject.name + " → PLAYER ON TILE");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnTile = false;

            
            if (rend != null)
                rend.material.color = Color.white;

            Debug.Log(gameObject.name + " → PLAYER LEFT TILE");
        }
    }
}
