# unity-vector-extensions
A set of Vector structs to support some HLSL-like vector functionality.

## Use
```cs
using ShaderTypes;
// ...

Vector3 a;
Vector4 b = new Vector4(a, 5);
a.xy = b.wz + a.yx;
b.xy /= b.zw;

// ...
```

## Features
### Subvector Getters and Setters

Convenience getters and setters are provided for getting and setting subvectors of a vector type, like HLSL vectors.

```cs
Vector4 v;
v.xxx;  v.rrr; // Vector3
v.yx;   v.gr;  // Vector2
v.wxyx; v.argr // Vector4
```

### Per-element Vector Operators

Multiplication, divison, additon, and division operators are defined for each vector type and perform the operation on each element of the target vector. Basic float multiplication and division operators are also provided.

```cs
new Vector2(1, 2) * new Vector2(3, 4) == new Vector2(3, 8)

Vector3 a, b;
a.zx += b.yz;
b.yz *= b.xw;
b.yyz /= a.yyz;
a /= b;
b /= 2;
```

### Implicit UnityEngine.Vector* Conversion

Implicit vector conversion to and from Unity vectors.

```cs
UnityEngine.Vector3 a = new ShaderTypes.Vector3(2, 2);
ShaderTypes.Vector3 b = new UnityEngine.Vector3(1, 1);
```

## Shader Type Definition Statements
```cs
// define common shader types in csharp
using float4 = ShaderTypes.Vector4;
using float3 = ShaderTypes.Vector3;
using float2 = ShaderTypes.Vector2;

using half4 = ShaderTypes.Vector4;
using half3 = ShaderTypes.Vector3;
using half2 = ShaderTypes.Vector2;

using fixed4 = ShaderTypes.Vector4;
using fixed3 = ShaderTypes.Vector3;
using fixed2 = ShaderTypes.Vector2;
```

## Regenerating ShaderVectorTypes.cs

Run `node generate-ShaderVectorTypes` in the repository root.
