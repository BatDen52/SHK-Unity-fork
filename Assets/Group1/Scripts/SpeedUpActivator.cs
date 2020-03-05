using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpActivator : MonoBehaviour
{
    [SerializeField] private TimerManager _timer;
    [SerializeField] private PlayerMover _player;

    void Update()
    {
        if (Vector3.Distance(_player.transform.position, transform.position) < 0.2f)
        {
            _timer.Add();

            _player.SpeedUpStart();

            Destroy(gameObject);
        }
    }
}
