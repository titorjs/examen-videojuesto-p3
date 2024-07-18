using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Establecer el valor inicial del slider con el valor actual del volumen
        volumeSlider.value = AudioListener.volume;

        // Añadir el listener para el evento de cambio de valor del slider
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    // Método para establecer el volumen
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
