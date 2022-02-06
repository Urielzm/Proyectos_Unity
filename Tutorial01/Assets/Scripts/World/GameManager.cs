using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ammoText;
    
    public static GameManager Instance { get; private set; }

    public int gunAmmo = 10;

    public Text HealtText;
    public int healt = 100;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        HealtText.text = healt.ToString();
    }

}
