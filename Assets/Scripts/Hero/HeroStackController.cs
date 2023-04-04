using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> _blockList = new List<GameObject>();
    public  GameObject _lastBlockObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateLastBlockObject()
    {
        _lastBlockObject = _blockList[_blockList.Count -1];
    }
    
    public void IncreaseBlockStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y +2f,transform.position.z);
        _gameObject.transform.position = new Vector3(_lastBlockObject.transform.position.x, 
        _lastBlockObject.transform.position.y-2f,_lastBlockObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        _blockList.Add(_gameObject);
        UpdateLastBlockObject();
    }

    public void DecreaseBlockStack(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        _blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }
}
