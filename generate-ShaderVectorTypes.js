const fs = require('fs');

// Returns an array of arrays with all the combinations of
// vector elements -- xyz, zyx, xxyy, etc
// els: an array of elements to generate the combinations for -- ['x', 'y', 'z']
// ct: the final number of elements in the arrays to be generated
function getElementCombinations(els, ct, currarr = []) {

    if (currarr.length == ct) return [currarr];

    const res = [];
    for (const e in els) {
        res.push(...getElementCombinations(els, ct, [...currarr, els[e]]));
    }

    return res;
}

// Creates a function based on the elements and size of vector being used
// ex:
// public static Vector2 xx(this Vector3 v) { return new Vector2(v.x, v.x); }
function elementsToFunction(els, size) {

    const rawfields = ['x', 'y', 'z', 'w'];
    const thisvec = `Vector${ size }`;
    const tgvec = `Vector${ els.length }`;
    const args = els.map(e => `${ e }`).join(', ');

    let member = `public ${ tgvec } ${ els.join('') } { `;
    member += `get { return new ${ tgvec }(${args}); } `;
    member += `set { ${ els.map((e, i) => `${ e } = value.${ rawfields[i] };` ).join(' ') } }`;
    member += ' }';

    return member;

}

// returns an overloaded operator function for a vector with the provided members
// ex:
// public static Vector2 operator +(Vector2 a, Vector2 b) { a.x += b.x; a.y += b.y; return a; }
function toOperatorFunction(els, op) {

    const thisvec = `Vector${ els.length }`;
    let func = `public static ${ thisvec } operator ${ op }(${ thisvec } a, ${ thisvec } b) `;
    func += `{ ${ els.map(e => `a.${ e } ${ op }= b.${ e };`).join(' ') } return a; }`
    return func;

}

// returns a list of constructors for all combinations of vector lengths
function generateConstructors(els) {

    function getArgLengthArray(ct, arr = []) {

        if (ct == 0) return [arr];

        const res = [];
        for (let i = 1; i <= ct; i ++) {
            res.push(...getArgLengthArray(ct - i, [...arr, i]));
        }

        return res;
    }

    const rawfields = ['x', 'y', 'z', 'w'];
    return getArgLengthArray(els.length)
        .map(lens => {

            const args = lens
                .map((l, i) => `${ l == 1 ? 'float' : `Vector${ l }` } v${ i }`)
                .join(', ');

            let cons = `public Vector${ els.length }(${ args }) { `;
            let curr = 0;
            lens.forEach((l, i) => {

                if (l == 1) {

                    cons += `${ rawfields[curr] } = v${ i }; `;
                    curr ++;

                } else {

                    for(let j = 0; j < l; j ++) {

                        cons += `${ rawfields[curr] } = v${ i }.${ rawfields[j] }; `;
                        curr ++;

                    }

                }

            });

            cons += '}';
            return cons;

        });

}

function generateArrayAccessor(els) {

    let getter = els
        .reduce((v, e, i) => v + `if(i == ${ i }) return ${ els[ i ] }; else `, '') + 'throw new System.IndexOutOfRangeException();';

    let setter = els
        .reduce((v, e, i) => v + `if(i == ${ i }) ${ els[ i ] } = value; else `, '') + 'throw new System.IndexOutOfRangeException();';

    return `public float this[int i] { get { ${ getter } } set { ${setter} } }`

}


const vecfields = ['x', 'y', 'z', 'w'];
const colfields = ['r', 'g', 'b', 'a'];
const operators = ['+', '-', '*', '/'];
let body = '';

// vector size
for (let i = 2; i <= 4; i ++) {

    // extension size
    const fields = vecfields.slice(0, i);

    let structdef =
`
    public struct Vector${ i } {
        public float ${ fields.join() };

        // constructors
${ generateConstructors(fields).map(c => '        ' + c).join('\n') }

        // operators
${ operators.map(op => '        ' + toOperatorFunction(fields, op)).join('\n') }
        public static Vector${ i } operator *(Vector${ i } v, float d) { ${ fields.map(f => `v.${ f } *= d; `).join('') }return v; }
        public static Vector${ i } operator /(Vector${ i } v, float d) { ${ fields.map(f => `v.${ f } /= d; `).join('') }return v; }
        public static implicit operator Vector${ i }(UnityEngine.Vector${ i } v) { return new Vector${ i }(${ fields.map(f => `v.${ f }`).join(', ') }); }
        public static implicit operator UnityEngine.Vector${ i }(Vector${ i } v) { return new UnityEngine.Vector${ i }(${ fields.map(f => `v.${ f }`).join(', ') }); }

        // getters & setters
        ${ generateArrayAccessor(fields) }

`;

    for (let v = 2; v <= 4; v ++) {

        structdef += 
            getElementCombinations(fields, v)
                .map(arr => `        ${ elementsToFunction(arr, i) }`)
                .join('\n')
                 + '\n';

    }

    structdef += '    }\n';

    body += structdef;

}

fs.writeFileSync('ShaderVectorTypes.cs',
`
/*
 * @author Garrett Johnson <garrett.kjohnson@gmail.com>
 * https://github.com/gkjohnson/unity-vector-extensions
 *
 * Generated file
 */
namespace ShaderTypes {
${ body }
}
`);


