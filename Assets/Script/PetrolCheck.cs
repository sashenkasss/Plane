using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PetrolCheck : MonoBehaviour {

    public static float petrol = 1.0f;
    public Slider slider;
    public GameObject cube;
    void Start()
    {
        petrol = 1.0f;
        InvokeRepeating("Decrease", 1.0f, 0.3f);
    }

    void Decrease()
    {
        if (petrol <= 0)
        {
            cube.SetActive(false);
            //SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
        else cube.SetActive(true);
        petrol-=0.01f;
        slider.value = petrol;
    }
}
