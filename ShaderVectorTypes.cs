
/*
 * @author Garrett Johnson <garrett.kjohnson@gmail.com>
 * https://github.com/gkjohnson/unity-vector-extensions
 *
 * Generated file
 */
namespace ShaderTypes {

    public struct Vector2 {
        public float x,y;

        // constructors
        public Vector2(float v0) { x = v0; y = 0; }
        public Vector2(float v0, float v1) { x = v0; y = v1; }
        public Vector2(Vector2 v0) { x = v0.x; y = v0.y; }

        // operators
        public static Vector2 operator +(Vector2 a, Vector2 b) { a.x += b.x; a.y += b.y; return a; }
        public static Vector2 operator -(Vector2 a, Vector2 b) { a.x -= b.x; a.y -= b.y; return a; }
        public static Vector2 operator *(Vector2 a, Vector2 b) { a.x *= b.x; a.y *= b.y; return a; }
        public static Vector2 operator /(Vector2 a, Vector2 b) { a.x /= b.x; a.y /= b.y; return a; }
        public static Vector2 operator *(Vector2 v, float d) { v.x *= d; v.y *= d; return v; }
        public static Vector2 operator /(Vector2 v, float d) { v.x /= d; v.y /= d; return v; }
        public static bool operator ==(Vector2 a, Vector2 b) { return a.Equals(b); }
        public static bool operator !=(Vector2 a, Vector2 b) { return !a.Equals(b); }
        public static implicit operator Vector2(UnityEngine.Vector2 v) { return new Vector2(v.x, v.y); }
        public static implicit operator UnityEngine.Vector2(Vector2 v) { return new UnityEngine.Vector2(v.x, v.y); }

        // getters & setters
        public float this[int i] { get { if(i == 0) return x; else if(i == 1) return y; else throw new System.IndexOutOfRangeException(); } set { if(i == 0) x = value; else if(i == 1) y = value; else throw new System.IndexOutOfRangeException(); } }

