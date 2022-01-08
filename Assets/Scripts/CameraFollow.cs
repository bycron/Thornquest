using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public Transform playerTransform;
    [SerializeField] public float speed;
    [SerializeField] public float minX;
    [SerializeField] public float maxX;
    [SerializeField] public float minY;
    [SerializeField] public float maxY;

    private void Start() 
    {
        transform.position = playerTransform.position;
    }

    private void Update()
    {
        if (playerTransform != null) {

            float clampedX = Mathf.Clamp(playerTransform.position.x, minX, maxX);
            float clampedY = Mathf.Clamp(playerTransform.position.y, minY, maxY);

            transform.position = Vector2.Lerp(transform.position, new Vector2(clampedX, clampedY), speed);
        }
    }
}
