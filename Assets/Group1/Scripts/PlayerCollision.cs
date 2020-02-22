using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private TimerManager _timer;

    private PlayerController _player;
    private List<EnemyController> _enemyList;
    private List<SpeedUp> _speedUpList;

    void Start()
    {
        _enemyList = ((EnemyController[])FindObjectsOfType(typeof(EnemyController))).ToList();
        _speedUpList = ((SpeedUp[])FindObjectsOfType(typeof(SpeedUp))).ToList();
    }

    void Update()
    {
        foreach (EnemyController enemy in _enemyList)
        {
            if (Vector3.Distance(_player.transform.position, enemy.transform.position) < 0.2f)
            {
                KillEnemy(enemy);
                _enemyList.Remove(enemy);
            }
        }

        foreach (SpeedUp speedUp in _speedUpList)
        {
            if (Vector3.Distance(_player.transform.position, speedUp.transform.position) < 0.2f)
            {
                _timer.Add();
                _player.SpeedUpStarting();
                Destroy(speedUp.gameObject);
                _speedUpList.Remove(speedUp);
            }
        }
    }

    public void KillEnemy(EnemyController enemy)
    {
        Destroy(enemy.gameObject);
    }

    private void PlayerSpeedUpEnding()
    {
        _player.SpeedUpEnding();
    }

    private void OnEnable()
    {
        _player = GetComponent<PlayerController>();
        _timer.EndOfTime += PlayerSpeedUpEnding;
    }

    private void OnDisable()
    {
        _timer.EndOfTime -= _player.SpeedUpEnding;
    }
}
