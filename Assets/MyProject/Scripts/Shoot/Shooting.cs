using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private FindTarget findTarget;

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject bulletPrefab;

    private string fire1 = "Fire1";
    private bool isShoot = true;
    private bool start = false;

    private void Awake()
    {
        StartCoroutine(Shoot());
    }
    private void Update()
    {
        if (Input.GetAxis(fire1) == 1)
        {
            if (isShoot)
            {
                var bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
                isShoot = false;
            }
        }
        
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            isShoot = true;
            yield return new WaitForSeconds(1);
        }
        yield return null;
    }
}