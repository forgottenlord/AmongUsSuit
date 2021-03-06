using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmongUsSuit.Models;
using UnityEngine;

namespace UmongUsSuit.Panels
{
    /// <summary>
    /// Двухмерный список предметов.
    /// </summary>
    public class TwoDimListUI : GenericUIList<ItemUI, Item>
    {
        [SerializeField][Range(1, 10)]
        private int itemsPerRow;

        [SerializeField]
        private ItemListUI RowPrototype;
        [HideInInspector]
        private List<ItemListUI> Rows = new List<ItemListUI>();
        public void Refresh(List<Item> items)
        {
            Clear();
            int r = 0;
            ItemListUI row = null;
            for (int n = 0; n < items.Count; n++, r++)
            {
                Debug.Log("r="+r+" "+ (r % itemsPerRow == 0));
                if (r % itemsPerRow == 0)
                {
                    int rowNum = (int)(r / itemsPerRow);
                    if (rowNum < Rows.Count)
                    {
                        row = Rows[rowNum];
                        row.gameObject.SetActive(true);
                    }
                    else
                    {
                        row = Instantiate<ItemListUI>(RowPrototype, RowPrototype.transform.parent);
                        row.gameObject.SetActive(true);
                        Rows.Add(row);
                    }
                }
                if (row.elements.Count<itemsPerRow) row.AddDefault();
                ItemUI item = ((ItemUI)row.elements[n % itemsPerRow]);
                item.SetItem(items[n]);
                item.Refresh();
            }
        }
        public void Clear()
        {
            for (int n = 0; n < Rows.Count; n++)
            {
                Rows[n].gameObject.SetActive(false);
            }
        }
    }
}
