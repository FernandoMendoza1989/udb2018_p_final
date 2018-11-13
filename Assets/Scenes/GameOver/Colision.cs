﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        //Detectar Muerte
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("JuegoTerminado");
        }
    }
}
