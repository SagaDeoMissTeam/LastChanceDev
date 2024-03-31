using System;
using code.Dialoges;
using code.events;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace code.entity.npc
{
    public class NPC : MonoBehaviour
    {
        public TMP_Text textName;
        public string npcName = "???";
        public int id;

        public bool isNameKnown = false;

        public bool playerOnCollision = false;

        private void Start()
        {
            PlayerEvents.OnPlayerInteract += playerInteract;

            textName = transform.Find("Canvas").Find("Name").GetComponent<TMP_Text>();
            
            
            textName.SetText(npcName);
        }

        private void Update()
        {
        }

        private void OnDestroy()
        {
            PlayerEvents.OnPlayerInteract -= playerInteract;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.transform.CompareTag("Player"))
            {
                playerOnCollision = true;
                PlayerEvents.SendOnPlayerCanInteract();
            }
        }        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.transform.CompareTag("Player"))
            {
                playerOnCollision = false;
                PlayerEvents.SendOnPlayerCantInteract();
            }
        }


        public void playerInteract()
        {
            if (playerOnCollision)
            {
                PlayerEvents.SendOnPlayerSendDialog(DialogsData.getDialog4());
            }
        }
        
    }
}