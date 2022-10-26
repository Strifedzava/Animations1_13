using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 1;
    void Update()
    {
        transform.position += transform.forward * Speed*Time.deltaTime;
    }
}
