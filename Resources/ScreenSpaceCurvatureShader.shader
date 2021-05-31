Shader "Hidden/Custom/ScreenSpaceCurvature"
{
    HLSLINCLUDE

     ENDHLSL

    SubShader
    {
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            HLSLPROGRAM

                #pragma vertex VertDefault
                #pragma fragment FragDefault

            ENDHLSL
        }
    }
}
