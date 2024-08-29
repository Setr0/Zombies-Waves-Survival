using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTraveller : MonoBehaviour
{
    [SerializeField] float speed = 4f;

    [Space(20)]
    [SerializeField] Vector2 min;
    [SerializeField] Vector2 max;

    Vector2 targetPosition;

    void Start()
    {
        GetNewPosition();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, targetPosition) <= 0.25f)
            GetNewPosition();
    }

    void GetNewPosition()
    {
        targetPosition = new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));
    }
}
