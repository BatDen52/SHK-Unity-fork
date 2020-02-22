using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _radiusGenerationPosition;
    [SerializeField] private float _speed;

    private Mover _enemy;
    private Vector3 _targetPosition;

    void Start()
    {
        _enemy = GetComponent<Mover>();
        GenerateNewTargetPosition();
    }

    private void Update()
    {
        _enemy.MoveToTarget(_targetPosition, _speed);

        if (transform.position == _targetPosition)
            GenerateNewTargetPosition();
    }

    private void GenerateNewTargetPosition()
    {
        _targetPosition = Random.insideUnitCircle * _radiusGenerationPosition;
    }
}
