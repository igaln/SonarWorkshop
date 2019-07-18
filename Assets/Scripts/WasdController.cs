using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasdController : MonoBehaviour
{
    [SerializeField]
    float _moveSpeed = 0.1f;

    [SerializeField]
    float _rotateSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) 
            return;

        var move = Vector3.zero;
        var rotate = 0f;

        if (Input.GetKey(KeyCode.W))
            move += transform.forward;
        if (Input.GetKey(KeyCode.A))
            move += -transform.right;
        if (Input.GetKey(KeyCode.S))
            move += -transform.forward;
        if (Input.GetKey(KeyCode.D))
            move += transform.right;

        if (Input.GetKey(KeyCode.E))
            rotate += 2;
        if (Input.GetKey(KeyCode.Q))
            rotate -= 2;

        var moveSpeed = move * _moveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
            moveSpeed *= 2;

        transform.Rotate(Vector3.up, _rotateSpeed * rotate);

        transform.position += moveSpeed;
    }
}
