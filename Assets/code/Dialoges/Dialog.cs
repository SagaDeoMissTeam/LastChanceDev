using System;
using code.interfaces;

namespace code.Dialoges
{
    public class Dialog : ITick
    {
        public Dialog main = null;
        public DialogManager manager;
        public string owner { get; }
        public string message { get; }
        public Dialog parent { get; set; } = null;
        public bool isStart = false;
        public string outMessage = "";

        private int timeTick = 0;
        private int messageChar = 0;

        public Dialog(string owner, string message)
        {
            this.message = message;
            this.owner = owner;
        }        
        
        public Dialog(string owner, string message,Dialog parent)
        {
            this.message = message;
            this.parent = parent;
            this.owner = owner;
        }

        public Dialog addParent(Dialog parent)
        {
            this.parent = parent;
            return this.parent;
        }

        public Dialog setStart()
        {
            this.isStart = true;
            return this;
        }
        public Dialog setEnd()
        {
            this.isStart = false;
            return this;
        }

        public Dialog getMain()
        {
            return main;
        }

        public Dialog setManager(DialogManager manager)
        {
            this.manager = manager;
            return this;
        }

        public void onTick()
        {
            if (timeTick % 25 == 0)
            {
                if (messageChar > message.Length - 1)
                {
                    isStart = false;
                    return;
                }

                if (message[messageChar] == ' ')
                {
                    outMessage += message[messageChar];
                    messageChar++;
                }

                outMessage += message[messageChar];

                messageChar++;
            }

            manager.TITTLE.SetText(owner);
            manager.SUB_TITTLE.SetText(outMessage);
            timeTick++;
        }
    }
}