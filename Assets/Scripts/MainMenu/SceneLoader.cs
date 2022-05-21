using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CargarEscena(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void SalirDelJuego()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
