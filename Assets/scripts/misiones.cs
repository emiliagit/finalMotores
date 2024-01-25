using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misiones : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out spawner spawn))
        {
            spawn.Spawn();
        }
    }
}