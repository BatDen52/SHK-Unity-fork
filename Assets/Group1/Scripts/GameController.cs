﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private PlayerController _player;

    private void Update()
    {
        if (((EnemyController[])FindObjectsOfType(typeof(EnemyController))).Length == 0)
        {
            End();
            _player.enabled = false;
        }
    }

    public void End()
    {
        _endPanel.SetActive(true);
    }
}
