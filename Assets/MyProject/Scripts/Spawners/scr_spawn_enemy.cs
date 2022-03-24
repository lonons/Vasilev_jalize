using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_spawn_enemy : MonoBehaviour
{
    [SerializeField] private GameObject[] spots_enemy_spawner; // префабы точки спавна противников
    [SerializeField] private GameObject enemy; // префаб противника

    [SerializeField] private int count_spawn_enemy = 1; // кол-во противников, которое будет создано
    [SerializeField] private float timer_spawn_enemy_second = 10; // сколько секунд между спавном
    private float temp_timer = 0;
    private int count_spawn = 0; // переменная для отслеживания кол-ва уже создангных врагов
    private System.Random rand = new System.Random();

    bool timerIsRunning = true;

    private void Start()
    {
        temp_timer = timer_spawn_enemy_second;
    }
    private void Update()
    {
        if (timerIsRunning) 
        {
            if (temp_timer > 0) temp_timer -= Time.deltaTime;
            else
            {
                int indexSpot = rand.Next(spots_enemy_spawner.Length); //выбор точки создания противника из созданного массива
                Instantiate(enemy, spots_enemy_spawner[indexSpot].transform.position, spots_enemy_spawner[indexSpot].transform.rotation);
                temp_timer = timer_spawn_enemy_second;
                count_spawn++;
                if (count_spawn+1 > count_spawn_enemy) timerIsRunning = false;
            }
        }
    }
}
