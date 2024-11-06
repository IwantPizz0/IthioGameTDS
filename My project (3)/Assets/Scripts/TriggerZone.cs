using UnityEngine;
using TMPro;  // Подключаем библиотеку для работы с TextMeshPro

public class TriggerZone2D : MonoBehaviour
{
    public LayerMask playerLayer; // Маска слоев для игрока (в инспекторе)
    public TextMeshProUGUI textUI; // Ссылка на TextMeshProUGUI для отображения текста
    private bool isPlayerInZone = false; // Флаг, указывающий на нахождение игрока в зоне

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, что объект с нужным слоем (Player)
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            // Игрок вошел в зону
            isPlayerInZone = true;
            ShowText("УРА ПОЕДА, ТЕПЕРЬ ВЫХОДИ ИЗ ИГРЫ И ПОТРОГАЙ ТРАВУ!!!!!!!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Проверяем, что объект с нужным слоем (Player)
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            // Игрок покинул зону
            isPlayerInZone = false;
            HideText();
        }
    }

    private void ShowText(string message)
    {
        // Показать текст на экране
        textUI.text = message;
        textUI.gameObject.SetActive(true);  // Активируем текстовый объект
    }

    private void HideText()
    {
        // Скрыть текст на экране
        textUI.gameObject.SetActive(false);
    }
}
