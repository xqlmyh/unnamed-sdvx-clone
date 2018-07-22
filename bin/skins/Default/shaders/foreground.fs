precision mediump float;

varying vec2 texVp;

uniform ivec2 screenCenter;
// x = bar time
// y = object glow
// z = real time since song start
uniform vec3 timing;
uniform ivec2 viewport;
uniform float objectGlow;
// fg_texture.png
uniform sampler2D mainTex;
// current FrameBuffer
uniform sampler2D fb_tex;
uniform float tilt;
uniform float clearTransition;

#define PI 3.14159265359
#define TWO_PI 6.28318530718

void main()
{
    gl_FragColor = vec4(0.0);
}
