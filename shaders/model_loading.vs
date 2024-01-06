#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;
layout (location = 2) in vec2 aTexCoords;
layout (location = 3) in vec3 aColor;
layout (location = 4) in vec3 aTangent;

out vec3 position;
out vec2 TexCoords;
out vec3 normal;
out vec3 color;

out mat3 TBN;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

uniform sampler2D displacementMap;

uniform bool useDisplacementMap;

void main()
{
    position = (model * vec4(aPos, 1.0)).xyz;
    TexCoords = aTexCoords;
    normal = (model * vec4(aNormal, 0.0)).xyz;
    color = aColor;

    vec3 T = normalize(model * vec4(aTangent, 0.0)).xyz;
    vec3 B = normalize(cross(normal, T));
    vec3 N = normalize(normal);

	TBN = mat3(T, B, N);

    if (useDisplacementMap)
    {
        float height = texture(displacementMap, aTexCoords).r;
        position = position + N * height * 0.02; // displacement_coefficient;
    }

    gl_Position = projection * view * vec4(position, 1.0);
}