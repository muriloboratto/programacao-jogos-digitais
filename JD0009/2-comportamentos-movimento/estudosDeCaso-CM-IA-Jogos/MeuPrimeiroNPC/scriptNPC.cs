public class scriptNPC : MonoBehaviour
{
    public float velocidadeMaximaDePerseguicao = 15f;    
    public float distanciaDeDesaceleração = 1f; 

    Vector2 velocidade = Vector2.zero;    
             
    void Update()
    {
       Vector2 posicaoDoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
       
       Vector2 distanciaDoMouseAteJogador = (posicaoDoMouse - (Vector2)transform.position);
       Vector2 velocidadeDesejada = distanciaDoMouseAteJogador.normalized * velocidadeMaximaDePerseguicao;
       Vector2 steering = velocidadeDesejada - velocidade;

       velocidade = velocidade + steering * Time.deltaTime;

       float fatorDeDesaceleracao = Mathf.Clamp01(distanciaDoMouseAteJogador.magnitude / distanciaDeDesaceleração);
       velocidade = velocidade * fatorDeDesaceleracao;

       transform.position = transform.position + (Vector3)velocidade * Time.deltaTime;
    }

}
