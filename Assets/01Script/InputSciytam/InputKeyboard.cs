using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboard : MonoBehaviour, IInputHandler
{
    public Vector2 GetInput()
    {
        return new Vector2(Input.GetAxis("Horixzontal"), Input.GetAxis("Vectical"));
    }
}
