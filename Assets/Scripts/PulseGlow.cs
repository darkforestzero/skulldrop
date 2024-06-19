using System.Collections;
using UnityEngine;

public class PulseGlow : MonoBehaviour
{
    public Material glowMaterial;
    public float pulseSpeed = 1f;
    public float maxEmission = 1f;

    private bool pulsing = false;
    private Coroutine pulseCoroutine;

    void Start()
    {
        if (glowMaterial == null)
        {
            Debug.LogError("Glow material is not assigned.");
            return;
        }
        StartPulsing();
    }

    public void StartPulsing()
    {
        if (pulsing) return;
        pulsing = true;
        pulseCoroutine = StartCoroutine(PulseGlowEffect());
    }

    public void StopPulsing()
    {
        if (!pulsing) return;
        pulsing = false;
        if (pulseCoroutine != null)
        {
            StopCoroutine(pulseCoroutine);
            pulseCoroutine = null;
        }
        // Reset emission to default
        glowMaterial.SetColor("_EmissionColor", Color.black);
        DynamicGI.SetEmissive(GetComponent<Renderer>(), Color.black);
    }

    private IEnumerator PulseGlowEffect()
    {
        while (pulsing)
        {
            float emission = Mathf.PingPong(Time.time * pulseSpeed, maxEmission);
            Color baseColor = Color.white; // Change this to the base color you want for the emission
            Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

            glowMaterial.SetColor("_EmissionColor", finalColor);
            DynamicGI.SetEmissive(GetComponent<Renderer>(), finalColor);

            yield return null;
        }
    }
}