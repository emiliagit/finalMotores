using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject firePrefab;

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out FollowPlayer enemy))
        {
            enemy.TakeDaño();
            Instantiate(firePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
