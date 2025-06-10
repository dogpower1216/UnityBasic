using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gacha : MonoBehaviour
{
    // 기존 캐릭터 리스트 선언 및 초기화 (Awake 함수 내)는 동일합니다.
    public List<string> sRankCharacters = new List<string>();
    public List<string> aRankCharacters = new List<string>();
    public List<string> bRankCharacters = new List<string>();
    public List<string> cRankCharacters = new List<string>();

    void Awake()
    {
        // --- S 등급 캐릭터 (5명) ---
        sRankCharacters.Add("전설의 용사 아서");
        sRankCharacters.Add("신비한 마법사 엘라");
        sRankCharacters.Add("불멸의 기사 제이");
        sRankCharacters.Add("어둠의 그림자 리오");
        sRankCharacters.Add("빛의 성녀 루나");

        // --- A 등급 캐릭터 (10명) ---
        aRankCharacters.Add("정의의 궁수 론");
        aRankCharacters.Add("강철의 전사 브루스");
        aRankCharacters.Add("바람의 요정 실피드");
        aRankCharacters.Add("얼음의 마녀 프리야");
        aRankCharacters.Add("불꽃의 정령사 이그니스");
        aRankCharacters.Add("수호자 크로노스");
        aRankCharacters.Add("방랑자 케인");
        aRankCharacters.Add("치유사 세라");
        aRankCharacters.Add("닌자 카이");
        aRankCharacters.Add("음유시인 아리아");

        // --- B 등급 캐릭터 (15명) ---
        bRankCharacters.Add("견습 기사 알렉스");
        bRankCharacters.Add("활기찬 모험가 릴리");
        bRankCharacters.Add("평범한 병사 존");
        bRankCharacters.Add("민첩한 도적 진");
        bRankCharacters.Add("숲의 사냥꾼 닉");
        bRankCharacters.Add("탐험가 에밀리");
        bRankCharacters.Add("떠돌이 마법사 피터");
        bRankCharacters.Add("농부 데이비드");
        bRankCharacters.Add("강력한 도끼병");
        bRankCharacters.Add("명랑한 상인 캐롤");
        bRankCharacters.Add("기사단원 칼");
        bRankCharacters.Add("도서관 사서 클레어");
        bRankCharacters.Add("산적 두목");
        bRankCharacters.Add("견습 사제 로즈");
        bRankCharacters.Add("어부 빅터");

        // --- C 등급 캐릭터 (20명) ---
        cRankCharacters.Add("마을 주민 A");
        cRankCharacters.Add("허수아비");
        cRankCharacters.Add("초급 병사");
        cRankCharacters.Add("고블린 슬레이어");
        cRankCharacters.Add("작은 쥐");
        cRankCharacters.Add("어린 마법사 지망생");
        cRankCharacters.Add("순찰대원");
        cRankCharacters.Add("잡화상인");
        cRankCharacters.Add("농부의 아들");
        cRankCharacters.Add("광부 브라이언");
        cRankCharacters.Add("나무꾼 벤");
        cRankCharacters.Add("시장 상인 리사");
        cRankCharacters.Add("평범한 시민");
        cRankCharacters.Add("여행자 폴");
        cRankCharacters.Add("어린 궁수 지망생");
        cRankCharacters.Add("떠돌이 개");
        cRankCharacters.Add("폐지 줍는 노인");
        cRankCharacters.Add("고양이");
        cRankCharacters.Add("양");
        cRankCharacters.Add("쥐");

        Debug.Log("캐릭터 뽑기 시스템 준비 완료!");
    }

    /// <summary>
    /// 단일 캐릭터를 뽑고 그 결과를 (등급, 캐릭터 이름) 튜플로 반환하는 함수.
    /// </summary>
    /// <returns>뽑힌 캐릭터의 등급과 이름을 포함하는 튜플</returns>
    (string rank, string name) DrawSingleCharacter()
    {
        int randomNumber = Random.Range(0, 100);
        string resultRank = "Unknown";
        string resultCharacterName = "알 수 없는 캐릭터";

        if (randomNumber < 5) // S 등급 (5% 확률)
        {
            resultRank = "S";
            if (sRankCharacters.Count > 0)
            {
                int index = Random.Range(0, sRankCharacters.Count);
                resultCharacterName = sRankCharacters[index];
            }
        }
        else if (randomNumber < 20) // A 등급 (15% 확률)
        {
            resultRank = "A";
            if (aRankCharacters.Count > 0)
            {
                int index = Random.Range(0, aRankCharacters.Count);
                resultCharacterName = aRankCharacters[index];
            }
        }
        else if (randomNumber < 50) // B 등급 (30% 확률)
        {
            resultRank = "B";
            if (bRankCharacters.Count > 0)
            {
                int index = Random.Range(0, bRankCharacters.Count);
                resultCharacterName = bRankCharacters[index];
            }
        }
        else // C 등급 (50% 확률)
        {
            resultRank = "C";
            if (cRankCharacters.Count > 0)
            {
                int index = Random.Range(0, cRankCharacters.Count);
                resultCharacterName = cRankCharacters[index];
            }
        }

        // 이 부분은 뽑는 중간에 각 캐릭터가 뭔지 보고 싶을 때만 사용하세요.
         Debug.Log($"--- {resultRank} 등급: {resultCharacterName} 획득! ---");

        return (resultRank, resultCharacterName); // 등급과 이름을 함께 반환
    }

    /// <summary>
    /// 버튼 클릭 시 호출될 10연차 뽑기 함수입니다.
    /// 뽑기 결과를 등급별로 정렬하여 출력합니다.
    /// </summary>
    public void OnClickDrawTenPullsButton()
    {
        Debug.Log("\n--- 10연차 뽑기를 시작합니다! ---");

        // 등급별로 캐릭터를 저장할 List<string>들을 생성합니다.
        List<string> sResults = new List<string>();
        List<string> aResults = new List<string>();
        List<string> bResults = new List<string>();
        List<string> cResults = new List<string>();

        for (int i = 0; i < 10; i++) // 10번 반복하여 뽑기 수행
        {
            (string rank, string name) result = DrawSingleCharacter(); // 등급과 이름을 함께 받습니다.

            // 뽑힌 캐릭터를 해당 등급의 리스트에 추가합니다.
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

        Debug.Log("\n--- 10연차 뽑기 결과 요약 ---");

        // S 등급 결과 출력
        if (sResults.Count > 0)
        {
            Debug.Log($"S 등급 ({sResults.Count}개):");
            foreach (string characterName in sResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // A 등급 결과 출력
        if (aResults.Count > 0)
        {
            Debug.Log($"A 등급 ({aResults.Count}개):");
            foreach (string characterName in aResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // B 등급 결과 출력
        if (bResults.Count > 0)
        {
            Debug.Log($"B 등급 ({bResults.Count}개):");
            foreach (string characterName in bResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // C 등급 결과 출력
        if (cResults.Count > 0)
        {
            Debug.Log($"C 등급 ({cResults.Count}개):");
            foreach (string characterName in cResults)
            {
                Debug.Log($"- {characterName}");
            }
        }

        // 만약 아무것도 안 뽑혔다면 (이럴 리는 없지만)
        if (sResults.Count == 0 && aResults.Count == 0 && bResults.Count == 0 && cResults.Count == 0)
        {
            Debug.Log("아무것도 획득하지 못했습니다.");
        }
    }
}
