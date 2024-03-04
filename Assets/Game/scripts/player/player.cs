using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private vidaJugador VidaPlayer;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float MovAdelanteAtras = Input.GetAxis("Vertical") * moveSpeed;
        float MovIzqDer = Input.GetAxis("Horizontal") * moveSpeed;

        MovAdelanteAtras *= Time.deltaTime;
        MovIzqDer *= Time.deltaTime;

        transform.Translate(MovIzqDer, 0, MovAdelanteAtras);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.TryGetComponent(out spawner spawn))
        {
            spawn.Spawn();
        }
    }

    
}
