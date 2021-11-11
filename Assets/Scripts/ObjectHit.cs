using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material initialMaterial;
    [SerializeField] Material materialChange;

    [SerializeField]  private bool wasHit;
    public bool WasHit { get => wasHit; set => wasHit = value; }

    private void Start()
    {
        wasHit = false;
        gameObject.GetComponent<MeshRenderer>().material = initialMaterial;
    }

    public void ProcessHit()
    {
        wasHit = true;
        gameObject.GetComponent<MeshRenderer>().material = materialChange;
    }
}
