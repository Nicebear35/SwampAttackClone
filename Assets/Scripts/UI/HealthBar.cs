using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : Bar
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += OnValueChanged;   
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnValueChanged;          
    }
}