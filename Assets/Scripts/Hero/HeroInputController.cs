using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    public float _horizontalValue;
    public float HorizontalValue 
    {
        get{return _horizontalValue;}

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleHeroHorizontalInput();
        
    }
    public void HandleHeroHorizontalInput()
    {
        if(Input.GetMouseButton(0))
        {
            _horizontalValue = Input.GetAxis("Mouse X");
        }
        else{
            _horizontalValue = 0;
        }
    }
}
