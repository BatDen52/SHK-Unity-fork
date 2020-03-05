using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverChecker : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private PlayerMover _player;

    private int _enemyCount;
    private EnemyDeath[] _enemyList;

    private void OnEnable()
    {
        _enemyList = FindObjectsOfType<EnemyDeath>();

        _enemyCount = _enemyList.Length;

        foreach (var enemy in _enemyList)
        {
            enemy.Deathed += OnEnemyDeathed;
        }
    }

    private void OnDisable()
    {
        foreach (var enemy in _enemyList)
        {
            enemy.Deathed -= OnEnemyDeathed;
        }
    }

    private void OnEnemyDeathed()
    {
        _enemyCount--;
    }

    private void Update()
    {
        if (_enemyCount == 0)
        {
            ShowEndScreen();
            _player.enabled = false;
        }
    }

    public void ShowEndScreen()
    {
        _endPanel.SetActive(true);
    }
}
