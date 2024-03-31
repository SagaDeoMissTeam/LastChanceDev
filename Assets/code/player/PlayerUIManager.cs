using code.Dialoges;
using code.events;
using code.interfaces;
using TMPro;
using UnityEngine;

namespace code.player
{
    public class PlayerUIManager : ITick
    {

        public PlayerCharacter player;
        public GameObject mainPlayerUI;

        public GameObject canvas;

        public GameObject interactPanel;

        public PlayerUIManager(PlayerCharacter player, GameObject mainPlayerUI)
        {
            this.player = player;
            this.mainPlayerUI = mainPlayerUI;

            canvas = this.mainPlayerUI.transform.Find("Canvas").gameObject;
            interactPanel = canvas.transform.Find("BackGround").gameObject;
        }

        public void Start()
        {
            interactPanel.SetActive(false);
            PlayerEvents.OnPlayerCanInteract += showInteract;
            PlayerEvents.OnPlayerCantInteract += hideInteract;
            PlayerEvents.OnPlayerSendDialog += hideInteract;
        }


        public void onDestroy()
        {
            PlayerEvents.OnPlayerCanInteract -= showInteract;
            PlayerEvents.OnPlayerCantInteract -= hideInteract;
            PlayerEvents.OnPlayerSendDialog -= hideInteract;
        }

        public void onTick()
        {
            
        }


        public void showInteract()
        {
            if(player.inputMode == InputMode.UI || player.inputMode == InputMode.DIALOG) interactPanel.SetActive(false);
            interactPanel.SetActive(true);
        }        
        public void hideInteract()
        {
            interactPanel.SetActive(false);
        }

        public void hideInteract(Dialog dialog)
        {
            interactPanel.SetActive(false);
        }
    }
}