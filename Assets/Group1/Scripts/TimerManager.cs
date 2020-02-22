using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private float _interval;
    
    private List<Timer> _timerList;

    public event UnityAction EndOfTime;

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
            {
                EndOfTime?.Invoke();
                _timerList.Remove(timer);
            }
        }
    }

    public void Add()
    {
        Timer t = new Timer(_interval);
        _timerList.Add(t);
    }
}
