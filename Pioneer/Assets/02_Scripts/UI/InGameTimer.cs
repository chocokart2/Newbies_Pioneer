using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameTimer : MonoBehaviour
{
    /*[Header("시계 UI 설정")]
    public TextMeshProUGUI clockText;

    [Header("시간 설정")]
    [Tooltip("게임 하루의 총 '실제' 시간 (초 단위)")]
    public float realSecondsPerFullDay = 270f; // 4분 30초

    [Tooltip("게임 시작 시간 (0~24시)")]
    public float startHour = 6f;

    [Header("아이콘 설정")]
    public GameObject dayIcon;
    public GameObject NightIcon;

    [HideInInspector]
    public float gameHoursPerDay;     // 게임 기준 낮 시간 (16시간)
    [HideInInspector]
    public float gameHoursPerNight;   // 게임 기준 밤 시간 (8시간)

    private float currentDayTimeInSeconds;
    private float timeMultiplier;

    void Start()
    {
        dayIcon.SetActive(true);
        NightIcon.SetActive(false);

        // 1. 시간 배율 계산
        // 24시간(86400초) / 실제 하루 시간(270초) = 320
        timeMultiplier = 86400f / realSecondsPerFullDay;

        // 2. 게임 시작 시간 설정
        // (예: 6시 * 60분 * 60초 = 21600초)
        currentDayTimeInSeconds = startHour * 3600f;

        // (참고) 요청하신 낮/밤 비율 계산
        CalculateDayNightRatio();
    }

    void Update()
    {
        // 1. 시간 업데이트
        // 실제 시간(Time.deltaTime)에 배율을 곱해 게임 시간을 더함
        currentDayTimeInSeconds += Time.deltaTime * timeMultiplier;

        if (!IsNight())
        {
            dayIcon.SetActive(true);
            NightIcon.SetActive(false);
        }
        else
        {
            dayIcon.SetActive(false);
            NightIcon.SetActive(true);
        }

        // 2. 하루 리셋 (24시가 지나면 0시로)
        // 86400초(24시간)를 초과하면 86400을 빼서 0부터 다시 시작
        if (currentDayTimeInSeconds >= 86400f)
        {
            currentDayTimeInSeconds -= 86400f;
            // 여기서 '하루가 지남' 이벤트를 발생시킬 수 있습니다.
        }

        // 3. UI 표시용 시/분 계산
        // TimeSpan을 사용하면 초(seconds)를 시:분:초로 변환하기 매우 편리합니다.
        TimeSpan timeSpan = TimeSpan.FromSeconds(currentDayTimeInSeconds);

        int hours = timeSpan.Hours;
        int minutes = timeSpan.Minutes;

        // 4. UI 텍스트 업데이트
        // string.Format을 사용해 "HH:mm" 형식(예: 06:05)으로 만듭니다.
        clockText.text = string.Format("{0:D2}:{1:D2}", hours, minutes);

        
    }

    /// <summary>
    /// (참고) 요청하신 '낮 3분 / 밤 1분 30초'의 비율을
    /// 24시간 기준으로 변환합니다.
    /// </summary>
    void CalculateDayNightRatio()
    {
        float dayDurationReal = GameManager.Instance.dayDuration;  // 3분
        float nightDurationReal = GameManager.Instance.nightDuration; // 1분 30초

        // (180 / 270) * 24시간 = 16시간
        gameHoursPerDay = (dayDurationReal / realSecondsPerFullDay) * 24f;

        // (90 / 270) * 24시간 = 8시간
        gameHoursPerNight = (nightDurationReal / realSecondsPerFullDay) * 24f;

        Debug.Log($"[TimeManager] 이 게임의 하루는 낮 {gameHoursPerDay}시간, 밤 {gameHoursPerNight}시간으로 구성됩니다.");
    }

    /// <summary>
    /// (선택 사항) 다른 스크립트에서 현재 시간을 시간(float)으로 가져갈 때 사용
    /// </summary>
    public float GetCurrentHour()
    {
        return currentDayTimeInSeconds / 3600f;
    }

    /// <summary>
    /// (선택 사항) 다른 스크립트에서 지금이 밤인지 확인할 때 사용
    /// (예: 낮 16시간, 밤 8시간. 6시 시작 -> 22시(오후 10시)에 밤 시작)
    /// </summary>
    public bool IsNight()
    {
        float dayStartHour = 6f; // 6시
        float nightStartHour = 22f; // 6 + 16 = 22시
        float currentHour = GetCurrentHour();

        // 22시 이후이거나 6시 이전이면 밤
        if (currentHour >= nightStartHour || currentHour < dayStartHour)
        {
            return true;
        }
        return false;
    }*/
}
