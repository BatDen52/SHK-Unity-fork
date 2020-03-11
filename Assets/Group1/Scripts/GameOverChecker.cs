using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameOverChecker : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private PlayerMover _player;

    private List<EnemyDeathTrigger> _enemyList;

    private void OnEnable()
    {
        _enemyList = FindObjectsOfType<EnemyDeathTrigger>().ToList();

        foreach (var enemy in _enemyList)
        {
            enemy.Died += OnEnemyDeathed;
        }
    }

    private void OnDisable()
    {
        foreach (var enemy in _enemyList)
        {
            enemy.Died -= OnEnemyDeathed;
        }
    }

    private void OnEnemyDeathed(EnemyDeathTrigger enemy)
    {
        _enemyList.Remove(enemy);
    }

    private void Update()
    {
        if (_enemyList.Count == 0)
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
