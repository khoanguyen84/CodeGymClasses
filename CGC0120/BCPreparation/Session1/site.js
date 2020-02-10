document.write('Hello world');
console.log('Hello world');
alert('Hello world');

let a = 5;
let b = 7;
let c = a + b;

document.write('<br>');
document.write('a + b =' + c); // a + b = 12
document.write('<br>');
document.write(a + '+' + b + '=' + c); /* 5 + 7 = 12 */

document.write('<br>');
document.write(a + '+' + b + '=' + a + b); /* 5 + 7 = 12      c1 
                                                5 + 7 = 5 + 7   c2
                                                5 + 7 = 57      c3
                                                5 + 7 = (5 + 7) c4
                                            */