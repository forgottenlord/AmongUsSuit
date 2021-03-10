using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using UmongUsSuit.Network;
using TMPro;
using UmongUsSuit.Models;

namespace UmongUsSuit.Panels
{
    public class GumblePanel : GenericUIList<ItemUI, Character>
    {
        public UnityEngine.UI.Button ToMainButton;
        //public ExcursionEditorPanel Editor;
        public async override void Init()
        {
            base.Init();
            //Common.SetActionOnButton(BackButton, ControllUI.PrevPanel);
            Common.SetActionOnButton(ToMainButton, ()=>
            {
                ControllUI.SwitchPanel(0, null);// FtpIO.excursionList.excursions.Count-1);
            });
            /*Common.SetActionOnButton(SaveButton, () =>
            {
            });*/
        }
        public override ItemUI AddDefault()
        {
            return base.AddDefault();
        }
        public override void Refresh(DataObject data)
        {
            for (int n = 0; n < elements.Count; n++)
            {
                if (elements[n]!= null)
                Destroy(elements[n]?.gameObject);
            }
            elements.Clear();
            /*for (int n = 0; n < ; n++)
            {
                Add(prototype, );
            }*/
        }
    }
}