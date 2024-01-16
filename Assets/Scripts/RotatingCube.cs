using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    [SerializeField] private float _zRotationSpeed;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        _transform.Rotate(0f, _zRotationSpeed * Time.deltaTime, 0f);
    }
}