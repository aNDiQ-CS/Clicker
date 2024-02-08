using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Storage _storage;

    private TextMeshProUGUI _textMeshProUGUI;
   
    private void Start()
    {        
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        print(_textMeshProUGUI);
    }

    private void Update()
    {
        _textMeshProUGUI.SetText("Score: " + _storage.Ammount);
    }
}
