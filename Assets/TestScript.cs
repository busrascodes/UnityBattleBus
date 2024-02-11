using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Image imageToFill; // ������ �� ��������� Image, ������� ����� ������ ������
    public float nValue; // ���������� N, �������� ������� ����� ���������� ���������� ��������

    void Update()
    {
        // ������������ �������� ���������� N �� 0 �� 100
        nValue = Mathf.Clamp(nValue, 0f, 100f);

        // ��������� ������� ���������� ��������
        float fillPercent = nValue / 100f;

        // ������������� ���������� �������� � ������������ � ���������
        imageToFill.fillAmount = fillPercent;
    }
}
