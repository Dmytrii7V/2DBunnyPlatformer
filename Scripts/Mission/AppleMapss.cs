using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMapss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AppleMapssText.applee += 1;
            Destroy(gameObject);
        }

    }
}
