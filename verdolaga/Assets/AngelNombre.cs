using UnityEngine;

public class AngelNombre : MonoBehaviour
{
    public string Nombre = "Angel Luis";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Cambio realizado por Leandro
    public void SaludoLeandro()
    {
        Debug.Log("Este método lo agregó Leandro.");
    }
}
