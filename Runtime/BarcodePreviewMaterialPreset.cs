using System;
using UnityEngine;

namespace Dorofii.Barcode.Runtime
{
    [Serializable]
    [CreateAssetMenu(menuName = "Tools/Barcode/MaterialPreset")]
    public class BarcodePreviewMaterialPreset : ScriptableObject
    {
        public Material Default;
        public Material Clock90Left;
    }
}
