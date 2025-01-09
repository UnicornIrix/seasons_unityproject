using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova_cambio_stagioni : MonoBehaviour
{
    public Animator animator;

    public void SET_Estate() {
        animator.SetBool("bool_est", true);
        animator.SetBool("bool_aut", false);
        animator.SetBool("bool_inv", false);
        animator.SetBool("bool_prim", false);
    }

    public void SET_Autunno()
    {
        animator.SetBool("bool_est", false);
        animator.SetBool("bool_aut", true);
        animator.SetBool("bool_inv", false);
        animator.SetBool("bool_prim", false);
    }

    public void SET_Inverno()
    {
        animator.SetBool("bool_est", false);
        animator.SetBool("bool_aut", false);
        animator.SetBool("bool_inv", true);
        animator.SetBool("bool_prim", false);
    }

    public void SET_Primavera()
    {
        animator.SetBool("bool_est", false);
        animator.SetBool("bool_aut", false);
        animator.SetBool("bool_inv", false);
        animator.SetBool("bool_prim", true);
    }
}
