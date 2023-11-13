
let functionsArrayOf5=[];
for(let i=1;i<=5;i++){
let func=new Function("return function print"+i+"(){console.log("+i+")}")();
functionsArrayOf5.push(func);
}

functionsArrayOf5.forEach(f => {
    f();
});

/////////////////
console.log("===============================")
let functionsArrayOf1000=[];
for(let i=1;i<=1000;i++){
let func=new Function("return function print"+i+"(){console.log("+i+")}")();
functionsArrayOf1000.push(func);
}

functionsArrayOf1000.forEach(f => {
    f();
});