using UnityEngine;
using System.Collections;

public class Missil : MonoBehaviour, Projetil 
{

	[Range(0,5)]
	public float velocidade;
	private Inimigo alvo;
	public int pontosDeDano;

	void Start () 
	{
		autoDestroiDepoisDeSegundos (10);
		alteraDirecao ();
	}

	void Update () 
	{
		anda ();
		if (alvo != null) 
		{
			alteraDirecao ();
		}
	}

	public void defineAlvo(Inimigo inimigo) 
	{
		alvo = inimigo;	
	}

	private void anda()
	{
		Vector3 posicaoAtual = transform.position;
		Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
		transform.position = posicaoAtual + deslocamento;
	}

	private void alteraDirecao() 
	{
		Vector3 posicaoAtual = transform.position;
		Vector3 posicaoDoAlvo = alvo.transform.position;
		Vector3 direcaoDoAlvo = posicaoDoAlvo - posicaoAtual;
		transform.rotation = Quaternion.LookRotation (direcaoDoAlvo);
	}

	private void autoDestroiDepoisDeSegundos(float segundos) 
	{
		Destroy (this.gameObject, segundos);
	}

	void OnTriggerEnter (Collider elementoColidido) 
	{
		if (elementoColidido.CompareTag ("Inimigo")) 
		{
			Destroy (this.gameObject);
			Inimigo inimigo = elementoColidido.GetComponent<Inimigo>();
			inimigo.recebeDano(pontosDeDano);
		}
	}
}
