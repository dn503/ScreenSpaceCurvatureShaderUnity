using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
 
[Serializable]
[PostProcess(typeof(ScreenSpaceCurvatureRenderer), PostProcessEvent.AfterStack, "Custom/ScreenSpaceCurvature")]
public sealed class ScreenSpaceCurvature : PostProcessEffectSettings
{

}
 
public sealed class ScreenSpaceCurvatureRenderer : PostProcessEffectRenderer<ScreenSpaceCurvature>
{
    public override void Render(PostProcessRenderContext context)
    {

    }
    
}
