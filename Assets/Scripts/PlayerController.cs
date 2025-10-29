using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro; //libreria para usar textos

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; //variable para guardar la velocidad
    public int score = 0;
    public bool hasShrooms = false;
    public bool hasButcher = false;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI notificationText;
    public GameObject VictoryPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTextScore();
    }

    // Update is called once per frame
    void Update()
    {
        //leer las teclas WASD o las flechas
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //creamos un vector para direccion del movimiento
        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0);

        transform.Translate(direction * speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 1f;
        if (other.CompareTag("Collectable"))
        {
            score = score + 1; //igual a: score+=1 ; score ++;
            UpdateTextScore();

            Destroy(other.gameObject);
            Debug.Log("Collected!!!");
            ShowNotification("Recolectado!!");
            Debug.Log("Score: " + score);
        }

        if (other.CompareTag("Shrooms"))
        {
            hasShrooms = true;
            Debug.Log("Shroom Collected!");
            Destroy(other.gameObject);
            ShowNotification("Hongos Recolectados!!!");
        }

        //condición de victoria
        if (score >= 3 && hasShrooms && !hasButcher) // el && significa "y", el || significa "o"; como en lógica: V||V = V, V||F = V, F||F = F
        {
            Time.timeScale = 0f;
            Debug.Log("Has ganado, no te han chuleteado, tienes suficientes puntos y la llave!");
            ShowNotification("tienes los hongos, las bostas y no te han chuleteado!!");
            VictoryPanel.SetActive(true);

        }
        // para booleanos, si se pone el nombre de la variable sola, se asume si es verdadero, si tiene "!" delante, se asume si es falso

        if (other.CompareTag("Butcher"))
        {
            hasButcher = true;
            Debug.Log("Muelto");
            Destroy(gameObject);
            ShowNotification("Muelto");
        }
    }

    void UpdateTextScore()
    {
        textScore.text = "Score: " + score;
    }

    void ShowNotification(string message)
    {
        notificationText.text = message;
    }


}
