﻿
using UnityEngine;
using System.Collections;

public class SpawnTestState : SceneStateBase {
	
	public static bool IsTutorial;//튜토리얼 중인지
	public static uint lastSelectStageId;
	public static ulong verifyToken;
	
	public static string StageName = null;
	
	public override void OnEnter(System.Action callback)
	{
		base.OnEnter(callback);
		StageName = "SpawnTestScene";
		//LoadLevelAsync(StageName);
		
		CameraManager.instance.RtsCamera.Reset();
		SceneSetting();
		InitGame(null);
		
		GameReadyState.NextAction = _ACTION.GO_NEXT;
		
		
	}
	
	public override void OnExit(System.Action callback)
	{
		base.OnExit(callback);
		
		Time.timeScale = 1f;
		
		// xray 일단 주석처리 
		// CameraManager.instance.XRayComponent.XRaCameraMode();
	}
	
	void OnLevelWasLoaded(int level)
	{
		if (Application.loadedLevelName != StageName) return;

		SingleGameState.IsMapLoad = true;
		CameraManager.instance.RtsCamera.Reset();
		SceneSetting();
		InitGame(Application.loadedLevelName);
		
		//SoundManager.instance.PlayBgmSound(_LowDataMgr.instance.GetBGMFile(Application.loadedLevelName));
	}
	
	void InitGame(string a)
	{
		SetupMainCamera(true, GAME_MODE.SINGLE, false);
		
		StartCoroutine (initTestScene ());
		
	}
	
	IEnumerator initTestScene(){
		
		bool bLoadDone = false;
		_LowDataMgr.instance.LoadLowDataAllData((ratio, desc) =>{
			if (ratio==1f)
			{
				bLoadDone = true;
			}
			else{
				//yield return null;
				Debug.Log(" load data :"+(ratio*100));
			}
		});
		
		//_LowDataMgr.instance.LoadLowDataForTest ();
		
		while (!bLoadDone) {
			yield return null;
		}
		
		//yield return new WaitForSeconds (1f);
		
		//마지막으로 선택한 스테이지 아이디 저장
		SingleGameState.lastSelectStageId = 110;//210;
		SingleGameState.CurStageName = "1-10";//"2-10";
		SingleGameState.verifyToken = 0;
		SingleGameState.StageQuestList = new System.Collections.Generic.List<NetData.StageClearData>();
		
		for(int i=0;i<3;i++){
			NetData.StageClearData d = new NetData.StageClearData(ClearQuestType.NO_DIE_PARTNER, 0);
			
			if (i==0){
				d.Type = ClearQuestType.NO_DIE_PARTNER;
				d.Value = 0;
				d.CurValueCount = 0;
				d.IsClear = true;
			}
			else if (i==1){
				d.Type = ClearQuestType.TIME_LIMIT;
				d.Value = 240;
				d.CurValueCount = 0;
				d.IsClear = true;
			}
			else if (i==2){
				d.Type = ClearQuestType.HP_PERCENT;
				d.Value = 50;
				d.CurValueCount = 0;
				d.IsClear = true;
			}
			
			SingleGameState.StageQuestList.Add(d);
		}
		/////////////////
		
		//public void SetPlayCharInfo(
		//ulong charIdx, uint level, uint viplv, ulong exp, ulong attend, string lastAttend, string charName, uint userCharIndex, uint BaseAttack , 
		// uint guildId, ulong contri, bool isHideCostume)
		ulong charIdx = 10000007240729082;
		uint level = 73;
		uint viplv = 0;
		ulong exp = 84260;
		ulong attent = 0;
		string lastAttend = "";
		string charName = "kyh";
		uint userCharIndex = 11000;
		uint BaseAttack = 10686;
		uint guildId = 30;
		ulong contri = 0;
		bool isHideCos = false;
		
		
		NetData.instance.GetUserInfo ().SetPlayCharInfo (charIdx, level, viplv, exp, attent, lastAttend, charName, userCharIndex, BaseAttack, guildId, contri, isHideCos);
		NetData.instance.GetUserInfo ().SetPlayCharAsset (1000, 1000, 164, 0, 0, 1140, 0, 0, 0);
		NetData.instance.MakePlayerSyncData(false);
		GameInfoBase infoBase = ResourceMgr.InstAndGetComponent<GameInfoBase>( "GameInfo/SingleGameInfo");
		
		
		//yield return new WaitForSeconds (2.0f);
		
		//GameObject.Find ("UNIT_0").transform.localPosition = new Vector3 (-48.3f, 0.2f, 65.19f);
		//GameObject.Find ("UNIT_0").transform.localPosition = new Vector3 (-12.7f, 0.2f, -59.91f);
		
//		GameObject regenObj = GameObject.Find ("CutSceneTestManager").GetComponent<CutSceneTestManager> ().unit_regen_pos;
//		BoxCollider col = regenObj.GetComponent<BoxCollider> ();
//		Vector3 colliderPos = regenObj.transform.TransformPoint (col.center);
//		
//		GameObject.Find ("UNIT_0").transform.position = colliderPos;
		
		yield return null;
	}
}
