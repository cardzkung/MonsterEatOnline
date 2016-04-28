using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkedPlayerScript : NetworkBehaviour {

	public Camera playerCamera;
	public MonsterController player;
	public AudioListener audioListener;
	Renderer[] renderers;
	
	public override void OnStartLocalPlayer () {
		playerCamera.enabled = true;
		player.enabled = true;
		audioListener.enabled = true;

		gameObject.name = "LOCAL Player";
		base.OnStartLocalPlayer ();
	}

	void Start(){
		renderers = GetComponentsInChildren<Renderer> ();
		Setup ();
//		if (!isLocalPlayer) {
//			gameObject.layer = LayerMask.NameToLayer ("RemotePlayer");
//		} else {
//			gameObject.layer = LayerMask.NameToLayer ("LocalPlayer");
//		}
//		RegisterPlayer ();
	}

//	void RegisterPlayer(){
//		string _ID = "Player " + GetComponent<NetworkIdentity> ().netId;
//		transform.name = _ID;
//	}

	void ToggleRenderer(bool isAlive){
		for (int i=0; i<renderers.Length; i++)
			renderers [i].enabled = isAlive;
	}

	void ToggleControls(bool isAlive){
		player.enabled = isAlive;
		playerCamera.cullingMask = ~playerCamera.cullingMask;
	}

	public IEnumerator Respawn(){
		if (isLocalPlayer) {
			//ScoreController.death++;
		}
		yield return new WaitForSeconds (3f);
		SetDefaults ();
		Transform spawn = NetworkManager.singleton.GetStartPosition ();
		transform.position = spawn.position;
		transform.rotation = spawn.rotation;
		ToggleRenderer (true);
	}

	[SerializeField]
	private Behaviour[] disableOnDeath;
	private bool[] wasEnabled;
//	[SyncVar]
//	private bool _isDead = false;
//	public bool isDead {
//		get{ return _isDead;}
//		protected set {_isDead = value;}
//	}


//	[ClientRpc]
//	public void RpcTakeDamage(int _amount){
//		if (isDead)
//			return;
//		UIManager.HP -= _amount;
//		if (UIManager.HP <= 0) 
//			Die ();
//	}


	public void Die(){

		ToggleRenderer (false);

		for (int i = 0; i < disableOnDeath.Length; i++) {
			disableOnDeath [i].enabled = false;
		}
		StartCoroutine (Respawn ());
	}

	public void Setup(){
		wasEnabled = new bool[disableOnDeath.Length];
		for (int i=0; i<wasEnabled.Length; i++) {
			wasEnabled [i] = disableOnDeath [i].enabled;
		}
		SetDefaults ();
	}
	
	public void SetDefaults(){
		//isDead = false;
		//loginName = "Player";
		if (isLocalPlayer) {
			UIManager.HP = 1;
			UIManager.Hit = 0;
			UIManager.Score = 0;
			transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
		}
		for (int i=0; i<disableOnDeath.Length; i++) {
			disableOnDeath [i].enabled = wasEnabled [i];
		}
		Collider _col = GetComponent<Collider> ();
		if (_col != null)
			_col.enabled = true;
	}
}
