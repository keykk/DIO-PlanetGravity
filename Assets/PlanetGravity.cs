using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravityStrength = 9.81f; // For�a da gravidade

    private void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody != null)
        {
            // Calcula a dire��o da for�a (do objeto para o centro do planeta)
            Vector3 direction = (transform.position - other.transform.position).normalized;

            // Aplica a for�a gravitacional
            other.attachedRigidbody.AddForce(direction * gravityStrength, ForceMode.Acceleration);
        }
    }
}