using UnityEngine;

public class SkyManager : MonoBehaviour
{
    public float skySpeed = 1f;

    private Material skyboxIntance;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skySpeed);
    }
}
