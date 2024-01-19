using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionCoin : MonoBehaviour
{
    public AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollacTableControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}