using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float _speed = 100f;
    private void Update()
    {   
        transform.Rotate(0, _speed * Time.deltaTime, 0, Space.Self);
    }
}
