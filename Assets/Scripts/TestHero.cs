using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHero : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    private void Start()
    {
        StartCoroutine(Test());
    }

    private IEnumerator Test()
    {
        _animator.SetBool("Walk", false);
        yield return new WaitForSeconds(2f);
        
        _animator.SetBool("Walk", true);
        yield return new WaitForSeconds(2f);
        
        _animator.SetInteger("Slap_Index", 2);
        _animator.SetTrigger("Slap");
        yield return new WaitForSeconds(2f);
        
        _animator.SetInteger("Slap_Index", 1);
        _animator.SetTrigger("Slap");
        yield return new WaitForSeconds(2f);
        
        _animator.SetInteger("Slap_Index", 0);
        _animator.SetTrigger("Slap");
        yield return new WaitForSeconds(2f);
        
        _animator.SetBool("Walk", false);
        yield return new WaitForSeconds(2f);

        StartCoroutine(Test());

        // _animator.SetTrigger("Slap");
        // _animator.SetInteger("Slap_Index", 0);
        // _animator.SetInteger("Slap_Index", 1);
        // _animator.SetInteger("Slap_Index", 2);
        // _animator.SetBool("Walk", true);
        // _animator.SetBool("Walk", false);
    }
}
