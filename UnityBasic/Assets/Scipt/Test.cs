using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string myname = "권우중";
    private string sex = "남";
    private string bloodtype = "A";
    private int age = 41;
    private int height = 176;
    private int weight = 88;
    private string mbti = "ESTJ";
    private string hobby = "레이싱";
    private string specialty = "칵테일제조";
    private string Like = "여행";

    void Start()
    {

        Debug.Log($"나의 이름은 {myname}입니다.");
        Debug.Log($"나의 성별은 {sex}입니다.");
        Debug.Log($"나의 혈액형은 {bloodtype}입니다.");
        Debug.Log($"나의 나이는 {age}세 입니다.");
        Debug.Log($"나의 키는 {height}입니다.");
        Debug.Log($"나의 몸무게는 {weight}입니다.");
        Debug.Log($"나의 mbti는 {mbti}입니다.");
        Debug.Log($"나의 취미는 {hobby}입니다.");
        Debug.Log($"나의 특기는 {specialty}입니다.");
        Debug.Log($"나의 기호는 {Like}입니다.");
    }
}