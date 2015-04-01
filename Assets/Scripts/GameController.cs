using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public GameObject torrePrefab;
	[SerializeField] private Jogador jogador;
	[SerializeField] private GameObject gameOver;
	[SerializeField] private FabricaDeTorre fabricaDeTorre;

	void Start ()
	{
		gameOver.SetActive(false);
	}

	void Update () 
	{
		if (! JogoAcabou ()) 
		{
			if (clicouComBotaoPrimario ()) 
			{
				selecionaLocalParaConstrucao ();
			}
		} else 
		{
			gameOver.SetActive(true);
		}
	}

	private bool clicouComBotaoPrimario() 
	{
		return Input.GetMouseButtonDown (0);
	}

	private RaycastHit disparaRaioDaCameraAteUmPonto(Vector3 ponto)
	{
		Ray raio = Camera.main.ScreenPointToRay (ponto);
		RaycastHit elementoAtingidoPeloRaio;
		float comprimentoMaximoDoRaio = 100.0f;
		Physics.Raycast (raio, out elementoAtingidoPeloRaio, comprimentoMaximoDoRaio);
		return elementoAtingidoPeloRaio;
	}

	private void selecionaLocalParaConstrucao ()
	{
		Vector3 posicaoDoClique = Input.mousePosition;
		RaycastHit elementoAtingidoPeloRaio = disparaRaioDaCameraAteUmPonto(posicaoDoClique);
		if(elementoAtingidoPeloRaio.collider != null) {
			Vector3 posicaoDoElemento = elementoAtingidoPeloRaio.point;
			fabricaDeTorre.SetLocalDeConstrucao(posicaoDoElemento);
//			Instantiate(torrePrefab, posicaoDoElemento, Quaternion.identity);
		}
	}

	private bool JogoAcabou ()
	{
		return !jogador.EstaVivo ();
	}

	public void RecomecaJogo ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
