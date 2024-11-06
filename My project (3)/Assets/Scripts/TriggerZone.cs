using UnityEngine;
using TMPro;  // ���������� ���������� ��� ������ � TextMeshPro

public class TriggerZone2D : MonoBehaviour
{
    public LayerMask playerLayer; // ����� ����� ��� ������ (� ����������)
    public TextMeshProUGUI textUI; // ������ �� TextMeshProUGUI ��� ����������� ������
    private bool isPlayerInZone = false; // ����, ����������� �� ���������� ������ � ����

    private void OnTriggerEnter2D(Collider2D other)
    {
        // ���������, ��� ������ � ������ ����� (Player)
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            // ����� ����� � ����
            isPlayerInZone = true;
            ShowText("��� �����, ������ ������ �� ���� � �������� �����!!!!!!!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // ���������, ��� ������ � ������ ����� (Player)
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            // ����� ������� ����
            isPlayerInZone = false;
            HideText();
        }
    }

    private void ShowText(string message)
    {
        // �������� ����� �� ������
        textUI.text = message;
        textUI.gameObject.SetActive(true);  // ���������� ��������� ������
    }

    private void HideText()
    {
        // ������ ����� �� ������
        textUI.gameObject.SetActive(false);
    }
}
