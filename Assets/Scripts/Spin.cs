using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1f;

    private void LateUpdate()
    {
        var newVec = Quaternion.Euler(0, 0, _rotationSpeed);
        transform.Rotate(newVec.eulerAngles);
    }
}
