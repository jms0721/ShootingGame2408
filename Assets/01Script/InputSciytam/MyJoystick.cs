using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Transform handle;   // ������ ���۹����� �ð������� üũ�غ��� ���ؼ�.
    private Transform pivot;    // ������ ������� Ȯ���ϱ� ���� ���� ��. 
    private float distance;  // handle�� ���̽�ƽ�� �߽ɺο��� ��ŭ �־������� �Ÿ��� ����.
    private Vector2 direction;

    // direction �� ���� �ܺο��� �б⸸ �����ϵ��� Direction����. 
    // ĸ��ȭ 
    public Vector2 Direction => direction;


    private void Awake()
    {
        InitJoystick(); // ���Ƿ� ȣ��. ���Ŀ��� ���ӸŴ������� �����ϵ���. 
    }

    public void InitJoystick()
    {
        handle = transform.Find("Handle");
        pivot = transform.Find("Pivot");
    }



    // ���콺�� ��ġ�� handle ��ġ�� �����ϰ�, 
    // �����ϸ鼭, pivot���� �� �־������� �ʰ� ������ �ϰ�,
    // direction �� ���� ����. 
    public void OnDrag(PointerEventData eventData)
    {
        if(handle != null && pivot != null)
        {
            distance = Vector2.Distance(transform.position, pivot.position);//Distance �޼ҵ� : ���� ����

            handle.position = eventData.position;
            
            float currentDist = Vector2.Distance(transform.position, handle.position);

            direction = (handle.position - transform.position).normalized;

            if(currentDist > distance)// ���� ������ �ڵ��� �̵�
            {
                handle.localPosition = direction * distance;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    // handle �ʱ� ��ġ�� ���ñ��ؿ� 0, 0, 0���� ����. 
    public void OnPointerUp(PointerEventData eventData)
    {
        direction = Vector2.zero;
        handle.localPosition = Vector3.zero;
    }
}
