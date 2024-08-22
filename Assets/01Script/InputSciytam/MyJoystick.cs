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

    // direction�� ���� �ܺο��� �б⸸ �����ϵ��� Direction����
    // ĸ��ȭ
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

    // ���콺�� ��ġ�� handle ��ġ�� �����ϰ�,
    // �����ϸ�, pivot���� �� �־������� �ʰ� ������ �ϰ�,
    // direction�� ���� ����.
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    // handle �ʱ� ��ġ�� ���ñ��ؿ� 0,0,0���� ����
    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
