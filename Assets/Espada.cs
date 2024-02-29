using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{

    private Animator WeaponAnimator;
    private enemyLife EnemyLife;

    private bool isAnimationPlaying = false;

    private void Start()
    {
        WeaponAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAnimationPlaying)
        {
            StartCoroutine(PlayWeaponAnimation());

        }
        
    }

    private System.Collections.IEnumerator PlayWeaponAnimation()
    {

        isAnimationPlaying = true;
        WeaponAnimator.SetTrigger("atackTrigger");

        yield return new WaitForSeconds(WeaponAnimator.GetCurrentAnimatorStateInfo(0).length);

        WeaponAnimator.SetTrigger("desactivar");
        isAnimationPlaying = false;

        yield return new WaitForSeconds(0.5f); // Ajusta este valor seg�n tus necesidades
        isAnimationPlaying = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyLife.TakeDa�o();
        }
    }

    
}
