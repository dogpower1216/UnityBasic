using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string myname = "�ǿ���";
    private string sex = "��";
    private string bloodtype = "A";
    private int age = 41;
    private int height = 176;
    private int weight = 88;
    private string mbti = "ESTJ";
    private string hobby = "���̽�";
    private string specialty = "Ĭ��������";
    private string Like = "����";

    void Start()
    {

        Debug.Log($"���� �̸��� {myname}�Դϴ�.");
        Debug.Log($"���� ������ {sex}�Դϴ�.");
        Debug.Log($"���� �������� {bloodtype}�Դϴ�.");
        Debug.Log($"���� ���̴� {age}�� �Դϴ�.");
        Debug.Log($"���� Ű�� {height}�Դϴ�.");
        Debug.Log($"���� �����Դ� {weight}�Դϴ�.");
        Debug.Log($"���� mbti�� {mbti}�Դϴ�.");
        Debug.Log($"���� ��̴� {hobby}�Դϴ�.");
        Debug.Log($"���� Ư��� {specialty}�Դϴ�.");
        Debug.Log($"���� ��ȣ�� {Like}�Դϴ�.");
    }
}