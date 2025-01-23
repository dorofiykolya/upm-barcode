# Barcode decoder for Unity

# Project Archived

**This repository is no longer maintained and has been archived.**  
Future development and support for this project have been moved to the [OpenUGD](https://github.com/openugd).

## Important Notice

- **New Repository**: The project is actively maintained at [OpenUGD](https://github.com/openugd/upm-barcode).
- **Archived Status**: This repository is now a read-only archive and will not receive updates, bug fixes, or new features.

Thank you for your continued interest and support!  
Please refer to the new repository for the latest updates and contributions.

---

For any further questions, feel free to reach out to the maintainers at the new repository.

**You can decode barcodes in Unity using this library.**

**It uses a ZXing library for decoding barcodes.**

Support for all platforms that support **UnityEngine.WebCamTexture**.

---

Simple way to decode barcodes from camera and preview.
```csharp
using System;
using System.Threading.Tasks;
using Dorofii.Barcode.Runtime;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class Example : MonoBehaviour
{
   public RawImage rawImage;

    async void Start()
    {
        if(rawImage == null)
            rawImage = GetComponent<RawImage>();
        
        var barcode = await Barcode.DecodeFromCameraAndPreviewAsync(rawImage);
        Debug.Log(barcode);
    }
}
```
