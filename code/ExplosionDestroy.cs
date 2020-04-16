using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
    private void FixedUpdate()
    {
        Destroy(gameObject, 0.3f);
    }
}
