using UnityEngine;
using System.Collections;

public class MoveFundo : MonoBehaviour {

  float larguraTela;

  void Start(){
  
    SpriteRenderer grafico = GetComponent<SpriteRenderer>();

    float larguraImagem = grafico.sprite.bounds.size.x;
    float alturaImagem  = grafico.sprite.bounds.size.y;

    float alturaTela = Camera.main.orthographicSize * 2f;
    larguraTela = alturaTela / Screen.height * Screen.width;

    Vector2 novaEscala = transform.localScale;
    novaEscala.x = larguraTela / larguraImagem + 0.25f;
    novaEscala.y = alturaTela / alturaImagem;
    this.transform.localScale = novaEscala;
 
    if (this.name == "imagemFundoB")
      transform.position = new Vector2 (larguraTela, 0f);


     GetComponent<Rigidbody2D>().velocity = new Vector2(-3,0);

  }

  void Update(){
     
     if(transform.position.x <= -larguraTela){
        transform.position = new Vector2(larguraTela, 0f);
     }

  }


}