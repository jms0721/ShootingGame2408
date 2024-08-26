using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputJoystick : MonoBehaviour, IInputHandler
{
    private MyJoystick joystick;

    private void Awake()
    {
        joystick = FindAnyObjectByType<MyJoystick>();
    }

    public void InitJoystick()
    {
        joystick = FindAnyObjectByType<MyJoystick>();
        if (joystick == null)
            Debug.Log("InputJoystick.cs - InitJoystick() - 조이스틱 참조 실패");
    }
    public Vector2 GetInput()
    {
        return joystick.Direction;
    }
}
