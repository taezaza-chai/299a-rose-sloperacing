using UnityEngine;
using TMPro;  // ������Ѻ TextMeshPro

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // ��ҧ�ԧ UI Text
    private float elapsedTime = 0f;  // ���ҷ���ҹ�
    private bool isRunning = true;   // ��������ѧ���Թ�������

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
        isRunning = false; // ��ش��������Ͷ֧��鹪��
    }
}