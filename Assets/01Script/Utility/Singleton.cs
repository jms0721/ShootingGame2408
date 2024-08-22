using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. ���� ������ �Ǵ��� �ν��Ͻ��� �ı����� �ʰ�, ������ �����ִ� �̱���.
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Inst { get; private set; }

    protected virtual void Awake()
    {
        if (Inst == null)
        {
            Inst = this as T;
            DontDestroyOnLoad(gameObject); // �ڽ��� ��ü�� �ı����� �ʵ��� ����.
        }
        else
        {
            Destroy(gameObject);
        }
    }

    protected virtual void DoAwake() { } // �Ļ�Ŭ�������� �ڽ��� �ʱ�ȭ�� �ʿ��� ����
}

// 2. ���� ������ �Ǹ�, �ν��Ͻ��� �ı��� �Ǵ� �̱���.
public class SingletonDestroy<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Inst { get; private set; }

    protected virtual void Awake()
    {
        if (Inst == null)
        {
            Inst = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
        DoAwake();
    }

    protected virtual void DoAwake() { }
}