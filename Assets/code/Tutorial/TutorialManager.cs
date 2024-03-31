using System;
using code.game;
using UnityEngine;

namespace code.Tutorial
{
    public class TutorialManager : MonoBehaviour
    {
        public InitGame Game;
        public GameObject tutorialUI;

        [SerializeField] public GameObject _canvas;

        private void Start()
        {
            _canvas = tutorialUI.transform.Find("Canvas").gameObject;
            _canvas.SetActive(false);
        }
    }
}