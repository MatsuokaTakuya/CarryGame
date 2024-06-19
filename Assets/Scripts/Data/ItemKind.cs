using System;
using System.Collections.Generic;
using UnityEditor;

namespace Data
{
    public enum ItemKind
    {
        Apple,
        None,
    }


    public class ItemKindData
    {
        public ItemKind itemKind { get; private set; }
        public string assetPath { get; private set; }

        public ItemKindData(ItemKind itemKind, string assetPath)
        {
            this.itemKind = itemKind;
            this.assetPath = assetPath;
        }
    }
}