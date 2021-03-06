using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UmongUsSuit.Models;
//using UmongUsSuit.Network;

namespace UmongUsSuit.Panels
{
    public abstract class Panel : MonoBehaviour
    {
        void Start()
        {
            Init();
        }
        public abstract void Init();
        public abstract void Refresh(DataObject data);
        public void Show()
        {
            gameObject.SetActive(true);
        }
        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
