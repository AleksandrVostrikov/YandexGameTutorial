using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position += transform.forward * _speed * Time.fixedDeltaTime;
        }
    }
}
