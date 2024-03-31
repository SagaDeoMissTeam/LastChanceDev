using System;
using code.Dialoges;
using code.entity.npc;
using UnityEngine;

namespace code.events
{
    public class PlayerEvents 
    {
        public static Action<string, int> OnPlayerTriggered;
        public static Action OnPlayerInteract;
        public static Action<NPC> OnPlayerNPCInteract;
        public static Action OnPlayerCanInteract;
        public static Action OnPlayerCantInteract;

        public static Action<Dialog> OnPlayerSendDialog;
        public static Action OnDialogEnd;




        public static void SendPlayerTriggered(string objectName, int id)
        {
           if(OnPlayerTriggered != null) OnPlayerTriggered.Invoke(objectName, id);
        }        
        public static void SendOnPlayerNPCInteract(NPC npc)
        {
           if(OnPlayerNPCInteract != null) OnPlayerNPCInteract.Invoke(npc);
        }       
        public static void SendOnPlayerInteract()
        {
           if(OnPlayerInteract != null) OnPlayerInteract.Invoke();
        }        
        public static void SendOnPlayerCanInteract()
        {
           if(OnPlayerCanInteract != null) OnPlayerCanInteract.Invoke();
        }        
        public static void SendOnPlayerCantInteract()
        {
           if(OnPlayerCantInteract != null) OnPlayerCantInteract.Invoke();
        }        
        
        public static void SendOnPlayerSendDialog(Dialog dialog)
        {
           if(OnPlayerSendDialog != null) OnPlayerSendDialog.Invoke(dialog);
        }        
        
        public static void SendOnDialogEnd()
        {
           if(OnDialogEnd != null) OnDialogEnd.Invoke();
        }
    }
}