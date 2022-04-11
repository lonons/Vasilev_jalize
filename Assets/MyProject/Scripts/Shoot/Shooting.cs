using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FindTarget))]
public class Shooting : MonoBehaviour
{
    private FindTarget findTarget;

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject bulletPrefab;

    private void Start()
    {
        findTarget = GetComponent<FindTarget>();
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            var bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(1);
        }
        yield return null;
    }
}