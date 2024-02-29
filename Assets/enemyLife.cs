using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyLife : MonoBehaviour
{

    private int daño = 10;
    private int Salud = 100;
    public Animator animator;

    private bool damageAnimationPlayed = false;

   

    public void TakeDaño()
    {
        Salud -= daño;

        if( Salud <= 30 && !damageAnimationPlayed)
        {
            if (animator != null)
            {
                animator.SetTrigger("TakeDamage");
                damageAnimationPlayed = true;
            }
        }

        if( Salud == 0)
        {
            Destroy(gameObject);
        }
    }

   

}

