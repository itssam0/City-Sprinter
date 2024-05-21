using UnityEngine;

public class UpdateShaderTime : MonoBehaviour
{
    public Material material;

    void Update()
    {
        if (material != null)
        {
            material.SetFloat("_MyTime", Time.time);
        }
    }
}
