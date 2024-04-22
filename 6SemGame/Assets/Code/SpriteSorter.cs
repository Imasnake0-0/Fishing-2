using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isStatic;
    private int SortingOrderBase = 0;
    private Renderer renderer;
    public float offset = 0;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(SortingOrderBase - transform.position.y + offset);
        if (isStatic)
            Destroy(this);
    }
}
