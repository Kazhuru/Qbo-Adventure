using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] GameObject cubePrefab;
    [SerializeField] float instanceInterval = 4f;
    [SerializeField] Transform minPoint;
    [SerializeField] Transform maxPoint;
    [SerializeField] float instanceRotationRandom = 1f;

    private bool loopCreation = true;

    private void Start()
    {
        StartCoroutine(StartInstancingCubes());
    }

    private IEnumerator StartInstancingCubes()
    {
        while (loopCreation)
        {
            yield return new WaitForSeconds(instanceInterval);
            GameObject instace = Instantiate(
                cubePrefab,
                GetInstancePostion(),
                Quaternion.Euler(Random.Range(-instanceRotationRandom, instanceRotationRandom),
                Random.Range(-instanceRotationRandom, instanceRotationRandom),
                Random.Range(-instanceRotationRandom, instanceRotationRandom)));
        }
    }

    private Vector3 GetInstancePostion()
    {
        return new Vector3(
        Random.Range(minPoint.position.x, maxPoint.position.x),
        gameObject.transform.position.y,
        Random.Range(minPoint.position.z, maxPoint.position.z));
    }
}
