using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed;
    float firstCursorPos;
    float lastCursorPos;

    void Start()
    {

    }

    void Update()
    {
        bool MouseButtonDown = Input.GetMouseButtonDown(0);
        bool MouseButtonUp = Input.GetMouseButtonUp(0);

        if (MouseButtonDown)
        {
            firstCursorPos = Input.mousePosition.x;
        }
        else if (MouseButtonUp)
        {
            lastCursorPos = Input.mousePosition.x;
            float distance = lastCursorPos - firstCursorPos;
            moveSpeed = distance * 0.0002f;
        }

        this.gameObject.transform.Translate(moveSpeed, 0, 0);

        moveSpeed *= 0.96f;

    }
}