        public Vector2 xx { get { return new Vector2(x, x); } set { x = value.x; x = value.y; } }
        public Vector2 xy { get { return new Vector2(x, y); } set { x = value.x; y = value.y; } }
        public Vector2 yx { get { return new Vector2(y, x); } set { y = value.x; x = value.y; } }
        public Vector2 yy { get { return new Vector2(y, y); } set { y = value.x; y = value.y; } }
        public Vector3 xxx { get { return new Vector3(x, x, x); } set { x = value.x; x = value.y; x = value.z; } }
        public Vector3 xxy { get { return new Vector3(x, x, y); } set { x = value.x; x = value.y; y = value.z; } }
        public Vector3 xyx { get { return new Vector3(x, y, x); } set { x = value.x; y = value.y; x = value.z; } }
        public Vector3 xyy { get { return new Vector3(x, y, y); } set { x = value.x; y = value.y; y = value.z; } }
        public Vector3 yxx { get { return new Vector3(y, x, x); } set { y = value.x; x = value.y; x = value.z; } }
        public Vector3 yxy { get { return new Vector3(y, x, y); } set { y = value.x; x = value.y; y = value.z; } }
        public Vector3 yyx { get { return new Vector3(y, y, x); } set { y = value.x; y = value.y; x = value.z; } }
        public Vector3 yyy { get { return new Vector3(y, y, y); } set { y = value.x; y = value.y; y = value.z; } }
        public Vector4 xxxx { get { return new Vector4(x, x, x, x); } set { x = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 xxxy { get { return new Vector4(x, x, x, y); } set { x = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 xxyx { get { return new Vector4(x, x, y, x); } set { x = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 xxyy { get { return new Vector4(x, x, y, y); } set { x = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 xyxx { get { return new Vector4(x, y, x, x); } set { x = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 xyxy { get { return new Vector4(x, y, x, y); } set { x = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 xyyx { get { return new Vector4(x, y, y, x); } set { x = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 xyyy { get { return new Vector4(x, y, y, y); } set { x = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 yxxx { get { return new Vector4(y, x, x, x); } set { y = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 yxxy { get { return new Vector4(y, x, x, y); } set { y = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 yxyx { get { return new Vector4(y, x, y, x); } set { y = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 yxyy { get { return new Vector4(y, x, y, y); } set { y = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 yyxx { get { return new Vector4(y, y, x, x); } set { y = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 yyxy { get { return new Vector4(y, y, x, y); } set { y = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 yyyx { get { return new Vector4(y, y, y, x); } set { y = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 yyyy { get { return new Vector4(y, y, y, y); } set { y = value.x; y = value.y; y = value.z; y = value.w; } }
    }

    public struct Vector3 {
        public float x,y,z;

        // constructors
        public Vector3(float v0) { x = v0; y = 0; z = 0; }
        public Vector3(float v0, float v1) { x = v0; y = v1; z = 0; }
        public Vector3(float v0, float v1, float v2) { x = v0; y = v1; z = v2; }
        public Vector3(float v0, Vector2 v1) { x = v0; y = v1.x; z = v1.y; }
        public Vector3(Vector2 v0) { x = v0.x; y = v0.y; z = 0; }
        public Vector3(Vector2 v0, float v1) { x = v0.x; y = v0.y; z = v1; }
        public Vector3(Vector3 v0) { x = v0.x; y = v0.y; z = v0.z; }

        // operators
        public static Vector3 operator +(Vector3 a, Vector3 b) { a.x += b.x; a.y += b.y; a.z += b.z; return a; }
        public static Vector3 operator -(Vector3 a, Vector3 b) { a.x -= b.x; a.y -= b.y; a.z -= b.z; return a; }
        public static Vector3 operator *(Vector3 a, Vector3 b) { a.x *= b.x; a.y *= b.y; a.z *= b.z; return a; }
        public static Vector3 operator /(Vector3 a, Vector3 b) { a.x /= b.x; a.y /= b.y; a.z /= b.z; return a; }
        public static Vector3 operator *(Vector3 v, float d) { v.x *= d; v.y *= d; v.z *= d; return v; }
        public static Vector3 operator /(Vector3 v, float d) { v.x /= d; v.y /= d; v.z /= d; return v; }
        public static bool operator ==(Vector3 a, Vector3 b) { return a.Equals(b); }
        public static bool operator !=(Vector3 a, Vector3 b) { return !a.Equals(b); }
        public static implicit operator Vector3(UnityEngine.Vector3 v) { return new Vector3(v.x, v.y, v.z); }
        public static implicit operator UnityEngine.Vector3(Vector3 v) { return new UnityEngine.Vector3(v.x, v.y, v.z); }

        // getters & setters
        public float this[int i] { get { if(i == 0) return x; else if(i == 1) return y; else if(i == 2) return z; else throw new System.IndexOutOfRangeException(); } set { if(i == 0) x = value; else if(i == 1) y = value; else if(i == 2) z = value; else throw new System.IndexOutOfRangeException(); } }

        public Vector2 xx { get { return new Vector2(x, x); } set { x = value.x; x = value.y; } }
        public Vector2 xy { get { return new Vector2(x, y); } set { x = value.x; y = value.y; } }
        public Vector2 xz { get { return new Vector2(x, z); } set { x = value.x; z = value.y; } }
        public Vector2 yx { get { return new Vector2(y, x); } set { y = value.x; x = value.y; } }
        public Vector2 yy { get { return new Vector2(y, y); } set { y = value.x; y = value.y; } }
        public Vector2 yz { get { return new Vector2(y, z); } set { y = value.x; z = value.y; } }
        public Vector2 zx { get { return new Vector2(z, x); } set { z = value.x; x = value.y; } }
        public Vector2 zy { get { return new Vector2(z, y); } set { z = value.x; y = value.y; } }
        public Vector2 zz { get { return new Vector2(z, z); } set { z = value.x; z = value.y; } }
        public Vector3 xxx { get { return new Vector3(x, x, x); } set { x = value.x; x = value.y; x = value.z; } }
        public Vector3 xxy { get { return new Vector3(x, x, y); } set { x = value.x; x = value.y; y = value.z; } }
        public Vector3 xxz { get { return new Vector3(x, x, z); } set { x = value.x; x = value.y; z = value.z; } }
        public Vector3 xyx { get { return new Vector3(x, y, x); } set { x = value.x; y = value.y; x = value.z; } }
        public Vector3 xyy { get { return new Vector3(x, y, y); } set { x = value.x; y = value.y; y = value.z; } }
        public Vector3 xyz { get { return new Vector3(x, y, z); } set { x = value.x; y = value.y; z = value.z; } }
        public Vector3 xzx { get { return new Vector3(x, z, x); } set { x = value.x; z = value.y; x = value.z; } }
        public Vector3 xzy { get { return new Vector3(x, z, y); } set { x = value.x; z = value.y; y = value.z; } }
        public Vector3 xzz { get { return new Vector3(x, z, z); } set { x = value.x; z = value.y; z = value.z; } }
        public Vector3 yxx { get { return new Vector3(y, x, x); } set { y = value.x; x = value.y; x = value.z; } }
        public Vector3 yxy { get { return new Vector3(y, x, y); } set { y = value.x; x = value.y; y = value.z; } }
        public Vector3 yxz { get { return new Vector3(y, x, z); } set { y = value.x; x = value.y; z = value.z; } }
        public Vector3 yyx { get { return new Vector3(y, y, x); } set { y = value.x; y = value.y; x = value.z; } }
        public Vector3 yyy { get { return new Vector3(y, y, y); } set { y = value.x; y = value.y; y = value.z; } }
        public Vector3 yyz { get { return new Vector3(y, y, z); } set { y = value.x; y = value.y; z = value.z; } }
        public Vector3 yzx { get { return new Vector3(y, z, x); } set { y = value.x; z = value.y; x = value.z; } }
        public Vector3 yzy { get { return new Vector3(y, z, y); } set { y = value.x; z = value.y; y = value.z; } }
        public Vector3 yzz { get { return new Vector3(y, z, z); } set { y = value.x; z = value.y; z = value.z; } }
        public Vector3 zxx { get { return new Vector3(z, x, x); } set { z = value.x; x = value.y; x = value.z; } }
        public Vector3 zxy { get { return new Vector3(z, x, y); } set { z = value.x; x = value.y; y = value.z; } }
        public Vector3 zxz { get { return new Vector3(z, x, z); } set { z = value.x; x = value.y; z = value.z; } }
        public Vector3 zyx { get { return new Vector3(z, y, x); } set { z = value.x; y = value.y; x = value.z; } }
        public Vector3 zyy { get { return new Vector3(z, y, y); } set { z = value.x; y = value.y; y = value.z; } }
        public Vector3 zyz { get { return new Vector3(z, y, z); } set { z = value.x; y = value.y; z = value.z; } }
        public Vector3 zzx { get { return new Vector3(z, z, x); } set { z = value.x; z = value.y; x = value.z; } }
        public Vector3 zzy { get { return new Vector3(z, z, y); } set { z = value.x; z = value.y; y = value.z; } }
        public Vector3 zzz { get { return new Vector3(z, z, z); } set { z = value.x; z = value.y; z = value.z; } }
        public Vector4 xxxx { get { return new Vector4(x, x, x, x); } set { x = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 xxxy { get { return new Vector4(x, x, x, y); } set { x = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 xxxz { get { return new Vector4(x, x, x, z); } set { x = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 xxyx { get { return new Vector4(x, x, y, x); } set { x = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 xxyy { get { return new Vector4(x, x, y, y); } set { x = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 xxyz { get { return new Vector4(x, x, y, z); } set { x = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 xxzx { get { return new Vector4(x, x, z, x); } set { x = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 xxzy { get { return new Vector4(x, x, z, y); } set { x = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 xxzz { get { return new Vector4(x, x, z, z); } set { x = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 xyxx { get { return new Vector4(x, y, x, x); } set { x = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 xyxy { get { return new Vector4(x, y, x, y); } set { x = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 xyxz { get { return new Vector4(x, y, x, z); } set { x = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 xyyx { get { return new Vector4(x, y, y, x); } set { x = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 xyyy { get { return new Vector4(x, y, y, y); } set { x = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 xyyz { get { return new Vector4(x, y, y, z); } set { x = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 xyzx { get { return new Vector4(x, y, z, x); } set { x = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 xyzy { get { return new Vector4(x, y, z, y); } set { x = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 xyzz { get { return new Vector4(x, y, z, z); } set { x = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 xzxx { get { return new Vector4(x, z, x, x); } set { x = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 xzxy { get { return new Vector4(x, z, x, y); } set { x = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 xzxz { get { return new Vector4(x, z, x, z); } set { x = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 xzyx { get { return new Vector4(x, z, y, x); } set { x = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 xzyy { get { return new Vector4(x, z, y, y); } set { x = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 xzyz { get { return new Vector4(x, z, y, z); } set { x = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 xzzx { get { return new Vector4(x, z, z, x); } set { x = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 xzzy { get { return new Vector4(x, z, z, y); } set { x = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 xzzz { get { return new Vector4(x, z, z, z); } set { x = value.x; z = value.y; z = value.z; z = value.w; } }
        public Vector4 yxxx { get { return new Vector4(y, x, x, x); } set { y = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 yxxy { get { return new Vector4(y, x, x, y); } set { y = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 yxxz { get { return new Vector4(y, x, x, z); } set { y = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 yxyx { get { return new Vector4(y, x, y, x); } set { y = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 yxyy { get { return new Vector4(y, x, y, y); } set { y = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 yxyz { get { return new Vector4(y, x, y, z); } set { y = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 yxzx { get { return new Vector4(y, x, z, x); } set { y = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 yxzy { get { return new Vector4(y, x, z, y); } set { y = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 yxzz { get { return new Vector4(y, x, z, z); } set { y = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 yyxx { get { return new Vector4(y, y, x, x); } set { y = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 yyxy { get { return new Vector4(y, y, x, y); } set { y = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 yyxz { get { return new Vector4(y, y, x, z); } set { y = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 yyyx { get { return new Vector4(y, y, y, x); } set { y = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 yyyy { get { return new Vector4(y, y, y, y); } set { y = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 yyyz { get { return new Vector4(y, y, y, z); } set { y = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 yyzx { get { return new Vector4(y, y, z, x); } set { y = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 yyzy { get { return new Vector4(y, y, z, y); } set { y = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 yyzz { get { return new Vector4(y, y, z, z); } set { y = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 yzxx { get { return new Vector4(y, z, x, x); } set { y = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 yzxy { get { return new Vector4(y, z, x, y); } set { y = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 yzxz { get { return new Vector4(y, z, x, z); } set { y = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 yzyx { get { return new Vector4(y, z, y, x); } set { y = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 yzyy { get { return new Vector4(y, z, y, y); } set { y = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 yzyz { get { return new Vector4(y, z, y, z); } set { y = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 yzzx { get { return new Vector4(y, z, z, x); } set { y = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 yzzy { get { return new Vector4(y, z, z, y); } set { y = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 yzzz { get { return new Vector4(y, z, z, z); } set { y = value.x; z = value.y; z = value.z; z = value.w; } }
        public Vector4 zxxx { get { return new Vector4(z, x, x, x); } set { z = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 zxxy { get { return new Vector4(z, x, x, y); } set { z = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 zxxz { get { return new Vector4(z, x, x, z); } set { z = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 zxyx { get { return new Vector4(z, x, y, x); } set { z = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 zxyy { get { return new Vector4(z, x, y, y); } set { z = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 zxyz { get { return new Vector4(z, x, y, z); } set { z = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 zxzx { get { return new Vector4(z, x, z, x); } set { z = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 zxzy { get { return new Vector4(z, x, z, y); } set { z = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 zxzz { get { return new Vector4(z, x, z, z); } set { z = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 zyxx { get { return new Vector4(z, y, x, x); } set { z = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 zyxy { get { return new Vector4(z, y, x, y); } set { z = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 zyxz { get { return new Vector4(z, y, x, z); } set { z = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 zyyx { get { return new Vector4(z, y, y, x); } set { z = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 zyyy { get { return new Vector4(z, y, y, y); } set { z = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 zyyz { get { return new Vector4(z, y, y, z); } set { z = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 zyzx { get { return new Vector4(z, y, z, x); } set { z = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 zyzy { get { return new Vector4(z, y, z, y); } set { z = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 zyzz { get { return new Vector4(z, y, z, z); } set { z = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 zzxx { get { return new Vector4(z, z, x, x); } set { z = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 zzxy { get { return new Vector4(z, z, x, y); } set { z = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 zzxz { get { return new Vector4(z, z, x, z); } set { z = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 zzyx { get { return new Vector4(z, z, y, x); } set { z = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 zzyy { get { return new Vector4(z, z, y, y); } set { z = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 zzyz { get { return new Vector4(z, z, y, z); } set { z = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 zzzx { get { return new Vector4(z, z, z, x); } set { z = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 zzzy { get { return new Vector4(z, z, z, y); } set { z = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 zzzz { get { return new Vector4(z, z, z, z); } set { z = value.x; z = value.y; z = value.z; z = value.w; } }
    }

    public struct Vector4 {
        public float x,y,z,w;

        // constructors
        public Vector4(float v0) { x = v0; y = 0; z = 0; w = 0; }
        public Vector4(float v0, float v1) { x = v0; y = v1; z = 0; w = 0; }
        public Vector4(float v0, float v1, float v2) { x = v0; y = v1; z = v2; w = 0; }
        public Vector4(float v0, float v1, float v2, float v3) { x = v0; y = v1; z = v2; w = v3; }
        public Vector4(float v0, float v1, Vector2 v2) { x = v0; y = v1; z = v2.x; w = v2.y; }
        public Vector4(float v0, Vector2 v1) { x = v0; y = v1.x; z = v1.y; w = 0; }
        public Vector4(float v0, Vector2 v1, float v2) { x = v0; y = v1.x; z = v1.y; w = v2; }
        public Vector4(float v0, Vector3 v1) { x = v0; y = v1.x; z = v1.y; w = v1.z; }
        public Vector4(Vector2 v0) { x = v0.x; y = v0.y; z = 0; w = 0; }
        public Vector4(Vector2 v0, float v1) { x = v0.x; y = v0.y; z = v1; w = 0; }
        public Vector4(Vector2 v0, float v1, float v2) { x = v0.x; y = v0.y; z = v1; w = v2; }
        public Vector4(Vector2 v0, Vector2 v1) { x = v0.x; y = v0.y; z = v1.x; w = v1.y; }
        public Vector4(Vector3 v0) { x = v0.x; y = v0.y; z = v0.z; w = 0; }
        public Vector4(Vector3 v0, float v1) { x = v0.x; y = v0.y; z = v0.z; w = v1; }
        public Vector4(Vector4 v0) { x = v0.x; y = v0.y; z = v0.z; w = v0.w; }

        // operators
        public static Vector4 operator +(Vector4 a, Vector4 b) { a.x += b.x; a.y += b.y; a.z += b.z; a.w += b.w; return a; }
        public static Vector4 operator -(Vector4 a, Vector4 b) { a.x -= b.x; a.y -= b.y; a.z -= b.z; a.w -= b.w; return a; }
        public static Vector4 operator *(Vector4 a, Vector4 b) { a.x *= b.x; a.y *= b.y; a.z *= b.z; a.w *= b.w; return a; }
        public static Vector4 operator /(Vector4 a, Vector4 b) { a.x /= b.x; a.y /= b.y; a.z /= b.z; a.w /= b.w; return a; }
        public static Vector4 operator *(Vector4 v, float d) { v.x *= d; v.y *= d; v.z *= d; v.w *= d; return v; }
        public static Vector4 operator /(Vector4 v, float d) { v.x /= d; v.y /= d; v.z /= d; v.w /= d; return v; }
        public static bool operator ==(Vector4 a, Vector4 b) { return a.Equals(b); }
        public static bool operator !=(Vector4 a, Vector4 b) { return !a.Equals(b); }
        public static implicit operator Vector4(UnityEngine.Vector4 v) { return new Vector4(v.x, v.y, v.z, v.w); }
        public static implicit operator UnityEngine.Vector4(Vector4 v) { return new UnityEngine.Vector4(v.x, v.y, v.z, v.w); }

        // getters & setters
        public float this[int i] { get { if(i == 0) return x; else if(i == 1) return y; else if(i == 2) return z; else if(i == 3) return w; else throw new System.IndexOutOfRangeException(); } set { if(i == 0) x = value; else if(i == 1) y = value; else if(i == 2) z = value; else if(i == 3) w = value; else throw new System.IndexOutOfRangeException(); } }

        public Vector2 xx { get { return new Vector2(x, x); } set { x = value.x; x = value.y; } }
        public Vector2 xy { get { return new Vector2(x, y); } set { x = value.x; y = value.y; } }
        public Vector2 xz { get { return new Vector2(x, z); } set { x = value.x; z = value.y; } }
        public Vector2 xw { get { return new Vector2(x, w); } set { x = value.x; w = value.y; } }
        public Vector2 yx { get { return new Vector2(y, x); } set { y = value.x; x = value.y; } }
        public Vector2 yy { get { return new Vector2(y, y); } set { y = value.x; y = value.y; } }
        public Vector2 yz { get { return new Vector2(y, z); } set { y = value.x; z = value.y; } }
        public Vector2 yw { get { return new Vector2(y, w); } set { y = value.x; w = value.y; } }
        public Vector2 zx { get { return new Vector2(z, x); } set { z = value.x; x = value.y; } }
        public Vector2 zy { get { return new Vector2(z, y); } set { z = value.x; y = value.y; } }
        public Vector2 zz { get { return new Vector2(z, z); } set { z = value.x; z = value.y; } }
        public Vector2 zw { get { return new Vector2(z, w); } set { z = value.x; w = value.y; } }
        public Vector2 wx { get { return new Vector2(w, x); } set { w = value.x; x = value.y; } }
        public Vector2 wy { get { return new Vector2(w, y); } set { w = value.x; y = value.y; } }
        public Vector2 wz { get { return new Vector2(w, z); } set { w = value.x; z = value.y; } }
        public Vector2 ww { get { return new Vector2(w, w); } set { w = value.x; w = value.y; } }
        public Vector3 xxx { get { return new Vector3(x, x, x); } set { x = value.x; x = value.y; x = value.z; } }
        public Vector3 xxy { get { return new Vector3(x, x, y); } set { x = value.x; x = value.y; y = value.z; } }
        public Vector3 xxz { get { return new Vector3(x, x, z); } set { x = value.x; x = value.y; z = value.z; } }
        public Vector3 xxw { get { return new Vector3(x, x, w); } set { x = value.x; x = value.y; w = value.z; } }
        public Vector3 xyx { get { return new Vector3(x, y, x); } set { x = value.x; y = value.y; x = value.z; } }
        public Vector3 xyy { get { return new Vector3(x, y, y); } set { x = value.x; y = value.y; y = value.z; } }
        public Vector3 xyz { get { return new Vector3(x, y, z); } set { x = value.x; y = value.y; z = value.z; } }
        public Vector3 xyw { get { return new Vector3(x, y, w); } set { x = value.x; y = value.y; w = value.z; } }
        public Vector3 xzx { get { return new Vector3(x, z, x); } set { x = value.x; z = value.y; x = value.z; } }
        public Vector3 xzy { get { return new Vector3(x, z, y); } set { x = value.x; z = value.y; y = value.z; } }
        public Vector3 xzz { get { return new Vector3(x, z, z); } set { x = value.x; z = value.y; z = value.z; } }
        public Vector3 xzw { get { return new Vector3(x, z, w); } set { x = value.x; z = value.y; w = value.z; } }
        public Vector3 xwx { get { return new Vector3(x, w, x); } set { x = value.x; w = value.y; x = value.z; } }
        public Vector3 xwy { get { return new Vector3(x, w, y); } set { x = value.x; w = value.y; y = value.z; } }
        public Vector3 xwz { get { return new Vector3(x, w, z); } set { x = value.x; w = value.y; z = value.z; } }
        public Vector3 xww { get { return new Vector3(x, w, w); } set { x = value.x; w = value.y; w = value.z; } }
        public Vector3 yxx { get { return new Vector3(y, x, x); } set { y = value.x; x = value.y; x = value.z; } }
        public Vector3 yxy { get { return new Vector3(y, x, y); } set { y = value.x; x = value.y; y = value.z; } }
        public Vector3 yxz { get { return new Vector3(y, x, z); } set { y = value.x; x = value.y; z = value.z; } }
        public Vector3 yxw { get { return new Vector3(y, x, w); } set { y = value.x; x = value.y; w = value.z; } }
        public Vector3 yyx { get { return new Vector3(y, y, x); } set { y = value.x; y = value.y; x = value.z; } }
        public Vector3 yyy { get { return new Vector3(y, y, y); } set { y = value.x; y = value.y; y = value.z; } }
        public Vector3 yyz { get { return new Vector3(y, y, z); } set { y = value.x; y = value.y; z = value.z; } }
        public Vector3 yyw { get { return new Vector3(y, y, w); } set { y = value.x; y = value.y; w = value.z; } }
        public Vector3 yzx { get { return new Vector3(y, z, x); } set { y = value.x; z = value.y; x = value.z; } }
        public Vector3 yzy { get { return new Vector3(y, z, y); } set { y = value.x; z = value.y; y = value.z; } }
        public Vector3 yzz { get { return new Vector3(y, z, z); } set { y = value.x; z = value.y; z = value.z; } }
        public Vector3 yzw { get { return new Vector3(y, z, w); } set { y = value.x; z = value.y; w = value.z; } }
        public Vector3 ywx { get { return new Vector3(y, w, x); } set { y = value.x; w = value.y; x = value.z; } }
        public Vector3 ywy { get { return new Vector3(y, w, y); } set { y = value.x; w = value.y; y = value.z; } }
        public Vector3 ywz { get { return new Vector3(y, w, z); } set { y = value.x; w = value.y; z = value.z; } }
        public Vector3 yww { get { return new Vector3(y, w, w); } set { y = value.x; w = value.y; w = value.z; } }
        public Vector3 zxx { get { return new Vector3(z, x, x); } set { z = value.x; x = value.y; x = value.z; } }
        public Vector3 zxy { get { return new Vector3(z, x, y); } set { z = value.x; x = value.y; y = value.z; } }
        public Vector3 zxz { get { return new Vector3(z, x, z); } set { z = value.x; x = value.y; z = value.z; } }
        public Vector3 zxw { get { return new Vector3(z, x, w); } set { z = value.x; x = value.y; w = value.z; } }
        public Vector3 zyx { get { return new Vector3(z, y, x); } set { z = value.x; y = value.y; x = value.z; } }
        public Vector3 zyy { get { return new Vector3(z, y, y); } set { z = value.x; y = value.y; y = value.z; } }
        public Vector3 zyz { get { return new Vector3(z, y, z); } set { z = value.x; y = value.y; z = value.z; } }
        public Vector3 zyw { get { return new Vector3(z, y, w); } set { z = value.x; y = value.y; w = value.z; } }
        public Vector3 zzx { get { return new Vector3(z, z, x); } set { z = value.x; z = value.y; x = value.z; } }
        public Vector3 zzy { get { return new Vector3(z, z, y); } set { z = value.x; z = value.y; y = value.z; } }
        public Vector3 zzz { get { return new Vector3(z, z, z); } set { z = value.x; z = value.y; z = value.z; } }
        public Vector3 zzw { get { return new Vector3(z, z, w); } set { z = value.x; z = value.y; w = value.z; } }
        public Vector3 zwx { get { return new Vector3(z, w, x); } set { z = value.x; w = value.y; x = value.z; } }
        public Vector3 zwy { get { return new Vector3(z, w, y); } set { z = value.x; w = value.y; y = value.z; } }
        public Vector3 zwz { get { return new Vector3(z, w, z); } set { z = value.x; w = value.y; z = value.z; } }
        public Vector3 zww { get { return new Vector3(z, w, w); } set { z = value.x; w = value.y; w = value.z; } }
        public Vector3 wxx { get { return new Vector3(w, x, x); } set { w = value.x; x = value.y; x = value.z; } }
        public Vector3 wxy { get { return new Vector3(w, x, y); } set { w = value.x; x = value.y; y = value.z; } }
        public Vector3 wxz { get { return new Vector3(w, x, z); } set { w = value.x; x = value.y; z = value.z; } }
        public Vector3 wxw { get { return new Vector3(w, x, w); } set { w = value.x; x = value.y; w = value.z; } }
        public Vector3 wyx { get { return new Vector3(w, y, x); } set { w = value.x; y = value.y; x = value.z; } }
        public Vector3 wyy { get { return new Vector3(w, y, y); } set { w = value.x; y = value.y; y = value.z; } }
        public Vector3 wyz { get { return new Vector3(w, y, z); } set { w = value.x; y = value.y; z = value.z; } }
        public Vector3 wyw { get { return new Vector3(w, y, w); } set { w = value.x; y = value.y; w = value.z; } }
        public Vector3 wzx { get { return new Vector3(w, z, x); } set { w = value.x; z = value.y; x = value.z; } }
        public Vector3 wzy { get { return new Vector3(w, z, y); } set { w = value.x; z = value.y; y = value.z; } }
        public Vector3 wzz { get { return new Vector3(w, z, z); } set { w = value.x; z = value.y; z = value.z; } }
        public Vector3 wzw { get { return new Vector3(w, z, w); } set { w = value.x; z = value.y; w = value.z; } }
        public Vector3 wwx { get { return new Vector3(w, w, x); } set { w = value.x; w = value.y; x = value.z; } }
        public Vector3 wwy { get { return new Vector3(w, w, y); } set { w = value.x; w = value.y; y = value.z; } }
        public Vector3 wwz { get { return new Vector3(w, w, z); } set { w = value.x; w = value.y; z = value.z; } }
        public Vector3 www { get { return new Vector3(w, w, w); } set { w = value.x; w = value.y; w = value.z; } }
        public Vector4 xxxx { get { return new Vector4(x, x, x, x); } set { x = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 xxxy { get { return new Vector4(x, x, x, y); } set { x = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 xxxz { get { return new Vector4(x, x, x, z); } set { x = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 xxxw { get { return new Vector4(x, x, x, w); } set { x = value.x; x = value.y; x = value.z; w = value.w; } }
        public Vector4 xxyx { get { return new Vector4(x, x, y, x); } set { x = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 xxyy { get { return new Vector4(x, x, y, y); } set { x = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 xxyz { get { return new Vector4(x, x, y, z); } set { x = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 xxyw { get { return new Vector4(x, x, y, w); } set { x = value.x; x = value.y; y = value.z; w = value.w; } }
        public Vector4 xxzx { get { return new Vector4(x, x, z, x); } set { x = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 xxzy { get { return new Vector4(x, x, z, y); } set { x = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 xxzz { get { return new Vector4(x, x, z, z); } set { x = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 xxzw { get { return new Vector4(x, x, z, w); } set { x = value.x; x = value.y; z = value.z; w = value.w; } }
        public Vector4 xxwx { get { return new Vector4(x, x, w, x); } set { x = value.x; x = value.y; w = value.z; x = value.w; } }
        public Vector4 xxwy { get { return new Vector4(x, x, w, y); } set { x = value.x; x = value.y; w = value.z; y = value.w; } }
        public Vector4 xxwz { get { return new Vector4(x, x, w, z); } set { x = value.x; x = value.y; w = value.z; z = value.w; } }
        public Vector4 xxww { get { return new Vector4(x, x, w, w); } set { x = value.x; x = value.y; w = value.z; w = value.w; } }
        public Vector4 xyxx { get { return new Vector4(x, y, x, x); } set { x = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 xyxy { get { return new Vector4(x, y, x, y); } set { x = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 xyxz { get { return new Vector4(x, y, x, z); } set { x = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 xyxw { get { return new Vector4(x, y, x, w); } set { x = value.x; y = value.y; x = value.z; w = value.w; } }
        public Vector4 xyyx { get { return new Vector4(x, y, y, x); } set { x = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 xyyy { get { return new Vector4(x, y, y, y); } set { x = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 xyyz { get { return new Vector4(x, y, y, z); } set { x = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 xyyw { get { return new Vector4(x, y, y, w); } set { x = value.x; y = value.y; y = value.z; w = value.w; } }
        public Vector4 xyzx { get { return new Vector4(x, y, z, x); } set { x = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 xyzy { get { return new Vector4(x, y, z, y); } set { x = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 xyzz { get { return new Vector4(x, y, z, z); } set { x = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 xyzw { get { return new Vector4(x, y, z, w); } set { x = value.x; y = value.y; z = value.z; w = value.w; } }
        public Vector4 xywx { get { return new Vector4(x, y, w, x); } set { x = value.x; y = value.y; w = value.z; x = value.w; } }
        public Vector4 xywy { get { return new Vector4(x, y, w, y); } set { x = value.x; y = value.y; w = value.z; y = value.w; } }
        public Vector4 xywz { get { return new Vector4(x, y, w, z); } set { x = value.x; y = value.y; w = value.z; z = value.w; } }
        public Vector4 xyww { get { return new Vector4(x, y, w, w); } set { x = value.x; y = value.y; w = value.z; w = value.w; } }
        public Vector4 xzxx { get { return new Vector4(x, z, x, x); } set { x = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 xzxy { get { return new Vector4(x, z, x, y); } set { x = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 xzxz { get { return new Vector4(x, z, x, z); } set { x = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 xzxw { get { return new Vector4(x, z, x, w); } set { x = value.x; z = value.y; x = value.z; w = value.w; } }
        public Vector4 xzyx { get { return new Vector4(x, z, y, x); } set { x = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 xzyy { get { return new Vector4(x, z, y, y); } set { x = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 xzyz { get { return new Vector4(x, z, y, z); } set { x = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 xzyw { get { return new Vector4(x, z, y, w); } set { x = value.x; z = value.y; y = value.z; w = value.w; } }
        public Vector4 xzzx { get { return new Vector4(x, z, z, x); } set { x = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 xzzy { get { return new Vector4(x, z, z, y); } set { x = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 xzzz { get { return new Vector4(x, z, z, z); } set { x = value.x; z = value.y; z = value.z; z = value.w; } }
        public Vector4 xzzw { get { return new Vector4(x, z, z, w); } set { x = value.x; z = value.y; z = value.z; w = value.w; } }
        public Vector4 xzwx { get { return new Vector4(x, z, w, x); } set { x = value.x; z = value.y; w = value.z; x = value.w; } }
        public Vector4 xzwy { get { return new Vector4(x, z, w, y); } set { x = value.x; z = value.y; w = value.z; y = value.w; } }
        public Vector4 xzwz { get { return new Vector4(x, z, w, z); } set { x = value.x; z = value.y; w = value.z; z = value.w; } }
        public Vector4 xzww { get { return new Vector4(x, z, w, w); } set { x = value.x; z = value.y; w = value.z; w = value.w; } }
        public Vector4 xwxx { get { return new Vector4(x, w, x, x); } set { x = value.x; w = value.y; x = value.z; x = value.w; } }
        public Vector4 xwxy { get { return new Vector4(x, w, x, y); } set { x = value.x; w = value.y; x = value.z; y = value.w; } }
        public Vector4 xwxz { get { return new Vector4(x, w, x, z); } set { x = value.x; w = value.y; x = value.z; z = value.w; } }
        public Vector4 xwxw { get { return new Vector4(x, w, x, w); } set { x = value.x; w = value.y; x = value.z; w = value.w; } }
        public Vector4 xwyx { get { return new Vector4(x, w, y, x); } set { x = value.x; w = value.y; y = value.z; x = value.w; } }
        public Vector4 xwyy { get { return new Vector4(x, w, y, y); } set { x = value.x; w = value.y; y = value.z; y = value.w; } }
        public Vector4 xwyz { get { return new Vector4(x, w, y, z); } set { x = value.x; w = value.y; y = value.z; z = value.w; } }
        public Vector4 xwyw { get { return new Vector4(x, w, y, w); } set { x = value.x; w = value.y; y = value.z; w = value.w; } }
        public Vector4 xwzx { get { return new Vector4(x, w, z, x); } set { x = value.x; w = value.y; z = value.z; x = value.w; } }
        public Vector4 xwzy { get { return new Vector4(x, w, z, y); } set { x = value.x; w = value.y; z = value.z; y = value.w; } }
        public Vector4 xwzz { get { return new Vector4(x, w, z, z); } set { x = value.x; w = value.y; z = value.z; z = value.w; } }
        public Vector4 xwzw { get { return new Vector4(x, w, z, w); } set { x = value.x; w = value.y; z = value.z; w = value.w; } }
        public Vector4 xwwx { get { return new Vector4(x, w, w, x); } set { x = value.x; w = value.y; w = value.z; x = value.w; } }
        public Vector4 xwwy { get { return new Vector4(x, w, w, y); } set { x = value.x; w = value.y; w = value.z; y = value.w; } }
        public Vector4 xwwz { get { return new Vector4(x, w, w, z); } set { x = value.x; w = value.y; w = value.z; z = value.w; } }
        public Vector4 xwww { get { return new Vector4(x, w, w, w); } set { x = value.x; w = value.y; w = value.z; w = value.w; } }
        public Vector4 yxxx { get { return new Vector4(y, x, x, x); } set { y = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 yxxy { get { return new Vector4(y, x, x, y); } set { y = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 yxxz { get { return new Vector4(y, x, x, z); } set { y = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 yxxw { get { return new Vector4(y, x, x, w); } set { y = value.x; x = value.y; x = value.z; w = value.w; } }
        public Vector4 yxyx { get { return new Vector4(y, x, y, x); } set { y = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 yxyy { get { return new Vector4(y, x, y, y); } set { y = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 yxyz { get { return new Vector4(y, x, y, z); } set { y = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 yxyw { get { return new Vector4(y, x, y, w); } set { y = value.x; x = value.y; y = value.z; w = value.w; } }
        public Vector4 yxzx { get { return new Vector4(y, x, z, x); } set { y = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 yxzy { get { return new Vector4(y, x, z, y); } set { y = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 yxzz { get { return new Vector4(y, x, z, z); } set { y = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 yxzw { get { return new Vector4(y, x, z, w); } set { y = value.x; x = value.y; z = value.z; w = value.w; } }
        public Vector4 yxwx { get { return new Vector4(y, x, w, x); } set { y = value.x; x = value.y; w = value.z; x = value.w; } }
        public Vector4 yxwy { get { return new Vector4(y, x, w, y); } set { y = value.x; x = value.y; w = value.z; y = value.w; } }
        public Vector4 yxwz { get { return new Vector4(y, x, w, z); } set { y = value.x; x = value.y; w = value.z; z = value.w; } }
        public Vector4 yxww { get { return new Vector4(y, x, w, w); } set { y = value.x; x = value.y; w = value.z; w = value.w; } }
        public Vector4 yyxx { get { return new Vector4(y, y, x, x); } set { y = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 yyxy { get { return new Vector4(y, y, x, y); } set { y = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 yyxz { get { return new Vector4(y, y, x, z); } set { y = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 yyxw { get { return new Vector4(y, y, x, w); } set { y = value.x; y = value.y; x = value.z; w = value.w; } }
        public Vector4 yyyx { get { return new Vector4(y, y, y, x); } set { y = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 yyyy { get { return new Vector4(y, y, y, y); } set { y = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 yyyz { get { return new Vector4(y, y, y, z); } set { y = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 yyyw { get { return new Vector4(y, y, y, w); } set { y = value.x; y = value.y; y = value.z; w = value.w; } }
        public Vector4 yyzx { get { return new Vector4(y, y, z, x); } set { y = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 yyzy { get { return new Vector4(y, y, z, y); } set { y = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 yyzz { get { return new Vector4(y, y, z, z); } set { y = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 yyzw { get { return new Vector4(y, y, z, w); } set { y = value.x; y = value.y; z = value.z; w = value.w; } }
        public Vector4 yywx { get { return new Vector4(y, y, w, x); } set { y = value.x; y = value.y; w = value.z; x = value.w; } }
        public Vector4 yywy { get { return new Vector4(y, y, w, y); } set { y = value.x; y = value.y; w = value.z; y = value.w; } }
        public Vector4 yywz { get { return new Vector4(y, y, w, z); } set { y = value.x; y = value.y; w = value.z; z = value.w; } }
        public Vector4 yyww { get { return new Vector4(y, y, w, w); } set { y = value.x; y = value.y; w = value.z; w = value.w; } }
        public Vector4 yzxx { get { return new Vector4(y, z, x, x); } set { y = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 yzxy { get { return new Vector4(y, z, x, y); } set { y = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 yzxz { get { return new Vector4(y, z, x, z); } set { y = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 yzxw { get { return new Vector4(y, z, x, w); } set { y = value.x; z = value.y; x = value.z; w = value.w; } }
        public Vector4 yzyx { get { return new Vector4(y, z, y, x); } set { y = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 yzyy { get { return new Vector4(y, z, y, y); } set { y = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 yzyz { get { return new Vector4(y, z, y, z); } set { y = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 yzyw { get { return new Vector4(y, z, y, w); } set { y = value.x; z = value.y; y = value.z; w = value.w; } }
        public Vector4 yzzx { get { return new Vector4(y, z, z, x); } set { y = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 yzzy { get { return new Vector4(y, z, z, y); } set { y = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 yzzz { get { return new Vector4(y, z, z, z); } set { y = value.x; z = value.y; z = value.z; z = value.w; } }
        public Vector4 yzzw { get { return new Vector4(y, z, z, w); } set { y = value.x; z = value.y; z = value.z; w = value.w; } }
        public Vector4 yzwx { get { return new Vector4(y, z, w, x); } set { y = value.x; z = value.y; w = value.z; x = value.w; } }
        public Vector4 yzwy { get { return new Vector4(y, z, w, y); } set { y = value.x; z = value.y; w = value.z; y = value.w; } }
        public Vector4 yzwz { get { return new Vector4(y, z, w, z); } set { y = value.x; z = value.y; w = value.z; z = value.w; } }
        public Vector4 yzww { get { return new Vector4(y, z, w, w); } set { y = value.x; z = value.y; w = value.z; w = value.w; } }
        public Vector4 ywxx { get { return new Vector4(y, w, x, x); } set { y = value.x; w = value.y; x = value.z; x = value.w; } }
        public Vector4 ywxy { get { return new Vector4(y, w, x, y); } set { y = value.x; w = value.y; x = value.z; y = value.w; } }
        public Vector4 ywxz { get { return new Vector4(y, w, x, z); } set { y = value.x; w = value.y; x = value.z; z = value.w; } }
        public Vector4 ywxw { get { return new Vector4(y, w, x, w); } set { y = value.x; w = value.y; x = value.z; w = value.w; } }
        public Vector4 ywyx { get { return new Vector4(y, w, y, x); } set { y = value.x; w = value.y; y = value.z; x = value.w; } }
        public Vector4 ywyy { get { return new Vector4(y, w, y, y); } set { y = value.x; w = value.y; y = value.z; y = value.w; } }
        public Vector4 ywyz { get { return new Vector4(y, w, y, z); } set { y = value.x; w = value.y; y = value.z; z = value.w; } }
        public Vector4 ywyw { get { return new Vector4(y, w, y, w); } set { y = value.x; w = value.y; y = value.z; w = value.w; } }
        public Vector4 ywzx { get { return new Vector4(y, w, z, x); } set { y = value.x; w = value.y; z = value.z; x = value.w; } }
        public Vector4 ywzy { get { return new Vector4(y, w, z, y); } set { y = value.x; w = value.y; z = value.z; y = value.w; } }
        public Vector4 ywzz { get { return new Vector4(y, w, z, z); } set { y = value.x; w = value.y; z = value.z; z = value.w; } }
        public Vector4 ywzw { get { return new Vector4(y, w, z, w); } set { y = value.x; w = value.y; z = value.z; w = value.w; } }
        public Vector4 ywwx { get { return new Vector4(y, w, w, x); } set { y = value.x; w = value.y; w = value.z; x = value.w; } }
        public Vector4 ywwy { get { return new Vector4(y, w, w, y); } set { y = value.x; w = value.y; w = value.z; y = value.w; } }
        public Vector4 ywwz { get { return new Vector4(y, w, w, z); } set { y = value.x; w = value.y; w = value.z; z = value.w; } }
        public Vector4 ywww { get { return new Vector4(y, w, w, w); } set { y = value.x; w = value.y; w = value.z; w = value.w; } }
        public Vector4 zxxx { get { return new Vector4(z, x, x, x); } set { z = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 zxxy { get { return new Vector4(z, x, x, y); } set { z = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 zxxz { get { return new Vector4(z, x, x, z); } set { z = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 zxxw { get { return new Vector4(z, x, x, w); } set { z = value.x; x = value.y; x = value.z; w = value.w; } }
        public Vector4 zxyx { get { return new Vector4(z, x, y, x); } set { z = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 zxyy { get { return new Vector4(z, x, y, y); } set { z = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 zxyz { get { return new Vector4(z, x, y, z); } set { z = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 zxyw { get { return new Vector4(z, x, y, w); } set { z = value.x; x = value.y; y = value.z; w = value.w; } }
        public Vector4 zxzx { get { return new Vector4(z, x, z, x); } set { z = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 zxzy { get { return new Vector4(z, x, z, y); } set { z = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 zxzz { get { return new Vector4(z, x, z, z); } set { z = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 zxzw { get { return new Vector4(z, x, z, w); } set { z = value.x; x = value.y; z = value.z; w = value.w; } }
        public Vector4 zxwx { get { return new Vector4(z, x, w, x); } set { z = value.x; x = value.y; w = value.z; x = value.w; } }
        public Vector4 zxwy { get { return new Vector4(z, x, w, y); } set { z = value.x; x = value.y; w = value.z; y = value.w; } }
        public Vector4 zxwz { get { return new Vector4(z, x, w, z); } set { z = value.x; x = value.y; w = value.z; z = value.w; } }
        public Vector4 zxww { get { return new Vector4(z, x, w, w); } set { z = value.x; x = value.y; w = value.z; w = value.w; } }
        public Vector4 zyxx { get { return new Vector4(z, y, x, x); } set { z = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 zyxy { get { return new Vector4(z, y, x, y); } set { z = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 zyxz { get { return new Vector4(z, y, x, z); } set { z = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 zyxw { get { return new Vector4(z, y, x, w); } set { z = value.x; y = value.y; x = value.z; w = value.w; } }
        public Vector4 zyyx { get { return new Vector4(z, y, y, x); } set { z = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 zyyy { get { return new Vector4(z, y, y, y); } set { z = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 zyyz { get { return new Vector4(z, y, y, z); } set { z = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 zyyw { get { return new Vector4(z, y, y, w); } set { z = value.x; y = value.y; y = value.z; w = value.w; } }
        public Vector4 zyzx { get { return new Vector4(z, y, z, x); } set { z = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 zyzy { get { return new Vector4(z, y, z, y); } set { z = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 zyzz { get { return new Vector4(z, y, z, z); } set { z = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 zyzw { get { return new Vector4(z, y, z, w); } set { z = value.x; y = value.y; z = value.z; w = value.w; } }
        public Vector4 zywx { get { return new Vector4(z, y, w, x); } set { z = value.x; y = value.y; w = value.z; x = value.w; } }
        public Vector4 zywy { get { return new Vector4(z, y, w, y); } set { z = value.x; y = value.y; w = value.z; y = value.w; } }
        public Vector4 zywz { get { return new Vector4(z, y, w, z); } set { z = value.x; y = value.y; w = value.z; z = value.w; } }
        public Vector4 zyww { get { return new Vector4(z, y, w, w); } set { z = value.x; y = value.y; w = value.z; w = value.w; } }
        public Vector4 zzxx { get { return new Vector4(z, z, x, x); } set { z = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 zzxy { get { return new Vector4(z, z, x, y); } set { z = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 zzxz { get { return new Vector4(z, z, x, z); } set { z = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 zzxw { get { return new Vector4(z, z, x, w); } set { z = value.x; z = value.y; x = value.z; w = value.w; } }
        public Vector4 zzyx { get { return new Vector4(z, z, y, x); } set { z = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 zzyy { get { return new Vector4(z, z, y, y); } set { z = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 zzyz { get { return new Vector4(z, z, y, z); } set { z = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 zzyw { get { return new Vector4(z, z, y, w); } set { z = value.x; z = value.y; y = value.z; w = value.w; } }
        public Vector4 zzzx { get { return new Vector4(z, z, z, x); } set { z = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 zzzy { get { return new Vector4(z, z, z, y); } set { z = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 zzzz { get { return new Vector4(z, z, z, z); } set { z = value.x; z = value.y; z = value.z; z = value.w; } }
        public Vector4 zzzw { get { return new Vector4(z, z, z, w); } set { z = value.x; z = value.y; z = value.z; w = value.w; } }
        public Vector4 zzwx { get { return new Vector4(z, z, w, x); } set { z = value.x; z = value.y; w = value.z; x = value.w; } }
        public Vector4 zzwy { get { return new Vector4(z, z, w, y); } set { z = value.x; z = value.y; w = value.z; y = value.w; } }
        public Vector4 zzwz { get { return new Vector4(z, z, w, z); } set { z = value.x; z = value.y; w = value.z; z = value.w; } }
        public Vector4 zzww { get { return new Vector4(z, z, w, w); } set { z = value.x; z = value.y; w = value.z; w = value.w; } }
        public Vector4 zwxx { get { return new Vector4(z, w, x, x); } set { z = value.x; w = value.y; x = value.z; x = value.w; } }
        public Vector4 zwxy { get { return new Vector4(z, w, x, y); } set { z = value.x; w = value.y; x = value.z; y = value.w; } }
        public Vector4 zwxz { get { return new Vector4(z, w, x, z); } set { z = value.x; w = value.y; x = value.z; z = value.w; } }
        public Vector4 zwxw { get { return new Vector4(z, w, x, w); } set { z = value.x; w = value.y; x = value.z; w = value.w; } }
        public Vector4 zwyx { get { return new Vector4(z, w, y, x); } set { z = value.x; w = value.y; y = value.z; x = value.w; } }
        public Vector4 zwyy { get { return new Vector4(z, w, y, y); } set { z = value.x; w = value.y; y = value.z; y = value.w; } }
        public Vector4 zwyz { get { return new Vector4(z, w, y, z); } set { z = value.x; w = value.y; y = value.z; z = value.w; } }
        public Vector4 zwyw { get { return new Vector4(z, w, y, w); } set { z = value.x; w = value.y; y = value.z; w = value.w; } }
        public Vector4 zwzx { get { return new Vector4(z, w, z, x); } set { z = value.x; w = value.y; z = value.z; x = value.w; } }
        public Vector4 zwzy { get { return new Vector4(z, w, z, y); } set { z = value.x; w = value.y; z = value.z; y = value.w; } }
        public Vector4 zwzz { get { return new Vector4(z, w, z, z); } set { z = value.x; w = value.y; z = value.z; z = value.w; } }
        public Vector4 zwzw { get { return new Vector4(z, w, z, w); } set { z = value.x; w = value.y; z = value.z; w = value.w; } }
        public Vector4 zwwx { get { return new Vector4(z, w, w, x); } set { z = value.x; w = value.y; w = value.z; x = value.w; } }
        public Vector4 zwwy { get { return new Vector4(z, w, w, y); } set { z = value.x; w = value.y; w = value.z; y = value.w; } }
        public Vector4 zwwz { get { return new Vector4(z, w, w, z); } set { z = value.x; w = value.y; w = value.z; z = value.w; } }
        public Vector4 zwww { get { return new Vector4(z, w, w, w); } set { z = value.x; w = value.y; w = value.z; w = value.w; } }
        public Vector4 wxxx { get { return new Vector4(w, x, x, x); } set { w = value.x; x = value.y; x = value.z; x = value.w; } }
        public Vector4 wxxy { get { return new Vector4(w, x, x, y); } set { w = value.x; x = value.y; x = value.z; y = value.w; } }
        public Vector4 wxxz { get { return new Vector4(w, x, x, z); } set { w = value.x; x = value.y; x = value.z; z = value.w; } }
        public Vector4 wxxw { get { return new Vector4(w, x, x, w); } set { w = value.x; x = value.y; x = value.z; w = value.w; } }
        public Vector4 wxyx { get { return new Vector4(w, x, y, x); } set { w = value.x; x = value.y; y = value.z; x = value.w; } }
        public Vector4 wxyy { get { return new Vector4(w, x, y, y); } set { w = value.x; x = value.y; y = value.z; y = value.w; } }
        public Vector4 wxyz { get { return new Vector4(w, x, y, z); } set { w = value.x; x = value.y; y = value.z; z = value.w; } }
        public Vector4 wxyw { get { return new Vector4(w, x, y, w); } set { w = value.x; x = value.y; y = value.z; w = value.w; } }
        public Vector4 wxzx { get { return new Vector4(w, x, z, x); } set { w = value.x; x = value.y; z = value.z; x = value.w; } }
        public Vector4 wxzy { get { return new Vector4(w, x, z, y); } set { w = value.x; x = value.y; z = value.z; y = value.w; } }
        public Vector4 wxzz { get { return new Vector4(w, x, z, z); } set { w = value.x; x = value.y; z = value.z; z = value.w; } }
        public Vector4 wxzw { get { return new Vector4(w, x, z, w); } set { w = value.x; x = value.y; z = value.z; w = value.w; } }
        public Vector4 wxwx { get { return new Vector4(w, x, w, x); } set { w = value.x; x = value.y; w = value.z; x = value.w; } }
        public Vector4 wxwy { get { return new Vector4(w, x, w, y); } set { w = value.x; x = value.y; w = value.z; y = value.w; } }
        public Vector4 wxwz { get { return new Vector4(w, x, w, z); } set { w = value.x; x = value.y; w = value.z; z = value.w; } }
        public Vector4 wxww { get { return new Vector4(w, x, w, w); } set { w = value.x; x = value.y; w = value.z; w = value.w; } }
        public Vector4 wyxx { get { return new Vector4(w, y, x, x); } set { w = value.x; y = value.y; x = value.z; x = value.w; } }
        public Vector4 wyxy { get { return new Vector4(w, y, x, y); } set { w = value.x; y = value.y; x = value.z; y = value.w; } }
        public Vector4 wyxz { get { return new Vector4(w, y, x, z); } set { w = value.x; y = value.y; x = value.z; z = value.w; } }
        public Vector4 wyxw { get { return new Vector4(w, y, x, w); } set { w = value.x; y = value.y; x = value.z; w = value.w; } }
        public Vector4 wyyx { get { return new Vector4(w, y, y, x); } set { w = value.x; y = value.y; y = value.z; x = value.w; } }
        public Vector4 wyyy { get { return new Vector4(w, y, y, y); } set { w = value.x; y = value.y; y = value.z; y = value.w; } }
        public Vector4 wyyz { get { return new Vector4(w, y, y, z); } set { w = value.x; y = value.y; y = value.z; z = value.w; } }
        public Vector4 wyyw { get { return new Vector4(w, y, y, w); } set { w = value.x; y = value.y; y = value.z; w = value.w; } }
        public Vector4 wyzx { get { return new Vector4(w, y, z, x); } set { w = value.x; y = value.y; z = value.z; x = value.w; } }
        public Vector4 wyzy { get { return new Vector4(w, y, z, y); } set { w = value.x; y = value.y; z = value.z; y = value.w; } }
        public Vector4 wyzz { get { return new Vector4(w, y, z, z); } set { w = value.x; y = value.y; z = value.z; z = value.w; } }
        public Vector4 wyzw { get { return new Vector4(w, y, z, w); } set { w = value.x; y = value.y; z = value.z; w = value.w; } }
        public Vector4 wywx { get { return new Vector4(w, y, w, x); } set { w = value.x; y = value.y; w = value.z; x = value.w; } }
        public Vector4 wywy { get { return new Vector4(w, y, w, y); } set { w = value.x; y = value.y; w = value.z; y = value.w; } }
        public Vector4 wywz { get { return new Vector4(w, y, w, z); } set { w = value.x; y = value.y; w = value.z; z = value.w; } }
        public Vector4 wyww { get { return new Vector4(w, y, w, w); } set { w = value.x; y = value.y; w = value.z; w = value.w; } }
        public Vector4 wzxx { get { return new Vector4(w, z, x, x); } set { w = value.x; z = value.y; x = value.z; x = value.w; } }
        public Vector4 wzxy { get { return new Vector4(w, z, x, y); } set { w = value.x; z = value.y; x = value.z; y = value.w; } }
        public Vector4 wzxz { get { return new Vector4(w, z, x, z); } set { w = value.x; z = value.y; x = value.z; z = value.w; } }
        public Vector4 wzxw { get { return new Vector4(w, z, x, w); } set { w = value.x; z = value.y; x = value.z; w = value.w; } }
        public Vector4 wzyx { get { return new Vector4(w, z, y, x); } set { w = value.x; z = value.y; y = value.z; x = value.w; } }
        public Vector4 wzyy { get { return new Vector4(w, z, y, y); } set { w = value.x; z = value.y; y = value.z; y = value.w; } }
        public Vector4 wzyz { get { return new Vector4(w, z, y, z); } set { w = value.x; z = value.y; y = value.z; z = value.w; } }
        public Vector4 wzyw { get { return new Vector4(w, z, y, w); } set { w = value.x; z = value.y; y = value.z; w = value.w; } }
        public Vector4 wzzx { get { return new Vector4(w, z, z, x); } set { w = value.x; z = value.y; z = value.z; x = value.w; } }
        public Vector4 wzzy { get { return new Vector4(w, z, z, y); } set { w = value.x; z = value.y; z = value.z; y = value.w; } }
        public Vector4 wzzz { get { return new Vector4(w, z, z, z); } set { w = value.x; z = value.y; z = value.z; z = value.w; } }
        public Vector4 wzzw { get { return new Vector4(w, z, z, w); } set { w = value.x; z = value.y; z = value.z; w = value.w; } }
        public Vector4 wzwx { get { return new Vector4(w, z, w, x); } set { w = value.x; z = value.y; w = value.z; x = value.w; } }
        public Vector4 wzwy { get { return new Vector4(w, z, w, y); } set { w = value.x; z = value.y; w = value.z; y = value.w; } }
        public Vector4 wzwz { get { return new Vector4(w, z, w, z); } set { w = value.x; z = value.y; w = value.z; z = value.w; } }
        public Vector4 wzww { get { return new Vector4(w, z, w, w); } set { w = value.x; z = value.y; w = value.z; w = value.w; } }
        public Vector4 wwxx { get { return new Vector4(w, w, x, x); } set { w = value.x; w = value.y; x = value.z; x = value.w; } }
        public Vector4 wwxy { get { return new Vector4(w, w, x, y); } set { w = value.x; w = value.y; x = value.z; y = value.w; } }
        public Vector4 wwxz { get { return new Vector4(w, w, x, z); } set { w = value.x; w = value.y; x = value.z; z = value.w; } }
        public Vector4 wwxw { get { return new Vector4(w, w, x, w); } set { w = value.x; w = value.y; x = value.z; w = value.w; } }
        public Vector4 wwyx { get { return new Vector4(w, w, y, x); } set { w = value.x; w = value.y; y = value.z; x = value.w; } }
        public Vector4 wwyy { get { return new Vector4(w, w, y, y); } set { w = value.x; w = value.y; y = value.z; y = value.w; } }
        public Vector4 wwyz { get { return new Vector4(w, w, y, z); } set { w = value.x; w = value.y; y = value.z; z = value.w; } }
        public Vector4 wwyw { get { return new Vector4(w, w, y, w); } set { w = value.x; w = value.y; y = value.z; w = value.w; } }
        public Vector4 wwzx { get { return new Vector4(w, w, z, x); } set { w = value.x; w = value.y; z = value.z; x = value.w; } }
        public Vector4 wwzy { get { return new Vector4(w, w, z, y); } set { w = value.x; w = value.y; z = value.z; y = value.w; } }
        public Vector4 wwzz { get { return new Vector4(w, w, z, z); } set { w = value.x; w = value.y; z = value.z; z = value.w; } }
        public Vector4 wwzw { get { return new Vector4(w, w, z, w); } set { w = value.x; w = value.y; z = value.z; w = value.w; } }
        public Vector4 wwwx { get { return new Vector4(w, w, w, x); } set { w = value.x; w = value.y; w = value.z; x = value.w; } }
        public Vector4 wwwy { get { return new Vector4(w, w, w, y); } set { w = value.x; w = value.y; w = value.z; y = value.w; } }
        public Vector4 wwwz { get { return new Vector4(w, w, w, z); } set { w = value.x; w = value.y; w = value.z; z = value.w; } }
        public Vector4 wwww { get { return new Vector4(w, w, w, w); } set { w = value.x; w = value.y; w = value.z; w = value.w; } }
    }

}
