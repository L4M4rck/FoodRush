using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource sonido;
    public Image Icono;
    public Sprite On;
    public Sprite Off;
    public bool toggle = true;
    
public void Mutear ()
    {
        if (toggle)
        {
            sonido.mute = false;
            Icono.overrideSprite = On;
            toggle = false;
        }
        else
        {
            sonido.mute = true;
            Icono.overrideSprite = Off;
            toggle = true;
        }
    }
}
