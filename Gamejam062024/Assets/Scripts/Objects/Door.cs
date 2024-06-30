using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : ActivatedObject
{
    [SerializeField] private float _yOffset;
    [SerializeField] private Transform _transform;

    private Vector2 _doorPosition;
    private Vector2 _newDoorPosition;

    private void OnValidate()
    {
        if (_transform == null) _transform = transform;
        
        _doorPosition = _transform.position;
        _newDoorPosition = new Vector2(_doorPosition.x, _doorPosition.y + _yOffset);
    }

    private void FixedUpdate()
    {
        if (IsActive) transform.position = _newDoorPosition;
    }
}
