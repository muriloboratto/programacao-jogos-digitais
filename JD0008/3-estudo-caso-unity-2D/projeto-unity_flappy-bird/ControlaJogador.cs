using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour {

  bool comecou;
  bool acabou;
  Rigidbody2D corpoJogador;
  Vector2 forcaImpulso = new Vector2(0, 500f);

  void Start () { 
    corpoJogador = GetComponent<Rigidbody2D> ();
  }
  
  void Update () {

    if (Input.GetButtonDown ("Fire1")) { 
    
      if (!comecou) {
        comecou = true;
        corpoJogador.isKinematic = false;
      }

      corpoJogador.velocity = new Vector2 (0, 0);
      corpoJogador.AddForce(forcaImpulso);    
    }
    
  }
}
