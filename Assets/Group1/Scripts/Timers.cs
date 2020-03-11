using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timers : MonoBehaviour
{
    [SerializeField] private float _interval;
    
    private List<Timer> _timerList;
    
    public event UnityAction TimeEnded;

    private void Start()
    {
        _timerList = new List<Timer>();
    }

    void Update()
    {
        foreach (Timer timer in _timerList)
        {
            timer.Tick(Time.deltaTime);

            if (timer.IsFinished)
                TimeEnded?.Invoke();
        }

        _timerList.RemoveAll(t => t.IsFinished);
    }

    public void Add()
    {
        Timer t = new Timer(_interval);
        _timerList.Add(t);
    }
}
