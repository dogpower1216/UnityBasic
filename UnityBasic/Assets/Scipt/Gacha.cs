using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gacha : MonoBehaviour
{
    // ���� ĳ���� ����Ʈ ���� �� �ʱ�ȭ (Awake �Լ� ��)�� �����մϴ�.
    public List<string> sRankCharacters = new List<string>();
    public List<string> aRankCharacters = new List<string>();
    public List<string> bRankCharacters = new List<string>();
    public List<string> cRankCharacters = new List<string>();

    void Awake()
    {
        // --- S ��� ĳ���� (5��) ---
        sRankCharacters.Add("������ ��� �Ƽ�");
        sRankCharacters.Add("�ź��� ������ ����");
        sRankCharacters.Add("�Ҹ��� ��� ����");
        sRankCharacters.Add("����� �׸��� ����");
        sRankCharacters.Add("���� ���� �糪");

        // --- A ��� ĳ���� (10��) ---
        aRankCharacters.Add("������ �ü� ��");
        aRankCharacters.Add("��ö�� ���� ��罺");
        aRankCharacters.Add("�ٶ��� ���� ���ǵ�");
        aRankCharacters.Add("������ ���� ������");
        aRankCharacters.Add("�Ҳ��� ���ɻ� �̱״Ͻ�");
        aRankCharacters.Add("��ȣ�� ũ�γ뽺");
        aRankCharacters.Add("����� ����");
        aRankCharacters.Add("ġ���� ����");
        aRankCharacters.Add("���� ī��");
        aRankCharacters.Add("�������� �Ƹ���");

        // --- B ��� ĳ���� (15��) ---
        bRankCharacters.Add("�߽� ��� �˷���");
        bRankCharacters.Add("Ȱ���� ���谡 ����");
        bRankCharacters.Add("����� ���� ��");
        bRankCharacters.Add("��ø�� ���� ��");
        bRankCharacters.Add("���� ��ɲ� ��");
        bRankCharacters.Add("Ž�谡 ���и�");
        bRankCharacters.Add("������ ������ ����");
        bRankCharacters.Add("��� ���̺��");
        bRankCharacters.Add("������ ������");
        bRankCharacters.Add("����� ���� ĳ��");
        bRankCharacters.Add("���ܿ� Į");
        bRankCharacters.Add("������ �缭 Ŭ����");
        bRankCharacters.Add("���� �θ�");
        bRankCharacters.Add("�߽� ���� ����");
        bRankCharacters.Add("��� ����");

        // --- C ��� ĳ���� (20��) ---
        cRankCharacters.Add("���� �ֹ� A");
        cRankCharacters.Add("����ƺ�");
        cRankCharacters.Add("�ʱ� ����");
        cRankCharacters.Add("��� �����̾�");
        cRankCharacters.Add("���� ��");
        cRankCharacters.Add("� ������ ������");
        cRankCharacters.Add("�������");
        cRankCharacters.Add("��ȭ����");
        cRankCharacters.Add("����� �Ƶ�");
        cRankCharacters.Add("���� ����̾�");
        cRankCharacters.Add("������ ��");
        cRankCharacters.Add("���� ���� ����");
        cRankCharacters.Add("����� �ù�");
        cRankCharacters.Add("������ ��");
        cRankCharacters.Add("� �ü� ������");
        cRankCharacters.Add("������ ��");
        cRankCharacters.Add("���� �ݴ� ����");
        cRankCharacters.Add("�����");
        cRankCharacters.Add("��");
        cRankCharacters.Add("��");

        Debug.Log("ĳ���� �̱� �ý��� �غ� �Ϸ�!");
    }

    /// <summary>
    /// ���� ĳ���͸� �̰� �� ����� (���, ĳ���� �̸�) Ʃ�÷� ��ȯ�ϴ� �Լ�.
    /// </summary>
    /// <returns>���� ĳ������ ��ް� �̸��� �����ϴ� Ʃ��</returns>
    (string rank, string name) DrawSingleCharacter()
    {
        int randomNumber = Random.Range(0, 100);
        string resultRank = "Unknown";
        string resultCharacterName = "�� �� ���� ĳ����";

        if (randomNumber < 5) // S ��� (5% Ȯ��)
        {
            resultRank = "S";
            if (sRankCharacters.Count > 0)
            {
                int index = Random.Range(0, sRankCharacters.Count);
                resultCharacterName = sRankCharacters[index];
            }
        }
        else if (randomNumber < 20) // A ��� (15% Ȯ��)
        {
            resultRank = "A";
            if (aRankCharacters.Count > 0)
            {
                int index = Random.Range(0, aRankCharacters.Count);
                resultCharacterName = aRankCharacters[index];
            }
        }
        else if (randomNumber < 50) // B ��� (30% Ȯ��)
        {
            resultRank = "B";
            if (bRankCharacters.Count > 0)
            {
                int index = Random.Range(0, bRankCharacters.Count);
                resultCharacterName = bRankCharacters[index];
            }
        }
        else // C ��� (50% Ȯ��)
        {
            resultRank = "C";
            if (cRankCharacters.Count > 0)
            {
                int index = Random.Range(0, cRankCharacters.Count);
                resultCharacterName = cRankCharacters[index];
            }
        }

        // �� �κ��� �̴� �߰��� �� ĳ���Ͱ� ���� ���� ���� ���� ����ϼ���.
         Debug.Log($"--- {resultRank} ���: {resultCharacterName} ȹ��! ---");

        return (resultRank, resultCharacterName); // ��ް� �̸��� �Բ� ��ȯ
    }

    /// <summary>
    /// ��ư Ŭ�� �� ȣ��� 10���� �̱� �Լ��Դϴ�.
    /// �̱� ����� ��޺��� �����Ͽ� ����մϴ�.
    /// </summary>
    public void OnClickDrawTenPullsButton()
    {
        Debug.Log("\n--- 10���� �̱⸦ �����մϴ�! ---");

        // ��޺��� ĳ���͸� ������ List<string>���� �����մϴ�.
        List<string> sResults = new List<string>();
        List<string> aResults = new List<string>();
        List<string> bResults = new List<string>();
        List<string> cResults = new List<string>();

        for (int i = 0; i < 10; i++) // 10�� �ݺ��Ͽ� �̱� ����
        {
            (string rank, string name) result = DrawSingleCharacter(); // ��ް� �̸��� �Բ� �޽��ϴ�.

            // ���� ĳ���͸� �ش� ����� ����Ʈ�� �߰��մϴ�.
            switch (result.rank)
            {
                case "S":
                    sResults.Add(result.name);
                    break;
                case "A":
                    aResults.Add(result.name);
                    break;
                case "B":
                    bResults.Add(result.name);
                    break;
                case "C":
                    cResults.Add(result.name);
                    break;
            }
        }

        Debug.Log("\n--- 10���� �̱� ��� ��� ---");

        // S ��� ��� ���
        if (sResults.Count > 0)
        {
            Debug.Log($"S ��� ({sResults.Count}��):");
            foreach (string characterName in sResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // A ��� ��� ���
        if (aResults.Count > 0)
        {
            Debug.Log($"A ��� ({aResults.Count}��):");
            foreach (string characterName in aResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // B ��� ��� ���
        if (bResults.Count > 0)
        {
            Debug.Log($"B ��� ({bResults.Count}��):");
            foreach (string characterName in bResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // C ��� ��� ���
        if (cResults.Count > 0)
        {
            Debug.Log($"C ��� ({cResults.Count}��):");
            foreach (string characterName in cResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // ���� �ƹ��͵� �� �����ٸ� (�̷� ���� ������)
        if (sResults.Count == 0 && aResults.Count == 0 && bResults.Count == 0 && cResults.Count == 0)
        {
            Debug.Log("�ƹ��͵� ȹ������ ���߽��ϴ�.");
        }
    }
}
