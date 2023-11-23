using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _lantern;

    private bool _isLantern;

    private void Start()
    {
        _isLantern = false;
        _lantern.SetActive(false);
    }

    private void Update()
    {
        OnLantern();
    }

    private void OnLantern()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (!_isLantern)
            {
                _lantern.SetActive(true);
                _isLantern = true;
            }
            else
            {
                _lantern.SetActive(false);
                _isLantern = false;
            }
            
        }
    }
}
