using UnityEngine;

public class AI_Ray : MonoBehaviour {

    [SerializeField] private Transform Player;
    private UnityEngine.AI.NavMeshAgent NMA;



	private void Start () {
        NMA = (UnityEngine.AI.NavMeshAgent)this.GetComponent("NavMeshAgent");
	}
	
	
	private void Update () {
        NMA.SetDestination(Player.position);
	}
}
