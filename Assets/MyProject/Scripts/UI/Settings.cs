using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    [SerializeField] private Button back;
    [SerializeField] private Slider volume;
    public AudioMixer _MasterMixer;
    // Start is called before the first frame update
    void Awake()
    {
        back.onClick.AddListener(Back);
        volume.onValueChanged.AddListener(Volume);
    }

    private void Back()
    {
        gameObject.SetActive(false);
    }
    private void Volume(float arg)
    {
        _MasterMixer.SetFloat("Master",arg);
    }

}
