using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpActivator : PlayerDistanceChecker
{
    [SerializeField] private Timers _timer;

    private void Update()
    {
        CheckDistance(SpeedUpPlayer);
    }

    private void SpeedUpPlayer()
    {
        _timer.Add();
        _player.SpeedUp();
    }
}
