using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class PlayerDistanceChecker : MonoBehaviour
{
    [SerializeField] protected PlayerMover _player;

    protected void CheckDistance(UnityAction collisionHandler)
    {
        if (Vector3.Distance(_player.transform.position, transform.position) < 0.2f)
        {
            collisionHandler?.Invoke();
            Destroy(gameObject);
        }
    }
}
