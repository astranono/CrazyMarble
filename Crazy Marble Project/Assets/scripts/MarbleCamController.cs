using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCamController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Transform _target;
    [SerializeField]
    private int _zDistance;
    [SerializeField]

    private int _yDistance;

    // Update is called once per frame
    void Update()
    {
        Vector3 p = _target.position;
        p.z = p.z - _zDistance;
        p.y += _yDistance;
        transform.position = p;
    }
}
