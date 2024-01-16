using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private float _speed;

    private Transform _transform;
    private Vector3 _startPosition;

    private void Awake()
    {
        _transform = transform;
        _startPosition = _transform.position;
    }

    private void Update()
    {
        float step = Mathf.PingPong(Time.time * _speed, _distance);
        Vector3 newPosition = _startPosition + (_transform.forward * step);

        _transform.position = newPosition;
    }

}
