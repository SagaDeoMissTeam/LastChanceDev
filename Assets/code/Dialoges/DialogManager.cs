using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using code.Dialoges;
using code.events;
using code.game;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public InitGame Game;
    public GameObject dialogUI;
    
    public Dialog currentDialog = null;
    public List<Dialog> dialogsList = new List<Dialog>();

    public TMP_Text TITTLE;
    public TMP_Text SUB_TITTLE;
    public GameObject NEXT_TEXT; 
    private Transform _canvas;

    public void Start()
    {
        PlayerEvents.OnPlayerSendDialog += addDialog;
        _canvas = dialogUI.transform.Find("Canvas");
        TITTLE = dialogUI.transform.Find("Canvas").Find("TittleBackGround").Find("Tittle").GetComponent<TMP_Text>();
        SUB_TITTLE = dialogUI.transform.Find("Canvas").Find("BackGround").Find("SubTittle").GetComponent<TMP_Text>();
        NEXT_TEXT = dialogUI.transform.Find("Canvas").Find("NextText").gameObject;
        render();
    }
    
    public void render()
    {
        
    }

    private void OnDestroy()
    {
        PlayerEvents.OnPlayerSendDialog -= addDialog;
    }


    public void Update()
    {
        if (currentDialog == null)
        {
            _canvas.gameObject.SetActive(false);
        }
        else
        {
            _canvas.gameObject.SetActive(true);
        }
        
        if(currentDialog != null && !currentDialog.isStart) NEXT_TEXT.SetActive(true);
        
        if (currentDialog != null && currentDialog.isStart)
        {
            currentDialog.onTick();
            NEXT_TEXT.SetActive(false);
        }
        else if (currentDialog != null && !currentDialog.isStart && Input.GetKeyDown(KeyCode.Space))
        {
            if (currentDialog.parent != null)
            {
                addDialog(currentDialog.parent);
                currentDialog.onTick();
            }
            else
            {
                currentDialog = null;
                PlayerEvents.SendOnDialogEnd();
            }
            
        }
        
    }
    
    
    protected void addDialog(Dialog dialog)
    {
        dialog.setManager(this);
        dialog.isStart = true;
        this.currentDialog = dialog;
    }
}
