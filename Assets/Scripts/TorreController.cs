using UnityEngine;
using System.Collections;

public class TorreController : MonoBehaviour 
{

	public GameObject projetilPrefab;
	public float raioDeAlcance;
	private float momentoDoUltimoDisparo;
	[SerializeField] private int custo;

	[Range(0,3)]
	public float tempoDeRecarga = 1f;

	public int GetCusto ()
	{
		return custo;
	}

	void Update () 
	{
		Inimigo alvo = escolheAlvo ();
		if (alvo != null) {
			mira (alvo);
			atira (alvo);
		}
	}

	private Inimigo escolheAlvo()
	{
		GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Inimigo");
		foreach (GameObject inimigo in inimigos) 
		{
			if (estaNoRaioDeAlcance(inimigo))
			{
				return inimigo.GetComponent<Inimigo>();
			}
		}
		return null;
	}

	private bool estaNoRaioDeAlcance(GameObject inimigo) 
	{
		Vector3 posicaoDoInimigoNoPlano = 
			Vector3.ProjectOnPlane(inimigo.transform.position, Vector3.up);
		Vector3 posicaoDaTorreNoPlano = 
			Vector3.ProjectOnPlane(this.transform.position, Vector3.up);

		float distanciaParaInimigo = 
			Vector3.Distance (posicaoDaTorreNoPlano, posicaoDoInimigoNoPlano);

		return distanciaParaInimigo <= raioDeAlcance;
	}

	private void atira (Inimigo inimigo)
	{
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga) 
		{
			momentoDoUltimoDisparo = tempoAtual;
			GameObject pontoDeDisparo = this.transform.Find ("CanhaoDaTorre/PontoDeDisparo").gameObject;
			Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
			GameObject projetilObject = (GameObject) Instantiate (projetilPrefab, posicaoDoPontoDeDisparo, Quaternion.identity);
			Projetil missil = projetilObject.GetComponent<Projetil>();
			missil.defineAlvo(inimigo);
		}
	}

	private void mira (Inimigo inimigo)
	{
		Vector3 direcaoDoAlvoNoPlano = Vector3.ProjectOnPlane(inimigo.transform.position - transform.position, Vector3.up);
		Quaternion rotacaoDoCanhao = Quaternion.LookRotation (direcaoDoAlvoNoPlano);
		GameObject canhaoDaTorre = this.transform.Find ("CanhaoDaTorre").gameObject;
		canhaoDaTorre.transform.rotation = Quaternion.Slerp(canhaoDaTorre.transform.rotation, rotacaoDoCanhao, Time.deltaTime * 5f);
	}
}