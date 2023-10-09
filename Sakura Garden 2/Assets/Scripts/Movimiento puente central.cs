using UnityEngine;

public class Movimientopuentecentral : MonoBehaviour
{
    public float Velocidadrotacion = -10f; 
    private bool Rotacioncompletada = false;

    private void Update()
    {
        if (!Rotacioncompletada)
        {
            if (Input.GetKey(KeyCode.P))
            {
                transform.Rotate(0f, Velocidadrotacion * Time.deltaTime, 0f, Space.World);

                float anguloActual = transform.rotation.eulerAngles.y;

                if (anguloActual <= -90f)
                {
                    Rotacioncompletada = true;
                    Debug.Log("Rotación detenida al superar los 90 grados en el eje Y.");
                }
            }
        }
    }
}
