using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    [SerializeField] int counter;
    [SerializeField] TextMeshProUGUI textScore;

    private void Start()
    {
        counter = 0;
        textScore.text = counter.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ObjectHit collitionObj = collision.gameObject.GetComponent<ObjectHit>();
        if (collitionObj != null)
        {
            if (!collitionObj.WasHit)
            {
                collitionObj.ProcessHit();
                counter++;
                textScore.text = counter.ToString();
            }
        }
    }
}
