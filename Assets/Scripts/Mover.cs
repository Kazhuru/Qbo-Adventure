using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    [SerializeField] bool invertedAxis = false;
    [SerializeField] bool invertedXMov = false;
    [SerializeField] bool invertedZMov = false;

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        string xString = "";
        string zString = "";

        if (invertedAxis)
        {
            xString = "Vertical";
            zString = "Horizontal";
        }
        else
        {
            xString = "Horizontal";
            zString = "Vertical";
        }

        float xValue = Input.GetAxis(xString) * Time.deltaTime;
        if (invertedXMov)
            xValue = xValue * -1;

        float zValue = Input.GetAxis(zString) * Time.deltaTime;
        if (invertedZMov)
            zValue = zValue * -1;

        transform.Translate(xValue * moveSpeed, 0, zValue * moveSpeed);

    }
}
