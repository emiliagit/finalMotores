using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    public GameObject firePrefab;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyLife>().TakeDa�o(20);
            Instantiate(firePrefab, transform.position, Quaternion.identity);
            //Destroy(gameObject);

        }
    }


}
