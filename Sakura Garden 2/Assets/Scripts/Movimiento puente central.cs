using UnityEngine;

public class Movimientopuentecentral : MonoBehaviour
{
    public float velocidadRotacion = 10f; // Ajusta la velocidad de rotaci�n seg�n tus necesidades
    private bool rotacionCompletada = false;

    private void Update()
    {
        if (!rotacionCompletada)
        {
            // Verifica si la tecla "P" fue presionada
            if (Input.GetKey(KeyCode.P))
            {
                // Realiza la rotaci�n cuando la tecla "P" es presionada
                transform.Rotate(0f, velocidadRotacion * Time.deltaTime, 0f, Space.Self);

                // Obtiene el �ngulo actual en el eje Y (entre 0 y 360 grados)
                float anguloActual = transform.rotation.eulerAngles.y;

                if (anguloActual > 90f)
                {
                    rotacionCompletada = true;
                    Debug.Log("Rotaci�n detenida al superar los 90 grados en el eje Y.");
                }
            }
        }
    }
}
