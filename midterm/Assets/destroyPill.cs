using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPill : MonoBehaviour
{
    public float life = 2f;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
