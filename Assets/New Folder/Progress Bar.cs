using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    public Slider progressSlider;  // drag your Slider here in the Inspector
    public float maxValue = 100f;
    private float currentValue;


    void Start()
    {
        currentValue = maxValue;
        progressSlider.maxValue = maxValue;
        progressSlider.value = currentValue;
    }


    // Call this to change the bar (e.g. take damage or gain progress)
    public void SetValue(float newValue)
    {
        currentValue = Mathf.Clamp(newValue, 0, maxValue);
        progressSlider.value = currentValue;
    }
}