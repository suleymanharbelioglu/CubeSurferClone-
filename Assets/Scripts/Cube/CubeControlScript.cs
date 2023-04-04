using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    public HeroStackController _heroStackController;
    public bool _isStack = false;
    public RaycastHit _raycastHit;
    public Vector3 _direction = Vector3.back;
    // Start is called before the first frame update
    void Start()
    {
        _heroStackController = GameObject.FindObjectOfType<HeroStackController>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetCubeRaycast();
        
    }
    public void SetCubeRaycast()
    {
        if(Physics.Raycast(transform.position, _direction, out _raycastHit,1f))
        {
            if(!_isStack)
            {
                _isStack = true;
                _heroStackController.IncreaseBlockStack(gameObject);
                SetDirection();
                
            }
            else{
                if(_raycastHit.transform.name == "ObstacleCube")
                {
                    _heroStackController.DecreaseBlockStack(gameObject);
                }
            }
        }
    }
    public void SetDirection()
    {
        _direction = Vector3.forward;
    }
}
