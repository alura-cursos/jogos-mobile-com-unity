using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour 
{

	private NavMeshAgent agente;
	
	void Start () 
	{
		agente = GetComponent<NavMeshAgent>();
		GameObject fimDoCaminho = GameObject.Find ("FimDoCaminho");
		Vector3 posicaoDoFimDoCaminho = fimDoCaminho.transform.position;
		agente.SetDestination (posicaoDoFimDoCaminho);
	}
}
