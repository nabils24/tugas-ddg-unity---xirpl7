﻿using System.Collections;
using UnityEngine;

public class Perulangan : MonoBehaviour
{
    string[] nama = {"satu", "dua", "tiga"};

    void Start()
    {
        for(int i = 0; i < nama.Length; i++){
            Debug.Log(nama[i]);
        }
    }
}
