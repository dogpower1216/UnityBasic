using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor.UI;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star; // star 는 문자

    void Start() 
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // 페이즈 1
        for (int a = 1; a <= 5; a++) // 작업자 a 는 1 에서 5 까지 반복으로 작업을 해라 5에서 멈춘다 a 는 증가
        {
            for (int b = 1; b <= a; b++) // 작업자 b 는 a 숫자 만큼 별 찍는 작업을 해라
                star += "★"; // star 는 문자열로 ★를 사용
            star += "\n"; // 한줄 작업 이 끝났으면 줄을 건너뛰기
        }
        Debug.Log(star); //  프린트
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int a = 5; a >= 1; a--) // 작업자 a 는 5 부터 1까지 감소 . 1에서 멈춘다 . (다섯줄을 만든다)  a 는 감소
        {
            for (int b = 1; b <= a; b++) //작업자 b  는 a 숫자 만큼 별을 만든다 .
                star += "★";
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        for (int a = 1; a <= 5; a++)
        {
            for (int b = 1; b <= a; b++)
                star += "★";
            star += "\n";
        }
        for (int a = 4; a >= 1; a--) // 작업 하나 더 하고 끝내라
        {
            for (int b = 1; b <= a; b++)
                star += "★";
            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4

        for (int a = 1; a <= 5; a++) // 작업자 a 는 1 에서 5 까지 반복으로 작업을 해라 5에서 멈춘다 a 는 증가
        {
            for (int c = 1; c <= 5 - a; c++) //별 찍기 전에 작업자 c 가 공백을 만들어라 .
                star += "　"; // star에 빈칸을 추가할꺼다

            for (int b = 1; b <= a; b++) // 작업자 b 는 a 숫자 만큼 별 찍는 작업을 해라
                star += "★"; // star 는 문자열로 ★를 사용
            star += "\n"; // 한줄 작업 이 끝났으면 줄을 건너뛰기
        }
        for (int a = 4; a >= 1; a--) // 작업 하나 더 하고 끝내라
        {
            for (int c = 1; c <= 5 - a; c++)
                star += "　";

            for (int b = 1; b <= a; b++)
                star += "★";
            star += "\n";
        }
        Debug.Log(star); //  프린트
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5
        for (int a = 1; a <= 5; a++)
        {
            for (int c = 1; c <= 5 - a; c++)
            {
                star += "　";
            }

            for (int b = 1; b <= (2 * a) - 1; b++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int a = 4; a >= 1; a--) // 작업 하나 더 하고 끝내라

        {
            for (int c = 1; c <= 5 - a; c++)
                star += "　";

            for (int b = 1; b <= (2 * a) - 1; b++)
                star += "★";
            star += "\n";
        }

        Debug.Log(star);
    }
}