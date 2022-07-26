using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float degreesPerSecond = 5f;

    private Transform _transform;
    void Awake() 
    {
        _transform = transform;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Rotate(0f, 0f, degreesPerSecond * Time.deltaTime);
    }
}
