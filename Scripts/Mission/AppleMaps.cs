using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMaps : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AppleMapsText.apple += 1;
            Destroy(gameObject);
        }

    }
}
