using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kayac;

public class Sample : MonoBehaviour
{
	[SerializeField]
	DebugUiManager _debugUi;
	[SerializeField]
	Shader _textShader;
	[SerializeField]
	Shader _texturedShader;
	[SerializeField]
	Font _font;
	[SerializeField]
	Camera _camera;

	DebugPrimitiveRenderer2D _renderer;
	SampleWindow _sampleWindow;

	// Use this for initialization
	void Start()
	{
		_renderer = new DebugPrimitiveRenderer2D(
			_textShader,
			_texturedShader,
			_font,
			_camera,
			8192);
		_debugUi.Initialize(_renderer);
		_sampleWindow = new SampleWindow(_debugUi);
		_debugUi.Add(_sampleWindow);
	}

	// Update is called once per frame
	void Update()
	{
		_debugUi.ManualUpdate(Time.deltaTime);
	}

	void LateUpdate()
	{
		_renderer.LateUpdate();
	}
}
