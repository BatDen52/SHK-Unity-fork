using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timers : MonoBehaviour
{
    private List<Timer> _timers;
    
    private void Start()
    {
        _timers = new List<Timer>();
    }

    private void Update()
    {
        foreach (Timer timer in _timers)
            timer.Tick(Time.deltaTime);

        _timers.RemoveAll(t => t.IsFinished);
    }

    public void Add(float interval, UnityAction timeEndedHandler)
    {
        Timer timer = new Timer(interval, timeEndedHandler);
        _timers.Add(timer);
    }
}
