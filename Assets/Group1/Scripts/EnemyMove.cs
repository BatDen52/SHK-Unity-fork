using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private int _targetDeltaPosition;
    [SerializeField] private int _speed;
    [SerializeField] private PlayerController _player;

    private Vector3 _targetPosition;

    void Start()
    {
        _targetPosition = Random.insideUnitCircle * _targetDeltaPosition;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        
        if (transform.position == _targetPosition)
            _targetPosition = Random.insideUnitCircle * _targetDeltaPosition;

        if (Vector3.Distance(_player.transform.position, this.transform.position) < 0.2f)
            _player.SendMessage(this.gameObject);
    }
}
