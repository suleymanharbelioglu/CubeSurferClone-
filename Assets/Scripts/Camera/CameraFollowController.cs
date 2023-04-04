using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    public Transform _heroTransform;
    public Vector3 _offset;
    public Vector3 _newPosition;
    public float _lerpValue;
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _heroTransform.position ;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        SetCameraSmoothFollow();

    }

    public void SetCameraSmoothFollow()
    {
        _newPosition = Vector3.Lerp(transform.position, 
        new Vector3(0f,_heroTransform.position.y, _heroTransform.position.z ) + _offset, _lerpValue*Time.deltaTime);
        transform.position = _newPosition;
    }
}
