using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class compass : MonoBehaviour
{

    float distanceFromPlayer = 4f;

    Transform Player;
    Transform targetMision;
    float heightAboveGround = 1f;

    public bool compassActive = true;

    private Renderer renderizado;


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        FindClosestMision();
        renderizado = GetComponent<Renderer>();

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
           
            compassActive = true;
            SetVisibility();

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            compassActive = false;
            SetVisibility();

        }

        if (compassActive)
        {
            FindClosestMision();

            float distanceMision = Vector3.Distance(Player.position, targetMision.position);


            Vector3 targetPosition = new Vector3(targetMision.position.x, Player.position.y + heightAboveGround, targetMision.position.z);
            Vector3 directionMision = targetPosition - Player.position;
            Vector3 desiredPosition = Player.position + directionMision.normalized * distanceFromPlayer;


            transform.LookAt(targetPosition);
            transform.position = desiredPosition;
        }

        
    }
    private void SetVisibility()
    {
        renderizado.enabled = compassActive;
    }

    void FindClosestMision()
    {
        GameObject[] misiones = GameObject.FindGameObjectsWithTag("Misiones");
        float closestDistance = Mathf.Infinity;

        if (misiones.Length > 0)
        {
            foreach (GameObject mision in misiones)
            {
                float distance = Vector3.Distance(Player.position, mision.transform.position);

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    targetMision = mision.transform;
                }
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
