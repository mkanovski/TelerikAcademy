let name = 'pesho';

console.log(name);

name = false; // може в същата променлива да слгаме друг тип данни - флексибилност на езика

console.log(name)

let age = 17; // Променливата let може да й се сменя типа

age += 1;

console.log(age);

var name1 = 'Pesho'; // НЕ СЕ ПОЛЗВА!

const fullname = 'Pesho Peshov'; // На промеливата const не може да й се променя типа

let text = '1756'
console.log(parseInt(text)); // ако променливата има и не цифрова стойност, ще изреже това, което е след първата не цифра

console.log(Number(text) + 10); // Това връща число само ако текста е само число

console.log(+text); // Връща цифра от текст, ако има не цифрови символи връща NaN

let float = '2435.545'

console.log(parseFloat(float)); // 

console.log(+float); // +-ът пак работи, така че най-добре да се ползва +

// сравнява се с тройно =.... ===

const diff = 0.00001
console.log( ((0.1 + 0.2) - diff) < 0)

num1 = '1';
num2 = 1;

num1 == num2; // true - Оеднаквява стойностите и тогава сряванява
num1 === num2; // false - сравнява и типовете и тогава стойностите
// Същото е и за != и !==
