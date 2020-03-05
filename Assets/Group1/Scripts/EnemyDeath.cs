using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private PlayerMover _player;

    public event UnityAction Deathed;

    private void Update()
    {
        if (Vector3.Distance(_player.transform.position, transform.position) < 0.2f)
        {
            Destroy(gameObject);
            Deathed?.Invoke();
        }
    }
}
