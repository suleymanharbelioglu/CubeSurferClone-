using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovementController : MonoBehaviour
{
   public HeroInputController _heroInputController;
    public float _forwardMovementSpeed;
    public float _horizontalMovementSpeed;
    public float _horizontalLimitValue;
    public float _newPositionX;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        SetHeroForwardMovement();
        SetHeroHorizontalMovement();

    }

    public void SetHeroForwardMovement()
    {
        transform.Translate(Vector3.down *_forwardMovementSpeed*Time.fixedDeltaTime);
    }

    public void SetHeroHorizontalMovement()
    {
        _newPositionX = transform.position.x + _heroInputController._horizontalValue*_horizontalMovementSpeed* Time.fixedDeltaTime;
        _newPositionX = Mathf.Clamp(_newPositionX, -_horizontalLimitValue, _horizontalLimitValue);
        transform.position = new Vector3(_newPositionX, transform.position.y, transform.position.z);
    }
}
