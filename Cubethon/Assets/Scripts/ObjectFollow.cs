using UnityEngine;

public class ObjectFollow : MonoBehaviour
{
    
    public Transform follow;
    public Vector3 offset;

    void Update()
    {
        transform.position = follow.position + offset;
    }
}
