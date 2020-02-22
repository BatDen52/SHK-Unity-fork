using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Mover))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _currentSpeed;
    private Mover _player;

    private void Start()
    {
        _player = GetComponent<Mover>();
        _currentSpeed = _speed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            _player.MoveUp(_currentSpeed);

        if (Input.GetKey(KeyCode.S))
            _player.MoveDown(_currentSpeed);

        if (Input.GetKey(KeyCode.A))
            _player.MoveLeft(_currentSpeed);

        if (Input.GetKey(KeyCode.D))
            _player.MoveRight(_currentSpeed);
    }
    
    public void SpeedUpStarting()
    {
        _currentSpeed += _speed;
    }

    public void SpeedUpEnding()
    {
        _currentSpeed -= _speed;
    }
}
