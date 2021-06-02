using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menumanager : MonoBehaviour
{
   
    public GameObject CanvasOpciones;
    public bool opciones;
    Canvas canvas;

    void Start()
    {
        canvas = CanvasOpciones.GetComponent<Canvas>();
        canvas.enabled = false;
    }

    //Opciones************************
    public void Opciones()
    {
        opciones = !opciones;
        canvas.enabled = opciones;
        Time.timeScale = (opciones) ? 0 : 1f;
    }

    //Jugar************************
    public void SceneChanger(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    //Salir************************
    public void CloseGame()
    {
        Application.Quit();
    }

    //Volumen************************
    public AudioMixer audioMixer;
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

   
}