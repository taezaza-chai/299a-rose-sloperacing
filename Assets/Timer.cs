using UnityEngine;
using TMPro;  // ใช้สำหรับ TextMeshPro

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // อ้างอิง UI Text
    private float elapsedTime = 0f;  // เวลาที่ผ่านไป
    private bool isRunning = true;   // เช็คว่าเกมยังดำเนินอยู่ไหม

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        isRunning = false; // หยุดเวลาเมื่อถึงเส้นชัย
    }
}