using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    LineRenderer _lineRenderer;
    Frog _frog;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _frog = FindObjectOfType<Frog>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_frog.IsDragging)
        {
            _lineRenderer.enabled = true;
            _lineRenderer.SetPosition(1, _frog.transform.position);
        }
        else {
            _lineRenderer.enabled = false;
        }
    }
}
