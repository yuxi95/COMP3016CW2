#version 330 core
out vec4 FragColor;

in vec3 position;
in vec2 TexCoords;
in vec3 normal;

in mat3 TBN;

// uniform vec3 ambient;
uniform vec3 materialColor = vec3(1.0);

uniform sampler2D albedoMap;
uniform sampler2D normalMap;

uniform bool useNormalMap;

uniform vec3 lightPosition;

uniform float alpha = 1.0;

void main()
{   
    vec3 n = normalize(normal);

    if (useNormalMap)
    {
        n = texture(normalMap, TexCoords).rgb;
		n = n * 2.0 - 1.0;
        n = normalize(TBN * n); 
    }

    vec4 albedo = texture(albedoMap, TexCoords);

    vec3 ambient = albedo.rgb * 0.3;

    vec3 l1 = normalize(-vec3(-1.0, -1.0, 1.0));

    vec3 l2 = normalize(lightPosition - position);

    float diffuse1 = max(dot(n, l1), 0.0);
    float diffuse2 = max(dot(n, l2), 0.0);

    vec3 finalColor = ambient + (diffuse1 + diffuse2) * albedo.rgb * materialColor;
    // vec3 finalColor = ambient + albedo * diffuse;

    FragColor = vec4(finalColor, alpha);
    // FragColor = vec4(n, 1.0);
}