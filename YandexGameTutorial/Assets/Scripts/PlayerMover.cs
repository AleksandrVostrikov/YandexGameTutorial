using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _previousMousPosition;
    private float _eulerAngleY;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _previousMousPosition = Input.mousePosition.x;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 position = transform.position += transform.forward * _speed * Time.deltaTime;
            position.x = Mathf.Clamp(position.x, -2.5f, 2.5f);
            transform.position = position;

            float deltaX = Input.mousePosition.x - _previousMousPosition;
            _previousMousPosition = Input.mousePosition.x;
            _eulerAngleY += deltaX;
            _eulerAngleY = Mathf.Clamp(_eulerAngleY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerAngleY, 0);
        }
    }
}
