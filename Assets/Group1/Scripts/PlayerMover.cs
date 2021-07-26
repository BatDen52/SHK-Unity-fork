using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _currentSpeed;

    private void Start()
    {
        _currentSpeed = _speed;
    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");

        if (horizontalDirection != 0 || verticalDirection != 0)
            Move(horizontalDirection, verticalDirection);
    }

    private void Move(float horizontalDirection, float verticalDirection)
    {
        Vector3 direction = new Vector3(horizontalDirection, verticalDirection);
        transform.Translate(direction * Time.deltaTime * _currentSpeed);
    }

    public void SpeedUp()
    {
        _currentSpeed += _speed;
    }

    public void SpeedDown()
    {
        _currentSpeed -= _speed;
    }
}
