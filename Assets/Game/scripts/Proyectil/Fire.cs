using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject firePrefab;

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyLife enemy))
        {
            enemy.TakeDaño(20);
            Instantiate(firePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
