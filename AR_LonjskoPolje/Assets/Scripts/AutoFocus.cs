using UnityEngine;
using System.Collections;
using Vuforia;

public class AutoFocus : MonoBehaviour
{

    // code from  Vuforia Developer Library
    // https://library.vuforia.com/articles/Solution/Camera-Focus-Modes
    void Start()
    {
        var vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(OnPaused);
    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        if (!paused)
        {
            CameraDevice.Instance.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}

