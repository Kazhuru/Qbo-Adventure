using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporalDrop : MonoBehaviour
{
    [SerializeField] float timeBeforeDead;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Plane"))
        { 
            StartCoroutine(WaitAndDestroy());
        }
    }

    private IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(timeBeforeDead);
        Destroy(gameObject);
    }
}
