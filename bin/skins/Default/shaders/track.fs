precision mediump float;

varying vec2 fsTex;

uniform sampler2D mainTex;
uniform vec4 lCol;
uniform vec4 rCol;
uniform float hidden;

void main()
{	
	vec4 mainColor = texture2D(mainTex, fsTex.xy);
    vec4 col = mainColor;

    if(fsTex.y > hidden * 0.6)
    {
        //Red channel to color right lane
        col.xyz = vec3(.9) * rCol.xyz * vec3(mainColor.x);

        //Blue channel to color left lane
        col.xyz += vec3(.9) * lCol.xyz * vec3(mainColor.z);

        //Color green channel white
        col.xyz += vec3(.6) * vec3(mainColor.y);
    }
    else
    {
        col.xyz = vec3(0.);
        col.a = col.a > 0.0 ? 0.3 : 0.0;
    }
    gl_FragColor = col;
}