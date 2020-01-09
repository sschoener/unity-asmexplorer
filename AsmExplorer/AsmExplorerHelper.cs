using System;
using UnityEngine;

namespace AsmExplorer {
	[ExecuteAlways]
	class AsmExplorerHelper : MonoBehaviour {
		static WebService s_WebService;

		void Awake() {
			RestartWebservice();
		}

		static void RestartWebservice()
		{
			s_WebService?.Stop();
			s_WebService = new WebService(new Explorer(), "explorer");
			s_WebService.Start();
			UnityEngine.Debug.Log("(Re)Starting web service");
		}

		void OnEnable()
		{
			RestartWebservice();
		}

		void OnDisable()
		{
			s_WebService?.Stop();
		}

		void OnDestroy()
		{
			s_WebService?.Stop();
		}

		void OnApplicationQuit() {
			s_WebService?.Stop();
		}
	}

}