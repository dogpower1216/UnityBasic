using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    string[] character = { "������", "���ѳ�", "�ռ���", "����ȣ", "������", "��ä��", "������", "������" };
    List<string> characterList = new List<string> { };
    private void Start()
    {
        characterList.Add("������");
        characterList.Add("���ѳ�");
        characterList.Add("�ռ���");
        characterList.Add("����ȣ");
        characterList.Add("������");
        characterList.Add("��ä��");
        characterList.Add("������");
        characterList.Add("������");
    }
    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0~7

        Debug.Log("������ ? " + character[randomValue] + "�� �����ϴ�.");
        //Txt_Bumin.text = "������? " + character[randomValue] + "�� �����ϴ�.";
    }

    public void ListGacha() // character.Count
    {
        int randomValue = Random.Range(0, characterList.Count); //8 , 0 ~ 7
      //  Txt_bumin.text = "������? " + characterList[randomValue] + "�� �����ϴ�.";
    }

    public void AddList()
    {
        // character �迭���� ��� �̸��� �ֽ��ϴ� .
        // characterList���� �ƹ� �����͵� �����ϴ� .

        // character �迭�� �����͸� characterList���ٰ� �־��ִ� ���� ����� ���ô�.
        // �츮�� ��� �ݺ����� ����ؼ� ����� ���ô�.

        
            for (int i = 0; i < character.Length; i++)
        {
            characterList.Add(character[i]);
        }
    for(int i = 0; i < characterList.Count;i++)
        {
            Debug.Log(characterList[i]);
        }
    }
}
