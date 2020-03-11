using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Timers))]
public class TimersEventSubscription : MonoBehaviour
{
    [SerializeField] private PlayerMover _player;

    private Timers _timer;

    private void OnEnable()
    {
        _timer = GetComponent<Timers>();
        _timer.TimeEnded += _player.SpeedDown;
    }

    private void OnDisable()
    {
        _timer.TimeEnded -= _player.SpeedDown;
    }
}
