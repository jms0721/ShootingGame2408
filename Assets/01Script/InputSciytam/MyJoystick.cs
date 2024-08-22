using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Transform handle;
    private Transform pivot;
    private float distance;
    private Vector2 direction;

    // direction의 값을 외부에서 읽기만 가능하도록 Direction생성
    // 캡슐화
    public Vector2 Direction => direction;

    private void Awake()
    {
        InitJoystick();
    }

    public void InitJoystick()
    {
        handle = transform.Find("Handle");
        pivot = transform.Find("Pivot");
    }

    // 마우스의 위치로 handle 위치를 갱신하고,
    // 갱신하면, pivot보다 더 멀어지지는 않게 관리를 하고,
    // direction의 값을 생성.
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // handle 초기 위치인 로컬기준에 0,0,0으로 변경
    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
