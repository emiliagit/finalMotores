using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float projectileSpeed = 10f;
    public float attackSpeed = 1f;
    private float nextAttackTime = 0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextAttackTime)
        {
            Shoot();
            nextAttackTime = Time.time + 1f / attackSpeed;

        }
    }

    private void Shoot()
    {

        Vector3 shootDirection = projectileSpawnPoint.forward;

        //Camera mainCamera = Camera.main;
        //Vector3 cameraCenter = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, mainCamera.nearClipPlane)); // calcula la posicion en el mundo del centro de la camara. Convierte un punto en las coordenadas de la vista de la camara en coordenadas del mundo.
        //Vector3 shootDirection = (cameraCenter - projectileSpawnPoint.position).normalized; //calcula la direccion en la que se dispara el proyectil desde el punto de origen del disparo hacia el centro de la camara y normaliza el vector.
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.LookRotation(shootDirection));
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        projectileRb.velocity = shootDirection * projectileSpeed;
        Destroy(projectile, 10f);
    }
}
