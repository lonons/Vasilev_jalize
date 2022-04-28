using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int MaxHealth = 10;
    int curHealth;
    void Awake()
    {
        curHealth = MaxHealth;
    }

    public void Hit(int Damage)
    {
        curHealth -= Damage;
        if (curHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        gameObject.SetActive(false);
    }

    public float hp ()
    {
        return curHealth;
    }

    public float MaxHp()
    {
        return MaxHealth;
    }
}
