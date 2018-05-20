
/*
 * @author Garrett Johnson <garrett.kjohnson@gmail.com>
 * https://github.com/gkjohnson/unity-vector-extensions
 *
 * Generated file
 */
namespace ShaderTypes {

    public struct Vector2 {
        public float x,y;

        public float r { get { return this.x; } set { this.x = value; } }
        public float g { get { return this.y; } set { this.y = value; } }

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
        public Vector2 rr { get { return new Vector2(r, r); } set { r = value.x; r = value.y; } }
        public Vector2 rg { get { return new Vector2(r, g); } set { r = value.x; g = value.y; } }
        public Vector2 gr { get { return new Vector2(g, r); } set { g = value.x; r = value.y; } }
        public Vector2 gg { get { return new Vector2(g, g); } set { g = value.x; g = value.y; } }
        public Vector3 xxx { get { return new Vector3(x, x, x); } set { x = value.x; x = value.y; x = value.z; } }
        public Vector3 xxy { get { return new Vector3(x, x, y); } set { x = value.x; x = value.y; y = value.z; } }
        public Vector3 xyx { get { return new Vector3(x, y, x); } set { x = value.x; y = value.y; x = value.z; } }
        public Vector3 xyy { get { return new Vector3(x, y, y); } set { x = value.x; y = value.y; y = value.z; } }
        public Vector3 yxx { get { return new Vector3(y, x, x); } set { y = value.x; x = value.y; x = value.z; } }
        public Vector3 yxy { get { return new Vector3(y, x, y); } set { y = value.x; x = value.y; y = value.z; } }
        public Vector3 yyx { get { return new Vector3(y, y, x); } set { y = value.x; y = value.y; x = value.z; } }
        public Vector3 yyy { get { return new Vector3(y, y, y); } set { y = value.x; y = value.y; y = value.z; } }
        public Vector3 rrr { get { return new Vector3(r, r, r); } set { r = value.x; r = value.y; r = value.z; } }
        public Vector3 rrg { get { return new Vector3(r, r, g); } set { r = value.x; r = value.y; g = value.z; } }
        public Vector3 rgr { get { return new Vector3(r, g, r); } set { r = value.x; g = value.y; r = value.z; } }
        public Vector3 rgg { get { return new Vector3(r, g, g); } set { r = value.x; g = value.y; g = value.z; } }
        public Vector3 grr { get { return new Vector3(g, r, r); } set { g = value.x; r = value.y; r = value.z; } }
        public Vector3 grg { get { return new Vector3(g, r, g); } set { g = value.x; r = value.y; g = value.z; } }
        public Vector3 ggr { get { return new Vector3(g, g, r); } set { g = value.x; g = value.y; r = value.z; } }
        public Vector3 ggg { get { return new Vector3(g, g, g); } set { g = value.x; g = value.y; g = value.z; } }
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
        public Vector4 rrrr { get { return new Vector4(r, r, r, r); } set { r = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 rrrg { get { return new Vector4(r, r, r, g); } set { r = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 rrgr { get { return new Vector4(r, r, g, r); } set { r = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 rrgg { get { return new Vector4(r, r, g, g); } set { r = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 rgrr { get { return new Vector4(r, g, r, r); } set { r = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 rgrg { get { return new Vector4(r, g, r, g); } set { r = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 rggr { get { return new Vector4(r, g, g, r); } set { r = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 rggg { get { return new Vector4(r, g, g, g); } set { r = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 grrr { get { return new Vector4(g, r, r, r); } set { g = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 grrg { get { return new Vector4(g, r, r, g); } set { g = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 grgr { get { return new Vector4(g, r, g, r); } set { g = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 grgg { get { return new Vector4(g, r, g, g); } set { g = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 ggrr { get { return new Vector4(g, g, r, r); } set { g = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 ggrg { get { return new Vector4(g, g, r, g); } set { g = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 gggr { get { return new Vector4(g, g, g, r); } set { g = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 gggg { get { return new Vector4(g, g, g, g); } set { g = value.x; g = value.y; g = value.z; g = value.w; } }
    }

    public struct Vector3 {
        public float x,y,z;

        public float r { get { return this.x; } set { this.x = value; } }
        public float g { get { return this.y; } set { this.y = value; } }
        public float b { get { return this.z; } set { this.z = value; } }

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
        public Vector2 rr { get { return new Vector2(r, r); } set { r = value.x; r = value.y; } }
        public Vector2 rg { get { return new Vector2(r, g); } set { r = value.x; g = value.y; } }
        public Vector2 rb { get { return new Vector2(r, b); } set { r = value.x; b = value.y; } }
        public Vector2 gr { get { return new Vector2(g, r); } set { g = value.x; r = value.y; } }
        public Vector2 gg { get { return new Vector2(g, g); } set { g = value.x; g = value.y; } }
        public Vector2 gb { get { return new Vector2(g, b); } set { g = value.x; b = value.y; } }
        public Vector2 br { get { return new Vector2(b, r); } set { b = value.x; r = value.y; } }
        public Vector2 bg { get { return new Vector2(b, g); } set { b = value.x; g = value.y; } }
        public Vector2 bb { get { return new Vector2(b, b); } set { b = value.x; b = value.y; } }
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
        public Vector3 rrr { get { return new Vector3(r, r, r); } set { r = value.x; r = value.y; r = value.z; } }
        public Vector3 rrg { get { return new Vector3(r, r, g); } set { r = value.x; r = value.y; g = value.z; } }
        public Vector3 rrb { get { return new Vector3(r, r, b); } set { r = value.x; r = value.y; b = value.z; } }
        public Vector3 rgr { get { return new Vector3(r, g, r); } set { r = value.x; g = value.y; r = value.z; } }
        public Vector3 rgg { get { return new Vector3(r, g, g); } set { r = value.x; g = value.y; g = value.z; } }
        public Vector3 rgb { get { return new Vector3(r, g, b); } set { r = value.x; g = value.y; b = value.z; } }
        public Vector3 rbr { get { return new Vector3(r, b, r); } set { r = value.x; b = value.y; r = value.z; } }
        public Vector3 rbg { get { return new Vector3(r, b, g); } set { r = value.x; b = value.y; g = value.z; } }
        public Vector3 rbb { get { return new Vector3(r, b, b); } set { r = value.x; b = value.y; b = value.z; } }
        public Vector3 grr { get { return new Vector3(g, r, r); } set { g = value.x; r = value.y; r = value.z; } }
        public Vector3 grg { get { return new Vector3(g, r, g); } set { g = value.x; r = value.y; g = value.z; } }
        public Vector3 grb { get { return new Vector3(g, r, b); } set { g = value.x; r = value.y; b = value.z; } }
        public Vector3 ggr { get { return new Vector3(g, g, r); } set { g = value.x; g = value.y; r = value.z; } }
        public Vector3 ggg { get { return new Vector3(g, g, g); } set { g = value.x; g = value.y; g = value.z; } }
        public Vector3 ggb { get { return new Vector3(g, g, b); } set { g = value.x; g = value.y; b = value.z; } }
        public Vector3 gbr { get { return new Vector3(g, b, r); } set { g = value.x; b = value.y; r = value.z; } }
        public Vector3 gbg { get { return new Vector3(g, b, g); } set { g = value.x; b = value.y; g = value.z; } }
        public Vector3 gbb { get { return new Vector3(g, b, b); } set { g = value.x; b = value.y; b = value.z; } }
        public Vector3 brr { get { return new Vector3(b, r, r); } set { b = value.x; r = value.y; r = value.z; } }
        public Vector3 brg { get { return new Vector3(b, r, g); } set { b = value.x; r = value.y; g = value.z; } }
        public Vector3 brb { get { return new Vector3(b, r, b); } set { b = value.x; r = value.y; b = value.z; } }
        public Vector3 bgr { get { return new Vector3(b, g, r); } set { b = value.x; g = value.y; r = value.z; } }
        public Vector3 bgg { get { return new Vector3(b, g, g); } set { b = value.x; g = value.y; g = value.z; } }
        public Vector3 bgb { get { return new Vector3(b, g, b); } set { b = value.x; g = value.y; b = value.z; } }
        public Vector3 bbr { get { return new Vector3(b, b, r); } set { b = value.x; b = value.y; r = value.z; } }
        public Vector3 bbg { get { return new Vector3(b, b, g); } set { b = value.x; b = value.y; g = value.z; } }
        public Vector3 bbb { get { return new Vector3(b, b, b); } set { b = value.x; b = value.y; b = value.z; } }
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
        public Vector4 rrrr { get { return new Vector4(r, r, r, r); } set { r = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 rrrg { get { return new Vector4(r, r, r, g); } set { r = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 rrrb { get { return new Vector4(r, r, r, b); } set { r = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 rrgr { get { return new Vector4(r, r, g, r); } set { r = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 rrgg { get { return new Vector4(r, r, g, g); } set { r = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 rrgb { get { return new Vector4(r, r, g, b); } set { r = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 rrbr { get { return new Vector4(r, r, b, r); } set { r = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 rrbg { get { return new Vector4(r, r, b, g); } set { r = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 rrbb { get { return new Vector4(r, r, b, b); } set { r = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 rgrr { get { return new Vector4(r, g, r, r); } set { r = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 rgrg { get { return new Vector4(r, g, r, g); } set { r = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 rgrb { get { return new Vector4(r, g, r, b); } set { r = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 rggr { get { return new Vector4(r, g, g, r); } set { r = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 rggg { get { return new Vector4(r, g, g, g); } set { r = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 rggb { get { return new Vector4(r, g, g, b); } set { r = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 rgbr { get { return new Vector4(r, g, b, r); } set { r = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 rgbg { get { return new Vector4(r, g, b, g); } set { r = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 rgbb { get { return new Vector4(r, g, b, b); } set { r = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 rbrr { get { return new Vector4(r, b, r, r); } set { r = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 rbrg { get { return new Vector4(r, b, r, g); } set { r = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 rbrb { get { return new Vector4(r, b, r, b); } set { r = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 rbgr { get { return new Vector4(r, b, g, r); } set { r = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 rbgg { get { return new Vector4(r, b, g, g); } set { r = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 rbgb { get { return new Vector4(r, b, g, b); } set { r = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 rbbr { get { return new Vector4(r, b, b, r); } set { r = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 rbbg { get { return new Vector4(r, b, b, g); } set { r = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 rbbb { get { return new Vector4(r, b, b, b); } set { r = value.x; b = value.y; b = value.z; b = value.w; } }
        public Vector4 grrr { get { return new Vector4(g, r, r, r); } set { g = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 grrg { get { return new Vector4(g, r, r, g); } set { g = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 grrb { get { return new Vector4(g, r, r, b); } set { g = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 grgr { get { return new Vector4(g, r, g, r); } set { g = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 grgg { get { return new Vector4(g, r, g, g); } set { g = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 grgb { get { return new Vector4(g, r, g, b); } set { g = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 grbr { get { return new Vector4(g, r, b, r); } set { g = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 grbg { get { return new Vector4(g, r, b, g); } set { g = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 grbb { get { return new Vector4(g, r, b, b); } set { g = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 ggrr { get { return new Vector4(g, g, r, r); } set { g = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 ggrg { get { return new Vector4(g, g, r, g); } set { g = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 ggrb { get { return new Vector4(g, g, r, b); } set { g = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 gggr { get { return new Vector4(g, g, g, r); } set { g = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 gggg { get { return new Vector4(g, g, g, g); } set { g = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 gggb { get { return new Vector4(g, g, g, b); } set { g = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 ggbr { get { return new Vector4(g, g, b, r); } set { g = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 ggbg { get { return new Vector4(g, g, b, g); } set { g = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 ggbb { get { return new Vector4(g, g, b, b); } set { g = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 gbrr { get { return new Vector4(g, b, r, r); } set { g = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 gbrg { get { return new Vector4(g, b, r, g); } set { g = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 gbrb { get { return new Vector4(g, b, r, b); } set { g = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 gbgr { get { return new Vector4(g, b, g, r); } set { g = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 gbgg { get { return new Vector4(g, b, g, g); } set { g = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 gbgb { get { return new Vector4(g, b, g, b); } set { g = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 gbbr { get { return new Vector4(g, b, b, r); } set { g = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 gbbg { get { return new Vector4(g, b, b, g); } set { g = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 gbbb { get { return new Vector4(g, b, b, b); } set { g = value.x; b = value.y; b = value.z; b = value.w; } }
        public Vector4 brrr { get { return new Vector4(b, r, r, r); } set { b = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 brrg { get { return new Vector4(b, r, r, g); } set { b = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 brrb { get { return new Vector4(b, r, r, b); } set { b = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 brgr { get { return new Vector4(b, r, g, r); } set { b = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 brgg { get { return new Vector4(b, r, g, g); } set { b = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 brgb { get { return new Vector4(b, r, g, b); } set { b = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 brbr { get { return new Vector4(b, r, b, r); } set { b = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 brbg { get { return new Vector4(b, r, b, g); } set { b = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 brbb { get { return new Vector4(b, r, b, b); } set { b = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 bgrr { get { return new Vector4(b, g, r, r); } set { b = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 bgrg { get { return new Vector4(b, g, r, g); } set { b = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 bgrb { get { return new Vector4(b, g, r, b); } set { b = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 bggr { get { return new Vector4(b, g, g, r); } set { b = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 bggg { get { return new Vector4(b, g, g, g); } set { b = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 bggb { get { return new Vector4(b, g, g, b); } set { b = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 bgbr { get { return new Vector4(b, g, b, r); } set { b = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 bgbg { get { return new Vector4(b, g, b, g); } set { b = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 bgbb { get { return new Vector4(b, g, b, b); } set { b = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 bbrr { get { return new Vector4(b, b, r, r); } set { b = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 bbrg { get { return new Vector4(b, b, r, g); } set { b = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 bbrb { get { return new Vector4(b, b, r, b); } set { b = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 bbgr { get { return new Vector4(b, b, g, r); } set { b = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 bbgg { get { return new Vector4(b, b, g, g); } set { b = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 bbgb { get { return new Vector4(b, b, g, b); } set { b = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 bbbr { get { return new Vector4(b, b, b, r); } set { b = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 bbbg { get { return new Vector4(b, b, b, g); } set { b = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 bbbb { get { return new Vector4(b, b, b, b); } set { b = value.x; b = value.y; b = value.z; b = value.w; } }
    }

    public struct Vector4 {
        public float x,y,z,w;

        public float r { get { return this.x; } set { this.x = value; } }
        public float g { get { return this.y; } set { this.y = value; } }
        public float b { get { return this.z; } set { this.z = value; } }
        public float a { get { return this.w; } set { this.w = value; } }

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
        public Vector2 rr { get { return new Vector2(r, r); } set { r = value.x; r = value.y; } }
        public Vector2 rg { get { return new Vector2(r, g); } set { r = value.x; g = value.y; } }
        public Vector2 rb { get { return new Vector2(r, b); } set { r = value.x; b = value.y; } }
        public Vector2 ra { get { return new Vector2(r, a); } set { r = value.x; a = value.y; } }
        public Vector2 gr { get { return new Vector2(g, r); } set { g = value.x; r = value.y; } }
        public Vector2 gg { get { return new Vector2(g, g); } set { g = value.x; g = value.y; } }
        public Vector2 gb { get { return new Vector2(g, b); } set { g = value.x; b = value.y; } }
        public Vector2 ga { get { return new Vector2(g, a); } set { g = value.x; a = value.y; } }
        public Vector2 br { get { return new Vector2(b, r); } set { b = value.x; r = value.y; } }
        public Vector2 bg { get { return new Vector2(b, g); } set { b = value.x; g = value.y; } }
        public Vector2 bb { get { return new Vector2(b, b); } set { b = value.x; b = value.y; } }
        public Vector2 ba { get { return new Vector2(b, a); } set { b = value.x; a = value.y; } }
        public Vector2 ar { get { return new Vector2(a, r); } set { a = value.x; r = value.y; } }
        public Vector2 ag { get { return new Vector2(a, g); } set { a = value.x; g = value.y; } }
        public Vector2 ab { get { return new Vector2(a, b); } set { a = value.x; b = value.y; } }
        public Vector2 aa { get { return new Vector2(a, a); } set { a = value.x; a = value.y; } }
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
        public Vector3 rrr { get { return new Vector3(r, r, r); } set { r = value.x; r = value.y; r = value.z; } }
        public Vector3 rrg { get { return new Vector3(r, r, g); } set { r = value.x; r = value.y; g = value.z; } }
        public Vector3 rrb { get { return new Vector3(r, r, b); } set { r = value.x; r = value.y; b = value.z; } }
        public Vector3 rra { get { return new Vector3(r, r, a); } set { r = value.x; r = value.y; a = value.z; } }
        public Vector3 rgr { get { return new Vector3(r, g, r); } set { r = value.x; g = value.y; r = value.z; } }
        public Vector3 rgg { get { return new Vector3(r, g, g); } set { r = value.x; g = value.y; g = value.z; } }
        public Vector3 rgb { get { return new Vector3(r, g, b); } set { r = value.x; g = value.y; b = value.z; } }
        public Vector3 rga { get { return new Vector3(r, g, a); } set { r = value.x; g = value.y; a = value.z; } }
        public Vector3 rbr { get { return new Vector3(r, b, r); } set { r = value.x; b = value.y; r = value.z; } }
        public Vector3 rbg { get { return new Vector3(r, b, g); } set { r = value.x; b = value.y; g = value.z; } }
        public Vector3 rbb { get { return new Vector3(r, b, b); } set { r = value.x; b = value.y; b = value.z; } }
        public Vector3 rba { get { return new Vector3(r, b, a); } set { r = value.x; b = value.y; a = value.z; } }
        public Vector3 rar { get { return new Vector3(r, a, r); } set { r = value.x; a = value.y; r = value.z; } }
        public Vector3 rag { get { return new Vector3(r, a, g); } set { r = value.x; a = value.y; g = value.z; } }
        public Vector3 rab { get { return new Vector3(r, a, b); } set { r = value.x; a = value.y; b = value.z; } }
        public Vector3 raa { get { return new Vector3(r, a, a); } set { r = value.x; a = value.y; a = value.z; } }
        public Vector3 grr { get { return new Vector3(g, r, r); } set { g = value.x; r = value.y; r = value.z; } }
        public Vector3 grg { get { return new Vector3(g, r, g); } set { g = value.x; r = value.y; g = value.z; } }
        public Vector3 grb { get { return new Vector3(g, r, b); } set { g = value.x; r = value.y; b = value.z; } }
        public Vector3 gra { get { return new Vector3(g, r, a); } set { g = value.x; r = value.y; a = value.z; } }
        public Vector3 ggr { get { return new Vector3(g, g, r); } set { g = value.x; g = value.y; r = value.z; } }
        public Vector3 ggg { get { return new Vector3(g, g, g); } set { g = value.x; g = value.y; g = value.z; } }
        public Vector3 ggb { get { return new Vector3(g, g, b); } set { g = value.x; g = value.y; b = value.z; } }
        public Vector3 gga { get { return new Vector3(g, g, a); } set { g = value.x; g = value.y; a = value.z; } }
        public Vector3 gbr { get { return new Vector3(g, b, r); } set { g = value.x; b = value.y; r = value.z; } }
        public Vector3 gbg { get { return new Vector3(g, b, g); } set { g = value.x; b = value.y; g = value.z; } }
        public Vector3 gbb { get { return new Vector3(g, b, b); } set { g = value.x; b = value.y; b = value.z; } }
        public Vector3 gba { get { return new Vector3(g, b, a); } set { g = value.x; b = value.y; a = value.z; } }
        public Vector3 gar { get { return new Vector3(g, a, r); } set { g = value.x; a = value.y; r = value.z; } }
        public Vector3 gag { get { return new Vector3(g, a, g); } set { g = value.x; a = value.y; g = value.z; } }
        public Vector3 gab { get { return new Vector3(g, a, b); } set { g = value.x; a = value.y; b = value.z; } }
        public Vector3 gaa { get { return new Vector3(g, a, a); } set { g = value.x; a = value.y; a = value.z; } }
        public Vector3 brr { get { return new Vector3(b, r, r); } set { b = value.x; r = value.y; r = value.z; } }
        public Vector3 brg { get { return new Vector3(b, r, g); } set { b = value.x; r = value.y; g = value.z; } }
        public Vector3 brb { get { return new Vector3(b, r, b); } set { b = value.x; r = value.y; b = value.z; } }
        public Vector3 bra { get { return new Vector3(b, r, a); } set { b = value.x; r = value.y; a = value.z; } }
        public Vector3 bgr { get { return new Vector3(b, g, r); } set { b = value.x; g = value.y; r = value.z; } }
        public Vector3 bgg { get { return new Vector3(b, g, g); } set { b = value.x; g = value.y; g = value.z; } }
        public Vector3 bgb { get { return new Vector3(b, g, b); } set { b = value.x; g = value.y; b = value.z; } }
        public Vector3 bga { get { return new Vector3(b, g, a); } set { b = value.x; g = value.y; a = value.z; } }
        public Vector3 bbr { get { return new Vector3(b, b, r); } set { b = value.x; b = value.y; r = value.z; } }
        public Vector3 bbg { get { return new Vector3(b, b, g); } set { b = value.x; b = value.y; g = value.z; } }
        public Vector3 bbb { get { return new Vector3(b, b, b); } set { b = value.x; b = value.y; b = value.z; } }
        public Vector3 bba { get { return new Vector3(b, b, a); } set { b = value.x; b = value.y; a = value.z; } }
        public Vector3 bar { get { return new Vector3(b, a, r); } set { b = value.x; a = value.y; r = value.z; } }
        public Vector3 bag { get { return new Vector3(b, a, g); } set { b = value.x; a = value.y; g = value.z; } }
        public Vector3 bab { get { return new Vector3(b, a, b); } set { b = value.x; a = value.y; b = value.z; } }
        public Vector3 baa { get { return new Vector3(b, a, a); } set { b = value.x; a = value.y; a = value.z; } }
        public Vector3 arr { get { return new Vector3(a, r, r); } set { a = value.x; r = value.y; r = value.z; } }
        public Vector3 arg { get { return new Vector3(a, r, g); } set { a = value.x; r = value.y; g = value.z; } }
        public Vector3 arb { get { return new Vector3(a, r, b); } set { a = value.x; r = value.y; b = value.z; } }
        public Vector3 ara { get { return new Vector3(a, r, a); } set { a = value.x; r = value.y; a = value.z; } }
        public Vector3 agr { get { return new Vector3(a, g, r); } set { a = value.x; g = value.y; r = value.z; } }
        public Vector3 agg { get { return new Vector3(a, g, g); } set { a = value.x; g = value.y; g = value.z; } }
        public Vector3 agb { get { return new Vector3(a, g, b); } set { a = value.x; g = value.y; b = value.z; } }
        public Vector3 aga { get { return new Vector3(a, g, a); } set { a = value.x; g = value.y; a = value.z; } }
        public Vector3 abr { get { return new Vector3(a, b, r); } set { a = value.x; b = value.y; r = value.z; } }
        public Vector3 abg { get { return new Vector3(a, b, g); } set { a = value.x; b = value.y; g = value.z; } }
        public Vector3 abb { get { return new Vector3(a, b, b); } set { a = value.x; b = value.y; b = value.z; } }
        public Vector3 aba { get { return new Vector3(a, b, a); } set { a = value.x; b = value.y; a = value.z; } }
        public Vector3 aar { get { return new Vector3(a, a, r); } set { a = value.x; a = value.y; r = value.z; } }
        public Vector3 aag { get { return new Vector3(a, a, g); } set { a = value.x; a = value.y; g = value.z; } }
        public Vector3 aab { get { return new Vector3(a, a, b); } set { a = value.x; a = value.y; b = value.z; } }
        public Vector3 aaa { get { return new Vector3(a, a, a); } set { a = value.x; a = value.y; a = value.z; } }
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
        public Vector4 rrrr { get { return new Vector4(r, r, r, r); } set { r = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 rrrg { get { return new Vector4(r, r, r, g); } set { r = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 rrrb { get { return new Vector4(r, r, r, b); } set { r = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 rrra { get { return new Vector4(r, r, r, a); } set { r = value.x; r = value.y; r = value.z; a = value.w; } }
        public Vector4 rrgr { get { return new Vector4(r, r, g, r); } set { r = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 rrgg { get { return new Vector4(r, r, g, g); } set { r = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 rrgb { get { return new Vector4(r, r, g, b); } set { r = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 rrga { get { return new Vector4(r, r, g, a); } set { r = value.x; r = value.y; g = value.z; a = value.w; } }
        public Vector4 rrbr { get { return new Vector4(r, r, b, r); } set { r = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 rrbg { get { return new Vector4(r, r, b, g); } set { r = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 rrbb { get { return new Vector4(r, r, b, b); } set { r = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 rrba { get { return new Vector4(r, r, b, a); } set { r = value.x; r = value.y; b = value.z; a = value.w; } }
        public Vector4 rrar { get { return new Vector4(r, r, a, r); } set { r = value.x; r = value.y; a = value.z; r = value.w; } }
        public Vector4 rrag { get { return new Vector4(r, r, a, g); } set { r = value.x; r = value.y; a = value.z; g = value.w; } }
        public Vector4 rrab { get { return new Vector4(r, r, a, b); } set { r = value.x; r = value.y; a = value.z; b = value.w; } }
        public Vector4 rraa { get { return new Vector4(r, r, a, a); } set { r = value.x; r = value.y; a = value.z; a = value.w; } }
        public Vector4 rgrr { get { return new Vector4(r, g, r, r); } set { r = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 rgrg { get { return new Vector4(r, g, r, g); } set { r = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 rgrb { get { return new Vector4(r, g, r, b); } set { r = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 rgra { get { return new Vector4(r, g, r, a); } set { r = value.x; g = value.y; r = value.z; a = value.w; } }
        public Vector4 rggr { get { return new Vector4(r, g, g, r); } set { r = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 rggg { get { return new Vector4(r, g, g, g); } set { r = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 rggb { get { return new Vector4(r, g, g, b); } set { r = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 rgga { get { return new Vector4(r, g, g, a); } set { r = value.x; g = value.y; g = value.z; a = value.w; } }
        public Vector4 rgbr { get { return new Vector4(r, g, b, r); } set { r = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 rgbg { get { return new Vector4(r, g, b, g); } set { r = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 rgbb { get { return new Vector4(r, g, b, b); } set { r = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 rgba { get { return new Vector4(r, g, b, a); } set { r = value.x; g = value.y; b = value.z; a = value.w; } }
        public Vector4 rgar { get { return new Vector4(r, g, a, r); } set { r = value.x; g = value.y; a = value.z; r = value.w; } }
        public Vector4 rgag { get { return new Vector4(r, g, a, g); } set { r = value.x; g = value.y; a = value.z; g = value.w; } }
        public Vector4 rgab { get { return new Vector4(r, g, a, b); } set { r = value.x; g = value.y; a = value.z; b = value.w; } }
        public Vector4 rgaa { get { return new Vector4(r, g, a, a); } set { r = value.x; g = value.y; a = value.z; a = value.w; } }
        public Vector4 rbrr { get { return new Vector4(r, b, r, r); } set { r = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 rbrg { get { return new Vector4(r, b, r, g); } set { r = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 rbrb { get { return new Vector4(r, b, r, b); } set { r = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 rbra { get { return new Vector4(r, b, r, a); } set { r = value.x; b = value.y; r = value.z; a = value.w; } }
        public Vector4 rbgr { get { return new Vector4(r, b, g, r); } set { r = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 rbgg { get { return new Vector4(r, b, g, g); } set { r = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 rbgb { get { return new Vector4(r, b, g, b); } set { r = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 rbga { get { return new Vector4(r, b, g, a); } set { r = value.x; b = value.y; g = value.z; a = value.w; } }
        public Vector4 rbbr { get { return new Vector4(r, b, b, r); } set { r = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 rbbg { get { return new Vector4(r, b, b, g); } set { r = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 rbbb { get { return new Vector4(r, b, b, b); } set { r = value.x; b = value.y; b = value.z; b = value.w; } }
        public Vector4 rbba { get { return new Vector4(r, b, b, a); } set { r = value.x; b = value.y; b = value.z; a = value.w; } }
        public Vector4 rbar { get { return new Vector4(r, b, a, r); } set { r = value.x; b = value.y; a = value.z; r = value.w; } }
        public Vector4 rbag { get { return new Vector4(r, b, a, g); } set { r = value.x; b = value.y; a = value.z; g = value.w; } }
        public Vector4 rbab { get { return new Vector4(r, b, a, b); } set { r = value.x; b = value.y; a = value.z; b = value.w; } }
        public Vector4 rbaa { get { return new Vector4(r, b, a, a); } set { r = value.x; b = value.y; a = value.z; a = value.w; } }
        public Vector4 rarr { get { return new Vector4(r, a, r, r); } set { r = value.x; a = value.y; r = value.z; r = value.w; } }
        public Vector4 rarg { get { return new Vector4(r, a, r, g); } set { r = value.x; a = value.y; r = value.z; g = value.w; } }
        public Vector4 rarb { get { return new Vector4(r, a, r, b); } set { r = value.x; a = value.y; r = value.z; b = value.w; } }
        public Vector4 rara { get { return new Vector4(r, a, r, a); } set { r = value.x; a = value.y; r = value.z; a = value.w; } }
        public Vector4 ragr { get { return new Vector4(r, a, g, r); } set { r = value.x; a = value.y; g = value.z; r = value.w; } }
        public Vector4 ragg { get { return new Vector4(r, a, g, g); } set { r = value.x; a = value.y; g = value.z; g = value.w; } }
        public Vector4 ragb { get { return new Vector4(r, a, g, b); } set { r = value.x; a = value.y; g = value.z; b = value.w; } }
        public Vector4 raga { get { return new Vector4(r, a, g, a); } set { r = value.x; a = value.y; g = value.z; a = value.w; } }
        public Vector4 rabr { get { return new Vector4(r, a, b, r); } set { r = value.x; a = value.y; b = value.z; r = value.w; } }
        public Vector4 rabg { get { return new Vector4(r, a, b, g); } set { r = value.x; a = value.y; b = value.z; g = value.w; } }
        public Vector4 rabb { get { return new Vector4(r, a, b, b); } set { r = value.x; a = value.y; b = value.z; b = value.w; } }
        public Vector4 raba { get { return new Vector4(r, a, b, a); } set { r = value.x; a = value.y; b = value.z; a = value.w; } }
        public Vector4 raar { get { return new Vector4(r, a, a, r); } set { r = value.x; a = value.y; a = value.z; r = value.w; } }
        public Vector4 raag { get { return new Vector4(r, a, a, g); } set { r = value.x; a = value.y; a = value.z; g = value.w; } }
        public Vector4 raab { get { return new Vector4(r, a, a, b); } set { r = value.x; a = value.y; a = value.z; b = value.w; } }
        public Vector4 raaa { get { return new Vector4(r, a, a, a); } set { r = value.x; a = value.y; a = value.z; a = value.w; } }
        public Vector4 grrr { get { return new Vector4(g, r, r, r); } set { g = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 grrg { get { return new Vector4(g, r, r, g); } set { g = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 grrb { get { return new Vector4(g, r, r, b); } set { g = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 grra { get { return new Vector4(g, r, r, a); } set { g = value.x; r = value.y; r = value.z; a = value.w; } }
        public Vector4 grgr { get { return new Vector4(g, r, g, r); } set { g = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 grgg { get { return new Vector4(g, r, g, g); } set { g = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 grgb { get { return new Vector4(g, r, g, b); } set { g = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 grga { get { return new Vector4(g, r, g, a); } set { g = value.x; r = value.y; g = value.z; a = value.w; } }
        public Vector4 grbr { get { return new Vector4(g, r, b, r); } set { g = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 grbg { get { return new Vector4(g, r, b, g); } set { g = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 grbb { get { return new Vector4(g, r, b, b); } set { g = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 grba { get { return new Vector4(g, r, b, a); } set { g = value.x; r = value.y; b = value.z; a = value.w; } }
        public Vector4 grar { get { return new Vector4(g, r, a, r); } set { g = value.x; r = value.y; a = value.z; r = value.w; } }
        public Vector4 grag { get { return new Vector4(g, r, a, g); } set { g = value.x; r = value.y; a = value.z; g = value.w; } }
        public Vector4 grab { get { return new Vector4(g, r, a, b); } set { g = value.x; r = value.y; a = value.z; b = value.w; } }
        public Vector4 graa { get { return new Vector4(g, r, a, a); } set { g = value.x; r = value.y; a = value.z; a = value.w; } }
        public Vector4 ggrr { get { return new Vector4(g, g, r, r); } set { g = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 ggrg { get { return new Vector4(g, g, r, g); } set { g = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 ggrb { get { return new Vector4(g, g, r, b); } set { g = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 ggra { get { return new Vector4(g, g, r, a); } set { g = value.x; g = value.y; r = value.z; a = value.w; } }
        public Vector4 gggr { get { return new Vector4(g, g, g, r); } set { g = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 gggg { get { return new Vector4(g, g, g, g); } set { g = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 gggb { get { return new Vector4(g, g, g, b); } set { g = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 ggga { get { return new Vector4(g, g, g, a); } set { g = value.x; g = value.y; g = value.z; a = value.w; } }
        public Vector4 ggbr { get { return new Vector4(g, g, b, r); } set { g = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 ggbg { get { return new Vector4(g, g, b, g); } set { g = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 ggbb { get { return new Vector4(g, g, b, b); } set { g = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 ggba { get { return new Vector4(g, g, b, a); } set { g = value.x; g = value.y; b = value.z; a = value.w; } }
        public Vector4 ggar { get { return new Vector4(g, g, a, r); } set { g = value.x; g = value.y; a = value.z; r = value.w; } }
        public Vector4 ggag { get { return new Vector4(g, g, a, g); } set { g = value.x; g = value.y; a = value.z; g = value.w; } }
        public Vector4 ggab { get { return new Vector4(g, g, a, b); } set { g = value.x; g = value.y; a = value.z; b = value.w; } }
        public Vector4 ggaa { get { return new Vector4(g, g, a, a); } set { g = value.x; g = value.y; a = value.z; a = value.w; } }
        public Vector4 gbrr { get { return new Vector4(g, b, r, r); } set { g = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 gbrg { get { return new Vector4(g, b, r, g); } set { g = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 gbrb { get { return new Vector4(g, b, r, b); } set { g = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 gbra { get { return new Vector4(g, b, r, a); } set { g = value.x; b = value.y; r = value.z; a = value.w; } }
        public Vector4 gbgr { get { return new Vector4(g, b, g, r); } set { g = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 gbgg { get { return new Vector4(g, b, g, g); } set { g = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 gbgb { get { return new Vector4(g, b, g, b); } set { g = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 gbga { get { return new Vector4(g, b, g, a); } set { g = value.x; b = value.y; g = value.z; a = value.w; } }
        public Vector4 gbbr { get { return new Vector4(g, b, b, r); } set { g = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 gbbg { get { return new Vector4(g, b, b, g); } set { g = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 gbbb { get { return new Vector4(g, b, b, b); } set { g = value.x; b = value.y; b = value.z; b = value.w; } }
        public Vector4 gbba { get { return new Vector4(g, b, b, a); } set { g = value.x; b = value.y; b = value.z; a = value.w; } }
        public Vector4 gbar { get { return new Vector4(g, b, a, r); } set { g = value.x; b = value.y; a = value.z; r = value.w; } }
        public Vector4 gbag { get { return new Vector4(g, b, a, g); } set { g = value.x; b = value.y; a = value.z; g = value.w; } }
        public Vector4 gbab { get { return new Vector4(g, b, a, b); } set { g = value.x; b = value.y; a = value.z; b = value.w; } }
        public Vector4 gbaa { get { return new Vector4(g, b, a, a); } set { g = value.x; b = value.y; a = value.z; a = value.w; } }
        public Vector4 garr { get { return new Vector4(g, a, r, r); } set { g = value.x; a = value.y; r = value.z; r = value.w; } }
        public Vector4 garg { get { return new Vector4(g, a, r, g); } set { g = value.x; a = value.y; r = value.z; g = value.w; } }
        public Vector4 garb { get { return new Vector4(g, a, r, b); } set { g = value.x; a = value.y; r = value.z; b = value.w; } }
        public Vector4 gara { get { return new Vector4(g, a, r, a); } set { g = value.x; a = value.y; r = value.z; a = value.w; } }
        public Vector4 gagr { get { return new Vector4(g, a, g, r); } set { g = value.x; a = value.y; g = value.z; r = value.w; } }
        public Vector4 gagg { get { return new Vector4(g, a, g, g); } set { g = value.x; a = value.y; g = value.z; g = value.w; } }
        public Vector4 gagb { get { return new Vector4(g, a, g, b); } set { g = value.x; a = value.y; g = value.z; b = value.w; } }
        public Vector4 gaga { get { return new Vector4(g, a, g, a); } set { g = value.x; a = value.y; g = value.z; a = value.w; } }
        public Vector4 gabr { get { return new Vector4(g, a, b, r); } set { g = value.x; a = value.y; b = value.z; r = value.w; } }
        public Vector4 gabg { get { return new Vector4(g, a, b, g); } set { g = value.x; a = value.y; b = value.z; g = value.w; } }
        public Vector4 gabb { get { return new Vector4(g, a, b, b); } set { g = value.x; a = value.y; b = value.z; b = value.w; } }
        public Vector4 gaba { get { return new Vector4(g, a, b, a); } set { g = value.x; a = value.y; b = value.z; a = value.w; } }
        public Vector4 gaar { get { return new Vector4(g, a, a, r); } set { g = value.x; a = value.y; a = value.z; r = value.w; } }
        public Vector4 gaag { get { return new Vector4(g, a, a, g); } set { g = value.x; a = value.y; a = value.z; g = value.w; } }
        public Vector4 gaab { get { return new Vector4(g, a, a, b); } set { g = value.x; a = value.y; a = value.z; b = value.w; } }
        public Vector4 gaaa { get { return new Vector4(g, a, a, a); } set { g = value.x; a = value.y; a = value.z; a = value.w; } }
        public Vector4 brrr { get { return new Vector4(b, r, r, r); } set { b = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 brrg { get { return new Vector4(b, r, r, g); } set { b = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 brrb { get { return new Vector4(b, r, r, b); } set { b = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 brra { get { return new Vector4(b, r, r, a); } set { b = value.x; r = value.y; r = value.z; a = value.w; } }
        public Vector4 brgr { get { return new Vector4(b, r, g, r); } set { b = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 brgg { get { return new Vector4(b, r, g, g); } set { b = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 brgb { get { return new Vector4(b, r, g, b); } set { b = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 brga { get { return new Vector4(b, r, g, a); } set { b = value.x; r = value.y; g = value.z; a = value.w; } }
        public Vector4 brbr { get { return new Vector4(b, r, b, r); } set { b = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 brbg { get { return new Vector4(b, r, b, g); } set { b = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 brbb { get { return new Vector4(b, r, b, b); } set { b = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 brba { get { return new Vector4(b, r, b, a); } set { b = value.x; r = value.y; b = value.z; a = value.w; } }
        public Vector4 brar { get { return new Vector4(b, r, a, r); } set { b = value.x; r = value.y; a = value.z; r = value.w; } }
        public Vector4 brag { get { return new Vector4(b, r, a, g); } set { b = value.x; r = value.y; a = value.z; g = value.w; } }
        public Vector4 brab { get { return new Vector4(b, r, a, b); } set { b = value.x; r = value.y; a = value.z; b = value.w; } }
        public Vector4 braa { get { return new Vector4(b, r, a, a); } set { b = value.x; r = value.y; a = value.z; a = value.w; } }
        public Vector4 bgrr { get { return new Vector4(b, g, r, r); } set { b = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 bgrg { get { return new Vector4(b, g, r, g); } set { b = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 bgrb { get { return new Vector4(b, g, r, b); } set { b = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 bgra { get { return new Vector4(b, g, r, a); } set { b = value.x; g = value.y; r = value.z; a = value.w; } }
        public Vector4 bggr { get { return new Vector4(b, g, g, r); } set { b = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 bggg { get { return new Vector4(b, g, g, g); } set { b = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 bggb { get { return new Vector4(b, g, g, b); } set { b = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 bgga { get { return new Vector4(b, g, g, a); } set { b = value.x; g = value.y; g = value.z; a = value.w; } }
        public Vector4 bgbr { get { return new Vector4(b, g, b, r); } set { b = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 bgbg { get { return new Vector4(b, g, b, g); } set { b = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 bgbb { get { return new Vector4(b, g, b, b); } set { b = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 bgba { get { return new Vector4(b, g, b, a); } set { b = value.x; g = value.y; b = value.z; a = value.w; } }
        public Vector4 bgar { get { return new Vector4(b, g, a, r); } set { b = value.x; g = value.y; a = value.z; r = value.w; } }
        public Vector4 bgag { get { return new Vector4(b, g, a, g); } set { b = value.x; g = value.y; a = value.z; g = value.w; } }
        public Vector4 bgab { get { return new Vector4(b, g, a, b); } set { b = value.x; g = value.y; a = value.z; b = value.w; } }
        public Vector4 bgaa { get { return new Vector4(b, g, a, a); } set { b = value.x; g = value.y; a = value.z; a = value.w; } }
        public Vector4 bbrr { get { return new Vector4(b, b, r, r); } set { b = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 bbrg { get { return new Vector4(b, b, r, g); } set { b = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 bbrb { get { return new Vector4(b, b, r, b); } set { b = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 bbra { get { return new Vector4(b, b, r, a); } set { b = value.x; b = value.y; r = value.z; a = value.w; } }
        public Vector4 bbgr { get { return new Vector4(b, b, g, r); } set { b = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 bbgg { get { return new Vector4(b, b, g, g); } set { b = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 bbgb { get { return new Vector4(b, b, g, b); } set { b = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 bbga { get { return new Vector4(b, b, g, a); } set { b = value.x; b = value.y; g = value.z; a = value.w; } }
        public Vector4 bbbr { get { return new Vector4(b, b, b, r); } set { b = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 bbbg { get { return new Vector4(b, b, b, g); } set { b = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 bbbb { get { return new Vector4(b, b, b, b); } set { b = value.x; b = value.y; b = value.z; b = value.w; } }
        public Vector4 bbba { get { return new Vector4(b, b, b, a); } set { b = value.x; b = value.y; b = value.z; a = value.w; } }
        public Vector4 bbar { get { return new Vector4(b, b, a, r); } set { b = value.x; b = value.y; a = value.z; r = value.w; } }
        public Vector4 bbag { get { return new Vector4(b, b, a, g); } set { b = value.x; b = value.y; a = value.z; g = value.w; } }
        public Vector4 bbab { get { return new Vector4(b, b, a, b); } set { b = value.x; b = value.y; a = value.z; b = value.w; } }
        public Vector4 bbaa { get { return new Vector4(b, b, a, a); } set { b = value.x; b = value.y; a = value.z; a = value.w; } }
        public Vector4 barr { get { return new Vector4(b, a, r, r); } set { b = value.x; a = value.y; r = value.z; r = value.w; } }
        public Vector4 barg { get { return new Vector4(b, a, r, g); } set { b = value.x; a = value.y; r = value.z; g = value.w; } }
        public Vector4 barb { get { return new Vector4(b, a, r, b); } set { b = value.x; a = value.y; r = value.z; b = value.w; } }
        public Vector4 bara { get { return new Vector4(b, a, r, a); } set { b = value.x; a = value.y; r = value.z; a = value.w; } }
        public Vector4 bagr { get { return new Vector4(b, a, g, r); } set { b = value.x; a = value.y; g = value.z; r = value.w; } }
        public Vector4 bagg { get { return new Vector4(b, a, g, g); } set { b = value.x; a = value.y; g = value.z; g = value.w; } }
        public Vector4 bagb { get { return new Vector4(b, a, g, b); } set { b = value.x; a = value.y; g = value.z; b = value.w; } }
        public Vector4 baga { get { return new Vector4(b, a, g, a); } set { b = value.x; a = value.y; g = value.z; a = value.w; } }
        public Vector4 babr { get { return new Vector4(b, a, b, r); } set { b = value.x; a = value.y; b = value.z; r = value.w; } }
        public Vector4 babg { get { return new Vector4(b, a, b, g); } set { b = value.x; a = value.y; b = value.z; g = value.w; } }
        public Vector4 babb { get { return new Vector4(b, a, b, b); } set { b = value.x; a = value.y; b = value.z; b = value.w; } }
        public Vector4 baba { get { return new Vector4(b, a, b, a); } set { b = value.x; a = value.y; b = value.z; a = value.w; } }
        public Vector4 baar { get { return new Vector4(b, a, a, r); } set { b = value.x; a = value.y; a = value.z; r = value.w; } }
        public Vector4 baag { get { return new Vector4(b, a, a, g); } set { b = value.x; a = value.y; a = value.z; g = value.w; } }
        public Vector4 baab { get { return new Vector4(b, a, a, b); } set { b = value.x; a = value.y; a = value.z; b = value.w; } }
        public Vector4 baaa { get { return new Vector4(b, a, a, a); } set { b = value.x; a = value.y; a = value.z; a = value.w; } }
        public Vector4 arrr { get { return new Vector4(a, r, r, r); } set { a = value.x; r = value.y; r = value.z; r = value.w; } }
        public Vector4 arrg { get { return new Vector4(a, r, r, g); } set { a = value.x; r = value.y; r = value.z; g = value.w; } }
        public Vector4 arrb { get { return new Vector4(a, r, r, b); } set { a = value.x; r = value.y; r = value.z; b = value.w; } }
        public Vector4 arra { get { return new Vector4(a, r, r, a); } set { a = value.x; r = value.y; r = value.z; a = value.w; } }
        public Vector4 argr { get { return new Vector4(a, r, g, r); } set { a = value.x; r = value.y; g = value.z; r = value.w; } }
        public Vector4 argg { get { return new Vector4(a, r, g, g); } set { a = value.x; r = value.y; g = value.z; g = value.w; } }
        public Vector4 argb { get { return new Vector4(a, r, g, b); } set { a = value.x; r = value.y; g = value.z; b = value.w; } }
        public Vector4 arga { get { return new Vector4(a, r, g, a); } set { a = value.x; r = value.y; g = value.z; a = value.w; } }
        public Vector4 arbr { get { return new Vector4(a, r, b, r); } set { a = value.x; r = value.y; b = value.z; r = value.w; } }
        public Vector4 arbg { get { return new Vector4(a, r, b, g); } set { a = value.x; r = value.y; b = value.z; g = value.w; } }
        public Vector4 arbb { get { return new Vector4(a, r, b, b); } set { a = value.x; r = value.y; b = value.z; b = value.w; } }
        public Vector4 arba { get { return new Vector4(a, r, b, a); } set { a = value.x; r = value.y; b = value.z; a = value.w; } }
        public Vector4 arar { get { return new Vector4(a, r, a, r); } set { a = value.x; r = value.y; a = value.z; r = value.w; } }
        public Vector4 arag { get { return new Vector4(a, r, a, g); } set { a = value.x; r = value.y; a = value.z; g = value.w; } }
        public Vector4 arab { get { return new Vector4(a, r, a, b); } set { a = value.x; r = value.y; a = value.z; b = value.w; } }
        public Vector4 araa { get { return new Vector4(a, r, a, a); } set { a = value.x; r = value.y; a = value.z; a = value.w; } }
        public Vector4 agrr { get { return new Vector4(a, g, r, r); } set { a = value.x; g = value.y; r = value.z; r = value.w; } }
        public Vector4 agrg { get { return new Vector4(a, g, r, g); } set { a = value.x; g = value.y; r = value.z; g = value.w; } }
        public Vector4 agrb { get { return new Vector4(a, g, r, b); } set { a = value.x; g = value.y; r = value.z; b = value.w; } }
        public Vector4 agra { get { return new Vector4(a, g, r, a); } set { a = value.x; g = value.y; r = value.z; a = value.w; } }
        public Vector4 aggr { get { return new Vector4(a, g, g, r); } set { a = value.x; g = value.y; g = value.z; r = value.w; } }
        public Vector4 aggg { get { return new Vector4(a, g, g, g); } set { a = value.x; g = value.y; g = value.z; g = value.w; } }
        public Vector4 aggb { get { return new Vector4(a, g, g, b); } set { a = value.x; g = value.y; g = value.z; b = value.w; } }
        public Vector4 agga { get { return new Vector4(a, g, g, a); } set { a = value.x; g = value.y; g = value.z; a = value.w; } }
        public Vector4 agbr { get { return new Vector4(a, g, b, r); } set { a = value.x; g = value.y; b = value.z; r = value.w; } }
        public Vector4 agbg { get { return new Vector4(a, g, b, g); } set { a = value.x; g = value.y; b = value.z; g = value.w; } }
        public Vector4 agbb { get { return new Vector4(a, g, b, b); } set { a = value.x; g = value.y; b = value.z; b = value.w; } }
        public Vector4 agba { get { return new Vector4(a, g, b, a); } set { a = value.x; g = value.y; b = value.z; a = value.w; } }
        public Vector4 agar { get { return new Vector4(a, g, a, r); } set { a = value.x; g = value.y; a = value.z; r = value.w; } }
        public Vector4 agag { get { return new Vector4(a, g, a, g); } set { a = value.x; g = value.y; a = value.z; g = value.w; } }
        public Vector4 agab { get { return new Vector4(a, g, a, b); } set { a = value.x; g = value.y; a = value.z; b = value.w; } }
        public Vector4 agaa { get { return new Vector4(a, g, a, a); } set { a = value.x; g = value.y; a = value.z; a = value.w; } }
        public Vector4 abrr { get { return new Vector4(a, b, r, r); } set { a = value.x; b = value.y; r = value.z; r = value.w; } }
        public Vector4 abrg { get { return new Vector4(a, b, r, g); } set { a = value.x; b = value.y; r = value.z; g = value.w; } }
        public Vector4 abrb { get { return new Vector4(a, b, r, b); } set { a = value.x; b = value.y; r = value.z; b = value.w; } }
        public Vector4 abra { get { return new Vector4(a, b, r, a); } set { a = value.x; b = value.y; r = value.z; a = value.w; } }
        public Vector4 abgr { get { return new Vector4(a, b, g, r); } set { a = value.x; b = value.y; g = value.z; r = value.w; } }
        public Vector4 abgg { get { return new Vector4(a, b, g, g); } set { a = value.x; b = value.y; g = value.z; g = value.w; } }
        public Vector4 abgb { get { return new Vector4(a, b, g, b); } set { a = value.x; b = value.y; g = value.z; b = value.w; } }
        public Vector4 abga { get { return new Vector4(a, b, g, a); } set { a = value.x; b = value.y; g = value.z; a = value.w; } }
        public Vector4 abbr { get { return new Vector4(a, b, b, r); } set { a = value.x; b = value.y; b = value.z; r = value.w; } }
        public Vector4 abbg { get { return new Vector4(a, b, b, g); } set { a = value.x; b = value.y; b = value.z; g = value.w; } }
        public Vector4 abbb { get { return new Vector4(a, b, b, b); } set { a = value.x; b = value.y; b = value.z; b = value.w; } }
        public Vector4 abba { get { return new Vector4(a, b, b, a); } set { a = value.x; b = value.y; b = value.z; a = value.w; } }
        public Vector4 abar { get { return new Vector4(a, b, a, r); } set { a = value.x; b = value.y; a = value.z; r = value.w; } }
        public Vector4 abag { get { return new Vector4(a, b, a, g); } set { a = value.x; b = value.y; a = value.z; g = value.w; } }
        public Vector4 abab { get { return new Vector4(a, b, a, b); } set { a = value.x; b = value.y; a = value.z; b = value.w; } }
        public Vector4 abaa { get { return new Vector4(a, b, a, a); } set { a = value.x; b = value.y; a = value.z; a = value.w; } }
        public Vector4 aarr { get { return new Vector4(a, a, r, r); } set { a = value.x; a = value.y; r = value.z; r = value.w; } }
        public Vector4 aarg { get { return new Vector4(a, a, r, g); } set { a = value.x; a = value.y; r = value.z; g = value.w; } }
        public Vector4 aarb { get { return new Vector4(a, a, r, b); } set { a = value.x; a = value.y; r = value.z; b = value.w; } }
        public Vector4 aara { get { return new Vector4(a, a, r, a); } set { a = value.x; a = value.y; r = value.z; a = value.w; } }
        public Vector4 aagr { get { return new Vector4(a, a, g, r); } set { a = value.x; a = value.y; g = value.z; r = value.w; } }
        public Vector4 aagg { get { return new Vector4(a, a, g, g); } set { a = value.x; a = value.y; g = value.z; g = value.w; } }
        public Vector4 aagb { get { return new Vector4(a, a, g, b); } set { a = value.x; a = value.y; g = value.z; b = value.w; } }
        public Vector4 aaga { get { return new Vector4(a, a, g, a); } set { a = value.x; a = value.y; g = value.z; a = value.w; } }
        public Vector4 aabr { get { return new Vector4(a, a, b, r); } set { a = value.x; a = value.y; b = value.z; r = value.w; } }
        public Vector4 aabg { get { return new Vector4(a, a, b, g); } set { a = value.x; a = value.y; b = value.z; g = value.w; } }
        public Vector4 aabb { get { return new Vector4(a, a, b, b); } set { a = value.x; a = value.y; b = value.z; b = value.w; } }
        public Vector4 aaba { get { return new Vector4(a, a, b, a); } set { a = value.x; a = value.y; b = value.z; a = value.w; } }
        public Vector4 aaar { get { return new Vector4(a, a, a, r); } set { a = value.x; a = value.y; a = value.z; r = value.w; } }
        public Vector4 aaag { get { return new Vector4(a, a, a, g); } set { a = value.x; a = value.y; a = value.z; g = value.w; } }
        public Vector4 aaab { get { return new Vector4(a, a, a, b); } set { a = value.x; a = value.y; a = value.z; b = value.w; } }
        public Vector4 aaaa { get { return new Vector4(a, a, a, a); } set { a = value.x; a = value.y; a = value.z; a = value.w; } }
    }

}
