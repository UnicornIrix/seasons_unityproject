using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prova_cambio_stagioni : MonoBehaviour
{
    public Animator animator;

    public void SET_Estate() {
        animator.Play("Estate");
    }

    public void SET_Autunno()
    {
        animator.Play("Autunno");
    }

    public void SET_Inverno()
    {
        animator.Play("Inverno");
    }

    public void SET_Primavera()
    {
        animator.Play("Primavera");
    }
}
