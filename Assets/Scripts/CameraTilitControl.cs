using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public float tiltSpeed;
    public float tiltUpperLimit;
    public float tiltLowerLimit;
    private float _currentTilt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xrot = Input.GetAxis("Mouse Y");
        _currentTilt += xrot * tiltSpeed * Time.deltaTime;
        _currentTilt = Mathf.Clamp(_currentTilt, tiltLowerLimit, tiltUpperLimit);
        transform.localRotation = Quaternion.Euler(_currentTilt, 0, 0);
    }
}
