using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private float _speed;

    private Transform _transform;
    private float _startPositionZ;

    private void Awake()
    {
        _transform = transform;
        _startPositionZ = _transform.position.z;
    }

    private void Update()
    {
        float newPositionZ = _startPositionZ + Mathf.PingPong(Time.time * _speed, _distance);

        _transform.position = new Vector3(_transform.position.x, _transform.position.y, newPositionZ);
    }

}
