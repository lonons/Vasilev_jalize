using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMine : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject minePrefab;

    private bool isMine = true;

    private string fire2 = "Fire2";
    private void Awake()
    {
        StartCoroutine(Mine());
    }

    private void Update()
    {
        if (Input.GetAxis(fire2) == 1 && isMine)
        {
            var bullet = Instantiate(minePrefab, spawnPoint.position, spawnPoint.rotation);
            isMine = false;
        }
    }
    private IEnumerator Mine()
    {
        while (true)
        {
            isMine = true;
            yield return new WaitForSeconds(3);
        }
        yield return null;
    }
}
