using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {

        Vector3 desiredPosition = target.position + offset; //Lavuðu eþittir yapsak olur mu ki acaba?
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
