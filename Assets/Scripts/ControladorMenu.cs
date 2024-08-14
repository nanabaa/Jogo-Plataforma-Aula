using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    private UIDocument document;
    private Button botao;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botao = document.rootVisualElement.Q<Button>("btnFases");
        botao.RegisterCallback<ClickEvent>(onPlay);
        botao = document.rootVisualElement.Q<Button>("btnCreditos");
        botao.RegisterCallback<ClickEvent>(onJogar);
    }

    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("fases");
    }

    void onJogar(ClickEvent evt)
    {
        SceneManager.LoadScene("Creditos");
    }
}
