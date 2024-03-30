using System.Collections;
using System.Collections.Generic;
using System.Linq;
using code.Dialoges;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject dialogUI;
    
    public Dialog currentDialog = null;
    public List<Dialog> dialogsList = new List<Dialog>();

    [SerializeField] public TMP_Text TITTLE;
    [SerializeField] public TMP_Text SUB_TITTLE;
    [SerializeField] public GameObject NEXT_TEXT; 
    private Transform _canvas;

    public void Start()
    {
        
        _canvas = dialogUI.transform.Find("Canvas");
        TITTLE = dialogUI.transform.Find("Canvas").Find("TittleBackGround").Find("Tittle").GetComponent<TMP_Text>();
        SUB_TITTLE = dialogUI.transform.Find("Canvas").Find("BackGround").Find("SubTittle").GetComponent<TMP_Text>();
        NEXT_TEXT = dialogUI.transform.Find("Canvas").Find("NextText").gameObject;
        render();
        addDialog(DialogsData.getDialog4());
    }
    
    public void render()
    {
        
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
