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

    const thisvec = `Vector${ size }`;
    const tgvec = `Vector${ els.length }`;
    const args = els.map(e => `v.${ e }`).join(', ');
    return `public static ${ tgvec } ${ els.join('') }(this ${ thisvec } v){ return new ${ tgvec }(${ args }); }`

}

const vecfields = ['x', 'y', 'z', 'w'];
const colfields = ['r', 'g', 'b', 'a'];

let functions = '';

// vector size
for (let i = 2; i <= 4; i ++) {

    functions += `\n    // Vector${ i } Extensions\n`;

    // extension size
    const fields = vecfields.slice(0, i);
    for (let v = 2; v <= 4; v ++) {

        functions += 
            getElementCombinations(fields, v)
                .map(arr => `    ${ elementsToFunction(arr, i) }`)
                .join('\n')
                 + '\n';

    }

}

fs.writeFileSync('HLSLVectorExtensions.cs',
`
/*
 * @author Garrett Johnson <garrett.kjohnson@gmail.com>
 * https://github.com/gkjohnson/unity-vector-extensions
 *
 * Generated Unity Vector extension file
 */
using UnityEngine;
public static class HLSLVectorExtensions {
${ functions }
}
`);


