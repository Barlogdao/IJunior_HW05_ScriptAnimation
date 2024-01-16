using UnityEngine;

public class GrowingCapsule : MonoBehaviour
{
    [SerializeField] private float _speed;
    [Min(0.1f)]
    [SerializeField] private float _maxScaleAddition;

    private Transform _transform;
    private Vector3 _startSize;

    private void Awake()
    {
        _transform = transform;
        _startSize = transform.localScale;
    }

    private void Update()
    {
        float scalingTime = Time.time * _speed;
        float step = Mathf.PingPong(scalingTime, _maxScaleAddition);
        Vector3 newSize = new Vector3(_startSize.x + step, _startSize.y + step, _startSize.z + step);

        _transform.localScale = newSize;
    }

}
