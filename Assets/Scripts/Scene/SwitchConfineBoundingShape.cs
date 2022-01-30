using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwitchBoundingShape();
    }

    /// <summary>
    /// Switch the collider that cinemachine uses to define the edges of the screen
    /// </summary>
    private void SwitchBoundingShape()
    {
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();
        CinemachineConfiner2D cinemachineConfiner2D = GetComponent<CinemachineConfiner2D>();
        cinemachineConfiner2D.m_BoundingShape2D = polygonCollider2D;

        // clear the cache since confiner bounds have changed
        cinemachineConfiner2D.InvalidateCache();
    }
}
