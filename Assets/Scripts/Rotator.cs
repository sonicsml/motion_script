using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private void Update( )
    {
            transform.rotation *= Quaternion.Euler(0, 0.3f, 0);
    }
}
