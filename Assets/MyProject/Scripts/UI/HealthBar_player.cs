using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar_player : MonoBehaviour
{
    Health health;
    Image HealthBar;
    [SerializeField] string tag = "Player";
    GameObject unit;

    void Awake()
    {
        HealthBar = GetComponent<Image>();
        unit = GameObject.FindWithTag(tag);
        health = unit.GetComponent<Health>();
    }

    void Update()
    {
        HealthBar.fillAmount =  health.hp() / health.MaxHp();
    }
}
