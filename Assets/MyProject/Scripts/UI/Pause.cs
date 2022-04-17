using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    string cancel = "Cancel";
    bool pause = false;
    [SerializeField]GameObject GO;

    private void Awake()
    {
    }
    void Update()
    {
        if (Input.GetButtonDown(cancel))
        {
            if (pause)
            {
                Time.timeScale = 1;
                GO.SetActive(false);
                pause = false;
            }
            else
            {
                Time.timeScale = 0;
                GO.SetActive(true);
                pause = true;
            }
        }
    }
}
