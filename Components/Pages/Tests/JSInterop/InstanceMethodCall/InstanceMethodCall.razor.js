
export function sayHello(helloHelperRef) {
    return helloHelperRef
        .invokeMethodAsync('SayHello')
        .then(r => console.log(r));
}