using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform startPoint;  // Ponto de início
    public Transform endPoint;    // Ponto de fim
    public float moveSpeed = 20f;  // Velocidade do carro
    public float resetDistance = 130f;  // Distância para resetar

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Move o carro para frente
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Verifica se o carro ultrapassou a distância de reset
        if (Vector3.Distance(initialPosition, transform.position) >= resetDistance)
        {
            // Teleporta o carro de volta ao ponto de início
            transform.position = startPoint.position;
        }
    }
}
