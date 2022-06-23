using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;

    public AudioSource audioUvod;
    public AudioSource audioStazaGranicara;

    private void Start()
    {
        animator1.speed = 0;
        animator2.speed = 0;
    }

    public void StartAnimationOne()
    {
        animator1.speed = 1;
        StartCoroutine("Uvod");
    }
    IEnumerator Uvod()
    {
        yield return new WaitForSeconds(1.261f);
        audioUvod.Play();
    }

    public void PauseAnimationOne()
    {
        animator1.speed = 0;
        audioUvod.Pause();
    }


    public void StartAnimationTwo()
    {
        animator2.speed = 1;
        StartCoroutine("StazaGranicara");
    }

    IEnumerator StazaGranicara()
    {
        yield return new WaitForSeconds(1.265f);
        audioStazaGranicara.Play();
    }

    public void PauseAnimationTwo()
    {
        animator2.speed = 0;
        audioStazaGranicara.Pause();
    }
}
