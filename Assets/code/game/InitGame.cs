using System;
using code.Dialoges;
using code.Tutorial;
using UnityEngine;

namespace code.game
{
    public class InitGame : MonoBehaviour
    {
        public DialogManager dialogUI;
        public TutorialManager tutorialUI;
        
        private void Start()
        {
            dialogUI.Game = this;
            tutorialUI.Game = this;
        }
    }
}