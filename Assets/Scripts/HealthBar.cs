using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Referender Slider UI
    public Slider slider;

    //Public method agar dapat dipakai diluar script ini
    public void SetMaxHealth(int health)
    {
        // maxValue == Maks Value pada slider
        slider.maxValue = health;
        // slider.value = health;
    }

    public void SetHealth(int health)
    {
        // Value == value pada slider
        slider.value = health;
    }
}
