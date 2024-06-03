using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Monster : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;

    void OnCollisionEnter2D(Collision2D collision)
    {

        Frog frog = collision.gameObject.GetComponent<Frog>();
        if (frog != null)
            StartCoroutine(DieAfterDelay());
        if (collision.contacts[0].normal.y < -0.5) {
            StartCoroutine(DieAfterDelay());
        }
    }

    IEnumerator DieAfterDelay()
    {
        yield return new WaitForSeconds((float)0.65);
        _particleSystem.Play();
        yield return new WaitForSeconds((float)0.15);
        gameObject.SetActive(false);

    }
}
